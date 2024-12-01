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
using DataAccessLayer.Repositories;
using CommonLayer.Entities;

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

        public void ResetLoginForm()
        {
            textBoxMail.Clear();
            textBoxPasword.Clear();
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
            string username = textBoxMail.Text; 
            string password = textBoxPasword.Text; 


            var user = _loginService.Login(username, password);

            if (user != null)
            {
                Form nextForm = null; 
                if(user.Role == "SuperAdministador")
                {
                    administrador admin = new administrador
                    {
                        Id = user.Id,
                        FirstName = user.Username.Split(' ')[0],
                        LastName = user.Username.Split(' ')[1],
                        Email = username,
                        Password = password,
                        idRol = 1
                    };

                    nextForm = new DashboardAdmin(admin);
                }
                else if (user.Role == "Administrador")
                {
                    administrador admin = new administrador
                    {
                        Id = user.Id,
                        FirstName = user.Username.Split(' ')[0],
                        LastName = user.Username.Split(' ')[1],
                        Email = username,
                        Password = password,
                        idRol = 2
                    };

                    nextForm = new DashboardAdmin(admin);
                }
                else if (user.Role == "Agente")
                {
                    nextForm = new AgentPanelForm();
                }
                else if (user.Role == "Cliente")
                {
                    Client client = new Client
                    {
                        IdClient = user.Id,           
                        FirstName = user.Username.Split(' ')[0],  
                        LastName = user.Username.Split(' ')[1],   
                        Email = username,                
                        Password = password,             
                        idRol = 4                         
                    };
                    nextForm = new FormClient(client);
                }

                if (nextForm != null)
                {
                    this.Hide();
                    nextForm.FormClosed += (s, args) =>
                    {
                        this.ResetLoginForm();
                        this.Show();
                    };
                    nextForm.Show();
                }
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
