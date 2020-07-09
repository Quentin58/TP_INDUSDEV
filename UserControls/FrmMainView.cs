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
        // Mode de saisie (Ticket ou Operateur) / true = ticket & false = operateur
        bool bEntryMode = true;
        #endregion

        // Constructeur
        public FrmMainView()
        {
            InitializeComponent();

            // Initialisation de l'affichage des controls
            this.InitializeDisplay(Program.connectedOperator);
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

            this.pnlManagement.Width = (int)(this.Width * 0.4);
            this.pnlMenu.Height = (int)(this.Height * 0.05);

            // Menu
            this.InitializeDisplayMenu(connectedOperator);
        }
        /*_____________________________________________________________________________________________*/
        private void InitializeDisplayMenu(T_OPERATOR connectedOperator)
        {
            // Controls du pnlMenu
            // Boutons
            this.btnDisconnect.Width = (int)(this.pnlMenu.Width * 0.15);
            // Images
            Size sPtb = new Size((int)(this.pnlMenu.Height * 0.9),
                (int)(this.pnlMenu.Height * 0.9));
            this.ptbAddTicketOrOperator.Size = sPtb;

            // Permet de moduler l'affichage si l'utilisateur connecté est un administrateur ou non
            if (connectedOperator.T_OPERATOR_TYPE.NAME_OPERATOR_TYPE == "Administrateur")
            {
                this.btnTicketsOrOperateur.Visible = true;
                this.btnTicketsOrOperateur.Width = (int)(this.pnlMenu.Width * 0.1);

                // Le bouton de modification des droits est disponible qu'en mode de saisie operateur (bEntryMode = false)
                if (!bEntryMode)
                {
                    this.ptbAddTicketOrOperator.Location = new Point((int)(this.pnlMenu.Width * 0.5 + this.ptbUpdateOperatorRights.Width * 2.2),
                                                                    (int)(this.pnlMenu.Height * 0.05));
                    this.ptbUpdateOperatorRights.Visible = true;
                    this.ptbUpdateOperatorRights.Size = sPtb;
                    this.ptbUpdateOperatorRights.Location = new Point((int)(this.pnlMenu.Width * 0.5 - this.ptbUpdateOperatorRights.Width * 1.2),
                        (int)(this.pnlMenu.Height * 0.05));
                }
                else
                {
                    this.ptbAddTicketOrOperator.Location = new Point((int)(this.pnlMenu.Width * 0.5 - this.ptbAddTicketOrOperator.Width * 0.5),
                                                                    (int)(this.pnlMenu.Height * 0.05));
                    this.ptbUpdateOperatorRights.Visible = false;
                }
            }
            else
            {
                this.btnTicketsOrOperateur.Visible = false;

                this.ptbAddTicketOrOperator.Location = new Point((int)(this.pnlMenu.Width * 0.5 - this.ptbAddTicketOrOperator.Width * 0.5),
                    (int)(this.pnlMenu.Height * 0.05));
                this.ptbUpdateOperatorRights.Visible = false;
            }
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
            this.InitializeDisplay(Program.connectedOperator);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Navigation entre les pages
        #region Navigation
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.FormClosing -= new FormClosingEventHandler(FrmMainView_FormClosing);
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is FrmConnection)
                    frm.Show();
            }
            this.Close();
        }
        /*_____________________________________________________________________________________________*/

        private void FrmMainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /*_____________________________________________________________________________________________*/

        // Navigation entre tickets et opérateurs
        private void btnTicketsOrOperateur_Click(object sender, EventArgs e)
        {
            // Switch mode de saisie :
            // - Changer variable
            this.bEntryMode = !this.bEntryMode;
            // - Changer text bouton
            this.btnTicketsOrOperateur.Text = (this.bEntryMode) ? "Opérateurs" : "Tickets";
            // - Mettre panel droite management en invisible
            this.pnlManagement.Visible = false;
            this.pnlManagement.Controls.Clear();
            // - Re-initialisé affichage menu
            this.InitializeDisplayMenu(Program.connectedOperator);
            // - Initialiser Panel d'affichage (selon le mode de saisie)
            // - Modifier fonction du bouton add
            this.ptbAddTicketOrOperator.Click += (this.bEntryMode) ? new EventHandler(ptbAddTicket_Click) : new EventHandler(ptbAddOperator_Click);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        // Ajout d'élément en base
        #region Ajout d'éléments
        // Pour les tickets
        private void ptbAddTicket_Click(object sender, EventArgs e)
        {
            this.pnlManagement.Controls.Clear();
            this.pnlManagement.Visible = true;
            this.pnlManagement.Width = (int)(this.Width * 0.4);

            // Création d'une nouvelle fenêtre d'ajout de ticket
            UcAddTicket newUcAddTicket = new UcAddTicket();
            newUcAddTicket.Dock = DockStyle.Fill;
            this.pnlManagement.Controls.Add(newUcAddTicket);
        }
        /*_____________________________________________________________________________________________*/
        // Pour les opérateurs
        private void ptbAddOperator_Click(object sender, EventArgs e)
        {
            this.pnlManagement.Controls.Clear();
            this.pnlManagement.Visible = true;
            this.pnlManagement.Width = (int)(this.Width * 0.4);

            // Création d'une nouvelle fenêtre d'ajout de ticket
            UcAddOperator newUcAddOperator = new UcAddOperator();
            newUcAddOperator.Dock = DockStyle.Fill;
            this.pnlManagement.Controls.Add(newUcAddOperator);
        }
        /*_____________________________________________________________________________________________*/
        // Pour les droits
        private void ptbUpdateOperatorRights_Click(object sender, EventArgs e)
        {
            this.pnlManagement.Controls.Clear();
            this.pnlManagement.Visible = true;
            this.pnlManagement.Width = (int)(this.Width * 0.4);

            // Création d'une nouvelle fenêtre d'ajout de ticket
            UcManageRights newUcManageRights = new UcManageRights();
            newUcManageRights.Dock = DockStyle.Fill;
            this.pnlManagement.Controls.Add(newUcManageRights);
        }
        /*_____________________________________________________________________________________________*/
        #endregion

        #endregion
    }
}
