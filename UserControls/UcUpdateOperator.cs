using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TP_INDUSDEV.Data;

namespace TP_INDUSDEV.UserControls
{
    public partial class UcUpdateOperator : UserControl
    {
        // Variables
        #region Variables

        readonly string strAddOperatorErrorMessage = "Impossible d'ajouter un nouvel opérateur.";
        T_OPERATOR dOperator = new T_OPERATOR();

        #endregion

        // Constructeur
        public UcUpdateOperator(int iIdOperator)
        {
            InitializeComponent();
            InitializeDisplay();
            dOperator = GetOperatorToUpdateData(iIdOperator);
            InitializeControlsData();
        }
        /*_____________________________________________________________________________________________*/

        // Méthodes
        #region Méthodes

        // Affichage
        #region Affichage

        // Initialisation de l'affichage
        private void InitializeDisplay()
        {
            // Permet de :
            // - positionner les controls par rapport à la page
            // - définir leur taille

            // Titre
            this.lblTitle.Height = (int)(this.Height * 0.1);
            this.ptbxQuit.Size = new Size((int)(this.lblTitle.Height * 0.5), (int)(this.lblTitle.Height * 0.5));
            this.ptbxQuit.Location = new Point((int)(this.lblTitle.Width - (this.lblTitle.Height * 0.1 + this.ptbxQuit.Width)), (int)(this.lblTitle.Height * 0.25));
            // Champs
            this.tbxOperatorFirstName.Width = (int)(this.Width * 0.7);
            this.tbxOperatorFirstName.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.25));
            this.tbxOperatorLastName.Width = (int)(this.Width * 0.7);
            this.tbxOperatorLastName.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.4));

            this.lblOperatorType.Size = new Size((int)(this.Width * 0.175),
                                            (int)(this.Height * 0.05));
            this.lblOperatorType.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.55));
            this.cbbxOperatorType.Width = (int)(this.Width * 0.7);
            this.cbbxOperatorType.Location = new Point((int)(this.Width * 0.15),
                                                        (int)(this.Height * 0.6));

            // Bouton
            this.btnUpdateOperator.Size = new Size((int)(this.Width * 0.5), (int)(this.Height * 0.1));
            this.btnUpdateOperator.Location = new Point((int)(this.Width * 0.25), (int)(this.Height * 0.85));
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Récupération données de l'opérateur à mettre à jour
        private T_OPERATOR GetOperatorToUpdateData(int iIdOperator)
        {
            if ((from t in Program.dcIndusDev.T_OPERATOR
                 where t.ID_OPERATOR == iIdOperator
                 select t).Any())
            {
                return (from t in Program.dcIndusDev.T_OPERATOR
                        where t.ID_OPERATOR == iIdOperator
                        select t).FirstOrDefault();
            }
            else
            {
                MessageBox.Show("Cet opérateur n'existe pas.");

                return default;
            }
        }
        /*_____________________________________________________________________________________________*/

        // Initialisation champs formulaire
        private void InitializeControlsData()
        {
            tbxOperatorFirstName.Text = dOperator.FIRST_NAME_OPERATOR;
            tbxOperatorLastName.Text = dOperator.LAST_NAME_OPERATOR;
            tbxOperatorLogin.Text = dOperator.LOGIN_OPERATOR;

            // ComboBox types d'opérateur
            cbbxOperatorType.DataSource = from t in Program.dcIndusDev.T_OPERATOR_TYPE
                                          select t.NAME_OPERATOR_TYPE;
            cbbxOperatorType.SelectedItem = (from t in Program.dcIndusDev.T_OPERATOR_TYPE
                                             where t.ID_OPERATOR_TYPE == dOperator.ID_OPERATOR_TYPE
                                             select t.NAME_OPERATOR_TYPE).FirstOrDefault();
        }
        /*_____________________________________________________________________________________________*/

        // Récupérer les informations du formulaire
        private T_OPERATOR GetOperatorData()
        {
            T_OPERATOR dOperator = this.dOperator;

            // Prénom, nom, login, type d'opérateur
            dOperator.FIRST_NAME_OPERATOR = tbxOperatorFirstName.Text;
            dOperator.LAST_NAME_OPERATOR = tbxOperatorLastName.Text;
            dOperator.LOGIN_OPERATOR = tbxOperatorLogin.Text;
            dOperator.T_OPERATOR_TYPE = (from t in Program.dcIndusDev.T_OPERATOR_TYPE
                                         where t.NAME_OPERATOR_TYPE == cbbxOperatorType.SelectedItem.ToString()
                                         select t).FirstOrDefault();
            ;
            return dOperator;
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Évenements
        #region Évenements

        // Affichage
        #region Affichage

        // Changement de taille
        private void UcUpdateOperator_Resize(object sender, EventArgs e)
        {
            InitializeDisplay();
        }
        /*_____________________________________________________________________________________________*/

        // Fermeture UserControl
        private void PtbxQuit_Click(object sender, EventArgs e)
        {
            Parent.Visible = false;
            Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        private void PtbxResetPassword_Click(object sender, EventArgs e)
        {
            dOperator.PASSWORD_OPERATOR = DateTime.Now.Year.ToString() + "TicketManager!";
        }

        // Mettre à jour opérateur
        private void BtnUpdateOperator_Click(object sender, EventArgs e)
        {
            GetOperatorData();
            Program.SubmitChanges(strAddOperatorErrorMessage);
            //UcDisplayOperator.DisplayOperators();
            Parent.Visible = false;
            Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/

        #endregion
    }
}
