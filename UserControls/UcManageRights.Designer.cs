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
            this.btnValidateRights = new ZiTest.CustomButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.ptbQuit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuit)).BeginInit();
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
            this.flpnlOperatorType.AutoScroll = true;
            this.flpnlOperatorType.Location = new System.Drawing.Point(17, 50);
            this.flpnlOperatorType.Name = "flpnlOperatorType";
            this.flpnlOperatorType.Size = new System.Drawing.Size(408, 436);
            this.flpnlOperatorType.TabIndex = 1;
            // 
            // btnValidateRights
            // 
            this.btnValidateRights.BorderColor = System.Drawing.Color.Silver;
            this.btnValidateRights.ButtonColor = System.Drawing.Color.Red;
            this.btnValidateRights.Location = new System.Drawing.Point(152, 492);
            this.btnValidateRights.Name = "btnValidateRights";
            this.btnValidateRights.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnValidateRights.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnValidateRights.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnValidateRights.Size = new System.Drawing.Size(125, 49);
            this.btnValidateRights.TabIndex = 2;
            this.btnValidateRights.Text = "Valider";
            this.btnValidateRights.TextColor = System.Drawing.Color.White;
            this.btnValidateRights.UseVisualStyleBackColor = true;
            this.btnValidateRights.Click += new System.EventHandler(this.customButton1_Click);
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
            this.lblTitle.Size = new System.Drawing.Size(428, 40);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Modification des droits";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblDesign.Size = new System.Drawing.Size(5, 504);
            this.lblDesign.TabIndex = 11;
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbQuit
            // 
            this.ptbQuit.BackColor = System.Drawing.Color.Firebrick;
            this.ptbQuit.Image = global::TP_INDUSDEV.Properties.Resources.quitIcon;
            this.ptbQuit.Location = new System.Drawing.Point(389, 3);
            this.ptbQuit.Name = "ptbQuit";
            this.ptbQuit.Size = new System.Drawing.Size(36, 30);
            this.ptbQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQuit.TabIndex = 12;
            this.ptbQuit.TabStop = false;
            // 
            // UcManageRights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.ptbQuit);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnValidateRights);
            this.Controls.Add(this.flpnlOperatorType);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UcManageRights";
            this.Size = new System.Drawing.Size(428, 544);
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpnlOperatorType;
        private ZiTest.CustomButton btnValidateRights;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.PictureBox ptbQuit;
    }
}
