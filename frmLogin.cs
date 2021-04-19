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
    public partial class frmLogin : Form
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

        public frmLogin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            this.Hide();
            register.Show();
        }

        private void lblCreateAccount_MouseEnter(object sender, EventArgs e)
        {
            lblCreateAccount.ForeColor = Color.Blue;
        }

        private void lblCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            lblCreateAccount.ForeColor = Color.FromArgb(78, 115, 223);
        }

        private void lblForgotPassword_MouseEnter(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.Blue;
        }

        private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgotPassword.ForeColor = Color.FromArgb(78, 115, 223);
        }
    }
}