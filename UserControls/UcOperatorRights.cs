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
    public partial class UcOperatorRigths : UserControl
    {

        // Variables
        #region Variables

        T_OPERATOR_TYPE OperatorType;
        List<T_RIGHT> liRight;
        List<TJ_RIGHT_OPERATOR_TYPE> liRightOperatorType;

        #endregion

        // Constructeur
        public UcOperatorRigths()
        {
            InitializeComponent();
        }
        public UcOperatorRigths(T_OPERATOR_TYPE operatorType, List<T_RIGHT> liRight, List<TJ_RIGHT_OPERATOR_TYPE> liRightOperatorType)
        {
            InitializeComponent();

            this.OperatorType = operatorType;
            this.liRight = liRight;
            this.liRightOperatorType = liRightOperatorType;

            lblOperatorTypeName.Text = operatorType.NAME_OPERATOR_TYPE;

            foreach (T_RIGHT right in liRight)
                clibxRightsOperator.Items.Add(right.NAME_RIGHT);

            foreach(TJ_RIGHT_OPERATOR_TYPE rightOperatorType in liRightOperatorType.Where(x => x.ID_OPERATOR_TYPE == OperatorType.ID_OPERATOR_TYPE))
                if(rightOperatorType.ALLOWED)
                    clibxRightsOperator.SetItemChecked(clibxRightsOperator.Items.IndexOf(liRight.FirstOrDefault(x => x.ID_RIGHT == rightOperatorType.ID_RIGHT).NAME_RIGHT),true);
        }

        // Méthodes
        #region Méthodes
        #endregion

        // Evenements
        #region Evenement
        #endregion

    }
}
