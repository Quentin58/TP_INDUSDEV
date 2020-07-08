namespace TP_INDUSDEV.UserControls
{
    partial class UcAddTicket
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
            this.lblStartDate = new System.Windows.Forms.Label();
            this.rtbxTicketDetails = new System.Windows.Forms.RichTextBox();
            this.rtbxTicketInterventionDescription = new System.Windows.Forms.RichTextBox();
            this.lblTicketDetails = new System.Windows.Forms.Label();
            this.lblTicketInterventionDescription = new System.Windows.Forms.Label();
            this.cbbxSelectedOperator = new System.Windows.Forms.ComboBox();
            this.lblSelectedOperator = new System.Windows.Forms.Label();
            this.btnAddTicket = new ZiTest.CustomButton();
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(208, 78);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 17);
            this.lblStartDate.TabIndex = 0;
            // 
            // rtbxTicketDetails
            // 
            this.rtbxTicketDetails.Location = new System.Drawing.Point(201, 66);
            this.rtbxTicketDetails.Name = "rtbxTicketDetails";
            this.rtbxTicketDetails.Size = new System.Drawing.Size(221, 96);
            this.rtbxTicketDetails.TabIndex = 2;
            this.rtbxTicketDetails.Text = "";
            // 
            // rtbxTicketInterventionDescription
            // 
            this.rtbxTicketInterventionDescription.Location = new System.Drawing.Point(201, 206);
            this.rtbxTicketInterventionDescription.Name = "rtbxTicketInterventionDescription";
            this.rtbxTicketInterventionDescription.Size = new System.Drawing.Size(221, 96);
            this.rtbxTicketInterventionDescription.TabIndex = 4;
            this.rtbxTicketInterventionDescription.Text = "";
            // 
            // lblTicketDetails
            // 
            this.lblTicketDetails.AutoSize = true;
            this.lblTicketDetails.Location = new System.Drawing.Point(201, 46);
            this.lblTicketDetails.Name = "lblTicketDetails";
            this.lblTicketDetails.Size = new System.Drawing.Size(51, 17);
            this.lblTicketDetails.TabIndex = 1;
            this.lblTicketDetails.Text = "Détails";
            // 
            // lblTicketInterventionDescription
            // 
            this.lblTicketInterventionDescription.AutoSize = true;
            this.lblTicketInterventionDescription.Location = new System.Drawing.Point(198, 186);
            this.lblTicketInterventionDescription.Name = "lblTicketInterventionDescription";
            this.lblTicketInterventionDescription.Size = new System.Drawing.Size(183, 17);
            this.lblTicketInterventionDescription.TabIndex = 3;
            this.lblTicketInterventionDescription.Text = "Description de l\'intervention";
            // 
            // cbbxSelectedOperator
            // 
            this.cbbxSelectedOperator.FormattingEnabled = true;
            this.cbbxSelectedOperator.Location = new System.Drawing.Point(201, 345);
            this.cbbxSelectedOperator.Name = "cbbxSelectedOperator";
            this.cbbxSelectedOperator.Size = new System.Drawing.Size(121, 24);
            this.cbbxSelectedOperator.TabIndex = 6;
            // 
            // lblSelectedOperator
            // 
            this.lblSelectedOperator.AutoSize = true;
            this.lblSelectedOperator.Location = new System.Drawing.Point(198, 325);
            this.lblSelectedOperator.Name = "lblSelectedOperator";
            this.lblSelectedOperator.Size = new System.Drawing.Size(77, 17);
            this.lblSelectedOperator.TabIndex = 5;
            this.lblSelectedOperator.Text = "Technicien";
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTicket.ButtonColor = System.Drawing.Color.Red;
            this.btnAddTicket.Location = new System.Drawing.Point(201, 406);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.btnAddTicket.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.btnAddTicket.OnHoverTextColor = System.Drawing.Color.Gray;
            this.btnAddTicket.Size = new System.Drawing.Size(125, 56);
            this.btnAddTicket.TabIndex = 7;
            this.btnAddTicket.Text = "Créer ticket";
            this.btnAddTicket.TextColor = System.Drawing.Color.White;
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.btnAddTicket_Click);
            // 
            // UcAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.lblSelectedOperator);
            this.Controls.Add(this.cbbxSelectedOperator);
            this.Controls.Add(this.lblTicketInterventionDescription);
            this.Controls.Add(this.lblTicketDetails);
            this.Controls.Add(this.rtbxTicketInterventionDescription);
            this.Controls.Add(this.rtbxTicketDetails);
            this.Controls.Add(this.lblStartDate);
            this.Name = "UcAddTicket";
            this.Size = new System.Drawing.Size(704, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.RichTextBox rtbxTicketDetails;
        private System.Windows.Forms.RichTextBox rtbxTicketInterventionDescription;
        private System.Windows.Forms.Label lblTicketDetails;
        private System.Windows.Forms.Label lblTicketInterventionDescription;
        private System.Windows.Forms.ComboBox cbbxSelectedOperator;
        private System.Windows.Forms.Label lblSelectedOperator;
        private ZiTest.CustomButton btnAddTicket;
    }
}
