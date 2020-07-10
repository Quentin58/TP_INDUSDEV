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
            this.tbxLogin = new CustomControlsLibrary.CustomTextBox();
            this.tbxPassword = new CustomControlsLibrary.CustomTextBox();
            this.lblDesign = new System.Windows.Forms.Label();
            this.btnConnect = new ZiTest.CustomButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(624, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ticket Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(0, 85);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(624, 31);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Connexion_Présentation";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxLogin
            // 
            this.tbxLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLogin.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxLogin.ButtonBorderOnFocusColor = System.Drawing.Color.Firebrick;
            this.tbxLogin.ColorWatermark = System.Drawing.Color.DarkGray;
            this.tbxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxLogin.IsPassword = false;
            this.tbxLogin.Location = new System.Drawing.Point(213, 156);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(191, 20);
            this.tbxLogin.TabIndex = 5;
            this.tbxLogin.Text = "Entrez votre indentifiant";
            this.tbxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxLogin.WatermarkText = "Entrez votre indentifiant";
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxPassword.ButtonBorderOnFocusColor = System.Drawing.Color.Firebrick;
            this.tbxPassword.ColorWatermark = System.Drawing.Color.DarkGray;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxPassword.IsPassword = true;
            this.tbxPassword.Location = new System.Drawing.Point(213, 197);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(191, 20);
            this.tbxPassword.TabIndex = 6;
            this.tbxPassword.Text = "Entrez votre mot de passe";
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.WatermarkText = "Entrez votre mot de passe";
            // 
            // lblDesign
            // 
            this.lblDesign.BackColor = System.Drawing.Color.Brown;
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.Location = new System.Drawing.Point(0, 55);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(624, 30);
            this.lblDesign.TabIndex = 7;
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            this.btnConnect.BorderColor = System.Drawing.SystemColors.Control;
            this.btnConnect.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnConnect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(240, 245);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnConnect.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.btnConnect.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.btnConnect.Size = new System.Drawing.Size(137, 40);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Se connecter";
            this.btnConnect.TextColor = System.Drawing.Color.Black;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page de connexion";
            this.VisibleChanged += new System.EventHandler(this.FrmConnection_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private CustomControlsLibrary.CustomTextBox tbxLogin;
        private CustomControlsLibrary.CustomTextBox tbxPassword;
        private System.Windows.Forms.Label lblDesign;
        private ZiTest.CustomButton btnConnect;
    }
}

