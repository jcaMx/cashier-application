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

    
    public partial class frmDiscountedItem : Form
    {
        double total;
        public frmDiscountedItem()
        {
            InitializeComponent();
        }
        private void InitializeMenu()
        {
            // Create MenuStrip
            MenuStrip menuStrip = new MenuStrip();

            // Create the 'File' menu item
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("File");

            // Create 'Log Out' and 'Exit' sub-menu items
            ToolStripMenuItem logOutMenuItem = new ToolStripMenuItem("Log Out");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");

            // Add event handlers for each menu item
            logOutMenuItem.Click += LogOutMenuItem_Click;
            exitMenuItem.Click += ExitMenuItem_Click;

            // Add the sub-menu items to the 'File' menu item
            fileMenuItem.DropDownItems.Add(logOutMenuItem);
            fileMenuItem.DropDownItems.Add(exitMenuItem);

            // Add the 'File' menu item to the MenuStrip
            menuStrip.Items.Add(fileMenuItem);

            // Add the MenuStrip to the form
            this.MainMenuStrip = menuStrip;
            Controls.Add(menuStrip);
        }

        // Event handler for 'Log Out' menu item
        private void LogOutMenuItem_Click(object sender, EventArgs e)
        {
            // Open Form2 and close the current form
            frmLogInAccount form2 = new frmLogInAccount();  
            form2.Show();
            this.Close();  
        }

        // Event handler for 'Exit' menu item
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Closes the entire application
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(textBoxPrice.Text);
            int quantity = int.Parse(textBoxQuantity.Text);
            double discount = double.Parse(textBoxDisount.Text);
            discount /= 100;
            double pricePerProduct = price * (1 - discount);
            double total = pricePerProduct * quantity;
            labelTotal.Text = total.ToString();
        }

        private void textBoxPayment_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double payment = double.Parse(textBoxPayment.Text);
            if (payment > total)
            {
                double change = payment - total;
                labelChange.Text = change.ToString();
            }
            else 
            {
                MessageBox.Show("Insufficient amount. ");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
