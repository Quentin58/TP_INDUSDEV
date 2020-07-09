namespace TP_INDUSDEV.UserControls
{
    partial class UcAddOperator
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
            this.cbbxOperatorType = new System.Windows.Forms.ComboBox();
            this.tbxOperatorFirstName = new CustomControlsLibrary.CustomTextBox();
            this.btnAddOperator = new ZiTest.CustomButton();
            this.tbxOperatorLastName = new CustomControlsLibrary.CustomTextBox();
            this.lblOperatorType = new System.Windows.Forms.Label();
            this.ptbxQuit = new System.Windows.Forms.PictureBox();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbxOperatorType
            // 
            this.cbbxOperatorType.FormattingEnabled = true;
            this.cbbxOperatorType.Location = new System.Drawing.Point(184, 197);
            this.cbbxOperatorType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbxOperatorType.Name = "cbbxOperatorType";
            this.cbbxOperatorType.Size = new System.Drawing.Size(92, 21);
            this.cbbxOperatorType.TabIndex = 3;
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
            this.tbxOperatorFirstName.Location = new System.Drawing.Point(184, 98);
            this.tbxOperatorFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOperatorFirstName.Name = "tbxOperatorFirstName";
            this.tbxOperatorFirstName.Size = new System.Drawing.Size(75, 18);
            this.tbxOperatorFirstName.TabIndex = 0;
            this.tbxOperatorFirstName.Text = "Prénom";
            this.tbxOperatorFirstName.WatermarkText = "Prénom";
            // 
            // btnAddOperator
            // 
            this.btnAddOperator.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAddOperator.ButtonColor = System.Drawing.Color.Firebrick;
            this.btnAddOperator.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddOperator.Location = new System.Drawing.Point(150, 314);
            this.btnAddOperator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddOperator.Name = "btnAddOperator";
            this.btnAddOperator.OnHoverBorderColor = System.Drawing.Color.DarkRed;
            this.btnAddOperator.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnAddOperator.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddOperator.Size = new System.Drawing.Size(174, 59);
            this.btnAddOperator.TabIndex = 4;
            this.btnAddOperator.Text = "Ajouter opérateur";
            this.btnAddOperator.TextColor = System.Drawing.Color.White;
            this.btnAddOperator.UseVisualStyleBackColor = true;
            this.btnAddOperator.Click += new System.EventHandler(this.BtnAddOperator_Click);
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
            this.tbxOperatorLastName.Location = new System.Drawing.Point(184, 136);
            this.tbxOperatorLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOperatorLastName.Name = "tbxOperatorLastName";
            this.tbxOperatorLastName.Size = new System.Drawing.Size(75, 18);
            this.tbxOperatorLastName.TabIndex = 1;
            this.tbxOperatorLastName.Text = "Nom";
            this.tbxOperatorLastName.WatermarkText = "Nom";
            // 
            // lblOperatorType
            // 
            this.lblOperatorType.AutoSize = true;
            this.lblOperatorType.Location = new System.Drawing.Point(182, 181);
            this.lblOperatorType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperatorType.Name = "lblOperatorType";
            this.lblOperatorType.Size = new System.Drawing.Size(87, 13);
            this.lblOperatorType.TabIndex = 2;
            this.lblOperatorType.Text = "Type d\'opérateur";
            // 
            // ptbQuit
            // 
            this.ptbxQuit.BackColor = System.Drawing.Color.Firebrick;
            this.ptbxQuit.Image = global::TP_INDUSDEV.Properties.Resources.quitIcon;
            this.ptbxQuit.Location = new System.Drawing.Point(435, 3);
            this.ptbxQuit.Name = "ptbQuit";
            this.ptbxQuit.Size = new System.Drawing.Size(36, 30);
            this.ptbxQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxQuit.TabIndex = 14;
            this.ptbxQuit.TabStop = false;
            this.ptbxQuit.Click += new System.EventHandler(this.PtbQuit_Click);
            // 
            // lblDesign
            // 
            this.lblDesign.BackColor = System.Drawing.Color.Firebrick;
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.White;
            this.lblDesign.Location = new System.Drawing.Point(0, 40);
            this.lblDesign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(5, 391);
            this.lblDesign.TabIndex = 13;
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(474, 40);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Ajout d\'un opérateur";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcAddOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ptbxQuit);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblOperatorType);
            this.Controls.Add(this.cbbxOperatorType);
            this.Controls.Add(this.tbxOperatorFirstName);
            this.Controls.Add(this.btnAddOperator);
            this.Controls.Add(this.tbxOperatorLastName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcAddOperator";
            this.Size = new System.Drawing.Size(474, 431);
            this.Resize += new System.EventHandler(this.UcAddOperator_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControlsLibrary.CustomTextBox tbxOperatorLastName;
        private ZiTest.CustomButton btnAddOperator;
        private CustomControlsLibrary.CustomTextBox tbxOperatorFirstName;
        private System.Windows.Forms.ComboBox cbbxOperatorType;
        private System.Windows.Forms.Label lblOperatorType;
        private System.Windows.Forms.PictureBox ptbxQuit;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblTitle;
    }
}
