﻿using BussisnesLayer.Services;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.forms
{
    public partial class FormClient : Form
    {
        
        private ITicketRepository _TicketRepository;

        public FormClient() : this(new TicketRepository())
        {
        }
        public FormClient(ITicketRepository TicketRepository)
        
        {
            InitializeComponent();  
            LoadTicketData();

            
        }


        public void LoadTicketData()
        {
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();
            if (loginForm != null)
            {
                loginForm.ResetLoginForm();
                loginForm.Show();
            }

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formModal = new AddTicketClient(this, _TicketRepository)
            {
                editMode = false
            };

            if (formModal.ShowDialog(this) == DialogResult.OK)
            {
                LoadTicketData();
            }
        }
    }
}
