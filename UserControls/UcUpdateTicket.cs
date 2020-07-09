using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TP_INDUSDEV.Data;

namespace TP_INDUSDEV.UserControls
{
    public partial class UcUpdateTicket : UserControl
    {
        // Variables
        #region Variables

        readonly string strUpdateTicketErrorMessage = "Erreur lors de la modification d'un ticket.";
        T_TICKET dTicket = new T_TICKET();

        #endregion

        // Constructeur
        public UcUpdateTicket(int iIdTicket)
        {
            InitializeComponent();
            InitializeDisplay();
            dTicket = GetTicketToUpdateData(iIdTicket);
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
            this.ptbxQuit.Size = new Size((int)(this.lblTitle.Height * 0.5), (int)(this.lblTitle.Height * 0.5));
            this.ptbxQuit.Location = new Point((int)(this.lblTitle.Width - (this.lblTitle.Height * 0.1 + this.ptbxQuit.Width)), (int)(this.lblTitle.Height * 0.25));
            // Label titre de champs
            Size sLblTitleField = new Size((int)(this.Width * 0.175),
                                            (int)(this.Height * 0.05));
            this.lblTicketInterventionDescription.Size = sLblTitleField;
            this.lblTicketInterventionDescription.Location = new Point((int)(this.Width * 0.15),
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
            this.rtbxTicketInterventionDescription.Size = sCtlField;
            this.rtbxTicketInterventionDescription.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.2));
            this.cbbxSelectedOperator.Size = sCtlField;
            this.cbbxSelectedOperator.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.5));
            this.cbbxLevelTicket.Size = sCtlField;
            this.cbbxLevelTicket.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.7));

            // Bouton
            this.btnUpdateTicket.Size = new Size((int)(this.Width * 0.5), (int)(this.Height * 0.1));
            this.btnUpdateTicket.Location = new Point((int)(this.Width * 0.25), (int)(this.Height * 0.85));
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Récupération données du ticket à mettre à jour
        private T_TICKET GetTicketToUpdateData(int iIdTicket)
        {
            if ((from t in Program.dcIndusDev.T_TICKET
                 where t.ID_TICKET == iIdTicket
                 select t).Any())
            {
                return (from t in Program.dcIndusDev.T_TICKET
                        where t.ID_TICKET == iIdTicket
                        select t).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("Ce ticket n'existe pas.");

                return default;
            }
        }
        /*_____________________________________________________________________________________________*/

        // Initialisation des données des champs du formulaire
        private void InitializeControlsData()
        {
            rtbxTicketInterventionDescription.Text = dTicket.INTERVENTION_DESCRIPTION_TICKET;

            // ComboBox techniciens
            cbbxSelectedOperator.DataSource = from t in Program.dcIndusDev.T_OPERATOR
                                              where t.ID_OPERATOR_TYPE == 2
                                              select t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR;
            cbbxSelectedOperator.SelectedItem = (from t in Program.dcIndusDev.T_OPERATOR
                                                 where t.ID_OPERATOR == dTicket.ID_SELECTED_OPERATOR
                                                 select t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR).FirstOrDefault();

            // ComboBox niveaux
            cbbxLevelTicket.DataSource = from t in Program.dcIndusDev.T_LEVEL_TICKET
                                         select t.NAME_LEVEL_TICKET;
            cbbxLevelTicket.SelectedItem = (from t in Program.dcIndusDev.T_LEVEL_TICKET
                                            where t.ID_LEVEL_TICKET == dTicket.ID_LEVEL_TICKET
                                            select t.NAME_LEVEL_TICKET).FirstOrDefault();
        }
        /*_____________________________________________________________________________________________*/

        // Récupérer les informations du formulaire
        private T_TICKET GetTicketData(bool bClosedTicket)
        {
            T_TICKET dTicket = this.dTicket;

            if (!bClosedTicket) // Simple mise à jour du ticket
            {
                // Description intervention, etat, niveau, opérateur choisi
                dTicket.INTERVENTION_DESCRIPTION_TICKET = rtbxTicketInterventionDescription.Text;
                if (dTicket.ID_TICKET_STATE == (from t in Program.dcIndusDev.T_TICKET_STATE
                                                where t.NAME_TICKET_STATE == "En saisie"
                                                select t.ID_TICKET_STATE).FirstOrDefault())
                {
                    dTicket.ID_TICKET_STATE = (from t in Program.dcIndusDev.T_TICKET_STATE
                                               where t.NAME_TICKET_STATE == "En cours"
                                               select t.ID_TICKET_STATE).FirstOrDefault();
                }
                dTicket.ID_LEVEL_TICKET = (from t in Program.dcIndusDev.T_LEVEL_TICKET
                                           where t.NAME_LEVEL_TICKET ==
                                           cbbxLevelTicket.SelectedItem.ToString()
                                           select t.ID_LEVEL_TICKET).FirstOrDefault();
                dTicket.ID_SELECTED_OPERATOR = (from t in Program.dcIndusDev.T_OPERATOR
                                                where t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR ==
                                                cbbxSelectedOperator.SelectedItem.ToString()
                                                select t.ID_OPERATOR).FirstOrDefault();
            }
            else // Fermeture et mise à jour du ticket
            {
                // Date fermeture, description intervention, etat, niveau, opérateur choisi, solveur
                dTicket.END_DATE_TICKET = DateTime.Now;
                dTicket.INTERVENTION_DESCRIPTION_TICKET = rtbxTicketInterventionDescription.Text;
                dTicket.ID_TICKET_STATE = (from t in Program.dcIndusDev.T_TICKET_STATE
                                           where t.NAME_TICKET_STATE == "Résolu"
                                           select t.ID_TICKET_STATE).FirstOrDefault();               
                dTicket.ID_LEVEL_TICKET = (from t in Program.dcIndusDev.T_LEVEL_TICKET
                                           where t.NAME_LEVEL_TICKET ==
                                           cbbxLevelTicket.SelectedItem.ToString()
                                           select t.ID_LEVEL_TICKET).FirstOrDefault();
                dTicket.ID_SELECTED_OPERATOR = (from t in Program.dcIndusDev.T_OPERATOR
                                                where t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR ==
                                                cbbxSelectedOperator.SelectedItem.ToString()
                                                select t.ID_OPERATOR).FirstOrDefault();
                dTicket.ID_SOLVER_OPERATOR = Program.connectedOperator.ID_OPERATOR;
            }

            return dTicket;
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Evenements
        #region Evenements

        // Affichage
        #region Affichage

        // Changement de taille
        private void UcUpdateTicket_Resize(object sender, EventArgs e)
        {
            InitializeDisplay();
        }
        /*_____________________________________________________________________________________________*/

        // Fermeture UserControl
        private void PtbxQuit_Click(object sender, EventArgs e)
        {
            Parent.Visible = false;
            Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Mettre à jour le ticket
        private void BtnUpdateTicket_Click(object sender, EventArgs e)
        {
            dTicket = GetTicketData(false);
            Program.SubmitChanges(strUpdateTicketErrorMessage);
            //UcDisplayTicket.DiplayTickets();
            Parent.Visible = false;
            Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/

        // Fermer le ticket 
        private void BtnCloseTicket_Click(object sender, EventArgs e)
        {
            dTicket = GetTicketData(true);
            Program.SubmitChanges(strUpdateTicketErrorMessage);
            //UcDisplayTicket.DiplayTickets();
            Parent.Visible = false;
            Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/

        #endregion
    }
}