using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_INDUSDEV.Data;

namespace TP_INDUSDEV.UserControls
{
    public partial class UcAddTicket : UserControl
    {
        // Variables
        #region Variables

        string strAddTicketErrorMessage = "Impossible d'ajouter un nouveau ticket.";
        string strRemoveTicketErrorMessage = "Impossible de supprimer un ticket.";
        string strUpdateTicketErrorMessage = "Impossible de modifier un ticket.";

        #endregion

        // Constructeur
        public UcAddTicket()
        {
            InitializeComponent();

            // Initialisation de l'affichage des controls et des valeurs
            this.InitializeDisplay();

            InitializeControls();
        }

        // Méthodes
        #region Méthodes

        // Affichage
        #region Affichage
        private void InitializeDisplay()
        {
            // Permet de :
            // - positionner les controls par rapport à la page
            // - définir leur taille

            // Titre
            this.lblTitle.Height = (int)(this.Height * 0.1);
            this.ptbQuit.Size = new Size((int)(this.lblTitle.Height * 0.5), (int)(this.lblTitle.Height * 0.5));
            this.ptbQuit.Location = new Point((int)(this.lblTitle.Width - (this.lblTitle.Height * 0.1 + this.ptbQuit.Width)), (int)(this.lblTitle.Height * 0.25));
            // Label titre de champs
            Size sLblTitleField = new Size((int)(this.Width * 0.175),
                                            (int)(this.Height * 0.05));
            this.lblTicketDetails.Size = sLblTitleField;
            this.lblTicketDetails.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.15));
            this.lblSelectedOperator.Size = sLblTitleField;
            this.lblSelectedOperator.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.45));
            this.lblLevelTicket.Size = sLblTitleField;
            this.lblLevelTicket.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.65));
            // Champs
            Size sCtlField = new Size((int)(this.Width * 0.7),
                                        (int)(this.Height * 0.15));
            this.rtbxTicketDetails.Size = sCtlField;
            this.rtbxTicketDetails.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.2));
            this.cbbxSelectedOperator.Size = sCtlField;
            this.cbbxSelectedOperator.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.5));
            this.cbbxLevelTicket.Size = sCtlField;
            this.cbbxLevelTicket.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.7));

            // Bouton
            this.btnAddTicket.Size = new Size((int)(this.Width * 0.5), (int)(this.Height * 0.1));
            this.btnAddTicket.Location = new Point((int)(this.Width * 0.25), (int)(this.Height * 0.85));
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Initialisation champs formulaire
        private void InitializeControls()
        {
            // ComboBox techniciens
            cbbxSelectedOperator.DataSource = from t in Program.dcIndusDev.T_OPERATOR
                                              where t.ID_OPERATOR_TYPE == 2
                                              select t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR;
            cbbxSelectedOperator.SelectedIndex = -1;

            // ComboBox niveaux
            cbbxLevelTicket.DataSource = from t in Program.dcIndusDev.T_LEVEL_TICKET
                                         select t.NAME_LEVEL_TICKET;
            cbbxLevelTicket.SelectedIndex = -1;
        }
        /*_____________________________________________________________________________________________*/

        // Ajouter nouveau ticket
        private void AddTicket(T_TICKET dTicket)
        {
            Program.dcIndusDev.T_TICKET.InsertOnSubmit(dTicket);
        }
        /*_____________________________________________________________________________________________*/

        // Supprimer un ticket existant
        private void RemoveTicket(T_TICKET dTicket)
        {
            Program.dcIndusDev.T_TICKET.DeleteOnSubmit(dTicket);
        }
        /*_____________________________________________________________________________________________*/

        // Récupérer les informations du formulaire
        private T_TICKET GetTicketData()
        {
            T_TICKET dTicket = new T_TICKET();

            // Date ouverture, détails, niveau, etat, créateur, opérateur choisi
            dTicket.START_DATE_TICKET = DateTime.Now;
            dTicket.DETAILS_TICKET = rtbxTicketDetails.Text;
            dTicket.ID_TICKET_STATE = (from t in Program.dcIndusDev.T_TICKET_STATE
                                       where t.NAME_TICKET_STATE == "En saisie"
                                       select t.ID_TICKET_STATE).FirstOrDefault();
            //dTicket.
            dTicket.ID_OWNER_OPERATOR = Program.connectedOperator.ID_OPERATOR;
            dTicket.ID_SELECTED_OPERATOR = (from t in Program.dcIndusDev.T_OPERATOR
                                            where t.FIRST_NAME_OPERATOR + t.LAST_NAME_OPERATOR ==
                                            cbbxSelectedOperator.SelectedItem.ToString()
                                            select t.ID_OPERATOR).FirstOrDefault();

            return dTicket;
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Evenements
        #region Evenements

        // Affichage
        #region Affichage
        private void UcAddTicket_Resize(object sender, EventArgs e)
        {
            this.InitializeDisplay();
        }
        /*_____________________________________________________________________________________________*/
        private void ptbQuit_Click(object sender, EventArgs e)
        {
            this.Parent.Visible = false;
            this.Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Créer un nouveau ticket
        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            AddTicket(GetTicketData());
            Program.SubmitChanges(strAddTicketErrorMessage);
        }
        /*_____________________________________________________________________________________________*/

        #endregion
    }
}
