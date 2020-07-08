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
            this.btnDisconnect = new ZiTest.CustomButton();
            this.pnlAddTicket = new System.Windows.Forms.Panel();
            this.btnOperators = new ZiTest.CustomButton();
            this.btnTickets = new ZiTest.CustomButton();
            this.ptb = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // flpnlMainContent
            // 
            this.flpnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpnlMainContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.flpnlMainContent.Name = "flpnlMainContent";
            this.flpnlMainContent.Size = new System.Drawing.Size(644, 557);
            this.flpnlMainContent.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.ptb);
            this.pnlMenu.Controls.Add(this.btnTickets);
            this.pnlMenu.Controls.Add(this.btnOperators);
            this.pnlMenu.Controls.Add(this.btnDisconnect);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMenu.Location = new System.Drawing.Point(0, 557);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1134, 52);
            this.pnlMenu.TabIndex = 1;
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
            // 
            // pnlAddTicket
            // 
            this.pnlAddTicket.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAddTicket.Location = new System.Drawing.Point(644, 0);
            this.pnlAddTicket.Name = "pnlAddTicket";
            this.pnlAddTicket.Size = new System.Drawing.Size(490, 557);
            this.pnlAddTicket.TabIndex = 2;
            this.pnlAddTicket.Visible = false;
            // 
            // btnOperators
            // 
            this.btnOperators.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOperators.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnOperators.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOperators.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnOperators.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnOperators.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnOperators.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperators.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperators.ForeColor = System.Drawing.Color.Black;
            this.btnOperators.Location = new System.Drawing.Point(0, 0);
            this.btnOperators.Name = "btnOperators";
            this.btnOperators.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnOperators.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.btnOperators.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.btnOperators.Size = new System.Drawing.Size(191, 52);
            this.btnOperators.TabIndex = 10;
            this.btnOperators.Text = "Opérateurs";
            this.btnOperators.TextColor = System.Drawing.Color.Black;
            this.btnOperators.UseVisualStyleBackColor = true;
            // 
            // btnTickets
            // 
            this.btnTickets.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTickets.ButtonColor = System.Drawing.SystemColors.Control;
            this.btnTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTickets.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnTickets.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnTickets.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTickets.ForeColor = System.Drawing.Color.Black;
            this.btnTickets.Location = new System.Drawing.Point(191, 0);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.OnHoverBorderColor = System.Drawing.SystemColors.Control;
            this.btnTickets.OnHoverButtonColor = System.Drawing.SystemColors.Control;
            this.btnTickets.OnHoverTextColor = System.Drawing.Color.Firebrick;
            this.btnTickets.Size = new System.Drawing.Size(191, 52);
            this.btnTickets.TabIndex = 11;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.TextColor = System.Drawing.Color.Black;
            this.btnTickets.UseVisualStyleBackColor = true;
            // 
            // ptb
            // 
            this.ptb.Image = global::TP_INDUSDEV.Properties.Resources.plus;
            this.ptb.Location = new System.Drawing.Point(579, 6);
            this.ptb.Name = "ptb";
            this.ptb.Size = new System.Drawing.Size(45, 43);
            this.ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb.TabIndex = 12;
            this.ptb.TabStop = false;
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
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnlMainContent;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlAddTicket;
        private ZiTest.CustomButton btnDisconnect;
        private ZiTest.CustomButton btnTickets;
        private ZiTest.CustomButton btnOperators;
        private System.Windows.Forms.PictureBox ptb;
    }
}