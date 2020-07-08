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
            this.tbxOperatorFirstName = new CustomControlsLibrary.CustomTextBox();
            this.tbxOperatorLastName = new CustomControlsLibrary.CustomTextBox();
            this.btnAddOperator = new ZiTest.CustomButton();
            this.SuspendLayout();
            // 
            // tbxOperatorFirstName
            // 
            this.tbxOperatorFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOperatorFirstName.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxOperatorFirstName.ButtonBorderOnFocusColor = System.Drawing.Color.Blue;
            this.tbxOperatorFirstName.ColorWatermark = System.Drawing.Color.Silver;
            this.tbxOperatorFirstName.ForeColor = System.Drawing.Color.Silver;
            this.tbxOperatorFirstName.IsPassword = false;
            this.tbxOperatorFirstName.Location = new System.Drawing.Point(287, 84);
            this.tbxOperatorFirstName.Name = "tbxOperatorFirstName";
            this.tbxOperatorFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbxOperatorFirstName.TabIndex = 0;
            this.tbxOperatorFirstName.Text = "Prénom";
            this.tbxOperatorFirstName.Visible = false;
            this.tbxOperatorFirstName.WatermarkText = "Prénom";
            // 
            // tbxOperatorLastName
            // 
            this.tbxOperatorLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxOperatorLastName.BottomBorderColor = System.Drawing.Color.Black;
            this.tbxOperatorLastName.ButtonBorderOnFocusColor = System.Drawing.Color.Blue;
            this.tbxOperatorLastName.ColorWatermark = System.Drawing.Color.Silver;
            this.tbxOperatorLastName.ForeColor = System.Drawing.Color.Silver;
            this.tbxOperatorLastName.IsPassword = false;
            this.tbxOperatorLastName.Location = new System.Drawing.Point(287, 134);
            this.tbxOperatorLastName.Name = "tbxOperatorLastName";
            this.tbxOperatorLastName.Size = new System.Drawing.Size(100, 22);
            this.tbxOperatorLastName.TabIndex = 1;
            this.tbxOperatorLastName.Text = "Nom";
            this.tbxOperatorLastName.WatermarkText = "Nom";
            // 
            // btnAddOperator
            // 
            this.btnAddOperator.BorderColor = System.Drawing.Color.Silver;
            this.btnAddOperator.ButtonColor = System.Drawing.Color.Red;
            this.btnAddOperator.Location = new System.Drawing.Point(287, 198);
            this.btnAddOperator.Name = "btnAddOperator";
            this.btnAddOperator.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnAddOperator.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnAddOperator.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAddOperator.Size = new System.Drawing.Size(125, 56);
            this.btnAddOperator.TabIndex = 2;
            this.btnAddOperator.Text = "Ajouter opérateur";
            this.btnAddOperator.TextColor = System.Drawing.Color.White;
            this.btnAddOperator.UseVisualStyleBackColor = true;
            this.btnAddOperator.Click += new System.EventHandler(this.BtnAddOperator_Click);
            // 
            // UcAddOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddOperator);
            this.Controls.Add(this.tbxOperatorLastName);
            this.Controls.Add(this.tbxOperatorFirstName);
            this.Name = "UcAddOperator";
            this.Size = new System.Drawing.Size(707, 464);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlsLibrary.CustomTextBox tbxOperatorFirstName;
        private CustomControlsLibrary.CustomTextBox tbxOperatorLastName;
        private ZiTest.CustomButton btnAddOperator;
    }
}
