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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLiveChat));
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.jImageButton2 = new JImageButton.JImageButton();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRecent = new System.Windows.Forms.Label();
            this.jmtxtSearch = new JMaterialTextbox.JMaterialTextbox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.jImageButton1 = new JImageButton.JImageButton();
            this.flpChats = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(162, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Live Chat";
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.White;
            this.pnlTopNav.Controls.Add(this.pictureBox3);
            this.pnlTopNav.Controls.Add(this.lblUsername);
            this.pnlTopNav.Controls.Add(this.lblDateTime);
            this.pnlTopNav.Controls.Add(this.panel1);
            this.pnlTopNav.Controls.Add(this.pictureBox2);
            this.pnlTopNav.Controls.Add(this.jImageButton2);
            this.pnlTopNav.Controls.Add(this.btnMinimize);
            this.pnlTopNav.Controls.Add(this.label2);
            this.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopNav.Location = new System.Drawing.Point(0, 0);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1150, 63);
            this.pnlTopNav.TabIndex = 1;
            this.pnlTopNav.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopNav_MouseDown);
            this.pnlTopNav.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopNav_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VTDI_CSS.Properties.Resources.profile;
            this.pictureBox3.Location = new System.Drawing.Point(862, 31);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(898, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 21);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateTime.Location = new System.Drawing.Point(537, 33);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(123, 21);
            this.lblDateTime.TabIndex = 17;
            this.lblDateTime.Text = "Date And Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(455, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 2);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VTDI_CSS.Properties.Resources.clock;
            this.pictureBox2.Location = new System.Drawing.Point(501, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // jImageButton2
            // 
            this.jImageButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.jImageButton2.CausesValidation = false;
            this.jImageButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton2.ErrorImage")));
            this.jImageButton2.Image = global::VTDI_CSS.Properties.Resources._return;
            this.jImageButton2.ImageHover = null;
            this.jImageButton2.InitialImage = null;
            this.jImageButton2.Location = new System.Drawing.Point(12, 9);
            this.jImageButton2.Name = "jImageButton2";
            this.jImageButton2.Size = new System.Drawing.Size(40, 35);
            this.jImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jImageButton2.TabIndex = 8;
            this.jImageButton2.Zoom = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinimize.Location = new System.Drawing.Point(1120, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 35);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(30, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(582, 40);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Type a message...";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lblRecent);
            this.panel3.Controls.Add(this.jmtxtSearch);
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 64);
            this.panel3.TabIndex = 0;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecent.ForeColor = System.Drawing.Color.Black;
            this.lblRecent.Location = new System.Drawing.Point(12, 15);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(106, 37);
            this.lblRecent.TabIndex = 2;
            this.lblRecent.Text = "Recent";
            // 
            // jmtxtSearch
            // 
            this.jmtxtSearch.BackColor = System.Drawing.Color.Transparent;
            this.jmtxtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmtxtSearch.Font_Size = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jmtxtSearch.ForeColors = System.Drawing.Color.DimGray;
            this.jmtxtSearch.HintText = null;
            this.jmtxtSearch.IsPassword = false;
            this.jmtxtSearch.LineBackColor = System.Drawing.Color.DimGray;
            this.jmtxtSearch.LineThickness = 2;
            this.jmtxtSearch.Location = new System.Drawing.Point(200, 21);
            this.jmtxtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jmtxtSearch.MaxLength = 32767;
            this.jmtxtSearch.Name = "jmtxtSearch";
            this.jmtxtSearch.OnFocusedColor = System.Drawing.Color.Black;
            this.jmtxtSearch.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jmtxtSearch.ReadOnly = false;
            this.jmtxtSearch.Size = new System.Drawing.Size(231, 31);
            this.jmtxtSearch.TabIndex = 2;
            this.jmtxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jmtxtSearch.TextName = "Search";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(30, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(630, 3);
            this.panel5.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.jImageButton1);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Location = new System.Drawing.Point(455, 690);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(695, 60);
            this.panel6.TabIndex = 2;
            // 
            // jImageButton1
            // 
            this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.jImageButton1.CausesValidation = false;
            this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("jImageButton1.ErrorImage")));
            this.jImageButton1.Image = global::VTDI_CSS.Properties.Resources.send1;
            this.jImageButton1.ImageHover = null;
            this.jImageButton1.InitialImage = null;
            this.jImageButton1.Location = new System.Drawing.Point(630, 12);
            this.jImageButton1.Name = "jImageButton1";
            this.jImageButton1.Size = new System.Drawing.Size(30, 30);
            this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jImageButton1.TabIndex = 3;
            this.jImageButton1.Zoom = 4;
            // 
            // flpChats
            // 
            this.flpChats.AutoScroll = true;
            this.flpChats.BackColor = System.Drawing.Color.White;
            this.flpChats.Location = new System.Drawing.Point(0, 120);
            this.flpChats.Name = "flpChats";
            this.flpChats.Size = new System.Drawing.Size(455, 630);
            this.flpChats.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::VTDI_CSS.Properties.Resources.vtdi;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(455, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 630);
            this.panel2.TabIndex = 5;
            // 
            // frmLiveChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1150, 750);
            this.Controls.Add(this.flpChats);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTopNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLiveChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLiveChat";
            this.Load += new System.EventHandler(this.frmLiveChat_Load);
            this.pnlTopNav.ResumeLayout(false);
            this.pnlTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTopNav;
        private System.Windows.Forms.Button btnMinimize;
        private JImageButton.JImageButton jImageButton2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRecent;
        private JMaterialTextbox.JMaterialTextbox jmtxtSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private JImageButton.JImageButton jImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flpChats;
        private System.Windows.Forms.Panel panel1;
    }
}