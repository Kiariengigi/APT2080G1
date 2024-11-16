using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using Org.BouncyCastle.Bcpg;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MainCode_Group1
{
    public partial class Form1 : Form
    { 
        private OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbPath = @"C:\Users\ngigi\OneDrive\Documents\Software_project\BackEndCode\MainCode_Group1";
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ngigi\OneDrive\Documents\Software_project\BackEndCode\MainCode_Group1\MainCode_Group1\Database21Old.mdb";

            connection = new OleDbConnection(connectionString);
            connection.Open();
        }



        private void Sign_Up_btn_Click(object sender, EventArgs e)
        {
            Sign_Up_btn.Visible = false;
            Sign_In_btn.Visible = false;
            Sign_In_btn1.Visible = this.Visible;
            Sign_up_btn1.Visible = this.Visible;
            Username.Visible = this.Visible;
            Password.Visible = this.Visible;
            Confirm_Pass.Visible = this.Visible;
        }

        private void Sign_In_btn_Click(object sender, EventArgs e)
        {
            Sign_Up_btn.Visible = false;
            Sign_In_btn.Visible = false;
            Sign_up_btn1.Location = new Point(100, 295);
            Sign_In_btn1.Location = new Point(100, 250);
            Sign_In_btn1.Visible = this.Visible;
            Sign_up_btn1.Visible = this.Visible;
            Password.Location = new Point(113, 200);
            Username.Location = new Point(113, 150);
            Username.Visible = this.Visible;
            Password.Visible = this.Visible;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_up_btn1_Click(object sender, EventArgs e)
        {
            if (Confirm_Pass.Visible == false)
            {
                Confirm_Pass.Visible = this.Visible;
                Password.Location = new Point(113, 165);
                Username.Location = new Point(113, 130);
                Sign_In_btn1.Location = new Point(100, 295);
                Sign_up_btn1.Location = new Point(100, 250);
            }
            else
            {
                if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
                {
                    MessageBox.Show("Please Enter a Username and Password");
                }
                else
                {
                    if (Password.Text == Confirm_Pass.Text)
                    {
                        if (connection != null && connection.State == System.Data.ConnectionState.Open)
                        {
                            string cheeckquery = "SELECT COUNT(*) FROM Users WHERE Username = ?";
                            using (OleDbCommand checkusercommand = new OleDbCommand(cheeckquery, connection))
                            {
                                checkusercommand.Parameters.AddWithValue("?", Username.Text);
                                int usercount = (int)checkusercommand.ExecuteScalar();
                                if (usercount > 0)
                                {
                                    MessageBox.Show("User already registered");
                                    return;
                                }

                            }
                            string query = "INSERT INTO Users (Username, [Password]) VALUES (@Username, @Password)";

                            using (OleDbCommand command = new OleDbCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Username", Username.Text);
                                command.Parameters.AddWithValue("@Password", Password.Text);

                                int result = command.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Welcome " + Username.Text);
                                    this.Hide();
                                    Form2 f2 = new Form2();
                                    f2.passingvalue = Username.Text;    
                                    f2.ShowDialog();    
                                    f2.StartPosition = FormStartPosition.CenterScreen;
                                    f2.FormClosed += (s, args) => this.Close();
                                    f2.Show();
                                }
                                else
                                {
                                    MessageBox.Show("There is already a user with those credentials");
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Connection is not open");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not Match");
                    }
                }


            }
            

            
        }

        private void Sign_In_btn1_Click(object sender, EventArgs e)
        {
            if (Confirm_Pass.Visible)
            {
                //confirm pass visible 
                Confirm_Pass.Visible = false;
                Password.Location = new Point(113, 185);
                Username.Location = new Point(113, 150);
                Sign_up_btn1.Location = new Point(100, 305);
                Sign_In_btn1.Location = new Point(100, 240);

            }
            else
            {
                //confirm pass is not visible
                if (string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(Username.Text))
                {
                    MessageBox.Show("Please enter Username and Password");

                }
                else
                {
                    string cheeckquery = "SELECT COUNT(*) FROM Users WHERE Username = ? AND [Password] = ?";
                    using (OleDbCommand checkusercommand = new OleDbCommand(cheeckquery, connection))
                    {
                        checkusercommand.Parameters.AddWithValue("?", Username.Text);
                        checkusercommand.Parameters.AddWithValue("?", Password.Text);
                        int usercount = (int)checkusercommand.ExecuteScalar();
                        if (usercount > 0)
                        {
                            MessageBox.Show("Welcome back " + Username.Text);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password ");
                        }
                    }


                }
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.FormClosed += (s, args) => this.Close();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.FormClosed += (s, args) => this.Close();
            f3.Show();
        }
    }
}




