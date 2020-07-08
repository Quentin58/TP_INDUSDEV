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

namespace TP_INDUSDEV
{
    public partial class FrmConnection : Form
    {
        // Variables
        #region Variables

        public static LinqToDB_INDUSDEV_DEVDataContext dcIndusDev = new LinqToDB_INDUSDEV_DEVDataContext();

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
    }
}
