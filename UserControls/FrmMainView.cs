using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.pnlAddTicket.Width = 12;
        }
        #endregion
        #endregion

        // Evenements
        #region Evenements

        #endregion
    }
}
