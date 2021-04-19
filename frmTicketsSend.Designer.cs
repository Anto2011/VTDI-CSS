
namespace VTDI_CSS
{
    partial class frmTicketsSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketsSend));
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxSend = new System.Windows.Forms.PictureBox();
            this.pbxTrash = new System.Windows.Forms.PictureBox();
            this.pbxAttachment = new System.Windows.Forms.PictureBox();
            this.lblUnderline = new System.Windows.Forms.Label();
            this.lblItalic = new System.Windows.Forms.Label();
            this.lblBold = new System.Windows.Forms.Label();
            this.ofdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSignOut = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblResource = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.btnExit = new JImageButton.JImageButton();
            this.btnAbout = new JImageButton.JImageButton();
            this.btnResources = new JImageButton.JImageButton();
            this.btnDashboard = new JImageButton.JImageButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnTicketCenter = new JImageButton.JImageButton();
            this.btnNotificationCenter = new JImageButton.JImageButton();
            this.btnMessageCenter = new JImageButton.JImageButton();
            this.pnlTopNav = new System.Windows.Forms.Panel();
            this.btnUserProfile = new JImageButton.JImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlTicketsCenter = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlShadow10 = new System.Windows.Forms.Panel();
            this.pnlAlertsCenter = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlShadow9 = new System.Windows.Forms.Panel();
            this.pnlMessageCenter = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlShadow8 = new System.Windows.Forms.Panel();
            this.pnlUserMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnActivityLog = new System.Windows.Forms.Button();
            this.pnlShadow7 = new System.Windows.Forms.Panel();
            this.txtSubject = new JMetroTextBox.JMetroTextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttachment)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlTopNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlTicketsCenter.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlAlertsCenter.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlMessageCenter.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlUserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(146, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ticket #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(146, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Recipient:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(289, 276);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(334, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(146, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Subject:";
            // 
            // rtbBody
            // 
            this.rtbBody.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBody.Location = new System.Drawing.Point(289, 461);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(1141, 383);
            this.rtbBody.TabIndex = 3;
            this.rtbBody.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(146, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 39;
            this.label8.Text = "Body:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.pbxSend);
            this.panel3.Controls.Add(this.pbxTrash);
            this.panel3.Controls.Add(this.pbxAttachment);
            this.panel3.Controls.Add(this.lblUnderline);
            this.panel3.Controls.Add(this.lblItalic);
            this.panel3.Controls.Add(this.lblBold);
            this.panel3.Location = new System.Drawing.Point(1436, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 383);
            this.panel3.TabIndex = 40;
            // 
            // pbxSend
            // 
            this.pbxSend.Image = global::VTDI_CSS.Properties.Resources.send;
            this.pbxSend.Location = new System.Drawing.Point(7, 317);
            this.pbxSend.Name = "pbxSend";
            this.pbxSend.Size = new System.Drawing.Size(33, 40);
            this.pbxSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSend.TabIndex = 45;
            this.pbxSend.TabStop = false;
            this.pbxSend.Click += new System.EventHandler(this.pbxSend_Click);
            // 
            // pbxTrash
            // 
            this.pbxTrash.Image = global::VTDI_CSS.Properties.Resources.trash;
            this.pbxTrash.Location = new System.Drawing.Point(7, 250);
            this.pbxTrash.Name = "pbxTrash";
            this.pbxTrash.Size = new System.Drawing.Size(33, 40);
            this.pbxTrash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxTrash.TabIndex = 44;
            this.pbxTrash.TabStop = false;
            this.pbxTrash.Click += new System.EventHandler(this.pbxTrash_Click);
            // 
            // pbxAttachment
            // 
            this.pbxAttachment.Image = global::VTDI_CSS.Properties.Resources.attachment;
            this.pbxAttachment.Location = new System.Drawing.Point(7, 182);
            this.pbxAttachment.Name = "pbxAttachment";
            this.pbxAttachment.Size = new System.Drawing.Size(33, 40);
            this.pbxAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAttachment.TabIndex = 41;
            this.pbxAttachment.TabStop = false;
            this.pbxAttachment.Click += new System.EventHandler(this.pbxAttachment_Click);
            // 
            // lblUnderline
            // 
            this.lblUnderline.AutoSize = true;
            this.lblUnderline.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderline.Location = new System.Drawing.Point(11, 126);
            this.lblUnderline.Name = "lblUnderline";
            this.lblUnderline.Size = new System.Drawing.Size(28, 30);
            this.lblUnderline.TabIndex = 43;
            this.lblUnderline.Text = "U";
            this.lblUnderline.Click += new System.EventHandler(this.lblUnderline_Click);
            // 
            // lblItalic
            // 
            this.lblItalic.AutoSize = true;
            this.lblItalic.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItalic.Location = new System.Drawing.Point(14, 76);
            this.lblItalic.Name = "lblItalic";
            this.lblItalic.Size = new System.Drawing.Size(20, 30);
            this.lblItalic.TabIndex = 42;
            this.lblItalic.Text = "I";
            this.lblItalic.Click += new System.EventHandler(this.lblItalic_Click);
            // 
            // lblBold
            // 
            this.lblBold.AutoSize = true;
            this.lblBold.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBold.Location = new System.Drawing.Point(13, 22);
            this.lblBold.Name = "lblBold";
            this.lblBold.Size = new System.Drawing.Size(26, 30);
            this.lblBold.TabIndex = 41;
            this.lblBold.Text = "B";
            this.lblBold.Click += new System.EventHandler(this.lblBold_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(136, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 45);
            this.label9.TabIndex = 41;
            this.label9.Text = "Upload A Ticket";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(285, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 21);
            this.label10.TabIndex = 42;
            this.label10.Text = "###";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.lblSignOut);
            this.panel1.Controls.Add(this.lblAbout);
            this.panel1.Controls.Add(this.lblResource);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnResources);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 900);
            this.panel1.TabIndex = 46;
            // 
            // lblSignOut
            // 
            this.lblSignOut.AutoSize = true;
            this.lblSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignOut.ForeColor = System.Drawing.Color.Gold;
            this.lblSignOut.Location = new System.Drawing.Point(37, 551);
            this.lblSignOut.Name = "lblSignOut";
            this.lblSignOut.Size = new System.Drawing.Size(68, 17);
            this.lblSignOut.TabIndex = 56;
            this.lblSignOut.Text = "SIGN OUT";
            this.lblSignOut.Visible = false;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.Gold;
            this.lblAbout.Location = new System.Drawing.Point(39, 423);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(51, 17);
            this.lblAbout.TabIndex = 55;
            this.lblAbout.Text = "ABOUT";
            this.lblAbout.Visible = false;
            // 
            // lblResource
            // 
            this.lblResource.AutoSize = true;
            this.lblResource.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResource.ForeColor = System.Drawing.Color.Gold;
            this.lblResource.Location = new System.Drawing.Point(26, 301);
            this.lblResource.Name = "lblResource";
            this.lblResource.Size = new System.Drawing.Size(79, 17);
            this.lblResource.TabIndex = 54;
            this.lblResource.Text = "RESOURCES";
            this.lblResource.Visible = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.Gold;
            this.lblDashboard.Location = new System.Drawing.Point(22, 184);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(89, 17);
            this.lblDashboard.TabIndex = 53;
            this.lblDashboard.Text = "DASHBOARD";
            this.lblDashboard.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.CausesValidation = false;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ErrorImage")));
            this.btnExit.Image = global::VTDI_CSS.Properties.Resources.exit;
            this.btnExit.ImageHover = null;
            this.btnExit.InitialImage = null;
            this.btnExit.Location = new System.Drawing.Point(12, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 47);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 16;
            this.btnExit.Zoom = 4;
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.CausesValidation = false;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAbout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ErrorImage")));
            this.btnAbout.Image = global::VTDI_CSS.Properties.Resources.info_icon;
            this.btnAbout.ImageHover = null;
            this.btnAbout.InitialImage = null;
            this.btnAbout.Location = new System.Drawing.Point(12, 373);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(112, 47);
            this.btnAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Zoom = 4;
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseLeave += new System.EventHandler(this.btnAbout_MouseLeave);
            // 
            // btnResources
            // 
            this.btnResources.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResources.BackColor = System.Drawing.Color.Transparent;
            this.btnResources.CausesValidation = false;
            this.btnResources.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResources.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnResources.ErrorImage")));
            this.btnResources.Image = global::VTDI_CSS.Properties.Resources.folder;
            this.btnResources.ImageHover = null;
            this.btnResources.InitialImage = null;
            this.btnResources.Location = new System.Drawing.Point(12, 251);
            this.btnResources.Name = "btnResources";
            this.btnResources.Size = new System.Drawing.Size(112, 47);
            this.btnResources.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnResources.TabIndex = 15;
            this.btnResources.Zoom = 4;
            this.btnResources.MouseEnter += new System.EventHandler(this.btnResources_MouseEnter);
            this.btnResources.MouseLeave += new System.EventHandler(this.btnResources_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.CausesValidation = false;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDashboard.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.ErrorImage")));
            this.btnDashboard.Image = global::VTDI_CSS.Properties.Resources.home2;
            this.btnDashboard.ImageHover = null;
            this.btnDashboard.InitialImage = null;
            this.btnDashboard.Location = new System.Drawing.Point(12, 134);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(112, 47);
            this.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDashboard.TabIndex = 7;
            this.btnDashboard.Zoom = 4;
            this.btnDashboard.MouseEnter += new System.EventHandler(this.btnDashboard_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VTDI_CSS.Properties.Resources.vtdi_logo75;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 75);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinimize.Location = new System.Drawing.Point(1470, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 35);
            this.btnMinimize.TabIndex = 48;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnTicketCenter
            // 
            this.btnTicketCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTicketCenter.BackColor = System.Drawing.Color.White;
            this.btnTicketCenter.CausesValidation = false;
            this.btnTicketCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTicketCenter.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnTicketCenter.ErrorImage")));
            this.btnTicketCenter.Image = global::VTDI_CSS.Properties.Resources.sticky_notes;
            this.btnTicketCenter.ImageHover = null;
            this.btnTicketCenter.InitialImage = null;
            this.btnTicketCenter.Location = new System.Drawing.Point(676, 72);
            this.btnTicketCenter.Name = "btnTicketCenter";
            this.btnTicketCenter.Size = new System.Drawing.Size(30, 25);
            this.btnTicketCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTicketCenter.TabIndex = 51;
            this.btnTicketCenter.Zoom = 4;
            this.btnTicketCenter.Click += new System.EventHandler(this.btnTicketCenter_Click);
            // 
            // btnNotificationCenter
            // 
            this.btnNotificationCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNotificationCenter.BackColor = System.Drawing.Color.White;
            this.btnNotificationCenter.CausesValidation = false;
            this.btnNotificationCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNotificationCenter.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNotificationCenter.ErrorImage")));
            this.btnNotificationCenter.Image = global::VTDI_CSS.Properties.Resources.notification;
            this.btnNotificationCenter.ImageHover = null;
            this.btnNotificationCenter.InitialImage = null;
            this.btnNotificationCenter.Location = new System.Drawing.Point(749, 72);
            this.btnNotificationCenter.Name = "btnNotificationCenter";
            this.btnNotificationCenter.Size = new System.Drawing.Size(30, 25);
            this.btnNotificationCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNotificationCenter.TabIndex = 50;
            this.btnNotificationCenter.Zoom = 4;
            this.btnNotificationCenter.Click += new System.EventHandler(this.btnNotificationCenter_Click);
            // 
            // btnMessageCenter
            // 
            this.btnMessageCenter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMessageCenter.BackColor = System.Drawing.Color.White;
            this.btnMessageCenter.CausesValidation = false;
            this.btnMessageCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMessageCenter.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnMessageCenter.ErrorImage")));
            this.btnMessageCenter.Image = global::VTDI_CSS.Properties.Resources.mail;
            this.btnMessageCenter.ImageHover = null;
            this.btnMessageCenter.InitialImage = null;
            this.btnMessageCenter.Location = new System.Drawing.Point(821, 72);
            this.btnMessageCenter.Name = "btnMessageCenter";
            this.btnMessageCenter.Size = new System.Drawing.Size(30, 25);
            this.btnMessageCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMessageCenter.TabIndex = 49;
            this.btnMessageCenter.Zoom = 4;
            this.btnMessageCenter.Click += new System.EventHandler(this.btnMessageCenter_Click);
            // 
            // pnlTopNav
            // 
            this.pnlTopNav.BackColor = System.Drawing.Color.White;
            this.pnlTopNav.Controls.Add(this.btnUserProfile);
            this.pnlTopNav.Controls.Add(this.label2);
            this.pnlTopNav.Controls.Add(this.pictureBox3);
            this.pnlTopNav.Controls.Add(this.label3);
            this.pnlTopNav.Controls.Add(this.lblUsername);
            this.pnlTopNav.Controls.Add(this.lblDateTime);
            this.pnlTopNav.Controls.Add(this.pictureBox5);
            this.pnlTopNav.Location = new System.Drawing.Point(137, 38);
            this.pnlTopNav.Name = "pnlTopNav";
            this.pnlTopNav.Size = new System.Drawing.Size(1350, 70);
            this.pnlTopNav.TabIndex = 52;
            this.pnlTopNav.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopNav_Paint);
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUserProfile.BackColor = System.Drawing.Color.White;
            this.btnUserProfile.CausesValidation = false;
            this.btnUserProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUserProfile.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnUserProfile.ErrorImage")));
            this.btnUserProfile.Image = global::VTDI_CSS.Properties.Resources.profile;
            this.btnUserProfile.ImageHover = null;
            this.btnUserProfile.InitialImage = null;
            this.btnUserProfile.Location = new System.Drawing.Point(1119, 32);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(30, 29);
            this.btnUserProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUserProfile.TabIndex = 23;
            this.btnUserProfile.Zoom = 4;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(752, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 106);
            this.label2.TabIndex = 21;
            this.label2.Text = "|";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VTDI_CSS.Properties.Resources.tickets;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(86, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tickets";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(1155, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 25);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblDateTime.Location = new System.Drawing.Point(854, 34);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(143, 25);
            this.lblDateTime.TabIndex = 15;
            this.lblDateTime.Text = "Date And Time";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VTDI_CSS.Properties.Resources.clock;
            this.pictureBox5.Location = new System.Drawing.Point(818, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pnlTicketsCenter
            // 
            this.pnlTicketsCenter.BackColor = System.Drawing.Color.White;
            this.pnlTicketsCenter.Controls.Add(this.panel8);
            this.pnlTicketsCenter.Location = new System.Drawing.Point(459, 109);
            this.pnlTicketsCenter.Name = "pnlTicketsCenter";
            this.pnlTicketsCenter.Size = new System.Drawing.Size(278, 212);
            this.pnlTicketsCenter.TabIndex = 76;
            this.pnlTicketsCenter.Visible = false;
            this.pnlTicketsCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTicketsCenter_Paint);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(278, 35);
            this.panel8.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Tickets Center";
            // 
            // pnlShadow10
            // 
            this.pnlShadow10.BackColor = System.Drawing.Color.DarkGray;
            this.pnlShadow10.Location = new System.Drawing.Point(462, 112);
            this.pnlShadow10.Name = "pnlShadow10";
            this.pnlShadow10.Size = new System.Drawing.Size(278, 212);
            this.pnlShadow10.TabIndex = 75;
            this.pnlShadow10.Visible = false;
            this.pnlShadow10.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShadow10_Paint);
            // 
            // pnlAlertsCenter
            // 
            this.pnlAlertsCenter.BackColor = System.Drawing.Color.White;
            this.pnlAlertsCenter.Controls.Add(this.panel7);
            this.pnlAlertsCenter.Location = new System.Drawing.Point(524, 109);
            this.pnlAlertsCenter.Name = "pnlAlertsCenter";
            this.pnlAlertsCenter.Size = new System.Drawing.Size(278, 212);
            this.pnlAlertsCenter.TabIndex = 74;
            this.pnlAlertsCenter.Visible = false;
            this.pnlAlertsCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAlertsCenter_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 35);
            this.panel7.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Alerts Center";
            // 
            // pnlShadow9
            // 
            this.pnlShadow9.BackColor = System.Drawing.Color.DarkGray;
            this.pnlShadow9.Location = new System.Drawing.Point(527, 112);
            this.pnlShadow9.Name = "pnlShadow9";
            this.pnlShadow9.Size = new System.Drawing.Size(278, 212);
            this.pnlShadow9.TabIndex = 73;
            this.pnlShadow9.Visible = false;
            this.pnlShadow9.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShadow9_Paint);
            // 
            // pnlMessageCenter
            // 
            this.pnlMessageCenter.BackColor = System.Drawing.Color.White;
            this.pnlMessageCenter.Controls.Add(this.panel5);
            this.pnlMessageCenter.Location = new System.Drawing.Point(589, 109);
            this.pnlMessageCenter.Name = "pnlMessageCenter";
            this.pnlMessageCenter.Size = new System.Drawing.Size(278, 212);
            this.pnlMessageCenter.TabIndex = 72;
            this.pnlMessageCenter.Visible = false;
            this.pnlMessageCenter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMessageCenter_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(278, 35);
            this.panel5.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Messages Center";
            // 
            // pnlShadow8
            // 
            this.pnlShadow8.BackColor = System.Drawing.Color.DarkGray;
            this.pnlShadow8.Location = new System.Drawing.Point(592, 113);
            this.pnlShadow8.Name = "pnlShadow8";
            this.pnlShadow8.Size = new System.Drawing.Size(278, 211);
            this.pnlShadow8.TabIndex = 71;
            this.pnlShadow8.Visible = false;
            this.pnlShadow8.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShadow8_Paint);
            // 
            // pnlUserMenu
            // 
            this.pnlUserMenu.BackColor = System.Drawing.Color.White;
            this.pnlUserMenu.Controls.Add(this.label5);
            this.pnlUserMenu.Controls.Add(this.btnProfile);
            this.pnlUserMenu.Controls.Add(this.btnSettings);
            this.pnlUserMenu.Controls.Add(this.btnLogout);
            this.pnlUserMenu.Controls.Add(this.btnActivityLog);
            this.pnlUserMenu.Location = new System.Drawing.Point(1215, 109);
            this.pnlUserMenu.Name = "pnlUserMenu";
            this.pnlUserMenu.Size = new System.Drawing.Size(181, 170);
            this.pnlUserMenu.TabIndex = 70;
            this.pnlUserMenu.Visible = false;
            this.pnlUserMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUserMenu_Paint);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(0, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "--------------------";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.DimGray;
            this.btnProfile.Location = new System.Drawing.Point(3, 0);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(175, 32);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.DimGray;
            this.btnSettings.Location = new System.Drawing.Point(3, 37);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(175, 32);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.Location = new System.Drawing.Point(3, 132);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 32);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnActivityLog
            // 
            this.btnActivityLog.FlatAppearance.BorderSize = 0;
            this.btnActivityLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivityLog.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivityLog.ForeColor = System.Drawing.Color.DimGray;
            this.btnActivityLog.Location = new System.Drawing.Point(3, 75);
            this.btnActivityLog.Name = "btnActivityLog";
            this.btnActivityLog.Size = new System.Drawing.Size(175, 32);
            this.btnActivityLog.TabIndex = 2;
            this.btnActivityLog.Text = "Activity Log";
            this.btnActivityLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivityLog.UseVisualStyleBackColor = true;
            // 
            // pnlShadow7
            // 
            this.pnlShadow7.BackColor = System.Drawing.Color.DarkGray;
            this.pnlShadow7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlShadow7.Location = new System.Drawing.Point(1219, 112);
            this.pnlShadow7.Name = "pnlShadow7";
            this.pnlShadow7.Size = new System.Drawing.Size(180, 170);
            this.pnlShadow7.TabIndex = 69;
            this.pnlShadow7.Visible = false;
            this.pnlShadow7.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShadow7_Paint);
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.Transparent;
            this.txtSubject.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSubject.BorderRadius = 10;
            this.txtSubject.FillColor = System.Drawing.Color.White;
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtSubject.Font_Size = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtSubject.ForeColors = System.Drawing.Color.Gray;
            this.txtSubject.IsPassword = false;
            this.txtSubject.LineThickness = 1;
            this.txtSubject.Location = new System.Drawing.Point(289, 352);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubject.MaxLength = 32767;
            this.txtSubject.MouseOnHover = System.Drawing.Color.Empty;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.OnFocusColor = System.Drawing.Color.Empty;
            this.txtSubject.OnFocusFontColor = System.Drawing.Color.Empty;
            this.txtSubject.ReadOnly = false;
            this.txtSubject.Size = new System.Drawing.Size(334, 40);
            this.txtSubject.TabIndex = 2;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSubject.TextName = "Enter Subject...";
            // 
            // frmTicketsSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.pnlTicketsCenter);
            this.Controls.Add(this.btnTicketCenter);
            this.Controls.Add(this.btnNotificationCenter);
            this.Controls.Add(this.pnlShadow10);
            this.Controls.Add(this.btnMessageCenter);
            this.Controls.Add(this.pnlTopNav);
            this.Controls.Add(this.pnlAlertsCenter);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.pnlShadow9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlMessageCenter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlShadow8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlUserMenu);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlShadow7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTicketsSend";
            this.Text = "frmTickets";
            this.Load += new System.EventHandler(this.frmTickets_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTickets_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTickets_MouseMove);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTrash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAttachment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlTopNav.ResumeLayout(false);
            this.pnlTopNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlTicketsCenter.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlAlertsCenter.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlMessageCenter.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pnlUserMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbxAttachment;
        private System.Windows.Forms.Label lblUnderline;
        private System.Windows.Forms.Label lblItalic;
        private System.Windows.Forms.Label lblBold;
        private System.Windows.Forms.PictureBox pbxTrash;
        private System.Windows.Forms.PictureBox pbxSend;
        private System.Windows.Forms.OpenFileDialog ofdUploadFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSignOut;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblResource;
        private System.Windows.Forms.Label lblDashboard;
        private JImageButton.JImageButton btnExit;
        private JImageButton.JImageButton btnAbout;
        private JImageButton.JImageButton btnResources;
        private JImageButton.JImageButton btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMinimize;
        private JImageButton.JImageButton btnTicketCenter;
        private JImageButton.JImageButton btnNotificationCenter;
        private JImageButton.JImageButton btnMessageCenter;
        private System.Windows.Forms.Panel pnlTopNav;
        private JImageButton.JImageButton btnUserProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pnlTicketsCenter;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlShadow10;
        private System.Windows.Forms.Panel pnlAlertsCenter;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlShadow9;
        private System.Windows.Forms.Panel pnlMessageCenter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlShadow8;
        private System.Windows.Forms.Panel pnlUserMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnActivityLog;
        private System.Windows.Forms.Panel pnlShadow7;
        private JMetroTextBox.JMetroTextBox txtSubject;
    }
}