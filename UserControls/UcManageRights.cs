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
    public partial class UcManageRights : UserControl
    {
        // Variables
        #region Variables

        List<T_OPERATOR_TYPE> liOperatorType;
        List<T_RIGHT> liRight;
        List<TJ_RIGHT_OPERATOR_TYPE> liRightOperatorType;

        #endregion

        // Constructeur
        public UcManageRights()
        {
            InitializeComponent();

            //Lance l'ensemble des méthodes de récupération de données.
            GetOperatorsTypes();
            GetRights();
            GetRightsOperatorsTypes();

            foreach (T_OPERATOR_TYPE operatorType in liOperatorType)
            {
                UcOperatorRigths ucOperatorRigthsTemp = new UcOperatorRigths(operatorType, liRight, liRightOperatorType);
                flpnlOperatorType.Controls.Add(ucOperatorRigthsTemp);
            }
        }

        // Méthodes
        #region Méthodes

        public void GetOperatorsTypes()
        {
            liOperatorType = new List<T_OPERATOR_TYPE>();

            liOperatorType = (from ot in Program.dcIndusDev.T_OPERATOR_TYPE
                              select ot).ToList();
        }

        public void GetRights()
        {
            liRight = new List<T_RIGHT>();

            liRight = (from r in Program.dcIndusDev.T_RIGHT
                       select r).ToList();
        }

        public void GetRightsOperatorsTypes()
        {
            liRightOperatorType = new List<TJ_RIGHT_OPERATOR_TYPE>();

            liRightOperatorType = (from rot in Program.dcIndusDev.TJ_RIGHT_OPERATOR_TYPE
                                    select rot).ToList();
        }

        #endregion

        // Evenements
        #region Evenements

        #endregion

        private void customButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
