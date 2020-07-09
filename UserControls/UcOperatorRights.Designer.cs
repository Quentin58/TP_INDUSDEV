namespace TP_INDUSDEV.UserControls
{
    partial class UcOperatorRigths
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
            this.lblOperatorTypeName = new System.Windows.Forms.Label();
            this.clibxRightsOperator = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblOperatorTypeName
            // 
            this.lblOperatorTypeName.Location = new System.Drawing.Point(3, 3);
            this.lblOperatorTypeName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblOperatorTypeName.Name = "lblOperatorTypeName";
            this.lblOperatorTypeName.Size = new System.Drawing.Size(107, 30);
            this.lblOperatorTypeName.TabIndex = 0;
            this.lblOperatorTypeName.Text = "label1";
            this.lblOperatorTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clibxRightsOperator
            // 
            this.clibxRightsOperator.CheckOnClick = true;
            this.clibxRightsOperator.FormattingEnabled = true;
            this.clibxRightsOperator.Location = new System.Drawing.Point(116, 3);
            this.clibxRightsOperator.Name = "clibxRightsOperator";
            this.clibxRightsOperator.Size = new System.Drawing.Size(245, 124);
            this.clibxRightsOperator.TabIndex = 1;
            // 
            // UcOperatorRigths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clibxRightsOperator);
            this.Controls.Add(this.lblOperatorTypeName);
            this.Name = "UcOperatorRigths";
            this.Size = new System.Drawing.Size(365, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOperatorTypeName;
        private System.Windows.Forms.CheckedListBox clibxRightsOperator;
    }
}
