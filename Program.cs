using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_INDUSDEV.Data;
using TP_INDUSDEV.UserControls;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TP_INDUSDEV
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        // Variables
        #region Variables

        public static linqToDB_INDUSDEV_DEVDataContext dcIndusDev = new linqToDB_INDUSDEV_DEVDataContext();
        public static T_OPERATOR connectedOperator;

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
            AppCenter.Start("0e1bd9d9-17ed-470c-ba8b-9562483895b2",
                   typeof(Analytics), typeof(Crashes));
            //Application.Run(new FormTest());
        }
    }
}
