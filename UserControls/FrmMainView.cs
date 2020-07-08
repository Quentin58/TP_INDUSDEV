using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_INDUSDEV.Data;

namespace TP_INDUSDEV.UserControls
{
    public partial class FrmMainView : Form
    {
        // Variables
        #region Variables

        #endregion

        // Constructeur
        public FrmMainView()
        {
            InitializeComponent();

            // Initialisation de l'affichage des controls
            this.InitializeDisplay();
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

            this.pnlAddTicket.Width = (int)(this.Width * 0.5);
            this.pnlMenu.Height = (int)(this.Height * 0.05);

            // Controls du pnlMenu
                // Boutons
            this.btnDisconnect.Width = (int)(this.pnlMenu.Width * 0.15);
            this.btnTicketsOrOperateur.Width = (int)(this.pnlMenu.Width * 0.1);

                // Images
            Size sPtb = new Size((int)(this.pnlMenu.Height * 0.9), 
                (int)(this.pnlMenu.Height * 0.9));
            this.ptbAddTicket.Size = sPtb;
            this.ptbAddTicket.Location = new Point((int)(this.pnlMenu.Width * 0.5 - this.ptbAddTicket.Width * 0.5),
                (int)(this.pnlMenu.Height * 0.05));

            this.ptbAddOperator.Size = sPtb;
            this.ptbAddOperator.Location = new Point((int)(this.pnlMenu.Width * 0.5 - this.ptbAddOperator.Width * 1.2),
                (int)(this.pnlMenu.Height * 0.05));

            this.ptbUpdateOperatorRights.Size = sPtb;
            this.ptbUpdateOperatorRights.Location = new Point((int)(this.pnlMenu.Width * 0.5 + this.ptbUpdateOperatorRights.Width * 1.2),
                (int)(this.pnlMenu.Height * 0.05));
        }
        /*_____________________________________________________________________________________________*/

        private void AdministratorDisplay(T_OPERATOR connectedOperator)
        {
            // Permet de moduler l'affichage si l'utilisateur connecté est un administrateur ou non
            this.btnTicketsOrOperateur.Visible = (connectedOperator.T_OPERATOR_TYPE.NAME_OPERATOR_TYPE == "Administrateur") ? true : false;
        }
        /*_____________________________________________________________________________________________*/
        #endregion
        #endregion

        // Evenements
        #region Evenements

        // Affichage
        #region Affichage
        private void FrmMainView_Resize(object sender, EventArgs e)
        {
            // Ré-initialisation de l'affichage lorsque la page est dedimentionnée
            this.InitializeDisplay();
        }
        /*_____________________________________________________________________________________________*/
        #endregion
        #endregion

    }
}
