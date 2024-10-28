using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    
    public partial class frmLogInAccount : Form
    {

        String uName;
        String password;
        public static frmLogInAccount instance;
        public frmLogInAccount()
        {
            InitializeComponent();
            InitializeMenu();
            instance = this;

        }
        
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string uName = "jca"; 
            string password = "123"; 

            
            if (!string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
               
                if (textBoxUsername.Text == uName && textBoxPassword.Text == password)
                {
                    MessageBox.Show($"Hello {uName} of Finance Department");
                    frmDiscountedItem compute = new frmDiscountedItem();
                    compute.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }

        }
        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            // Create 'Options' menu
            ToolStripMenuItem optionsMenu = new ToolStripMenuItem("Options");

            // Create 'Log Out' and 'Exit' menu items
            ToolStripMenuItem logOutMenuItem = new ToolStripMenuItem("Log Out");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit Application");

            // Add event handlers for Log Out and Exit
            logOutMenuItem.Click += new EventHandler(LogOutMenuItem_Click);
            exitMenuItem.Click += new EventHandler(ExitMenuItem_Click);

            // Add menu items to the 'Options' menu
            optionsMenu.DropDownItems.Add(logOutMenuItem);
            optionsMenu.DropDownItems.Add(exitMenuItem);

            // Add 'Options' to the MenuStrip
            menuStrip.Items.Add(optionsMenu);

            // Add MenuStrip to the form
            this.Controls.Add(menuStrip);
        }

        // Event handler for Log Out
        private void LogOutMenuItem_Click(object sender, EventArgs e)
        {
            // Show frmLogInAccount (Form 2)
            this.Hide(); // Hide the current form
            frmLogInAccount logInForm = new frmLogInAccount();
            logInForm.Show();
        }

        // Event handler for Exit
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application
        }
    }
}

