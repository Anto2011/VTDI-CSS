using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace VTDI_CSS
{
    public partial class frmLiveChat : Form
    {

        Point lastPoint;
        private const int dropShadow = 0x20000;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public frmLiveChat()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            tmrDateTime.Start();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dropShadow;
                return cp;
            }
        }

        public void createChats()
        {
            for (int i = 0; i < 10; i++)
            {
                Panel pnlChat = new Panel();
                pnlChat.Name = "panel" + (flpChats.Controls.Count + 1);
                pnlChat.BackColor = Color.WhiteSmoke;
                pnlChat.Size = new Size(432, 100);
                flpChats.Controls.Add(pnlChat);
                flpChats.Controls.SetChildIndex(pnlChat, 0);
                //pnlChat.Paint += (ss, ee) => { ee.Graphics.DrawString(pnlChat.Name, Font, Brushes.Black, 22, 11); };
                //flpChats.Invalidate();

                Label lblChatUsername = new Label();
                lblChatUsername.Name = "lblChatUsername" + i;
                lblChatUsername.Text = "Username";
                lblChatUsername.Font = new Font("Segoe UI", 14, FontStyle.Regular);
                lblChatUsername.AutoSize = true;
                lblChatUsername.Location = new Point(50, 12);
                pnlChat.Controls.Add(lblChatUsername);

                Label lblChatTime = new Label();
                lblChatTime.Name = "lblChatTime" + i;
                lblChatTime.Text = "Time";
                lblChatTime.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblChatTime.AutoSize = true;
                lblChatTime.Location = new Point(360, 12);
                pnlChat.Controls.Add(lblChatTime);

                Label lblChatMessagePrev = new Label();
                lblChatMessagePrev.Name = "lblChatMessagePrev" + i;
                lblChatMessagePrev.Text = "The chat's message preview will be placed here for viewing...";
                lblChatMessagePrev.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblChatMessagePrev.AutoSize = false;
                lblChatMessagePrev.Size = new Size(520, 20);
                lblChatMessagePrev.Location = new Point(50, 50);
                pnlChat.Controls.Add(lblChatMessagePrev);

                PictureBox pbxChatPicture = new PictureBox();
                pbxChatPicture.Name = "pbxChatPicture" + i;
                pbxChatPicture.Size = new Size(35, 35);
                pbxChatPicture.Location = new Point(10, 15);
                pbxChatPicture.Image = VTDI_CSS.Properties.Resources.profile2;
                pbxChatPicture.SizeMode = PictureBoxSizeMode.Zoom;
                pnlChat.Controls.Add(pbxChatPicture);



                pnlChat.Click += new EventHandler(pnlChat_Click);
            }
        }

        private void frmLiveChat_Load(object sender, EventArgs e)
        {
            createChats();
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblDateTime.Text = dateTime.ToString();
        }

        private void pnlTopNav_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pnlTopNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        void pnlChat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(((Panel)sender).Name + " Clicked");



            Label lbl = this.Controls.Find("lblChatUsername1", true).FirstOrDefault() as Label;
            if (lbl != null)
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.Black;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.DimGray;
        }
    }
}
