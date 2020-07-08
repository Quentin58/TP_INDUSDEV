using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_INDUSDEV.Data;
using TP_INDUSDEV.UserControls;

namespace TP_INDUSDEV
{
    public partial class FrmConnection : Form
    {
        // Variables
        #region Variables

        #endregion

        // Constructeur
        public FrmConnection()
        {
            InitializeComponent();
        }
        /*_______________________________________________________________________________________________________*/

        // Méthodes
        #region Méthodes

        #endregion

        // Evenements
        #region Evenements

        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            FrmMainView newFrmMainView = new FrmMainView();
            this.Visible = false;
            newFrmMainView.Show();
        }
    }
}
