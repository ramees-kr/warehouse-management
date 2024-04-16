using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_management.Data;
using warehouse_management.App.Interfaces;
using warehouse_management.Models.Entities;
using warehouse_management.App.Services;

namespace warehouse_management.UI
{
    public partial class LoginForm : Form
    {
        private WdbContext _dbContext;
        private User _currentUser;
        private int loginAttemptCount;

        //private readonly IStockService _stockService;
        private readonly IAuthService _authService; 

        public LoginForm(IStockService stockService, IAuthService authService, WdbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _authService = authService;
            loginAttemptCount = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            //Authenticate user using the AuthService
            if (_authService.AuthenticateUser(username, password))
            {
                //If user is authenticated, show the main form
                Dashboard dashBoard = new Dashboard(_dbContext, _currentUser);
                dashBoard.Show();
                this.Hide();
            }
            else
            {
                //If user is not authenticated, show an error message
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginAttemptCount++;
                if (loginAttemptCount >= 3)
                {
                    MessageBox.Show("You have exceeded the maximum number of login attempts. The application will now close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the application
            Application.Exit();
        }
    }
}
