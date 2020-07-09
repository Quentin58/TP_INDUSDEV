namespace TP_INDUSDEV.UserControls
{
    partial class UcDisplayTicket
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
            this.pnlInformations = new System.Windows.Forms.Panel();
            this.ptbxEdit = new System.Windows.Forms.PictureBox();
            this.ptbxDelete = new System.Windows.Forms.PictureBox();
            this.ptbxShowMore = new System.Windows.Forms.PictureBox();
            this.lblActualState = new System.Windows.Forms.Label();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblTicketNumer = new System.Windows.Forms.Label();
            this.lblLevelIndicator = new System.Windows.Forms.Label();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.pnlFieldHistory = new System.Windows.Forms.Panel();
            this.pnlDesign = new System.Windows.Forms.Panel();
            this.lblIndicatorTicketOwner = new System.Windows.Forms.Label();
            this.lblTitleDelegatedOperateur = new System.Windows.Forms.Label();
            this.lblTitleUpdateState = new System.Windows.Forms.Label();
            this.lblTitleUpdateDate = new System.Windows.Forms.Label();
            this.lblTitleOperator = new System.Windows.Forms.Label();
            this.lblTitleLevel = new System.Windows.Forms.Label();
            this.pnlInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxShowMore)).BeginInit();
            this.pnlHistory.SuspendLayout();
            this.pnlFieldHistory.SuspendLayout();
            this.pnlDesign.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformations
            // 
            this.pnlInformations.Controls.Add(this.ptbxEdit);
            this.pnlInformations.Controls.Add(this.ptbxDelete);
            this.pnlInformations.Controls.Add(this.ptbxShowMore);
            this.pnlInformations.Controls.Add(this.lblActualState);
            this.pnlInformations.Controls.Add(this.lblUpdateDate);
            this.pnlInformations.Controls.Add(this.lblCreateDate);
            this.pnlInformations.Controls.Add(this.lblTicketNumer);
            this.pnlInformations.Controls.Add(this.lblLevelIndicator);
            this.pnlInformations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInformations.Location = new System.Drawing.Point(0, 0);
            this.pnlInformations.Name = "pnlInformations";
            this.pnlInformations.Size = new System.Drawing.Size(913, 48);
            this.pnlInformations.TabIndex = 0;
            // 
            // ptbxEdit
            // 
            this.ptbxEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbxEdit.Image = global::TP_INDUSDEV.Properties.Resources.editIcon;
            this.ptbxEdit.Location = new System.Drawing.Point(748, 0);
            this.ptbxEdit.Name = "ptbxEdit";
            this.ptbxEdit.Size = new System.Drawing.Size(55, 48);
            this.ptbxEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxEdit.TabIndex = 7;
            this.ptbxEdit.TabStop = false;
            // 
            // ptbxDelete
            // 
            this.ptbxDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbxDelete.Image = global::TP_INDUSDEV.Properties.Resources.deleteIcon;
            this.ptbxDelete.Location = new System.Drawing.Point(803, 0);
            this.ptbxDelete.Name = "ptbxDelete";
            this.ptbxDelete.Size = new System.Drawing.Size(55, 48);
            this.ptbxDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxDelete.TabIndex = 6;
            this.ptbxDelete.TabStop = false;
            // 
            // ptbxShowMore
            // 
            this.ptbxShowMore.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbxShowMore.Image = global::TP_INDUSDEV.Properties.Resources.ShowMoreLess;
            this.ptbxShowMore.Location = new System.Drawing.Point(858, 0);
            this.ptbxShowMore.Name = "ptbxShowMore";
            this.ptbxShowMore.Size = new System.Drawing.Size(55, 48);
            this.ptbxShowMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxShowMore.TabIndex = 5;
            this.ptbxShowMore.TabStop = false;
            this.ptbxShowMore.Click += new System.EventHandler(this.ptbxShowMore_Click);
            // 
            // lblActualState
            // 
            this.lblActualState.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblActualState.Location = new System.Drawing.Point(334, 0);
            this.lblActualState.Name = "lblActualState";
            this.lblActualState.Size = new System.Drawing.Size(349, 48);
            this.lblActualState.TabIndex = 3;
            this.lblActualState.Text = "EtatActuel";
            this.lblActualState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUpdateDate.Location = new System.Drawing.Point(211, 0);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(123, 48);
            this.lblUpdateDate.TabIndex = 2;
            this.lblUpdateDate.Text = "DateDernièreModification";
            this.lblUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCreateDate.Location = new System.Drawing.Point(101, 0);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(110, 48);
            this.lblCreateDate.TabIndex = 1;
            this.lblCreateDate.Text = "DateCréation";
            this.lblCreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicketNumer
            // 
            this.lblTicketNumer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTicketNumer.Location = new System.Drawing.Point(44, 0);
            this.lblTicketNumer.Name = "lblTicketNumer";
            this.lblTicketNumer.Size = new System.Drawing.Size(57, 48);
            this.lblTicketNumer.TabIndex = 0;
            this.lblTicketNumer.Text = "TicketNumber";
            this.lblTicketNumer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevelIndicator
            // 
            this.lblLevelIndicator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLevelIndicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLevelIndicator.Location = new System.Drawing.Point(0, 0);
            this.lblLevelIndicator.Name = "lblLevelIndicator";
            this.lblLevelIndicator.Size = new System.Drawing.Size(44, 48);
            this.lblLevelIndicator.TabIndex = 4;
            this.lblLevelIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlHistory.Controls.Add(this.pnlFieldHistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHistory.Location = new System.Drawing.Point(398, 48);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(515, 161);
            this.pnlHistory.TabIndex = 1;
            // 
            // pnlFieldHistory
            // 
            this.pnlFieldHistory.BackColor = System.Drawing.Color.Firebrick;
            this.pnlFieldHistory.Controls.Add(this.lblTitleDelegatedOperateur);
            this.pnlFieldHistory.Controls.Add(this.lblTitleUpdateState);
            this.pnlFieldHistory.Controls.Add(this.lblTitleUpdateDate);
            this.pnlFieldHistory.Controls.Add(this.lblTitleOperator);
            this.pnlFieldHistory.Controls.Add(this.lblTitleLevel);
            this.pnlFieldHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFieldHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlFieldHistory.Name = "pnlFieldHistory";
            this.pnlFieldHistory.Size = new System.Drawing.Size(515, 27);
            this.pnlFieldHistory.TabIndex = 17;
            // 
            // pnlDesign
            // 
            this.pnlDesign.BackColor = System.Drawing.Color.Firebrick;
            this.pnlDesign.Controls.Add(this.lblIndicatorTicketOwner);
            this.pnlDesign.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDesign.Location = new System.Drawing.Point(0, 209);
            this.pnlDesign.Name = "pnlDesign";
            this.pnlDesign.Size = new System.Drawing.Size(913, 5);
            this.pnlDesign.TabIndex = 2;
            // 
            // lblIndicatorTicketOwner
            // 
            this.lblIndicatorTicketOwner.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblIndicatorTicketOwner.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIndicatorTicketOwner.Location = new System.Drawing.Point(0, 0);
            this.lblIndicatorTicketOwner.Name = "lblIndicatorTicketOwner";
            this.lblIndicatorTicketOwner.Size = new System.Drawing.Size(44, 5);
            this.lblIndicatorTicketOwner.TabIndex = 5;
            this.lblIndicatorTicketOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleDelegatedOperateur
            // 
            this.lblTitleDelegatedOperateur.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleDelegatedOperateur.ForeColor = System.Drawing.Color.White;
            this.lblTitleDelegatedOperateur.Location = new System.Drawing.Point(356, 0);
            this.lblTitleDelegatedOperateur.Name = "lblTitleDelegatedOperateur";
            this.lblTitleDelegatedOperateur.Size = new System.Drawing.Size(154, 27);
            this.lblTitleDelegatedOperateur.TabIndex = 14;
            this.lblTitleDelegatedOperateur.Text = "Opérateur aassigné";
            this.lblTitleDelegatedOperateur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleUpdateState
            // 
            this.lblTitleUpdateState.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleUpdateState.ForeColor = System.Drawing.Color.White;
            this.lblTitleUpdateState.Location = new System.Drawing.Point(202, 0);
            this.lblTitleUpdateState.Name = "lblTitleUpdateState";
            this.lblTitleUpdateState.Size = new System.Drawing.Size(154, 27);
            this.lblTitleUpdateState.TabIndex = 13;
            this.lblTitleUpdateState.Text = "Etat";
            this.lblTitleUpdateState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleUpdateDate
            // 
            this.lblTitleUpdateDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleUpdateDate.ForeColor = System.Drawing.Color.White;
            this.lblTitleUpdateDate.Location = new System.Drawing.Point(95, 0);
            this.lblTitleUpdateDate.Name = "lblTitleUpdateDate";
            this.lblTitleUpdateDate.Size = new System.Drawing.Size(107, 27);
            this.lblTitleUpdateDate.TabIndex = 12;
            this.lblTitleUpdateDate.Text = "Date";
            this.lblTitleUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleOperator
            // 
            this.lblTitleOperator.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleOperator.ForeColor = System.Drawing.Color.White;
            this.lblTitleOperator.Location = new System.Drawing.Point(41, 0);
            this.lblTitleOperator.Name = "lblTitleOperator";
            this.lblTitleOperator.Size = new System.Drawing.Size(54, 27);
            this.lblTitleOperator.TabIndex = 11;
            this.lblTitleOperator.Text = "Opérateur";
            this.lblTitleOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleLevel
            // 
            this.lblTitleLevel.BackColor = System.Drawing.Color.Firebrick;
            this.lblTitleLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitleLevel.ForeColor = System.Drawing.Color.White;
            this.lblTitleLevel.Location = new System.Drawing.Point(0, 0);
            this.lblTitleLevel.Name = "lblTitleLevel";
            this.lblTitleLevel.Size = new System.Drawing.Size(41, 27);
            this.lblTitleLevel.TabIndex = 10;
            this.lblTitleLevel.Text = "Niveau";
            this.lblTitleLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcDisplayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlInformations);
            this.Controls.Add(this.pnlDesign);
            this.DoubleBuffered = true;
            this.Name = "UcDisplayTicket";
            this.Size = new System.Drawing.Size(913, 214);
            this.Resize += new System.EventHandler(this.UcDisplayTicket_Resize);
            this.pnlInformations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxShowMore)).EndInit();
            this.pnlHistory.ResumeLayout(false);
            this.pnlFieldHistory.ResumeLayout(false);
            this.pnlDesign.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformations;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Label lblLevelIndicator;
        private System.Windows.Forms.Label lblActualState;
        private System.Windows.Forms.Label lblUpdateDate;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label lblTicketNumer;
        private System.Windows.Forms.PictureBox ptbxShowMore;
        private System.Windows.Forms.PictureBox ptbxEdit;
        private System.Windows.Forms.PictureBox ptbxDelete;
        private System.Windows.Forms.Panel pnlDesign;
        private System.Windows.Forms.Label lblIndicatorTicketOwner;
        private System.Windows.Forms.Panel pnlFieldHistory;
        private System.Windows.Forms.Label lblTitleDelegatedOperateur;
        private System.Windows.Forms.Label lblTitleUpdateState;
        private System.Windows.Forms.Label lblTitleUpdateDate;
        private System.Windows.Forms.Label lblTitleOperator;
        private System.Windows.Forms.Label lblTitleLevel;
    }
}
