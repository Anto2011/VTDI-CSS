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
    public partial class frmViewTickets : Form
    {

        Point lastPoint;
        private const int dropShadow = 0x20000;

        Image homeIcon = VTDI_CSS.Properties.Resources.home2;
        Image ticketIcon = VTDI_CSS.Properties.Resources.tickets2;
        Image userIcon = VTDI_CSS.Properties.Resources.users;
        Image exitIcon = VTDI_CSS.Properties.Resources.exit;

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

        public frmViewTickets()
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

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblDateTime.Text = dateTime.ToString();
        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            this.btnDashboard.Image = (Image)(new Bitmap(homeIcon, new Size(40, 40)));
            this.btnTickets.Image = (Image)(new Bitmap(ticketIcon, new Size(40, 30)));
            this.btnUsers.Image = (Image)(new Bitmap(userIcon, new Size(40, 40)));
            this.btnExit.Image = (Image)(new Bitmap(exitIcon, new Size(40, 40)));
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmTickets_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmTickets_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.Gainsboro;
        }

        private void btnTickets_MouseEnter(object sender, EventArgs e)
        {
            btnTickets.ForeColor = Color.White;
        }

        private void btnTickets_MouseLeave(object sender, EventArgs e)
        {
            btnTickets.ForeColor = Color.Gainsboro;
        }

        private void btnUsers_MouseEnter(object sender, EventArgs e)
        {
            btnUsers.ForeColor = Color.White;
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.ForeColor = Color.Gainsboro;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.ForeColor = Color.Gainsboro;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.Black;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.DimGray;
        }

        private void pnlShadow7_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 180, 170, 20, 20));
        }

        private void pnlShadow8_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 211, 20, 20));
        }

        private void pnlShadow9_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow9.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlShadow10_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow10.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlUserMenu_Paint(object sender, PaintEventArgs e)
        {
            pnlUserMenu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 181, 170, 20, 20));
        }

        private void pnlMessageCenter_Paint(object sender, PaintEventArgs e)
        {
            pnlMessageCenter.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlAlertsCenter_Paint(object sender, PaintEventArgs e)
        {
            pnlAlertsCenter.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlTicketsCenter_Paint(object sender, PaintEventArgs e)
        {
            pnlTicketsCenter.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void lblBold_Click(object sender, EventArgs e)
        {
            int selstart = rtbReply.SelectionStart;
            int sellength = rtbReply.SelectionLength;

            if (!rtbReply.SelectionFont.Bold)
            {
                rtbReply.SelectionFont = new Font(rtbReply.Font, FontStyle.Bold);
                rtbReply.SelectionStart = rtbReply.SelectionStart + rtbReply.SelectionLength;
                rtbReply.SelectionLength = 0;
                rtbReply.SelectionFont = rtbReply.Font;
                rtbReply.Select(selstart, sellength);
            }
            else
            {
                rtbReply.SelectionFont = new Font(rtbReply.Font, FontStyle.Regular);
                rtbReply.SelectionStart = rtbReply.SelectionStart + rtbReply.SelectionLength;
                rtbReply.SelectionLength = 0;
                rtbReply.SelectionFont = rtbReply.Font;
                rtbReply.Select(selstart, sellength);
            }
        }

        private void lblItalic_Click(object sender, EventArgs e)
        {
            int selstart = rtbReply.SelectionStart;
            int sellength = rtbReply.SelectionLength;

            if (!rtbReply.SelectionFont.Italic)
            {
                rtbReply.SelectionFont = new Font(rtbReply.Font, FontStyle.Italic);
                rtbReply.SelectionStart = rtbReply.SelectionStart + rtbReply.SelectionLength;
                rtbReply.SelectionLength = 0;
                rtbReply.SelectionFont = rtbReply.Font;
                rtbReply.Select(selstart, sellength);
            }
            else
            {
                rtbReply.SelectionFont = new Font(rtbReply.Font, FontStyle.Regular);
                rtbReply.SelectionStart = rtbReply.SelectionStart + rtbReply.SelectionLength;
                rtbReply.SelectionLength = 0;
                rtbReply.SelectionFont = rtbReply.Font;
                rtbReply.Select(selstart, sellength);
            }
        }

        private void lblUnderline_Click(object sender, EventArgs e)
        {
            int selstart = rtbReply.SelectionStart;
            int sellength = rtbReply.SelectionLength;

            if (!rtbReply.SelectionFont.Underline)
            {
                rtbReply.SelectionFont = new Font(rtbReply.Font, FontStyle.Underline);
                rtbReply.SelectionStart = rtbReply.SelectionStart + rtbReply.SelectionLength;
                rtbReply.SelectionLength = 0;
                rtbReply.SelectionFont = rtbReply.Font;
                rtbReply.Select(selstart, sellength);
            }
            else
            {
                rtbReply.SelectionFont = new Font(rtbReply.Font, FontStyle.Regular);
                rtbReply.SelectionStart = rtbReply.SelectionStart + rtbReply.SelectionLength;
                rtbReply.SelectionLength = 0;
                rtbReply.SelectionFont = rtbReply.Font;
                rtbReply.Select(selstart, sellength);
            }
        }

        private void pbxAttachment_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdUploadFile.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //Do whatever you want
                //openFileDialog1.FileName .....
            }
        }

        private void pbxReply_Click(object sender, EventArgs e)
        {
            lblReply.Visible = true;
            rtbReply.Visible = true;
            rtbMessage.Size = new Size(1029, 225);
        }

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            if (pnlUserMenu.Visible == true && pnlShadow7.Visible == true)
            {
                pnlUserMenu.Visible = false;
                pnlShadow7.Visible = false;
            }
            else
            {
                pnlUserMenu.Visible = true;
                pnlShadow7.Visible = true;
                pnlMessageCenter.Visible = false;
                pnlShadow8.Visible = false;
                pnlAlertsCenter.Visible = false;
                pnlShadow9.Visible = false;
                pnlTicketsCenter.Visible = false;
                pnlShadow10.Visible = false;
            }
        }

        private void btnMessageCenter_Click(object sender, EventArgs e)
        {
            if (pnlMessageCenter.Visible == true && pnlShadow8.Visible == true)
            {
                pnlMessageCenter.Visible = false;
                pnlShadow8.Visible = false;
            }
            else
            {
                pnlMessageCenter.Visible = true;
                pnlShadow8.Visible = true;
                pnlAlertsCenter.Visible = false;
                pnlShadow9.Visible = false;
                pnlTicketsCenter.Visible = false;
                pnlShadow10.Visible = false;
                pnlUserMenu.Visible = false;
                pnlShadow7.Visible = false;
            }
        }

        private void btnNotificationCenter_Click(object sender, EventArgs e)
        {
            if (pnlAlertsCenter.Visible == true && pnlShadow9.Visible == true)
            {
                pnlAlertsCenter.Visible = false;
                pnlShadow9.Visible = false;
            }
            else
            {
                pnlAlertsCenter.Visible = true;
                pnlShadow9.Visible = true;
                pnlMessageCenter.Visible = false;
                pnlShadow8.Visible = false;
                pnlTicketsCenter.Visible = false;
                pnlShadow10.Visible = false;
                pnlUserMenu.Visible = false;
                pnlShadow7.Visible = false;
            }
        }

        private void btnTicketCenter_Click(object sender, EventArgs e)
        {
            if (pnlTicketsCenter.Visible == true && pnlShadow10.Visible == true)
            {
                pnlTicketsCenter.Visible = false;
                pnlShadow10.Visible = false;
            }
            else
            {
                pnlTicketsCenter.Visible = true;
                pnlShadow10.Visible = true;
                pnlAlertsCenter.Visible = false;
                pnlShadow9.Visible = false;
                pnlMessageCenter.Visible = false;
                pnlShadow8.Visible = false;
                pnlUserMenu.Visible = false;
                pnlShadow7.Visible = false;
            }
        }
    }
}
