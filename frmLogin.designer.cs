
namespace VTDI_CSS
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.Logopicbox = new System.Windows.Forms.PictureBox();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.minimizelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.Usernametxt = new JMetroTextBox.JMetroTextBox();
            this.Passwordtxt = new JMetroTextBox.JMetroTextBox();
            this.Signinbtn = new JThinButton.JThinButton();
            this.remembermebox = new System.Windows.Forms.CheckBox();
            this.Facebookloginbtn = new JThinButton.JThinButton();
            this.Googleloginbtn = new JThinButton.JThinButton();
            this.forgotpasswordlbl = new System.Windows.Forms.Label();
            this.createaccountlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logopicbox)).BeginInit();
            this.Headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logopicbox
            // 
            this.Logopicbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logopicbox.Image = ((System.Drawing.Image)(resources.GetObject("Logopicbox.Image")));
            this.Logopicbox.Location = new System.Drawing.Point(0, 0);
            this.Logopicbox.Name = "Logopicbox";
            this.Logopicbox.Size = new System.Drawing.Size(373, 551);
            this.Logopicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logopicbox.TabIndex = 0;
            this.Logopicbox.TabStop = false;
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.Headerpanel.Controls.Add(this.minimizelbl);
            this.Headerpanel.Controls.Add(this.label2);
            this.Headerpanel.Controls.Add(this.label1);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(373, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(515, 122);
            this.Headerpanel.TabIndex = 1;
            // 
            // minimizelbl
            // 
            this.minimizelbl.AutoSize = true;
            this.minimizelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimizelbl.Location = new System.Drawing.Point(464, -4);
            this.minimizelbl.Name = "minimizelbl";
            this.minimizelbl.Size = new System.Drawing.Size(19, 25);
            this.minimizelbl.TabIndex = 2;
            this.minimizelbl.Text = "-";
            this.minimizelbl.Click += new System.EventHandler(this.minimizelbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(489, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(174, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back !!";
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.Headerpanel;
            // 
            // Usernametxt
            // 
            this.Usernametxt.BackColor = System.Drawing.Color.Transparent;
            this.Usernametxt.BorderColor = System.Drawing.Color.Silver;
            this.Usernametxt.BorderRadius = 13;
            this.Usernametxt.FillColor = System.Drawing.SystemColors.Window;
            this.Usernametxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Usernametxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Usernametxt.ForeColors = System.Drawing.Color.Black;
            this.Usernametxt.IsPassword = false;
            this.Usernametxt.LineThickness = 2;
            this.Usernametxt.Location = new System.Drawing.Point(435, 149);
            this.Usernametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Usernametxt.MaxLength = 32767;
            this.Usernametxt.MouseOnHover = System.Drawing.Color.Empty;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.Usernametxt.OnFocusColor = System.Drawing.Color.Empty;
            this.Usernametxt.OnFocusFontColor = System.Drawing.Color.Empty;
            this.Usernametxt.ReadOnly = false;
            this.Usernametxt.Size = new System.Drawing.Size(441, 39);
            this.Usernametxt.TabIndex = 2;
            this.Usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Usernametxt.TextName = "Username";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.Transparent;
            this.Passwordtxt.BorderColor = System.Drawing.Color.Silver;
            this.Passwordtxt.BorderRadius = 13;
            this.Passwordtxt.FillColor = System.Drawing.SystemColors.Window;
            this.Passwordtxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Passwordtxt.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Passwordtxt.ForeColors = System.Drawing.Color.Black;
            this.Passwordtxt.IsPassword = false;
            this.Passwordtxt.LineThickness = 2;
            this.Passwordtxt.Location = new System.Drawing.Point(435, 194);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Passwordtxt.MaxLength = 32767;
            this.Passwordtxt.MouseOnHover = System.Drawing.Color.Empty;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.Passwordtxt.OnFocusColor = System.Drawing.Color.Empty;
            this.Passwordtxt.OnFocusFontColor = System.Drawing.Color.Empty;
            this.Passwordtxt.ReadOnly = false;
            this.Passwordtxt.Size = new System.Drawing.Size(441, 39);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Passwordtxt.TextName = "Password";
            // 
            // Signinbtn
            // 
            this.Signinbtn.BackColor = System.Drawing.Color.Transparent;
            this.Signinbtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.Signinbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.Signinbtn.BorderRadius = 13;
            this.Signinbtn.ButtonText = "Login ";
            this.Signinbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signinbtn.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signinbtn.ForeColors = System.Drawing.SystemColors.ControlLightLight;
            this.Signinbtn.HoverBackground = System.Drawing.Color.White;
            this.Signinbtn.HoverBorder = System.Drawing.Color.Empty;
            this.Signinbtn.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.Signinbtn.LineThickness = 2;
            this.Signinbtn.Location = new System.Drawing.Point(435, 297);
            this.Signinbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Signinbtn.Name = "Signinbtn";
            this.Signinbtn.Size = new System.Drawing.Size(441, 35);
            this.Signinbtn.TabIndex = 4;
            // 
            // remembermebox
            // 
            this.remembermebox.AutoSize = true;
            this.remembermebox.Location = new System.Drawing.Point(444, 249);
            this.remembermebox.Name = "remembermebox";
            this.remembermebox.Size = new System.Drawing.Size(94, 17);
            this.remembermebox.TabIndex = 7;
            this.remembermebox.Text = "Remember me";
            this.remembermebox.UseVisualStyleBackColor = true;
            // 
            // Facebookloginbtn
            // 
            this.Facebookloginbtn.BackColor = System.Drawing.Color.Transparent;
            this.Facebookloginbtn.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Facebookloginbtn.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Facebookloginbtn.BorderRadius = 13;
            this.Facebookloginbtn.ButtonText = "Login with Facebook";
            this.Facebookloginbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facebookloginbtn.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facebookloginbtn.ForeColors = System.Drawing.SystemColors.ControlLightLight;
            this.Facebookloginbtn.HoverBackground = System.Drawing.Color.White;
            this.Facebookloginbtn.HoverBorder = System.Drawing.Color.Empty;
            this.Facebookloginbtn.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.Facebookloginbtn.LineThickness = 1;
            this.Facebookloginbtn.Location = new System.Drawing.Point(435, 423);
            this.Facebookloginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Facebookloginbtn.Name = "Facebookloginbtn";
            this.Facebookloginbtn.Size = new System.Drawing.Size(441, 38);
            this.Facebookloginbtn.TabIndex = 9;
            // 
            // Googleloginbtn
            // 
            this.Googleloginbtn.BackColor = System.Drawing.Color.Transparent;
            this.Googleloginbtn.BackgroundColor = System.Drawing.Color.Firebrick;
            this.Googleloginbtn.BorderColor = System.Drawing.Color.Firebrick;
            this.Googleloginbtn.BorderRadius = 13;
            this.Googleloginbtn.ButtonText = "Login with Google";
            this.Googleloginbtn.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Googleloginbtn.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Googleloginbtn.ForeColors = System.Drawing.SystemColors.ControlLightLight;
            this.Googleloginbtn.HoverBackground = System.Drawing.Color.White;
            this.Googleloginbtn.HoverBorder = System.Drawing.Color.Empty;
            this.Googleloginbtn.HoverFontColor = System.Drawing.SystemColors.ControlLightLight;
            this.Googleloginbtn.LineThickness = 2;
            this.Googleloginbtn.Location = new System.Drawing.Point(435, 367);
            this.Googleloginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Googleloginbtn.Name = "Googleloginbtn";
            this.Googleloginbtn.Size = new System.Drawing.Size(441, 38);
            this.Googleloginbtn.TabIndex = 10;
            // 
            // forgotpasswordlbl
            // 
            this.forgotpasswordlbl.AutoSize = true;
            this.forgotpasswordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpasswordlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.forgotpasswordlbl.Location = new System.Drawing.Point(579, 485);
            this.forgotpasswordlbl.Name = "forgotpasswordlbl";
            this.forgotpasswordlbl.Size = new System.Drawing.Size(131, 18);
            this.forgotpasswordlbl.TabIndex = 11;
            this.forgotpasswordlbl.Text = "Forgot Password?";
            // 
            // createaccountlbl
            // 
            this.createaccountlbl.AutoSize = true;
            this.createaccountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createaccountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(115)))), ((int)(((byte)(223)))));
            this.createaccountlbl.Location = new System.Drawing.Point(579, 515);
            this.createaccountlbl.Name = "createaccountlbl";
            this.createaccountlbl.Size = new System.Drawing.Size(113, 18);
            this.createaccountlbl.TabIndex = 12;
            this.createaccountlbl.Text = "Create Account!";
            this.createaccountlbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 551);
            this.Controls.Add(this.createaccountlbl);
            this.Controls.Add(this.forgotpasswordlbl);
            this.Controls.Add(this.Googleloginbtn);
            this.Controls.Add(this.Facebookloginbtn);
            this.Controls.Add(this.remembermebox);
            this.Controls.Add(this.Signinbtn);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.Logopicbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginfrm";
            this.Text = "loginfrm";
            ((System.ComponentModel.ISupportInitialize)(this.Logopicbox)).EndInit();
            this.Headerpanel.ResumeLayout(false);
            this.Headerpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logopicbox;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Label minimizelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private JDragControl.JDragControl jDragControl1;
        private JThinButton.JThinButton Googleloginbtn;
        private JThinButton.JThinButton Facebookloginbtn;
        private System.Windows.Forms.CheckBox remembermebox;
        private JThinButton.JThinButton Signinbtn;
        private JMetroTextBox.JMetroTextBox Passwordtxt;
        private JMetroTextBox.JMetroTextBox Usernametxt;
        private System.Windows.Forms.Label createaccountlbl;
        private System.Windows.Forms.Label forgotpasswordlbl;
    }
}