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
    public partial class UcHistoryTicket : UserControl
    {
        // Variables
        #region Variables
        T_UPDATE_TICKET updateTicket = new T_UPDATE_TICKET();

        // Liste des couleur des niveau d'importance des ticket (du rouge au vert =W pas urgent à très urgent)
        private List<string> liLevelTicketColor = new List<string>() { "#FF5333", "#FFCB63", "#FFFF60", "#CEFF77", "#4AD989" };
        #endregion

        public UcHistoryTicket(T_UPDATE_TICKET update)
        {
            InitializeComponent();
            updateTicket = update;

            InitializeDisplay();
            InitializeControls(update);
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

            this.lblLevelIndicator.Width = (int)(this.Width * 0.1);
            this.lblOperator.Width = (int)(this.Width * 0.2);
            this.lblUpdateDate.Width = (int)(this.Width * 0.25);
            this.lblUpdateState.Width = (int)(this.Width * 0.25);
            this.lblDelegatedOperateur.Width = (int)(this.Width * 0.2);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Données
        #region Données
        private void InitializeControls(T_UPDATE_TICKET update)
        {
            this.lblLevelIndicator.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFCC66");
        }
        /*_____________________________________________________________________________________________*/
        #endregion
        #endregion

        // Evénements
        #region Evénements

        // Affichage
        #region Affichage
        private void UcHistoryTicket_Resize(object sender, EventArgs e)
        {
            // Ré-initialisation de l'affichage lorsque la page est dedimentionnée
            this.InitializeDisplay();
        }
        /*_____________________________________________________________________________________________*/
        #endregion
        #endregion
    }
}
