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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ptbAddTicketOrOperator = new System.Windows.Forms.PictureBox();
            this.ptbUpdateOperatorRights = new System.Windows.Forms.PictureBox();
            this.btnTicketsOrOperateur = new ZiTest.CustomButton();
            this.btnDisconnect = new ZiTest.CustomButton();
            this.pnlManagement = new System.Windows.Forms.Panel();
            this.pnlDesing = new System.Windows.Forms.Panel();
            this.pnlFieldTicket = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddTicketOrOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUpdateOperatorRights)).BeginInit();
            this.SuspendLayout();
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
            this.ptbAddTicketOrOperator.Click += new System.EventHandler(this.ptbAddTicket_Click);
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
            this.ptbUpdateOperatorRights.Click += new System.EventHandler(this.ptbUpdateOperatorRights_Click);
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
            this.btnTicketsOrOperateur.Text = "Opérateurs";
            this.btnTicketsOrOperateur.TextColor = System.Drawing.Color.Black;
            this.btnTicketsOrOperateur.UseVisualStyleBackColor = true;
            this.btnTicketsOrOperateur.Visible = false;
            this.btnTicketsOrOperateur.Click += new System.EventHandler(this.btnTicketsOrOperateur_Click);
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
            // pnlManagement
            // 
            this.pnlManagement.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlManagement.Location = new System.Drawing.Point(693, 0);
            this.pnlManagement.Name = "pnlManagement";
            this.pnlManagement.Size = new System.Drawing.Size(441, 552);
            this.pnlManagement.TabIndex = 2;
            this.pnlManagement.Visible = false;
            // 
            // pnlDesing
            // 
            this.pnlDesing.BackColor = System.Drawing.Color.Firebrick;
            this.pnlDesing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesing.Location = new System.Drawing.Point(0, 552);
            this.pnlDesing.Name = "pnlDesing";
            this.pnlDesing.Size = new System.Drawing.Size(1134, 5);
            this.pnlDesing.TabIndex = 15;
            // 
            // pnlFieldTicket
            // 
            this.pnlFieldTicket.BackColor = System.Drawing.Color.Firebrick;
            this.pnlFieldTicket.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldTicket.Location = new System.Drawing.Point(0, 0);
            this.pnlFieldTicket.Name = "pnlFieldTicket";
            this.pnlFieldTicket.Size = new System.Drawing.Size(693, 42);
            this.pnlFieldTicket.TabIndex = 16;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 42);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(693, 510);
            this.pnlMainContent.TabIndex = 17;
            // 
            // FrmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 609);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlFieldTicket);
            this.Controls.Add(this.pnlManagement);
            this.Controls.Add(this.pnlDesing);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlManagement;
        private ZiTest.CustomButton btnDisconnect;
        private ZiTest.CustomButton btnTicketsOrOperateur;
        private System.Windows.Forms.PictureBox ptbUpdateOperatorRights;
        private System.Windows.Forms.PictureBox ptbAddTicketOrOperator;
        private System.Windows.Forms.Panel pnlDesing;
        private System.Windows.Forms.Panel pnlFieldTicket;
        private System.Windows.Forms.Panel pnlMainContent;
    }
}