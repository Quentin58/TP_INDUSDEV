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
            /*
            T_TICKET_STATE test = new T_TICKET_STATE
            {
                ID_TICKET_STATE = 1,
                NAME_TICKET_STATE = "En saisie"
            }; 
            T_TICKET_STATE test2 = new T_TICKET_STATE
            {
                ID_TICKET_STATE = 2,
                NAME_TICKET_STATE = "En cours"
            }; 
            T_TICKET_STATE test3 = new T_TICKET_STATE
            {
                ID_TICKET_STATE = 3,
                NAME_TICKET_STATE = "Résolu"
            }; 
            T_TICKET_STATE test4 = new T_TICKET_STATE
            {
                ID_TICKET_STATE = 4,
                NAME_TICKET_STATE = "Annulé"
            };

            List<T_TICKET_STATE> liTest = new List<T_TICKET_STATE>
            {
                test,test2,test3,test4
            };

            Program.dcIndusDev.T_TICKET_STATE.InsertAllOnSubmit(liTest);
            Program.SubmitChanges("Salut");*/

            InitializeControls();
        }

        // Méthodes
        #region Méthodes

        // Initialisation champs formulaire
        private void InitializeControls()
        {
            // ComboBox techniciens
            cbbxSelectedOperator.DataSource = from t in Program.dcIndusDev.T_OPERATOR
                                              where t.ID_OPERATOR_TYPE == 2
                                              select t.FIRST_NAME_OPERATOR + " " + t.LAST_NAME_OPERATOR;
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

            // Date ouverture, date fermeture, détails, description intervention, etat, créateur, opérateur choisi, solveur
            dTicket.START_DATE_TICKET = DateTime.Now;
            dTicket.END_DATE_TICKET = null;
            dTicket.DETAILS_TICKET = rtbxTicketDetails.Text;
            dTicket.INTERVENTION_DESCRIPTION_TICKET = rtbxTicketInterventionDescription.Text;
            dTicket.ID_TICKET_STATE = (from t in Program.dcIndusDev.T_TICKET_STATE
                                       where t.NAME_TICKET_STATE == "En saisie"
                                       select t.ID_TICKET_STATE).FirstOrDefault();
            dTicket.ID_OWNER_OPERATOR = (from t in Program.dcIndusDev.T_OPERATOR
                                         where t.FIRST_NAME_OPERATOR + t.LAST_NAME_OPERATOR ==
                                         cbbxSelectedOperator.SelectedItem.ToString()
                                         select t.ID_OPERATOR).FirstOrDefault(); ;
            dTicket.ID_SELECTED_OPERATOR = (from t in Program.dcIndusDev.T_OPERATOR
                                            where t.FIRST_NAME_OPERATOR + t.LAST_NAME_OPERATOR ==
                                            cbbxSelectedOperator.SelectedItem.ToString()
                                            select t.ID_OPERATOR).FirstOrDefault();
            dTicket.ID_SOLVER_OPERATOR = (from t in Program.dcIndusDev.T_OPERATOR
                                          where t.FIRST_NAME_OPERATOR + t.LAST_NAME_OPERATOR ==
                                          cbbxSelectedOperator.SelectedItem.ToString()
                                          select t.ID_OPERATOR).FirstOrDefault();
            ;
            return dTicket;
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Evenements
        #region Evenements

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
