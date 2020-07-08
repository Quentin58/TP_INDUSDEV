namespace TP_INDUSDEV.UserControls
{
    partial class UcManageRights
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpnlOperatorType = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(114, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 14);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flpnlOperatorType
            // 
            this.flpnlOperatorType.Location = new System.Drawing.Point(3, 3);
            this.flpnlOperatorType.Name = "flpnlOperatorType";
            this.flpnlOperatorType.Size = new System.Drawing.Size(306, 217);
            this.flpnlOperatorType.TabIndex = 1;
            // 
            // UcManageRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpnlOperatorType);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UcManageRights";
            this.Size = new System.Drawing.Size(312, 223);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpnlOperatorType;
    }
}
