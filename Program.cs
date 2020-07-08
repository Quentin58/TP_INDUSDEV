using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_INDUSDEV.Data;

namespace TP_INDUSDEV
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        // Variables
        #region Variables

        public static LinqToDB_INDUSDEV_DEVDataContext dcIndusDev = new LinqToDB_INDUSDEV_DEVDataContext();

        #endregion

        // Méthodes
        #region Méthodes

        // Appliquer les changements effectués à la base de données
        public static void SubmitChanges(string strMessage)
        {
            try
            {
                dcIndusDev.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(strMessage + "\n" + "Message d'erreur : " + ex.Message);
            }
        }
        /*_____________________________________________________________________________________________*/

        #endregion

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmConnection());
        }
    }
}
