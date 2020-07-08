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
using TP_INDUSDEV.UserControls;
using System.Data.Linq;

namespace TP_INDUSDEV.UserControls
{
    public partial class UcAddOperator : UserControl
    {
        // Variables
        #region Variables

        string strAddOperatorErrorMessage = "Impossible d'ajouter un nouvel opérateur.";
        string strRemoveOperatorErrorMessage = "Impossible de supprimer un opérateur.";
        string strUpdateOperatorErrorMessage = "Impossible de modifier un opérateur.";

        #endregion

        // Constructeur
        public UcAddOperator()
        {
            InitializeComponent();
            InitializeControls();
        }
        /*_____________________________________________________________________________________________*/

        // Méthodes
        #region Méthodes

        // Initialisation champs formulaire
        private void InitializeControls()
        {
            // ComboBox types opérateur
            cbbxOperatorType.DataSource = from t in Program.dcIndusDev.T_OPERATOR_TYPE
                                          select t.NAME_OPERATOR_TYPE;
        }
        /*_____________________________________________________________________________________________*/

        // Ajouter nouvel opérateur (intervevant, technicien ou administrateur)
        private void AddOperator(T_OPERATOR dOperator)
        {
            Program.dcIndusDev.T_OPERATOR.InsertOnSubmit(dOperator);
        }
        /*_____________________________________________________________________________________________*/

        // Supprimer un opérateur existant (intervenant, technicien ou administrateur)
        private void RemoveOperator(T_OPERATOR dOperator)
        {
            Program.dcIndusDev.T_OPERATOR.DeleteOnSubmit(dOperator);
        }
        /*_____________________________________________________________________________________________*/

        // Récupérer les informations du formulaire
        private T_OPERATOR GetOperatorFormData()
        {
            T_OPERATOR dOperator = new T_OPERATOR();

            // Prénom, nom, login, mot de passe, type d'opérateur
            dOperator.FIRST_NAME_OPERATOR = tbxOperatorFirstName.Text;
            dOperator.LAST_NAME_OPERATOR = tbxOperatorLastName.Text;
            dOperator.LOGIN_OPERATOR = CreateOperatorLogin(tbxOperatorFirstName.Text, tbxOperatorLastName.Text, GetOperatorId());
            dOperator.PASSWORD_OPERATOR = DateTime.Now.Year.ToString() + "TicketManager!";
            dOperator.T_OPERATOR_TYPE = (from t in Program.dcIndusDev.T_OPERATOR_TYPE
                                         where t.NAME_OPERATOR_TYPE == cbbxOperatorType.SelectedItem.ToString()
                                         select t).FirstOrDefault();
;
            return dOperator;
        }
        /*_____________________________________________________________________________________________*/

        // Créer un login opérateur
        private string CreateOperatorLogin(string strFirstName, string strLastName, int iId)
        {
            // Exemple: prénom = Hector, nom = Gurant, id = 54 => Login: hgurant54
            return strFirstName.Substring(0, 1).ToLower() + strLastName.ToLower() + iId.ToString();
        }
        /*_____________________________________________________________________________________________*/

        // Récupérer le dernier id opérateur
        private int GetOperatorId()
        {
            if ((from t in Program.dcIndusDev.T_OPERATOR select t).Any()) // Recherche d'un opérateur en base
            {
                return (from t in Program.dcIndusDev.T_OPERATOR
                        select t.ID_OPERATOR).Max() + 1;
            }
            else // Pas d'opérateur en base
            {
                return 1;
            }
        }
        /*_____________________________________________________________________________________________*/

        // Ajouter type opérateur
        private void AddOperatorType(string strTypeName)
        {
            T_OPERATOR_TYPE dOperatorType = new T_OPERATOR_TYPE
            {
                ID_OPERATOR_TYPE = (from t in Program.dcIndusDev.T_OPERATOR_TYPE
                                    select t.ID_OPERATOR_TYPE).Max() + 1,
                NAME_OPERATOR_TYPE = strTypeName
            };

            Program.dcIndusDev.T_OPERATOR_TYPE.InsertOnSubmit(dOperatorType);
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Évenements
        #region Évenements

        // Ajouter nouvel opérateur (intervenant, technicien ou administrateur)
        private void BtnAddOperator_Click(object sender, EventArgs e)
        {
            T_OPERATOR dOperator = GetOperatorFormData();         
            AddOperator(dOperator);
            Program.SubmitChanges(strAddOperatorErrorMessage);
        }
        /*_____________________________________________________________________________________________*/

        #endregion
    }
}
