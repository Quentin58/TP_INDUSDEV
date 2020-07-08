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
        // Vérifier si utilisateur existe
        private bool CheckOperatorExist(string strLogin, string strPassword)
        {
            try
            {
                bool bExist = (from o in Program.dcIndusDev.T_OPERATOR
                               where o.LOGIN_OPERATOR == strLogin
                                && o.PASSWORD_OPERATOR == strPassword
                               select o).Any();

                return bExist;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning", ex.Message);
                return false;
            }
        }
        /*_______________________________________________________________________________________________________*/

        // Récupérer un utilisateur selon un login et un password
        private T_OPERATOR GetOperator(string strLogin, string strPassword)
        {
            try
            {
                return (T_OPERATOR)(from o in Program.dcIndusDev.T_OPERATOR
                                    where o.LOGIN_OPERATOR == strLogin
                                     && o.PASSWORD_OPERATOR == strPassword
                                    select o).FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning", ex.Message);
                return new T_OPERATOR();
            }
        }
        /*_______________________________________________________________________________________________________*/
        #endregion

        // Evenements
        #region Evenements
        // Connexion
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Si les identifiant sont ok, on initialise l'opérator connecté
            if (CheckOperatorExist(this.tbxLogin.Text, this.tbxPassword.Text))
            {
                Program.connectedOperator = GetOperator(this.tbxLogin.Text, this.tbxPassword.Text);

                FrmMainView newFrmMainView = new FrmMainView();
                this.Visible = false;
                newFrmMainView.Show();
            }
            else
            {
                MessageBox.Show("Identifiants incorrectes !", "Erreur de connexion", MessageBoxButtons.OK);
            }
        }
        /*_______________________________________________________________________________________________________*/

        // Affichage
        private void FrmConnection_VisibleChanged(object sender, EventArgs e)
        {
            // On reset les control lorsque la visibilite de cette page change
            this.tbxLogin.Text = "Entrez votre indentifiant";
            this.tbxLogin.WatermarkText = "Entrez votre indentifiant";
            this.tbxPassword.Text = "Entrez votre mot de passe";
            this.tbxPassword.WatermarkText = "Entrez votre mot de passe";
        }
        /*_______________________________________________________________________________________________________*/

        #endregion
    }
}
