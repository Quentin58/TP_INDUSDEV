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
            this.lblTicketDetails = new System.Windows.Forms.Label();
            this.cbbxSelectedOperator = new System.Windows.Forms.ComboBox();
            this.lblSelectedOperator = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLevelTicket = new System.Windows.Forms.Label();
            this.cbbxLevelTicket = new System.Windows.Forms.ComboBox();
            this.btnAddTicket = new ZiTest.CustomButton();
            this.lblDesign = new System.Windows.Forms.Label();
            this.ptbQuit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuit)).BeginInit();
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
            this.rtbxTicketDetails.Location = new System.Drawing.Point(156, 107);
            this.rtbxTicketDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbxTicketDetails.Name = "rtbxTicketDetails";
            this.rtbxTicketDetails.Size = new System.Drawing.Size(221, 96);
            this.rtbxTicketDetails.TabIndex = 1;
            this.rtbxTicketDetails.Text = "";
            // 
            // lblTicketDetails
            // 
            this.lblTicketDetails.Location = new System.Drawing.Point(241, 78);
            this.lblTicketDetails.Name = "lblTicketDetails";
            this.lblTicketDetails.Size = new System.Drawing.Size(93, 25);
            this.lblTicketDetails.TabIndex = 1;
            this.lblTicketDetails.Text = "Détails";
            this.lblTicketDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbxSelectedOperator
            // 
            this.cbbxSelectedOperator.FormattingEnabled = true;
            this.cbbxSelectedOperator.Location = new System.Drawing.Point(205, 255);
            this.cbbxSelectedOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbxSelectedOperator.Name = "cbbxSelectedOperator";
            this.cbbxSelectedOperator.Size = new System.Drawing.Size(121, 24);
            this.cbbxSelectedOperator.TabIndex = 2;
            // 
            // lblSelectedOperator
            // 
            this.lblSelectedOperator.Location = new System.Drawing.Point(227, 226);
            this.lblSelectedOperator.Name = "lblSelectedOperator";
            this.lblSelectedOperator.Size = new System.Drawing.Size(121, 25);
            this.lblSelectedOperator.TabIndex = 5;
            this.lblSelectedOperator.Text = "Technicien";
            this.lblSelectedOperator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Firebrick;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(632, 49);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Ajout d\'un ticket";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevelTicket
            // 
            this.lblLevelTicket.Location = new System.Drawing.Point(208, 305);
            this.lblLevelTicket.Name = "lblLevelTicket";
            this.lblLevelTicket.Size = new System.Drawing.Size(121, 25);
            this.lblLevelTicket.TabIndex = 9;
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
            this.cbbxLevelTicket.TabIndex = 3;
            // 
            // btnAddTicket
            // 
            this.btnAddTicket.BorderColor = System.Drawing.Color.Firebrick;
            this.btnAddTicket.ButtonColor = System.Drawing.Color.Firebrick;
            this.btnAddTicket.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddTicket.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAddTicket.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTicket.Location = new System.Drawing.Point(212, 437);
            this.btnAddTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddTicket.Name = "btnAddTicket";
            this.btnAddTicket.OnHoverBorderColor = System.Drawing.Color.DarkRed;
            this.btnAddTicket.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.btnAddTicket.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddTicket.Size = new System.Drawing.Size(212, 57);
            this.btnAddTicket.TabIndex = 4;
            this.btnAddTicket.Text = "Créer ticket";
            this.btnAddTicket.TextColor = System.Drawing.Color.White;
            this.btnAddTicket.UseVisualStyleBackColor = true;
            this.btnAddTicket.Click += new System.EventHandler(this.BtnAddTicket_Click);
            // 
            // lblDesign
            // 
            this.lblDesign.BackColor = System.Drawing.Color.Firebrick;
            this.lblDesign.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.White;
            this.lblDesign.Location = new System.Drawing.Point(0, 49);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(7, 481);
            this.lblDesign.TabIndex = 10;
            this.lblDesign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbQuit
            // 
            this.ptbQuit.BackColor = System.Drawing.Color.Firebrick;
            this.ptbQuit.Image = global::TP_INDUSDEV.Properties.Resources.quitIcon;
            this.ptbQuit.Location = new System.Drawing.Point(580, 4);
            this.ptbQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptbQuit.Name = "ptbQuit";
            this.ptbQuit.Size = new System.Drawing.Size(48, 37);
            this.ptbQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbQuit.TabIndex = 11;
            this.ptbQuit.TabStop = false;
            this.ptbQuit.Click += new System.EventHandler(this.PtbQuit_Click);
            // 
            // UcAddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ptbQuit);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.lblLevelTicket);
            this.Controls.Add(this.cbbxLevelTicket);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAddTicket);
            this.Controls.Add(this.lblSelectedOperator);
            this.Controls.Add(this.cbbxSelectedOperator);
            this.Controls.Add(this.lblTicketDetails);
            this.Controls.Add(this.rtbxTicketDetails);
            this.Controls.Add(this.lblStartDate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcAddTicket";
            this.Size = new System.Drawing.Size(632, 530);
            this.Resize += new System.EventHandler(this.UcAddTicket_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ptbQuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.RichTextBox rtbxTicketDetails;
        private System.Windows.Forms.Label lblTicketDetails;
        private System.Windows.Forms.ComboBox cbbxSelectedOperator;
        private System.Windows.Forms.Label lblSelectedOperator;
        private ZiTest.CustomButton btnAddTicket;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLevelTicket;
        private System.Windows.Forms.ComboBox cbbxLevelTicket;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.PictureBox ptbQuit;
    }
}
