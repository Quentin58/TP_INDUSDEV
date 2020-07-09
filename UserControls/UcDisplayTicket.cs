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

        // Liste des couleur des niveau d'importance des ticket (du vert au rouge =W pas urgent à très urgent)
        private List<string> liLevelTicketColor = new List<string>() { "#4AD989", "#CEFF77", "#FFFF60", "#FFCB63", "#FF5333" };
        #endregion

        // Constructeur
        public UcDisplayTicket(T_TICKET ticket)
        {
            InitializeComponent();
            actualTicket = ticket;

            InitializeDisplay(Program.connectedOperator);
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

            // Pour les nformation Ticket
            this.pnlInformations.Height = (int)((int)(this.Height * 0.9));
            // Controls du panel d'infromation
            this.lblLevelIndicator.Width = (int)(this.pnlInformations.Width * 0.05);
            this.lblTicketNumer.Width = (int)(this.pnlInformations.Width * 0.1);
            this.lblCreateDate.Width = (int)(this.pnlInformations.Width * 0.15);
            this.lblUpdateDate.Width = (int)(this.pnlInformations.Width * 0.15);
            this.lblActualState.Width = (int)(this.pnlInformations.Width * 0.4);
            this.ptbxEdit.Width = (int)(this.pnlInformations.Height);
            this.ptbxDelete.Width = (int)(this.pnlInformations.Height);
            this.ptbxShowMore.Width = (int)(this.pnlInformations.Height);

            // Control panel design
            this.lblIndicatorTicketOwner.Width = (int)(this.pnlDesign.Width * 0.1);

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
            // Agrandir le usercontrol par rapport à l'historique et modifier taille panel
            List<T_UPDATE_TICKET> liUpdateTicket = (from c in Program.dcIndusDev.T_UPDATE_TICKET
                                                    where c.ID_TICKET == actualTicket.ID_TICKET
                                                    select c).ToList();
            if (!this.pnlHistory.Visible)
            {
                this.Height += (int)(liUpdateTicket.Count * (this.Height * 0.5));
                //this.pnlInformations.Height = (int)(this.Height * 0.2);
                this.pnlHistory.Visible = true;
                this.pnlHistory.Width = (int)(this.Width * 0.4);
            }
            else
            {
                this.Height -= (int)(liUpdateTicket.Count * (this.Height * 0.5));
                //this.pnlInformations.Height = (int)(this.Height * 0.2);
                this.pnlHistory.Visible = false;
            }
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        #endregion
    }
}
