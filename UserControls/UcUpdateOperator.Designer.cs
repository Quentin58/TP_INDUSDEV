namespace TP_INDUSDEV.UserControls
{
    partial class UcUpdateOperator
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblOperatorType = new System.Windows.Forms.Label();
            this.cbbxOperatorType = new System.Windows.Forms.ComboBox();
            this.tbxOperatorFirstName = new CustomControlsLibrary.CustomTextBox();
            this.btnUpdateOperator = new ZiTest.CustomButton();
            this.tbxOperatorLastName = new CustomControlsLibrary.CustomTextBox();
            this.tbxOperatorLogin = new CustomControlsLibrary.CustomTextBox();
            this.ptbxResetPassword = new System.Windows.Forms.PictureBox();
            this.ptbxQuit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxResetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesign
            // 
            this.lblDesign.BackColor = System.Drawing.Color.Firebrick;
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.White;
            this.lblDesign.Location = new System.Drawing.Point(0, 49);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(7, 512);
            this.lblDesign.TabIndex = 21;
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(599, 49);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Modification d\'un opérateur";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperatorType
            // 
            this.lblOperatorType.AutoSize = true;
            this.lblOperatorType.Location = new System.Drawing.Point(202, 318);
            this.lblOperatorType.Name = "lblOperatorType";
            this.lblOperatorType.Size = new System.Drawing.Size(117, 17);
            this.lblOperatorType.TabIndex = 17;
            this.lblOperatorType.Text = "Type d\'opérateur";
            // 
            // cbbxOperatorType
            // 
            this.cbbxOperatorType.FormattingEnabled = true;
            this.cbbxOperatorType.Location = new System.Drawing.Point(204, 337);
            this.cbbxOperatorType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxOperatorType.Name = "cbbxOperatorType";
            this.cbbxOperatorType.Size = new System.Drawing.Size(121, 24);
            this.cbbxOperatorType.TabIndex = 5;
            // 
            // tbxOperatorFirstName
            // 
            this.tbxOperatorFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOperatorFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOperatorFirstName.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxOperatorFirstName.ButtonBorderOnFocusColor = System.Drawing.Color.Firebrick;
            this.tbxOperatorFirstName.ColorWatermark = System.Drawing.Color.DarkGray;
            this.tbxOperatorFirstName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxOperatorFirstName.IsPassword = false;
            this.tbxOperatorFirstName.Location = new System.Drawing.Point(205, 121);
            this.tbxOperatorFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxOperatorFirstName.Name = "tbxOperatorFirstName";
            this.tbxOperatorFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbxOperatorFirstName.TabIndex = 1;
            this.tbxOperatorFirstName.Text = "Prénom";
            this.tbxOperatorFirstName.WatermarkText = "Prénom";
            // 
            // btnUpdateOperator
            // 
            this.btnUpdateOperator.BorderColor = System.Drawing.Color.Firebrick;
            this.btnUpdateOperator.ButtonColor = System.Drawing.Color.Firebrick;
            this.btnUpdateOperator.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUpdateOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateOperator.Location = new System.Drawing.Point(160, 386);
            this.btnUpdateOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateOperator.Name = "btnUpdateOperator";
            this.btnUpdateOperator.OnHoverBorderColor = System.Drawing.Color.DarkRed;
            this.btnUpdateOperator.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnUpdateOperator.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateOperator.Size = new System.Drawing.Size(232, 73);
            this.btnUpdateOperator.TabIndex = 6;
            this.btnUpdateOperator.Text = "Valider modifications";
            this.btnUpdateOperator.TextColor = System.Drawing.Color.White;
            this.btnUpdateOperator.UseVisualStyleBackColor = true;
            this.btnUpdateOperator.Click += new System.EventHandler(this.BtnUpdateOperator_Click);
            // 
            // tbxOperatorLastName
            // 
            this.tbxOperatorLastName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOperatorLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOperatorLastName.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxOperatorLastName.ButtonBorderOnFocusColor = System.Drawing.Color.Firebrick;
            this.tbxOperatorLastName.ColorWatermark = System.Drawing.Color.DarkGray;
            this.tbxOperatorLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxOperatorLastName.IsPassword = false;
            this.tbxOperatorLastName.Location = new System.Drawing.Point(205, 167);
            this.tbxOperatorLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxOperatorLastName.Name = "tbxOperatorLastName";
            this.tbxOperatorLastName.Size = new System.Drawing.Size(100, 22);
            this.tbxOperatorLastName.TabIndex = 2;
            this.tbxOperatorLastName.Text = "Nom";
            this.tbxOperatorLastName.WatermarkText = "Nom";
            // 
            // tbxOperatorLogin
            // 
            this.tbxOperatorLogin.BackColor = System.Drawing.SystemColors.Control;
            this.tbxOperatorLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOperatorLogin.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxOperatorLogin.ButtonBorderOnFocusColor = System.Drawing.Color.Firebrick;
            this.tbxOperatorLogin.ColorWatermark = System.Drawing.Color.DarkGray;
            this.tbxOperatorLogin.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxOperatorLogin.IsPassword = false;
            this.tbxOperatorLogin.Location = new System.Drawing.Point(205, 218);
            this.tbxOperatorLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxOperatorLogin.Name = "tbxOperatorLogin";
            this.tbxOperatorLogin.Size = new System.Drawing.Size(100, 22);
            this.tbxOperatorLogin.TabIndex = 3;
            this.tbxOperatorLogin.Text = "Login";
            this.tbxOperatorLogin.WatermarkText = "Login";
            // 
            // ptbxResetPassword
            // 
            this.ptbxResetPassword.BackColor = System.Drawing.SystemColors.Control;
            this.ptbxResetPassword.Image = global::TP_INDUSDEV.Properties.Resources.Reset;
            this.ptbxResetPassword.Location = new System.Drawing.Point(205, 260);
            this.ptbxResetPassword.Margin = new System.Windows.Forms.Padding(4);
            this.ptbxResetPassword.Name = "ptbxResetPassword";
            this.ptbxResetPassword.Size = new System.Drawing.Size(48, 44);
            this.ptbxResetPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxResetPassword.TabIndex = 24;
            this.ptbxResetPassword.TabStop = false;
            this.ptbxResetPassword.Click += new System.EventHandler(this.PtbxResetPassword_Click);
            // 
            // ptbxQuit
            // 
            this.ptbxQuit.BackColor = System.Drawing.Color.Firebrick;
            this.ptbxQuit.Image = global::TP_INDUSDEV.Properties.Resources.quitIcon;
            this.ptbxQuit.Location = new System.Drawing.Point(540, 4);
            this.ptbxQuit.Margin = new System.Windows.Forms.Padding(4);
            this.ptbxQuit.Name = "ptbxQuit";
            this.ptbxQuit.Size = new System.Drawing.Size(48, 37);
            this.ptbxQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxQuit.TabIndex = 22;
            this.ptbxQuit.TabStop = false;
            this.ptbxQuit.Click += new System.EventHandler(this.PtbxQuit_Click);
            // 
            // UcUpdateOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbxResetPassword);
            this.Controls.Add(this.tbxOperatorLogin);
            this.Controls.Add(this.ptbxQuit);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOperatorType);
            this.Controls.Add(this.cbbxOperatorType);
            this.Controls.Add(this.tbxOperatorFirstName);
            this.Controls.Add(this.btnUpdateOperator);
            this.Controls.Add(this.tbxOperatorLastName);
            this.Name = "UcUpdateOperator";
            this.Size = new System.Drawing.Size(599, 561);
            this.Resize += new System.EventHandler(this.UcUpdateOperator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxResetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxQuit;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblOperatorType;
        private System.Windows.Forms.ComboBox cbbxOperatorType;
        private CustomControlsLibrary.CustomTextBox tbxOperatorFirstName;
        private ZiTest.CustomButton btnUpdateOperator;
        private CustomControlsLibrary.CustomTextBox tbxOperatorLastName;
        private CustomControlsLibrary.CustomTextBox tbxOperatorLogin;
        private System.Windows.Forms.PictureBox ptbxResetPassword;
    }
}
