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
    public partial class UcDisplayTicket : UserControl
    {
        // Variables
        #region Variables
        T_TICKET actualTicket = new T_TICKET();

        // Liste des couleur des niveau d'importance des ticket (du rouge au vert =W pas urgent à très urgent)
        private List<string> liLevelTicketColor = new List<string>() { "#FF5333", "#FFCB63", "#FFFF60", "#CEFF77", "#4AD989" };

        bool bHistoryActivate = false;
        int iDefaultHeight = 0;
        #endregion

        // Constructeur
        public UcDisplayTicket(T_TICKET ticket)
        {
            InitializeComponent();
            actualTicket = ticket;

            InitializeDisplay(Program.connectedOperator);

            InitializeControls(ticket);
        }

        // Méthodes
        #region Méthodes

        // Affichage
        #region Affichage
        private void InitializeDisplay(T_OPERATOR connectedOperator)
        {
            // Permet de :
            // - positionner les controls par rapport à la page
            // - définir leur taille

            // Pour les information Ticket
            this.pnlInformations.Height = (int)(this.Height * 0.85);

            this.InitializeDisplayInformation();
            this.InitializeDisplayHistory();

            // Control panel design
            this.pnlDesign.Height = (int)(this.Height * 0.15);
            this.lblIndicatorTicketOwner.Width = (int)(this.pnlDesign.Width * 0.05);

            iDefaultHeight = this.Height;

            // Affichage selon type droit
            // Liste des droit de l'utilisateur
            List<string> liOperatorRights = (from r in Program.dcIndusDev.T_RIGHT
                                             join tj in Program.dcIndusDev.TJ_RIGHT_OPERATOR_TYPE on r.ID_RIGHT equals tj.ID_RIGHT
                                             where tj.ID_OPERATOR_TYPE == connectedOperator.ID_OPERATOR_TYPE
                                             select r.NAME_RIGHT).ToList();
            // - Droit de modifiaction
            this.ptbxEdit.Visible = (liOperatorRights.Contains("Modification Ticket")) ? true : false;
            // - Droit de suppression
            this.ptbxDelete.Visible = (liOperatorRights.Contains("Suppression Ticket")) ? true : false;
        }
        /*_____________________________________________________________________________________________*/

        private void InitializeDisplayInformation()
        {
            // Permet de :
            // - positionner les controls par rapport à la page
            // - définir leur taille

            // Controls du panel d'infromation
            this.lblLevelIndicator.Width = (int)(this.pnlInformations.Width * 0.05);
            this.lblTicketNumer.Width = (int)(this.pnlInformations.Width * 0.1);
            this.lblCreateDate.Width = (int)(this.pnlInformations.Width * 0.15);
            this.lblUpdateDate.Width = (int)(this.pnlInformations.Width * 0.15);
            this.lblActualState.Width = (int)(this.pnlInformations.Width * 0.4);
            this.ptbxEdit.Width = (int)(this.pnlInformations.Height);
            this.ptbxDelete.Width = (int)(this.pnlInformations.Height);
            this.ptbxShowMore.Width = (int)(this.pnlInformations.Height);
        }
        /*_____________________________________________________________________________________________*/

        private void InitializeDisplayHistory()
        {
            // Permet de :
            // - positionner les controls par rapport à la page
            // - définir leur taille

            // Historique
            this.pnlHistory.Width = (int)(this.Width * 0.6);
            this.pnlFieldHistory.Height = (int)(this.Height * 0.5);

            this.lblTitleLevel.Width = (int)(this.pnlHistory.Width * 0.1);
            this.lblTitleOperator.Width = (int)(this.pnlHistory.Width * 0.2);
            this.lblTitleUpdateDate.Width = (int)(this.pnlHistory.Width * 0.25);
            this.lblTitleUpdateState.Width = (int)(this.pnlHistory.Width * 0.25);
            this.lblTitleDelegatedOperateur.Width = (int)(this.pnlHistory.Width * 0.2);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Données
        #region Données
        private void InitializeControls(T_TICKET ticket)
        {
            int iLevelTicket = ticket.T_LEVEL_TICKET.GRADE_LEVEL_TICKET;
            this.lblLevelIndicator.BackColor = System.Drawing.ColorTranslator.FromHtml(liLevelTicketColor.ElementAtOrDefault(iLevelTicket));
            this.lblTicketNumer.Text = "Ticket N° " + ticket.ID_TICKET.ToString();
            this.lblCreateDate.Text = ticket.START_DATE_TICKET.ToString();
            string strLastUpadteDate = (from ut in Program.dcIndusDev.T_UPDATE_TICKET
                                        join t in Program.dcIndusDev.T_TICKET on ut.ID_TICKET equals t.ID_TICKET
                                        where t.ID_TICKET == ticket.ID_TICKET
                                        orderby ut.DATE_UPDATE_TICKET descending
                                        select ut.DATE_UPDATE_TICKET).FirstOrDefault().ToString();
            this.lblUpdateDate.Text = (strLastUpadteDate != "01/01/0001 00:00:00") ? strLastUpadteDate : "";
            this.lblActualState.Text = ticket.T_TICKET_STATE.NAME_TICKET_STATE;

            this.lblIndicatorTicketOwner.BackColor = (Program.connectedOperator.ID_OPERATOR == ticket.ID_SELECTED_OPERATOR ||
                                                    Program.connectedOperator.ID_OPERATOR == ticket.ID_OWNER_OPERATOR) ? Color.White : Color.Black;
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        #endregion

        // Evenements
        #region Evenements

        // Affichage
        #region Affichage
        private void UcDisplayTicket_Resize(object sender, EventArgs e)
        {
            InitializeDisplay(Program.connectedOperator);
        }
        /*_____________________________________________________________________________________________*/

        private void ptbxShowMore_Click(object sender, EventArgs e)
        {
            this.Resize -= new EventHandler(UcDisplayTicket_Resize);

            // Agrandir le usercontrol par rapport à l'historique et modifier taille panel
            List<T_UPDATE_TICKET> liUpdateTicket = (from c in Program.dcIndusDev.T_UPDATE_TICKET
                                                    where c.ID_TICKET == actualTicket.ID_TICKET
                                                    select c).ToList();
            int iUpdateSize = (int)(liUpdateTicket.Count + 1 * (this.Height * 0.5));
            if (!bHistoryActivate)
            {
                this.Height += iUpdateSize;
            }
            else
            {
                this.Height = iDefaultHeight;
            }

            bHistoryActivate = !bHistoryActivate;
            this.Resize += new EventHandler(UcDisplayTicket_Resize);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        #endregion
    }
}
