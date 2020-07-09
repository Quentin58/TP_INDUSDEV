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
        private void btnValidateRights_Click(object sender, EventArgs e)
        {
            foreach(UcOperatorRigths ucOperatorRigths in flpnlOperatorType.Controls)
                foreach(T_RIGHT right in liRight)
                {
                    if ((from tj in Program.dcIndusDev.TJ_RIGHT_OPERATOR_TYPE
                         where tj.ID_RIGHT == right.ID_RIGHT && tj.ID_OPERATOR_TYPE == ucOperatorRigths.OperatorType.ID_OPERATOR_TYPE
                         select tj).Any())
                    {
                        //TJ_RIGHT_OPERATOR_TYPE rightOperatorType = (from tj in Program.dcIndusDev.TJ_RIGHT_OPERATOR_TYPE
                        //                                            join r in Program.dcIndusDev.T_RIGHT on tj.ID_RIGHT equals r.ID_RIGHT
                        //                                            join ot in Program.dcIndusDev.T_OPERATOR_TYPE on tj.ID_OPERATOR_TYPE equals ot.ID_OPERATOR_TYPE
                        //                                            where r.ID_RIGHT == right.ID_RIGHT && ot.ID_OPERATOR_TYPE == ucOperatorRigths.OperatorType.ID_OPERATOR_TYPE
                        //                                            select tj).FirstOrDefault();

                        TJ_RIGHT_OPERATOR_TYPE rightOperatorType = (from tj in Program.dcIndusDev.TJ_RIGHT_OPERATOR_TYPE
                                                                    where tj.ID_RIGHT == right.ID_RIGHT && tj.ID_OPERATOR_TYPE == ucOperatorRigths.OperatorType.ID_OPERATOR_TYPE
                                                                    select tj).FirstOrDefault();

                        rightOperatorType.ALLOWED = ucOperatorRigths.GetClibxRightsOperator().GetItemChecked(ucOperatorRigths.GetClibxRightsOperator().Items.IndexOf(right.NAME_RIGHT));

                        try
                        {
                            Program.dcIndusDev.SubmitChanges();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else
                    {
                        TJ_RIGHT_OPERATOR_TYPE rightOperatorType = new TJ_RIGHT_OPERATOR_TYPE()
                        {
                            ALLOWED = ucOperatorRigths.GetClibxRightsOperator().GetItemChecked(ucOperatorRigths.GetClibxRightsOperator().Items.IndexOf(right.NAME_RIGHT)),
                            ID_OPERATOR_TYPE = ucOperatorRigths.OperatorType.ID_OPERATOR_TYPE,
                            ID_RIGHT = right.ID_RIGHT
                        };

                        Program.dcIndusDev.TJ_RIGHT_OPERATOR_TYPE.InsertOnSubmit(rightOperatorType);
                        Program.dcIndusDev.SubmitChanges();
                    }
                }
        }
        #endregion

    }
}
