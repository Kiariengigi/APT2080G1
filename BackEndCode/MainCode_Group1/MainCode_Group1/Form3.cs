using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainCode_Group1
{
    public partial class Form3 : Form
    {

        static void D_Result(int[] plants)
        {
            
        }
        //pH values 
        double[,] ph = { { 6.0, 6.5 }, { 4.5, 6.0 }, { 5.8, 6.0 }, { 6.2, 6.8 } };

        //Temo and Moisture Values
        int[,] Temp = { { 32, 27 }, { 30, 18 }, { 22, 20 }, { 27, 21 } };
        int[,] Moist = { { 65, 45 }, { 85, 75 }, { 65, 55 }, { 85, 65 } };
        int [,] plants = { { 0, 0 }, {0, 0 },{ 0, 0 }, { 0, 0 } };


        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            CheckBox[] checkBox = { checkBox0, checkBox1, checkBox2, checkBox3 };

            for (int q = 0; q < 4; q++)
            {
                checkBox[q].Checked = false;
            }
            TextBox[] pH_Read = { pH_Read0, pH_Read1, pH_Read2, pH_Read3 };
            TextBox[] Temp_Read = { Temp_Read0, Temp_Read1, Temp_Read2, Temp_Read3 };
            TextBox[] Moisture_Read = { Moisture_Read0, Moisture_Read1, Moisture_Read2, Moisture_Read3 };
            
            for (int y = 0; y < 4; y++)
            {
                if (string.IsNullOrEmpty(Temp_Read[0].Text))
                {
                    MessageBox.Show("No entered data", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    //pH Checking
                    for (int x = 0; x < 4; x++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            double reading;

                            double.TryParse(pH_Read[k].Text, out reading);

 

                            if (reading < ph[k, 0] || reading > ph[k, 1])
                            {
                                checkBox[k].Checked = true;
                                plants[k,0]++;
                                plants[k,1]++;
                                

                            }
                            

                            continue;

                        }
                        //Temp Checking
                        for (int i = 0; i < 4; i++)
                        {
                            double reading;

                            double.TryParse(Temp_Read[i].Text, out reading);

                            

                            if (reading > Temp[i, 0] || reading < Temp[i, 1])
                            {
                                checkBox[i].Checked = true;
                                plants[i,0]++;
                                plants[i,1]++;
                            }
                            
                            continue;

                        }
                        //Moisture Checking
                        for (int i = 0; i < 4; i++)
                        {
                            double reading;

                            double.TryParse(Moisture_Read[i].Text, out reading);

                          

                            if (reading > Moist[i, 0] || reading < Moist[i, 1])
                            {
                                checkBox[i].Checked = true;
                                plants[i,0]++;
                                plants[i,1]++;

                            }
                            


                        }
                        return; 
                    }
                    

                }
            }
        }



     

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox[] pH_Read = { pH_Read0, pH_Read1, pH_Read2, pH_Read3 };
            TextBox[] Temp_Read = { Temp_Read0, Temp_Read1, Temp_Read2, Temp_Read3 };
            TextBox[] Moisture_Read = { Moisture_Read0, Moisture_Read1, Moisture_Read2, Moisture_Read3 };
            for (int i = 0;i < 4;i++)
            {
                double reading;

                double.TryParse(pH_Read[i].Text, out reading);

                reading = ph[i, 0];

                pH_Read[i].Text = $"{reading}";

                double reading1;

                double.TryParse(Temp_Read[i].Text, out reading);

                reading1 = Temp[i, 0];

                Temp_Read[i].Text = $"{reading1}";

                double reading2;

                double.TryParse(Moisture_Read[i].Text, out reading);

                reading2 = Moist[i, 0];

                Moisture_Read[i].Text = $"{reading2}";




            }
        }
    }
}
