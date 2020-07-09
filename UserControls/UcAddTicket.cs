using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TP_INDUSDEV.Data;

namespace TP_INDUSDEV.UserControls
{
    public partial class UcAddTicket : UserControl
    {
        // Variables
        #region Variables

        string strAddTicketErrorMessage = "Impossible d'ajouter un nouveau ticket.";

        #endregion

        // Constructeur
        public UcAddTicket()
        {
            InitializeComponent();
            InitializeDisplay();
            InitializeControlsData();
        }
        /*_____________________________________________________________________________________________*/

        // Méthodes
        #region Méthodes

        // Affichage
        #region Affichage

        // Initialisation affichage
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

        // Initialisation des données des champs du formulaire
        private void InitializeControlsData()
        {
            // ComboBox techniciens
            cbbxSelectedOperator.DataSource = from t in Program.dcIndusDev.T_OPERATOR
                                              where t.ID_OPERATOR_TYPE == 2
                                              select t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR;
            cbbxSelectedOperator.SelectedIndex = -1; // Item sélectionné : aucun

            // ComboBox niveaux
            cbbxLevelTicket.DataSource = from t in Program.dcIndusDev.T_LEVEL_TICKET
                                         select t.NAME_LEVEL_TICKET;
            cbbxLevelTicket.SelectedIndex = -1; // Item sélectionné : aucun
        }
        /*_____________________________________________________________________________________________*/

        // Ajouter nouveau ticket
        private void AddTicket(T_TICKET dTicket)
        {
            Program.dcIndusDev.T_TICKET.InsertOnSubmit(dTicket);
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
            dTicket.ID_LEVEL_TICKET = (from t in Program.dcIndusDev.T_LEVEL_TICKET
                                       where t.NAME_LEVEL_TICKET == 
                                       cbbxLevelTicket.SelectedItem.ToString()
                                       select t.ID_LEVEL_TICKET).FirstOrDefault();
            dTicket.ID_OWNER_OPERATOR = Program.connectedOperator.ID_OPERATOR;
            dTicket.ID_SELECTED_OPERATOR = (from t in Program.dcIndusDev.T_OPERATOR
                                            where t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR ==
                                            cbbxSelectedOperator.SelectedItem.ToString()
                                            select t.ID_OPERATOR).FirstOrDefault();

            return dTicket;
        }
        /*_____________________________________________________________________________________________*/

        // Vider les champs du formulaire
        private void ClearFields()
        {
            rtbxTicketDetails.Text = "";
            cbbxSelectedOperator.SelectedIndex = -1;
            cbbxLevelTicket.SelectedIndex = -1;
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Evenements
        #region Evenements

        // Affichage
        #region Affichage

        // Changement de taille
        private void UcAddTicket_Resize(object sender, EventArgs e)
        {
            InitializeDisplay();
        }
        /*_____________________________________________________________________________________________*/

        // Fermeture UserControl
        private void PtbQuit_Click(object sender, EventArgs e)
        {
            Parent.Visible = false;
            Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Créer un nouveau ticket
        private void BtnAddTicket_Click(object sender, EventArgs e)
        {
            AddTicket(GetTicketData());
            Program.SubmitChanges(strAddTicketErrorMessage);
            ClearFields();
            //UcDisplayTicket.DiplayTickets();
        }
        /*_____________________________________________________________________________________________*/

        #endregion
    }
}
