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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing.Text;

namespace MainCode_Group1
{
    public partial class Form2 : Form
    {
        int stage = 1;
        public string Username;
        private OleDbConnection connection;
        public Form2()
        {
            InitializeComponent();

        }
        public string passingvalue
        {
            get { return Username; }
            set { Username = value; }
        }
        private void Alignment(Control control)
        {
            int x = (this.ClientSize.Width - control.Width) / 2;
            int y = (this.ClientSize.Height - control.Height) / 2;

            control.Location = new Point(x, y);


        }

        private void Form2_Load(object sender, EventArgs e)
        {



            string dbPath = @"C:\Users\ngigi\OneDrive\Documents\Software_project\BackEndCode\MainCode_Group1";
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ngigi\OneDrive\Documents\Software_project\BackEndCode\MainCode_Group1\MainCode_Group1\Database21Old.mdb";

            connection = new OleDbConnection(connectionString);
            connection.Open();

            Alignment(tomato_check);
            Alignment(Sugarcane_Check);
            Alignment(Tea_Check);
            Alignment(Maize_Check);
            Alignment(Next_Btn);

            int leftPostion = 600;
            tomato_check.Location = new Point(leftPostion, tomato_check.Location.Y);
            int leftPostion1 = 350;
            Tea_Check.Location = new Point(leftPostion1, Tea_Check.Location.Y);
            int leftPostion2 = 1100;
            Sugarcane_Check.Location = new Point(leftPostion2, Sugarcane_Check.Location.Y);
            int leftPostion3 = 850;
            Maize_Check.Location = new Point(leftPostion3, Maize_Check.Location.Y);
            Next_Btn.Location = new Point(Next_Btn.Location.X, 600);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Tea_Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Maize_Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Next_Btn_Click(object sender, EventArgs e)
        {


            Sugarcane_Check.Checked = false;
            Maize_Check.Checked = false;
            Tea_Check.Checked = false; 
            tomato_check.Checked = false;
                int Sugarcane = 0;
                int Maize = 0;
                int Tea = 0;
                int Tomato = 0;
                if (Sugarcane_Check.Checked) { Sugarcane = 1; };
                if (Maize_Check.Checked) { Maize = 2; };
                if (Tea_Check.Checked) { Tea = 4; };
                if (tomato_check.Checked) { Tomato = 8; };
                string defaultUsername = "rd";
                if (string.IsNullOrEmpty(Username)) // Check if Username is null or empty
                {
                    Username = defaultUsername; // Assign the default value
                }


                string query1 = "UPDATE Users SET Plants = @Plants WHERE Username = @Username";

                    using (OleDbCommand command = new OleDbCommand(query1, connection))
                    {
                        command.Parameters.AddWithValue("@Plants", Sugarcane + Maize + Tea + Tomato);
                        command.Parameters.AddWithValue("@Username", Username);

                        command.ExecuteNonQuery();
                        
                    }

               
                stage++;


            
            if (stage == 2)
            {
                int Maize1 = 0;
                int Tea1 = 0;
                int Tomato1 = 0;

                tomato_check.Checked = false;
                Maize_Check.Checked = false;
                tomato_check.Checked = false;

                Alignment(tomato_check);
                Alignment(Sugarcane_Check);
                Alignment(Tea_Check);
                Alignment(Maize_Check);

                int topPostion = 400;
                tomato_check.Location = new Point(tomato_check.Location.X, topPostion);
                int topPostion1 = 350;
                Maize_Check.Location = new Point(Maize_Check.Location.X, topPostion1);
                int topPostion2 = 300;
                Tea_Check.Location = new Point(Tea_Check.Location.X, topPostion2);
                Sugarcane_Check.Hide();

                tomato_check.Text = "Soil pH Sensor";
                Maize_Check.Text = "Soil Moisture Sensor";
                Tea_Check.Text = "Temperature Sensor";

                string query = "UPDATE Users SET Sensors = @Sensors WHERE Username = @Username";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Sensors", Maize1 + Tea1 + Tomato1);
                    command.Parameters.AddWithValue("@Username", Username);

                    command.ExecuteNonQuery();

                }

                

            }
            else
            {
                Form3 f3 = new Form3();
                this.Hide();
                f3.StartPosition = FormStartPosition.CenterScreen;
                f3.FormClosed += (s, args) => this.Close();
                f3.Show();
            }
            
            
                
            
            
        }
    }
}
