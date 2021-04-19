using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDI_CSS
{
    public partial class frmAdminProfile : Form
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
        public frmAdminProfile()
        {
            InitializeComponent();
            tmrDateTime.Start();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= dropShadow;
                return cp;
            }
        }

        private void frmAdminProfile_Load(object sender, EventArgs e)
        {
            this.btnDashboard.Image = (Image)(new Bitmap(homeIcon, new Size(40, 40)));
            this.btnTickets.Image = (Image)(new Bitmap(ticketIcon, new Size(40, 30)));
            this.btnUsers.Image = (Image)(new Bitmap(userIcon, new Size(40, 40)));
            this.btnExit.Image = (Image)(new Bitmap(exitIcon, new Size(40, 40)));
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lblDateTime.Text = dateTime.ToString();
        }

        private void frmAdminProfile_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmAdminProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
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

        private void pnlShadow1_Paint(object sender, PaintEventArgs e)
        {
            //pnlShadow1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1204, 412, 20, 20));
        }

        private void pnlAlerts_Paint(object sender, PaintEventArgs e)
        {
            if (pnlAlerts.Visible == true) {
                btnAlerts.BackColor = Color.Khaki;
                btnAlerts.ForeColor = Color.White;
                btnBioData.BackColor = Color.FromArgb(78, 115, 223);
                btnBioData.ForeColor = Color.White;
                btnProfileSettings.BackColor = Color.FromArgb(78, 115, 223);
                btnProfileSettings.ForeColor = Color.White;
                btnTicketsInfo.BackColor = Color.FromArgb(78, 115, 223);
                btnTicketsInfo.ForeColor = Color.White;
            }
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            pnlAlerts.Visible = true;
            pnlBioData.Visible = false;
            pnlProfileSettings.Visible = false;
            pnlTicketsInfo.Visible = false;
        }

        private void btnBioData_Click(object sender, EventArgs e)
        {
            pnlAlerts.Visible = false;
            pnlBioData.Visible = true;
            pnlProfileSettings.Visible = false;
            pnlTicketsInfo.Visible = false;
        }

        private void btnProfileSettings_Click(object sender, EventArgs e)
        {
            pnlAlerts.Visible = false;
            pnlBioData.Visible = false;
            pnlProfileSettings.Visible = true;
            pnlTicketsInfo.Visible = false;
        }

        private void btnTicketsInfo_Click(object sender, EventArgs e)
        {
            pnlAlerts.Visible = false;
            pnlBioData.Visible = false;
            pnlProfileSettings.Visible = false;
            pnlTicketsInfo.Visible = true;
        }

        private void pnlBioData_Paint(object sender, PaintEventArgs e)
        {
            if (pnlBioData.Visible == true) {
                btnAlerts.BackColor = Color.FromArgb(78, 115, 223);
                btnAlerts.ForeColor = Color.White;
                btnBioData.BackColor = Color.Khaki;
                btnBioData.ForeColor = Color.White;
                btnProfileSettings.BackColor = Color.FromArgb(78, 115, 223);
                btnProfileSettings.ForeColor = Color.White;
                btnTicketsInfo.BackColor = Color.FromArgb(78, 115, 223);
                btnTicketsInfo.ForeColor = Color.White;
            }
        }

        private void pnlProfileSettings_Paint(object sender, PaintEventArgs e)
        {
            if (pnlProfileSettings.Visible == true) {
                btnAlerts.BackColor = Color.FromArgb(78, 115, 223);
                btnAlerts.ForeColor = Color.White;
                btnBioData.BackColor = Color.FromArgb(78, 115, 223);
                btnBioData.ForeColor = Color.White;
                btnProfileSettings.BackColor = Color.Khaki;
                btnProfileSettings.ForeColor = Color.White;
                btnTicketsInfo.BackColor = Color.FromArgb(78, 115, 223);
                btnTicketsInfo.ForeColor = Color.White;
            }
        }

        private void pnlTicketsInfo_Paint(object sender, PaintEventArgs e)
        {
            if (pnlTicketsInfo.Visible == true) {
                btnAlerts.BackColor = Color.FromArgb(78, 115, 223);
                btnAlerts.ForeColor = Color.White;
                btnBioData.BackColor = Color.FromArgb(78, 115, 223);
                btnBioData.ForeColor = Color.White;
                btnProfileSettings.BackColor = Color.FromArgb(78, 115, 223);
                btnProfileSettings.ForeColor = Color.White;
                btnTicketsInfo.BackColor = Color.Khaki;
                btnTicketsInfo.ForeColor = Color.White;
            }
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

        private void btnAlerts_MouseEnter(object sender, EventArgs e)
        {
            btnAlerts.ForeColor = Color.Black;
        }

        private void btnAlerts_MouseLeave(object sender, EventArgs e)
        {
            btnAlerts.ForeColor = Color.White;
        }

        private void btnBioData_MouseEnter(object sender, EventArgs e)
        {
            btnBioData.ForeColor = Color.Black;
        }

        private void btnBioData_MouseLeave(object sender, EventArgs e)
        {
            btnBioData.ForeColor = Color.White;
        }

        private void btnProfileSettings_MouseEnter(object sender, EventArgs e)
        {
            btnProfileSettings.ForeColor = Color.Black;
        }

        private void btnProfileSettings_MouseLeave(object sender, EventArgs e)
        {
            btnProfileSettings.ForeColor = Color.White;
        }

        private void btnTicketsInfo_MouseEnter(object sender, EventArgs e)
        {
            btnTicketsInfo.ForeColor = Color.Black;
        }

        private void btnTicketsInfo_MouseLeave(object sender, EventArgs e)
        {
            btnTicketsInfo.ForeColor = Color.White;
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
