namespace TP_INDUSDEV
{
    partial class FrmConnection
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxPassword = new CustomControlsLibrary.CustomTextBox();
            this.tbxLogin = new CustomControlsLibrary.CustomTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(449, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ticket Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(233, 78);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(160, 31);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Connexion";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Se connecter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxPassword.ButtonBorderOnFocusColor = System.Drawing.Color.Blue;
            this.tbxPassword.ColorWatermark = System.Drawing.Color.Gray;
            this.tbxPassword.ForeColor = System.Drawing.Color.Gray;
            this.tbxPassword.IsPassword = true;
            this.tbxPassword.Location = new System.Drawing.Point(227, 197);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(151, 20);
            this.tbxPassword.TabIndex = 6;
            this.tbxPassword.Text = "Entrer votre mot de passe";
            this.tbxPassword.WatermarkText = "Entrer votre mot de passe";
            // 
            // tbxLogin
            // 
            this.tbxLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLogin.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxLogin.ButtonBorderOnFocusColor = System.Drawing.Color.Blue;
            this.tbxLogin.ColorWatermark = System.Drawing.Color.Empty;
            this.tbxLogin.IsPassword = false;
            this.tbxLogin.Location = new System.Drawing.Point(227, 156);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(151, 20);
            this.tbxLogin.TabIndex = 5;
            this.tbxLogin.WatermarkText = null;
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmConnection";
            this.Text = "Page de connexion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Button button1;
        private CustomControlsLibrary.CustomTextBox tbxLogin;
        private CustomControlsLibrary.CustomTextBox tbxPassword;
    }
}

