namespace TP_INDUSDEV.UserControls
{
    partial class UcUpdateTicket
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
            this.ptbxQuit = new System.Windows.Forms.PictureBox();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblLevelTicket = new System.Windows.Forms.Label();
            this.cbbxLevelTicket = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnUpdateTicket = new ZiTest.CustomButton();
            this.lblSelectedOperator = new System.Windows.Forms.Label();
            this.cbbxSelectedOperator = new System.Windows.Forms.ComboBox();
            this.lblTicketInterventionDescription = new System.Windows.Forms.Label();
            this.rtbxTicketInterventionDescription = new System.Windows.Forms.RichTextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnCloseTicket = new ZiTest.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQuit)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbxQuit
            // 
            this.ptbxQuit.BackColor = System.Drawing.Color.Firebrick;
            this.ptbxQuit.Image = global::TP_INDUSDEV.Properties.Resources.quitIcon;
            this.ptbxQuit.Location = new System.Drawing.Point(580, 4);
            this.ptbxQuit.Margin = new System.Windows.Forms.Padding(4);
            this.ptbxQuit.Name = "ptbxQuit";
            this.ptbxQuit.Size = new System.Drawing.Size(48, 37);
            this.ptbxQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxQuit.TabIndex = 22;
            this.ptbxQuit.TabStop = false;
            // 
            // lblDesign
            // 
            this.lblDesign.BackColor = System.Drawing.Color.Firebrick;
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.White;
            this.lblDesign.Location = new System.Drawing.Point(0, 49);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(7, 544);
            this.lblDesign.TabIndex = 21;
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevelTicket
            // 
            this.lblLevelTicket.Location = new System.Drawing.Point(209, 307);
            this.lblLevelTicket.Name = "lblLevelTicket";
            this.lblLevelTicket.Size = new System.Drawing.Size(121, 25);
            this.lblLevelTicket.TabIndex = 5;
            this.lblLevelTicket.Text = "Niveau";
            this.lblLevelTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbxLevelTicket
            // 
            this.cbbxLevelTicket.FormattingEnabled = true;
            this.cbbxLevelTicket.Location = new System.Drawing.Point(212, 334);
            this.cbbxLevelTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxLevelTicket.Name = "cbbxLevelTicket";
            this.cbbxLevelTicket.Size = new System.Drawing.Size(121, 24);
            this.cbbxLevelTicket.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(671, 49);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Modification d\'un ticket";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdateTicket
            // 
            this.btnUpdateTicket.BorderColor = System.Drawing.Color.Firebrick;
            this.btnUpdateTicket.ButtonColor = System.Drawing.Color.Firebrick;
            this.btnUpdateTicket.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnUpdateTicket.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateTicket.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTicket.Location = new System.Drawing.Point(212, 401);
            this.btnUpdateTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateTicket.Name = "btnUpdateTicket";
            this.btnUpdateTicket.OnHoverBorderColor = System.Drawing.Color.DarkRed;
            this.btnUpdateTicket.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnUpdateTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateTicket.Size = new System.Drawing.Size(212, 57);
            this.btnUpdateTicket.TabIndex = 7;
            this.btnUpdateTicket.Text = "Valider modifications";
            this.btnUpdateTicket.TextColor = System.Drawing.Color.White;
            this.btnUpdateTicket.UseVisualStyleBackColor = true;
            this.btnUpdateTicket.Click += new System.EventHandler(this.BtnUpdateTicket_Click);
            // 
            // lblSelectedOperator
            // 
            this.lblSelectedOperator.Location = new System.Drawing.Point(209, 226);
            this.lblSelectedOperator.Name = "lblSelectedOperator";
            this.lblSelectedOperator.Size = new System.Drawing.Size(121, 25);
            this.lblSelectedOperator.TabIndex = 3;
            this.lblSelectedOperator.Text = "Technicien";
            this.lblSelectedOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbxSelectedOperator
            // 
            this.cbbxSelectedOperator.FormattingEnabled = true;
            this.cbbxSelectedOperator.Location = new System.Drawing.Point(212, 253);
            this.cbbxSelectedOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxSelectedOperator.Name = "cbbxSelectedOperator";
            this.cbbxSelectedOperator.Size = new System.Drawing.Size(121, 24);
            this.cbbxSelectedOperator.TabIndex = 4;
            // 
            // lblTicketInterventionDescription
            // 
            this.lblTicketInterventionDescription.Location = new System.Drawing.Point(208, 78);
            this.lblTicketInterventionDescription.Name = "lblTicketInterventionDescription";
            this.lblTicketInterventionDescription.Size = new System.Drawing.Size(159, 25);
            this.lblTicketInterventionDescription.TabIndex = 1;
            this.lblTicketInterventionDescription.Text = "Description intervention";
            this.lblTicketInterventionDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbxTicketInterventionDescription
            // 
            this.rtbxTicketInterventionDescription.Location = new System.Drawing.Point(212, 105);
            this.rtbxTicketInterventionDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbxTicketInterventionDescription.Name = "rtbxTicketInterventionDescription";
            this.rtbxTicketInterventionDescription.Size = new System.Drawing.Size(221, 96);
            this.rtbxTicketInterventionDescription.TabIndex = 2;
            this.rtbxTicketInterventionDescription.Text = "";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(208, 78);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(0, 17);
            this.lblStartDate.TabIndex = 12;
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCloseTicket.ButtonColor = System.Drawing.Color.Firebrick;
            this.btnCloseTicket.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCloseTicket.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnCloseTicket.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnCloseTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTicket.Location = new System.Drawing.Point(228, 486);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.OnHoverBorderColor = System.Drawing.Color.DarkRed;
            this.btnCloseTicket.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnCloseTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCloseTicket.Size = new System.Drawing.Size(179, 57);
            this.btnCloseTicket.TabIndex = 8;
            this.btnCloseTicket.Text = "Fermer le ticket";
            this.btnCloseTicket.TextColor = System.Drawing.Color.White;
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.BtnCloseTicket_Click);
            // 
            // UcUpdateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCloseTicket);
            this.Controls.Add(this.ptbxQuit);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblLevelTicket);
            this.Controls.Add(this.cbbxLevelTicket);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpdateTicket);
            this.Controls.Add(this.lblSelectedOperator);
            this.Controls.Add(this.cbbxSelectedOperator);
            this.Controls.Add(this.lblTicketInterventionDescription);
            this.Controls.Add(this.rtbxTicketInterventionDescription);
            this.Controls.Add(this.lblStartDate);
            this.Name = "UcUpdateTicket";
            this.Size = new System.Drawing.Size(671, 593);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxQuit;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.Label lblLevelTicket;
        private System.Windows.Forms.ComboBox cbbxLevelTicket;
        private System.Windows.Forms.Label lblTitle;
        private ZiTest.CustomButton btnUpdateTicket;
        private System.Windows.Forms.Label lblSelectedOperator;
        private System.Windows.Forms.ComboBox cbbxSelectedOperator;
        private System.Windows.Forms.Label lblTicketInterventionDescription;
        private System.Windows.Forms.RichTextBox rtbxTicketInterventionDescription;
        private System.Windows.Forms.Label lblStartDate;
        private ZiTest.CustomButton btnCloseTicket;
    }
}
