namespace VTDI_CSS
{
    partial class frmLiveChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiveChat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.jImageButton1 = new JImageButton.JImageButton();
            this.jMetroTextBox1 = new JMetroTextBox.JMetroTextBox();
            this.pnlRecent = new System.Windows.Forms.Panel();
            this.pnlRecentMessages = new System.Windows.Forms.Panel();
            this.lblRecentTextMessageInfo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRecent = new System.Windows.Forms.Label();
            this.jmtxtSearch = new JMaterialTextbox.JMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlRecent.SuspendLayout();
            this.pnlRecentMessages.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.jImageButton1);
            this.panel1.Controls.Add(this.jMetroTextBox1);
            this.panel1.Controls.Add(this.pnlRecent);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 465);
            this.panel1.TabIndex = 0;
            // 
            // jImageButton1
            // 
            this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton1.BackColor = System.Drawing.Color.DarkGray;
            this.jImageButton1.CausesValidation = false;
            this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
            this.jImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton1.Image")));
            this.jImageButton1.ImageHover = null;
            this.jImageButton1.InitialImage = null;
            this.jImageButton1.Location = new System.Drawing.Point(825, 430);
            this.jImageButton1.Name = "jImageButton1";
            this.jImageButton1.Size = new System.Drawing.Size(43, 32);
            this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton1.TabIndex = 2;
            this.jImageButton1.Zoom = 4;
            // 
            // jMetroTextBox1
            // 
            this.jMetroTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.jMetroTextBox1.BorderColor = System.Drawing.Color.White;
            this.jMetroTextBox1.BorderRadius = 9;
            this.jMetroTextBox1.FillColor = System.Drawing.Color.DarkGray;
            this.jMetroTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBox1.Font_Size = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jMetroTextBox1.ForeColors = System.Drawing.Color.White;
            this.jMetroTextBox1.IsPassword = false;
            this.jMetroTextBox1.LineThickness = 4;
            this.jMetroTextBox1.Location = new System.Drawing.Point(339, 423);
            this.jMetroTextBox1.MaxLength = 32767;
            this.jMetroTextBox1.MouseOnHover = System.Drawing.Color.Empty;
            this.jMetroTextBox1.Name = "jMetroTextBox1";
            this.jMetroTextBox1.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.jMetroTextBox1.OnFocusColor = System.Drawing.Color.Empty;
            this.jMetroTextBox1.OnFocusFontColor = System.Drawing.Color.Empty;
            this.jMetroTextBox1.ReadOnly = false;
            this.jMetroTextBox1.Size = new System.Drawing.Size(480, 39);
            this.jMetroTextBox1.TabIndex = 1;
            this.jMetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMetroTextBox1.TextName = "Type a message";
            // 
            // pnlRecent
            // 
            this.pnlRecent.BackColor = System.Drawing.Color.White;
            this.pnlRecent.Controls.Add(this.pnlRecentMessages);
            this.pnlRecent.Controls.Add(this.panel3);
            this.pnlRecent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlRecent.Location = new System.Drawing.Point(0, 3);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Size = new System.Drawing.Size(333, 462);
            this.pnlRecent.TabIndex = 0;
            // 
            // pnlRecentMessages
            // 
            this.pnlRecentMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecentMessages.Controls.Add(this.lblRecentTextMessageInfo);
            this.pnlRecentMessages.Controls.Add(this.lblUser);
            this.pnlRecentMessages.Location = new System.Drawing.Point(1, 40);
            this.pnlRecentMessages.Name = "pnlRecentMessages";
            this.pnlRecentMessages.Size = new System.Drawing.Size(332, 57);
            this.pnlRecentMessages.TabIndex = 1;
            // 
            // lblRecentTextMessageInfo
            // 
            this.lblRecentTextMessageInfo.AutoSize = true;
            this.lblRecentTextMessageInfo.Location = new System.Drawing.Point(10, 32);
            this.lblRecentTextMessageInfo.Name = "lblRecentTextMessageInfo";
            this.lblRecentTextMessageInfo.Size = new System.Drawing.Size(108, 13);
            this.lblRecentTextMessageInfo.TabIndex = 1;
            this.lblRecentTextMessageInfo.Text = "Hi, I am a little hungry";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(8, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 21);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblRecent);
            this.panel3.Controls.Add(this.jmtxtSearch);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 40);
            this.panel3.TabIndex = 0;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecent.ForeColor = System.Drawing.Color.White;
            this.lblRecent.Location = new System.Drawing.Point(6, 6);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(70, 25);
            this.lblRecent.TabIndex = 2;
            this.lblRecent.Text = "Recent";
            this.lblRecent.Click += new System.EventHandler(this.label1_Click);
            // 
            // jmtxtSearch
            // 
            this.jmtxtSearch.BackColor = System.Drawing.Color.Transparent;
            this.jmtxtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmtxtSearch.Font_Size = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmtxtSearch.ForeColors = System.Drawing.Color.White;
            this.jmtxtSearch.HintText = null;
            this.jmtxtSearch.IsPassword = false;
            this.jmtxtSearch.LineBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jmtxtSearch.LineThickness = 3;
            this.jmtxtSearch.Location = new System.Drawing.Point(172, 8);
            this.jmtxtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jmtxtSearch.MaxLength = 32767;
            this.jmtxtSearch.Name = "jmtxtSearch";
            this.jmtxtSearch.OnFocusedColor = System.Drawing.Color.White;
            this.jmtxtSearch.OnFocusedTextColor = System.Drawing.Color.White;
            this.jmtxtSearch.ReadOnly = false;
            this.jmtxtSearch.Size = new System.Drawing.Size(148, 23);
            this.jmtxtSearch.TabIndex = 1;
            this.jmtxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jmtxtSearch.TextName = "Search";
            this.jmtxtSearch.Load += new System.EventHandler(this.jMaterialTextbox1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VTDI_CSS.Properties.Resources.vtdi_logo75;
            this.pictureBox1.Location = new System.Drawing.Point(353, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(434, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chat Box";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(872, 79);
            this.panel4.TabIndex = 1;
            // 
            // frmLiveChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(872, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLiveChat";
            this.Text = "frmLiveChat";
            this.panel1.ResumeLayout(false);
            this.pnlRecent.ResumeLayout(false);
            this.pnlRecentMessages.ResumeLayout(false);
            this.pnlRecentMessages.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRecent;
        private System.Windows.Forms.Label lblRecent;
        private JMaterialTextbox.JMaterialTextbox jmtxtSearch;
        private System.Windows.Forms.Panel panel3;
        private JImageButton.JImageButton jImageButton1;
        private JMetroTextBox.JMetroTextBox jMetroTextBox1;
        private System.Windows.Forms.Panel pnlRecentMessages;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRecentTextMessageInfo;
        private System.Windows.Forms.Label lblUser;
    }
}