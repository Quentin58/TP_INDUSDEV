namespace TP_INDUSDEV.UserControls
{
    partial class FrmMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpnlMainContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ptbAddTicketOrOperator = new System.Windows.Forms.PictureBox();
            this.ptbUpdateOperatorRights = new System.Windows.Forms.PictureBox();
            this.btnTicketsOrOperateur = new ZiTest.CustomButton();
            this.btnDisconnect = new ZiTest.CustomButton();
            this.pnlAddTicket = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddTicketOrOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUpdateOperatorRights)).BeginInit();
            this.SuspendLayout();
            // 
            // flpnlMainContent
            // 
            this.flpnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlMainContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.flpnlMainContent.Name = "flpnlMainContent";
            this.flpnlMainContent.Size = new System.Drawing.Size(693, 557);
            this.flpnlMainContent.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.ptbAddTicketOrOperator);
            this.pnlMenu.Controls.Add(this.ptbUpdateOperatorRights);
            this.pnlMenu.Controls.Add(this.btnTicketsOrOperateur);
            this.pnlMenu.Controls.Add(this.btnDisconnect);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenu.Location = new System.Drawing.Point(0, 557);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1134, 52);
            this.pnlMenu.TabIndex = 1;
            // 
            // ptbAddTicketOrOperator
            // 
            this.ptbAddTicketOrOperator.Image = global::TP_INDUSDEV.Properties.Resources.plus;
            this.ptbAddTicketOrOperator.Location = new System.Drawing.Point(630, 6);
            this.ptbAddTicketOrOperator.Name = "ptbAddTicketOrOperator";
            this.ptbAddTicketOrOperator.Size = new System.Drawing.Size(45, 43);
            this.ptbAddTicketOrOperator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAddTicketOrOperator.TabIndex = 14;
            this.ptbAddTicketOrOperator.TabStop = false;
            // 
            // ptbUpdateOperatorRights
            // 
            this.ptbUpdateOperatorRights.Image = global::TP_INDUSDEV.Properties.Resources.Padlock_symbol;
            this.ptbUpdateOperatorRights.Location = new System.Drawing.Point(528, 6);
            this.ptbUpdateOperatorRights.Name = "ptbUpdateOperatorRights";
            this.ptbUpdateOperatorRights.Size = new System.Drawing.Size(45, 43);
            this.ptbUpdateOperatorRights.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUpdateOperatorRights.TabIndex = 13;
            this.ptbUpdateOperatorRights.TabStop = false;
            this.ptbUpdateOperatorRights.Visible = false;
            // 
            // btnTicketsOrOperateur
            // 
            this.btnTicketsOrOperateur.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTicketsOrOperateur.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnTicketsOrOperateur.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTicketsOrOperateur.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTicketsOrOperateur.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnTicketsOrOperateur.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnTicketsOrOperateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicketsOrOperateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicketsOrOperateur.ForeColor = System.Drawing.Color.Black;
            this.btnTicketsOrOperateur.Location = new System.Drawing.Point(0, 0);
            this.btnTicketsOrOperateur.Name = "btnTicketsOrOperateur";
            this.btnTicketsOrOperateur.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnTicketsOrOperateur.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.btnTicketsOrOperateur.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.btnTicketsOrOperateur.Size = new System.Drawing.Size(191, 52);
            this.btnTicketsOrOperateur.TabIndex = 11;
            this.btnTicketsOrOperateur.Text = "Tickets";
            this.btnTicketsOrOperateur.TextColor = System.Drawing.Color.Black;
            this.btnTicketsOrOperateur.UseVisualStyleBackColor = true;
            this.btnTicketsOrOperateur.Visible = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDisconnect.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnDisconnect.Location = new System.Drawing.Point(885, 0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.btnDisconnect.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.btnDisconnect.Size = new System.Drawing.Size(249, 52);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Se déconnecter";
            this.btnDisconnect.TextColor = System.Drawing.Color.Black;
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // pnlAddTicket
            // 
            this.pnlAddTicket.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAddTicket.Location = new System.Drawing.Point(693, 0);
            this.pnlAddTicket.Name = "pnlAddTicket";
            this.pnlAddTicket.Size = new System.Drawing.Size(441, 557);
            this.pnlAddTicket.TabIndex = 2;
            this.pnlAddTicket.Visible = false;
            // 
            // FrmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 609);
            this.Controls.Add(this.flpnlMainContent);
            this.Controls.Add(this.pnlAddTicket);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmMainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page principale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainView_FormClosing);
            this.Resize += new System.EventHandler(this.FrmMainView_Resize);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddTicketOrOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUpdateOperatorRights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnlMainContent;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAddTicket;
        private ZiTest.CustomButton btnDisconnect;
        private ZiTest.CustomButton btnTicketsOrOperateur;
        private System.Windows.Forms.PictureBox ptbUpdateOperatorRights;
        private System.Windows.Forms.PictureBox ptbAddTicketOrOperator;
    }
}