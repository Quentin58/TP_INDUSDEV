using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TP_INDUSDEV.Data;

namespace TP_INDUSDEV.UserControls
{
    public partial class UcAddOperator : UserControl
    {
        // Variables
        #region Variables

        readonly string strAddOperatorErrorMessage = "Impossible d'ajouter un nouvel opérateur.";

        #endregion

        // Constructeur
        public UcAddOperator()
        {
            InitializeComponent();
            InitializeDisplay();
            InitializeControls();
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
            this.btnAddOperator.Size = new Size((int)(this.Width * 0.5), (int)(this.Height * 0.1));
            this.btnAddOperator.Location = new Point((int)(this.Width * 0.25), (int)(this.Height * 0.85));
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Initialisation champs formulaire
        private void InitializeControls()
        {
            // ComboBox types opérateur
            cbbxOperatorType.DataSource = from t in Program.dcIndusDev.T_OPERATOR_TYPE
                                          select t.NAME_OPERATOR_TYPE;
            cbbxOperatorType.SelectedIndex = -1;
        }
        /*_____________________________________________________________________________________________*/

        // Ajouter nouvel opérateur (intervevant, technicien ou administrateur)
        private void AddOperator(T_OPERATOR dOperator)
        {
            Program.dcIndusDev.T_OPERATOR.InsertOnSubmit(dOperator);
        }
        /*_____________________________________________________________________________________________*/

        // Récupérer les informations du formulaire
        private T_OPERATOR GetOperatorData()
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

        // Vider les champs du formulaire
        private void ClearFields()
        {
            tbxOperatorFirstName.Text = "";
            tbxOperatorLastName.Text = "";
            cbbxOperatorType.SelectedIndex = -1;
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Évenements
        #region Évenements

        // Affichage
        #region Affichage

        // Changement de taille
        private void UcAddOperator_Resize(object sender, EventArgs e)
        {
            InitializeDisplay();
        }
        /*_____________________________________________________________________________________________*/

        // Fermeture UserControl
        private void PtbQuit_Click(object sender, EventArgs e)
        {
            Parent.Visible = false;
            Parent.Controls.Remove(this);
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        // Ajouter nouvel opérateur (intervenant, technicien ou administrateur)
        private void BtnAddOperator_Click(object sender, EventArgs e)
        {        
            AddOperator(GetOperatorData());
            Program.SubmitChanges(strAddOperatorErrorMessage);
            ClearFields();
            //UcDisplayOperator.DisplayOperators();
        }
        /*_____________________________________________________________________________________________*/

        #endregion
    }
}
