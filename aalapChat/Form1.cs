using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace aalapChat
{
    public partial class Form1 : Form
    {
        Thread th;
        dbSet db = new dbSet();

        public Form1()
        {
            InitializeComponent();
            passTextBox.PasswordChar = '*';
        }

        private void register_Click(object sender, EventArgs e)
        {
            string q = "SELECT `mem_id`, `name` FROM `membertable` WHERE `user_name` = '" + unTextBoxIn.Text + "' or `email`= '" + emailTextBox.Text + "'";


            int registerRowNum =db.registerRow(q);


            if (registerRowNum == 0)
            {
                if (unTextBoxIn.Text.Length == 0 || emailTextBox.Text.Length == 0 || passTextBoxIn.Text.Length == 0 || nameTextIn.Text.Length == 0)
                {
                    MessageBox.Show("Please fill all the textboxes");
                }

                else
                {
                    string insertQuery = "INSERT INTO `membertable`(`name`, `email`, `user_name`, `password`) VALUES ('" + nameTextIn.Text + "','" + emailTextBox.Text + "','" + unTextBoxIn.Text + "','" + passTextBoxIn.Text+ "')";
                    db.sendQuery(insertQuery);
                    regWarning.Text = "Registration Successful! Please login now";
                }
            }
            else if (registerRowNum == -1)
            {
                regWarning.Text = "Sorry!! Error in server.";
            }
            else if (registerRowNum > 0)
            {
                regWarning.Text = "This Email or User Name already exist";
            }
            else
            {
                regWarning.Text = "Error!";
            }
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void warningText_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void nameIn_Click(object sender, EventArgs e)
        {

        }

        private void nameTextIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailIn_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unIn_Click(object sender, EventArgs e)
        {

        }

        private void unTextBoxIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void passIn_Click(object sender, EventArgs e)
        {

        }

        private void passTextBoxIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void regWarning_Click(object sender, EventArgs e)
        {

        }


        private void login_Click_1(object sender, EventArgs e)
        {
            if (unTextBox.Text.Length != 0 && unTextBox.Text.Length != 0)
            {
                string query = "SELECT `mem_id`, `name`, `email`, `user_name` FROM `membertable` WHERE user_name='" + unTextBox.Text + "' and password='" + passTextBox.Text + "'";
                int rowNum = db.loginRow(query);
                if (rowNum == 0) //query sends to connect will get an int variabe(how many rows are there if it is 0 nothing is there.);
                {
                    warningText.Text = "Inavlid Username or Passward";
                }
                else if (rowNum == -1)
                {
                    warningText.Text = "Error Occured";
                }
                else
                {
                    //MainChatBox fm = new MainChatBox();
                    // fm.Show();    //opening 2nd class object manually without theading.

                    db = null;
                    this.Close();
                    th = new Thread(openNewForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }
            }
            else
            {
                warningText.Text = "You forgot to enter Username ans Passowrd";
            }

        }


        private void openNewForm(Object obj)
        {

            Application.Run(new MainChatBox());
            
        }

        private void passTextBox_TextChanged_1(object sender, EventArgs e)
        {
        
        }

        private void warningText_Click_1(object sender, EventArgs e)
        {

        }

        private void unTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void passTextBoxIn_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void emailTextBoxIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void passTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 13)
            {
                login_Click_1(sender, e);
            }
        }

        private void passTextBoxIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 13)
            {
                register_Click(sender, e);
            }
        }




    }
}
