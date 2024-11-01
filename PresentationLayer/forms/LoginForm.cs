using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using BussisnesLayer.Services;
using PresentationLayer.forms.FormAgent;

namespace PresentationLayer.forms
{
    public partial class LoginForm : Form
    {
        private readonly LoginService _loginService;
        public LoginForm()
        {
            InitializeComponent();
            CustomizeButtonAccess();
            CustomizeButtonUser();
            _loginService = new LoginService();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            registerForm formRegister = new registerForm();
            this.Hide();
            formRegister.FormClosed += (s, args) => this.Show();
            formRegister.Show();
        }

        private void buttonAccess_Click(object sender, EventArgs e)
        {
            string username = textBoxMail.Text; // Asumiendo que tienes un TextBox para el usuario
            string password = textBoxPasword.Text; // Asumiendo que tienes un TextBox para la contraseña

            var user = _loginService.Login(username, password);

            if (user != null && user.Role == "Administrador")
            {
                MessageBox.Show("Acceso permitido", "Access");

                // Abre el formulario DashboardAgent y oculta el formulario de inicio de sesión
                DashboardAdmin dashboard = new DashboardAdmin();
                dashboard.ShowDialog();
                this.Hide(); // Opcional: Oculta el LoginForm después de acceder
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomizeButtonAccess()
        {
            buttonAccess.Size = new Size(140, 50);
            buttonAccess.FlatStyle = FlatStyle.Flat;
            buttonAccess.FlatAppearance.BorderSize = 0;
            buttonAccess.BackColor = Color.Transparent;
            buttonAccess.Paint += new PaintEventHandler(DrawCoolButton);
        }

        private void CustomizeButtonUser()
        {
            btnUser.Size = new Size(140, 50);
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.BackColor = Color.Transparent;
            btnUser.Paint += new PaintEventHandler(DrawCoolButton);
        }

        private void DrawCoolButton(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle buttonRect = btn.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(buttonRect, Color.FromArgb(123, 104, 238), Color.FromArgb(75, 0, 130), 45F))
            {
                GraphicsPath path = new GraphicsPath();
                path.AddArc(buttonRect.X, buttonRect.Y, 30, 30, 180, 90);
                path.AddArc(buttonRect.X + buttonRect.Width - 30, buttonRect.Y, 30, 30, 270, 90);
                path.AddArc(buttonRect.X + buttonRect.Width - 30, buttonRect.Y + buttonRect.Height - 30, 30, 30, 0, 90);
                path.AddArc(buttonRect.X, buttonRect.Y + buttonRect.Height - 30, 30, 30, 90, 90);
                path.CloseFigure();

                g.FillPath(brush, path);

                using (Pen shadowPen = new Pen(Color.FromArgb(50, 0, 0, 0), 5))
                {
                    g.DrawPath(shadowPen, path);
                }

                using (Pen borderPen = new Pen(Color.White, 2))
                {
                    g.DrawPath(borderPen, path);
                }
            }

            TextRenderer.DrawText(g, btn.Text, btn.Font, buttonRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
