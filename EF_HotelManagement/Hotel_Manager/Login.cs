using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Hotel_Manager.Entities.Login;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Manager
{
    public partial class Login : Form
    {
        LOGIN_MANAGER ContextLOGIN_MANAGER;
        FRONTEND_RESERVATION context;
        public Login()
        {
            ContextLOGIN_MANAGER = new LOGIN_MANAGER();
            ContextLOGIN_MANAGER.kitchen.Load();
            ContextLOGIN_MANAGER.frontend.Load();
            context = new FRONTEND_RESERVATION();
            context.reservation.Load();
            

            InitializeComponent();
            CenterToScreen();
        }
        private void signinButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifier("frontend".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))  
                {
                  
                    Frontend hotel_management = new Frontend(context);
                    hotel_management.Show();
                    this.Hide();
                }
                else if (verifier("kitchen".Trim(), usernameTextBox.Text.Trim(), passwordTextBox.Text.Trim()))  
                {
                    this.Hide();
                    Kitchen kitchen_management = new Kitchen(context);
                    kitchen_management.Show();
                }
                else   
                {
                    MessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = true;
            }
            if (usernameTextBox.Text != "Username" && usernameTextBox.Text != string.Empty)
            {
                usernameLabel.Visible = false;
            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = true;
            }
            if (passwordTextBox.Text != "Password" && passwordTextBox.Text != string.Empty)
            {
                passwordLabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!usernameLabel.Bounds.Contains(e.Location) && usernameTextBox.Text == string.Empty)
            {
                usernameLabel.Visible = false;
            }
            if (!passwordLabel.Bounds.Contains(e.Location) && passwordTextBox.Text == string.Empty)
            {
                passwordLabel.Visible = false;
            }

        }

        public bool verifier(string tableName, string username, string password)
        {
            bool success = false;
            frontend res1 = null;
            kitchen res2 = null; 
            try
            {
                if (tableName == "frontend")
                {
                    res1 = ContextLOGIN_MANAGER.frontend.Find(username);
                    if(res1!=null)success = res1.pass_word == password;
                }
                else
                {
                    res2 = ContextLOGIN_MANAGER.kitchen.Find(username);
                    if (res2 != null) success = res2.pass_word == password;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.ToString(), "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            return success;
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
           context.Dispose();
            Application.Exit();
        }

        private void LicenseCallButton_Click(object sender, EventArgs e)
        {
            License open_license = new License();
            open_license.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
     
            ContextLOGIN_MANAGER = new LOGIN_MANAGER();
            
          
        }

    }
}
