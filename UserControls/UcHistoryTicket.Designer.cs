namespace TP_INDUSDEV.UserControls
{
    partial class UcHistoryTicket
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
            this.lblLevelIndicator = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblUpdateState = new System.Windows.Forms.Label();
            this.lblDelegatedOperateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLevelIndicator
            // 
            this.lblLevelIndicator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLevelIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLevelIndicator.Location = new System.Drawing.Point(0, 0);
            this.lblLevelIndicator.Name = "lblLevelIndicator";
            this.lblLevelIndicator.Size = new System.Drawing.Size(44, 48);
            this.lblLevelIndicator.TabIndex = 5;
            this.lblLevelIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOperator.Location = new System.Drawing.Point(44, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(57, 48);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "TicketNumber";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUpdateDate.Location = new System.Drawing.Point(101, 0);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(110, 48);
            this.lblUpdateDate.TabIndex = 7;
            this.lblUpdateDate.Text = "DateCréation";
            this.lblUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdateState
            // 
            this.lblUpdateState.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUpdateState.Location = new System.Drawing.Point(211, 0);
            this.lblUpdateState.Name = "lblUpdateState";
            this.lblUpdateState.Size = new System.Drawing.Size(157, 48);
            this.lblUpdateState.TabIndex = 8;
            this.lblUpdateState.Text = "EtatActuel";
            this.lblUpdateState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDelegatedOperateur
            // 
            this.lblDelegatedOperateur.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDelegatedOperateur.Location = new System.Drawing.Point(368, 0);
            this.lblDelegatedOperateur.Name = "lblDelegatedOperateur";
            this.lblDelegatedOperateur.Size = new System.Drawing.Size(157, 48);
            this.lblDelegatedOperateur.TabIndex = 9;
            this.lblDelegatedOperateur.Text = "EtatActuel";
            this.lblDelegatedOperateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcHistoryTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDelegatedOperateur);
            this.Controls.Add(this.lblUpdateState);
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblLevelIndicator);
            this.Name = "UcHistoryTicket";
            this.Size = new System.Drawing.Size(539, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLevelIndicator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.Label lblUpdateState;
        private System.Windows.Forms.Label lblDelegatedOperateur;
    }
}
