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
    public partial class frmStudentDashboard : Form
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

        public frmStudentDashboard()
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

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void frmDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTopNav_Paint(object sender, PaintEventArgs e)
        {
            pnlTopNav.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1350, 70, 20, 20));
        }

        private void pnlWelcome_Paint(object sender, PaintEventArgs e)
        {
            pnlWelcome.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1302, 199, 20, 20));
        }

        private void pnlShadow1_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1302, 199, 20, 20));
        }

        private void pnlOpenTickets_Paint(object sender, PaintEventArgs e)
        {
            pnlOpenTickets.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 716, 478, 20, 20));
        }

        private void pnlShadow4_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 716, 478, 20, 20));
        }

        private void pnlDirectMessage_Paint(object sender, PaintEventArgs e)
        {
            pnlDirectMessage.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 294, 407, 20, 20));
        }

        private void pnlShadow5_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 294, 407, 20, 20));
        }

        private void pnlQuickAccess_Paint(object sender, PaintEventArgs e)
        {
            pnlQuickAccess.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 290, 481, 20, 20));
        }

        private void pnlShadow6_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 290, 481, 20, 20));
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            lblDashboard.Visible = true;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            lblDashboard.Visible = false;
        }

        private void btnResources_MouseEnter(object sender, EventArgs e)
        {
            lblResource.Visible = true;
        }

        private void btnResources_MouseLeave(object sender, EventArgs e)
        {
            lblResource.Visible = false;
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            lblAbout.Visible = true;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            lblAbout.Visible = false;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            lblSignOut.Visible = true;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            lblSignOut.Visible = false;
        }

        private void pnlShadow7_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 180, 170, 20, 20));
        }

        private void pnlUserMenu_Paint(object sender, PaintEventArgs e)
        {
            pnlUserMenu.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 181, 170, 20, 20));
        }

        private void pnlShadow8_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 211, 20, 20));
        }

        private void pnlMessageCenter_Paint(object sender, PaintEventArgs e)
        {
            pnlMessageCenter.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlShadow9_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow9.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlAlertsCenter_Paint(object sender, PaintEventArgs e)
        {
            pnlAlertsCenter.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlShadow10_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow10.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlTicketsCenter_Paint(object sender, PaintEventArgs e)
        {
            pnlTicketsCenter.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 278, 212, 20, 20));
        }

        private void pnlShadow11_Paint(object sender, PaintEventArgs e)
        {
            pnlShadow11.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 291, 64, 20, 20));
        }

        private void pnlAccessChat_Paint(object sender, PaintEventArgs e)
        {
            pnlAccessChat.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 291, 65, 20, 20));
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

        private void btnProfile_MouseEnter(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.Black;
        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.DimGray;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.ForeColor = Color.Black;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.ForeColor = Color.DimGray;
        }

        private void btnActivityLog_MouseEnter(object sender, EventArgs e)
        {
            btnActivityLog.ForeColor = Color.Black;
        }

        private void btnActivityLog_MouseLeave(object sender, EventArgs e)
        {
            btnActivityLog.ForeColor = Color.DimGray;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.Black;
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.ForeColor = Color.DimGray;
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
