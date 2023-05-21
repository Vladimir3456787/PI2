using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pI2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || comboBox2.SelectedIndex <= -1)
            {
                MessageBox.Show("Ошибка ввода, проверьте значения");
            }
            else
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    double a = 2.4;
                    double b = 1.05;
                    double c = 2.5;
                    double d = 0.38;

                    double PM = a * Math.Pow(Convert.ToDouble(textBox1.Text), b);
                    double TM = c * Math.Pow(PM, d);

                    label9.Text = Convert.ToString(PM);
                    label3.Text = Convert.ToString(TM);
                }
                if (comboBox2.SelectedIndex == 1)
                {
                    double a = 3;
                    double b = 1.12;
                    double c = 2.5;
                    double d = 0.35;

                    double PM = a * Math.Pow(Convert.ToDouble(textBox1.Text), b);
                    double TM = c * Math.Pow(PM, d);

                    label9.Text = Convert.ToString(PM);
                    label3.Text = Convert.ToString(TM);
                }
                if (comboBox2.SelectedIndex == 2)
                {
                    double a = 3.6;
                    double b = 1.20;
                    double c = 2.5;
                    double d = 0.32;

                    double PM = a * Math.Pow(Convert.ToDouble(textBox1.Text), b);
                    double TM = c * Math.Pow(PM, d);

                    label9.Text = Convert.ToString(PM);
                    label3.Text = Convert.ToString(TM);
                }
            }
            
           
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || comboBox3.SelectedIndex <= -1 || comboBox1.SelectedIndex <= -1 || comboBox4.SelectedIndex <= -1 || comboBox5.SelectedIndex <= -1 || comboBox6.SelectedIndex <= -1 || comboBox7.SelectedIndex <= -1 || comboBox8.SelectedIndex <= -1 || comboBox9.SelectedIndex <= -1 || comboBox10.SelectedIndex <= -1 || comboBox11.SelectedIndex <= -1 || comboBox12.SelectedIndex <= -1 || comboBox13.SelectedIndex <= -1 || comboBox14.SelectedIndex <= -1 || comboBox15.SelectedIndex <= -1 || comboBox16.SelectedIndex <= -1 || comboBox17.SelectedIndex <= -1)
            {
                MessageBox.Show("Ошибка ввода, проверьте значения"); 
            }
            else
            {
                double m1 = 0;
                double m2 = 0;
                double m3 = 0;
                double m4 = 0;
                double m5 = 0;
                double m6 = 0;
                double m7 = 0;
                double m8 = 0;
                double m9 = 0;
                double m10 = 0;
                double m11 = 0;
                double m12 = 0;
                double m13 = 0;
                double m14 = 0;
                double m15 = 0;

                // 1 показатель
                if (comboBox3.SelectedIndex == 0)
                {
                    m1 = 0.75;
                }
                if (comboBox3.SelectedIndex == 1)
                {
                    m1 = 0.88;
                }
                if (comboBox3.SelectedIndex == 2)
                {
                    m1 = 1;
                }
                if (comboBox3.SelectedIndex == 3)
                {
                    m1 = 1.15;
                }
                if (comboBox3.SelectedIndex == 4)
                {
                    m1 = 1.4;
                }
                if (comboBox3.SelectedIndex == 5)
                {
                    m1 = 1;
                }
                // 2 показатель
                if (comboBox4.SelectedIndex == 0)
                {
                    m2 = 1;
                }
                if (comboBox4.SelectedIndex == 1)
                {
                    m2 = 0.94;
                }
                if (comboBox4.SelectedIndex == 2)
                {
                    m2 = 1;
                }
                if (comboBox4.SelectedIndex == 3)
                {
                    m2 = 1.08;
                }
                if (comboBox4.SelectedIndex == 4)
                {
                    m2 = 1.16;
                }
                if (comboBox4.SelectedIndex == 5)
                {
                    m2 = 1;
                }
                // 3 показатель
                if (comboBox5.SelectedIndex == 0)
                {
                    m3 = 0.7;
                }
                if (comboBox5.SelectedIndex == 1)
                {
                    m3 = 0.85;
                }
                if (comboBox5.SelectedIndex == 2)
                {
                    m3 = 1;
                }
                if (comboBox5.SelectedIndex == 3)
                {
                    m3 = 1.15;
                }
                if (comboBox5.SelectedIndex == 4)
                {
                    m3 = 1.3;
                }
                if (comboBox5.SelectedIndex == 5)
                {
                    m3 = 1.65;
                }
                // 4 показатель
                if (comboBox6.SelectedIndex == 0)
                {
                    m4 = 1;
                }
                if (comboBox6.SelectedIndex == 1)
                {
                    m4 = 1;
                }
                if (comboBox6.SelectedIndex == 2)
                {
                    m4 = 1;
                }
                if (comboBox6.SelectedIndex == 3)
                {
                    m4 = 1.11;
                }
                if (comboBox6.SelectedIndex == 4)
                {
                    m4 = 1.3;
                }
                if (comboBox6.SelectedIndex == 5)
                {
                    m4 = 1.66;
                }
                // 5 показатель
                if (comboBox7.SelectedIndex == 0)
                {
                    m5 = 1;
                }
                if (comboBox7.SelectedIndex == 1)
                {
                    m5 = 1;
                }
                if (comboBox7.SelectedIndex == 2)
                {
                    m5 = 1;
                }
                if (comboBox7.SelectedIndex == 3)
                {
                    m5 = 1.06;
                }
                if (comboBox7.SelectedIndex == 4)
                {
                    m5 = 1.21;
                }
                if (comboBox7.SelectedIndex == 5)
                {
                    m5 = 1.56;
                }
                // 6 показатель
                if (comboBox8.SelectedIndex == 0)
                {
                    m6 = 1;
                }
                if (comboBox8.SelectedIndex == 1)
                {
                    m6 = 0.87;
                }
                if (comboBox8.SelectedIndex == 2)
                {
                    m6 = 1;
                }
                if (comboBox8.SelectedIndex == 3)
                {
                    m6 = 1.15;
                }
                if (comboBox8.SelectedIndex == 4)
                {
                    m6 = 1.3;
                }
                if (comboBox8.SelectedIndex == 5)
                {
                    m6 = 1;
                }
                // 7 показатель
                if (comboBox9.SelectedIndex == 0)
                {
                    m7 = 1;
                }
                if (comboBox9.SelectedIndex == 1)
                {
                    m7 = 0.87;
                }
                if (comboBox9.SelectedIndex == 2)
                {
                    m7 = 1;
                }
                if (comboBox9.SelectedIndex == 3)
                {
                    m7 = 1.07;
                }
                if (comboBox9.SelectedIndex == 4)
                {
                    m7 = 1.15;
                }
                if (comboBox9.SelectedIndex == 5)
                {
                    m7 = 1;
                }
                // 8 показатель
                if (comboBox10.SelectedIndex == 0)
                {
                    m8 = 1.46;
                }
                if (comboBox10.SelectedIndex == 1)
                {
                    m8 = 1.19;
                }
                if (comboBox10.SelectedIndex == 2)
                {
                    m8 = 1;
                }
                if (comboBox10.SelectedIndex == 3)
                {
                    m8 = 0.86;
                }
                if (comboBox10.SelectedIndex == 4)
                {
                    m8 = 0.71;
                }
                if (comboBox10.SelectedIndex == 5)
                {
                    m8 = 1;
                }
                // 9 показатель
                if (comboBox11.SelectedIndex == 0)
                {
                    m9 = 1.29;
                }
                if (comboBox11.SelectedIndex == 1)
                {
                    m9 = 1.13;
                }
                if (comboBox11.SelectedIndex == 2)
                {
                    m9 = 1;
                }
                if (comboBox11.SelectedIndex == 3)
                {
                    m9 = 0.91;
                }
                if (comboBox11.SelectedIndex == 4)
                {
                    m9 = 0.82;
                }
                if (comboBox11.SelectedIndex == 5)
                {
                    m9 = 1;
                }
                // 10 показатель
                if (comboBox12.SelectedIndex == 0)
                {
                    m10 = 1.42;
                }
                if (comboBox12.SelectedIndex == 1)
                {
                    m10 = 1.17;
                }
                if (comboBox12.SelectedIndex == 2)
                {
                    m10 = 1;
                }
                if (comboBox12.SelectedIndex == 3)
                {
                    m10 = 0.86;
                }
                if (comboBox12.SelectedIndex == 4)
                {
                    m10 = 0.7;
                }
                if (comboBox12.SelectedIndex == 5)
                {
                    m10 = 1;
                }
                // 11 показатель
                if (comboBox13.SelectedIndex == 0)
                {
                    m11 = 1.21;
                }
                if (comboBox13.SelectedIndex == 1)
                {
                    m11 = 1.10;
                }
                if (comboBox13.SelectedIndex == 2)
                {
                    m11 = 1;
                }
                if (comboBox13.SelectedIndex == 3)
                {
                    m11 = 0.9;
                }
                if (comboBox13.SelectedIndex == 4)
                {
                    m11 = 1;
                }
                if (comboBox13.SelectedIndex == 5)
                {
                    m11 = 1;
                }
                // 12 показатель
                if (comboBox14.SelectedIndex == 0)
                {
                    m12 = 1.14;
                }
                if (comboBox14.SelectedIndex == 1)
                {
                    m12 = 1.07;
                }
                if (comboBox14.SelectedIndex == 2)
                {
                    m12 = 1;
                }
                if (comboBox14.SelectedIndex == 3)
                {
                    m12 = 0.95;
                }
                if (comboBox14.SelectedIndex == 4)
                {
                    m12 = 1;
                }
                if (comboBox14.SelectedIndex == 5)
                {
                    m12 = 1;
                }
                // 13 показатель
                if (comboBox15.SelectedIndex == 0)
                {
                    m13 = 1.24;
                }
                if (comboBox15.SelectedIndex == 1)
                {
                    m13 = 1.1;
                }
                if (comboBox15.SelectedIndex == 2)
                {
                    m13 = 1;
                }
                if (comboBox15.SelectedIndex == 3)
                {
                    m13 = 0.91;
                }
                if (comboBox15.SelectedIndex == 4)
                {
                    m13 = 0.82;
                }
                if (comboBox15.SelectedIndex == 5)
                {
                    m13 = 1;
                }
                // 14 показатель
                if (comboBox16.SelectedIndex == 0)
                {
                    m14 = 1.24;
                }
                if (comboBox16.SelectedIndex == 1)
                {
                    m14 = 1.1;
                }
                if (comboBox16.SelectedIndex == 2)
                {
                    m14 = 1;
                }
                if (comboBox16.SelectedIndex == 3)
                {
                    m14 = 0.91;
                }
                if (comboBox16.SelectedIndex == 4)
                {
                    m14 = 0.83;
                }
                if (comboBox16.SelectedIndex == 5)
                {
                    m14 = 1;
                }
                // 15 показатель
                if (comboBox17.SelectedIndex == 0)
                {
                    m15 = 1.23;
                }
                if (comboBox17.SelectedIndex == 1)
                {
                    m15 = 1.08;
                }
                if (comboBox17.SelectedIndex == 2)
                {
                    m15 = 1;
                }
                if (comboBox17.SelectedIndex == 3)
                {
                    m15 = 1.04;
                }
                if (comboBox17.SelectedIndex == 4)
                {
                    m15 = 1.1;
                }
                if (comboBox17.SelectedIndex == 5)
                {
                    m15 = 1;
                }
                // основной расчет
                if (comboBox1.SelectedIndex == 0)
                {
                    double a = 3.2;
                    double b = 1.05;
                    double c = 2.5;
                    double d = 0.38;

                    double EAF = m1 * m2 * m3 * m4 * m5 * m6 * m7 * m8 * m9 * m10 * m11 * m12 * m13 * m14 * m15;
                    double PM = EAF * a * Math.Pow(Convert.ToDouble(textBox2.Text), b);
                    double TM = c * Math.Pow(PM, d);
                    label28.Text = Convert.ToString(PM);
                    label31.Text = Convert.ToString(TM);
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    double a = 3;
                    double b = 1.12;
                    double c = 2.5;
                    double d = 0.35;

                    double EAF = m1 * m2 * m3 * m4 * m5 * m6 * m7 * m8 * m9 * m10 * m11 * m12 * m13 * m14 * m15;
                    double PM = EAF * a * Math.Pow(Convert.ToDouble(textBox2.Text), b);
                    double TM = c * Math.Pow(PM, d);
                    label28.Text = Convert.ToString(PM);
                    label31.Text = Convert.ToString(TM);
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    double a = 2.8;
                    double b = 1.2;
                    double c = 2.5;
                    double d = 0.32;

                    double EAF = m1 * m2 * m3 * m4 * m5 * m6 * m7 * m8 * m9 * m10 * m11 * m12 * m13 * m14 * m15;
                    double PM = EAF * a * Math.Pow(Convert.ToDouble(textBox2.Text), b);
                    double TM = c * Math.Pow(PM, d);
                    label28.Text = Convert.ToString(PM);
                    label31.Text = Convert.ToString(TM);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || comboBox18.SelectedIndex <= -1 || comboBox19.SelectedIndex <= -1 || comboBox20.SelectedIndex <= -1 || comboBox21.SelectedIndex <= -1 || comboBox22.SelectedIndex <= -1 || comboBox23.SelectedIndex <= -1 || comboBox24.SelectedIndex <= -1 || comboBox25.SelectedIndex <= -1 || comboBox26.SelectedIndex <= -1 || comboBox27.SelectedIndex <= -1 || comboBox28.SelectedIndex <= -1 || comboBox29.SelectedIndex <= -1)
            {
                MessageBox.Show("Ошибка ввода, проверьте значения");
            }
            else
            {
                double A = 2.94;
                double B = 0.91;

                double k1 = 0;
                double k2 = 0;
                double k3 = 0;
                double k4 = 0;
                double k5 = 0;

                double t1 = 0;
                double t2 = 0;
                double t3 = 0;
                double t4 = 0;
                double t5 = 0;
                double t6 = 0;
                double t7 = 0;


                // 1 показатель
                if (comboBox22.SelectedIndex == 0)
                {
                    k1 = 6.20;
                }
                if (comboBox22.SelectedIndex == 1)
                {
                    k1 = 4.96;
                }
                if (comboBox22.SelectedIndex == 2)
                {
                    k1 = 3.72;
                }
                if (comboBox22.SelectedIndex == 3)
                {
                    k1 = 2.48;
                }
                if (comboBox22.SelectedIndex == 4)
                {
                    k1 = 1.24;
                }
                if (comboBox22.SelectedIndex == 5)
                {
                    k1 = 0;
                }
                // 2 показатель
                if (comboBox21.SelectedIndex == 0)
                {
                    k2 = 5.07;
                }
                if (comboBox21.SelectedIndex == 1)
                {
                    k2 = 4.05;
                }
                if (comboBox21.SelectedIndex == 2)
                {
                    k2 = 3.04;
                }
                if (comboBox21.SelectedIndex == 3)
                {
                    k2 = 2.03;
                }
                if (comboBox21.SelectedIndex == 4)
                {
                    k2 = 1.01;
                }
                if (comboBox21.SelectedIndex == 5)
                {
                    k2 = 0;
                }
                // 3 показатель
                if (comboBox20.SelectedIndex == 0)
                {
                    k3 = 7.07;
                }
                if (comboBox20.SelectedIndex == 1)
                {
                    k3 = 5.65;
                }
                if (comboBox20.SelectedIndex == 2)
                {
                    k3 = 4.24;
                }
                if (comboBox20.SelectedIndex == 3)
                {
                    k3 = 2.83;
                }
                if (comboBox20.SelectedIndex == 4)
                {
                    k3 = 1.41;
                }
                if (comboBox20.SelectedIndex == 5)
                {
                    k3 = 0;
                }
                // 4 показатель
                if (comboBox19.SelectedIndex == 0)
                {
                    k4 = 5.48;
                }
                if (comboBox19.SelectedIndex == 1)
                {
                    k4 = 4.38;
                }
                if (comboBox19.SelectedIndex == 2)
                {
                    k4 = 3.29;
                }
                if (comboBox19.SelectedIndex == 3)
                {
                    k4 = 2.19;
                }
                if (comboBox19.SelectedIndex == 4)
                {
                    k4 = 1.1;
                }
                if (comboBox19.SelectedIndex == 5)
                {
                    k4 = 0;
                }
                // 5 показатель
                if (comboBox18.SelectedIndex == 0)
                {
                    k5 = 7.8;
                }
                if (comboBox18.SelectedIndex == 1)
                {
                    k5 = 6.24;
                }
                if (comboBox18.SelectedIndex == 2)
                {
                    k5 = 4.68;
                }
                if (comboBox18.SelectedIndex == 3)
                {
                    k5 = 3.12;
                }
                if (comboBox18.SelectedIndex == 4)
                {
                    k5 = 1.56;
                }
                if (comboBox18.SelectedIndex == 5)
                {
                    k5 = 0;
                }
                // 1 показатель
                if (comboBox29.SelectedIndex == 0)
                {
                    t1 = 2.12;
                }
                if (comboBox29.SelectedIndex == 1)
                {
                    t1 = 1.62;
                }
                if (comboBox29.SelectedIndex == 2)
                {
                    t1 = 1.26;
                }
                if (comboBox29.SelectedIndex == 3)
                {
                    t1 = 1;
                }
                if (comboBox29.SelectedIndex == 4)
                {
                    t1 = 0.83;
                }
                if (comboBox29.SelectedIndex == 5)
                {
                    t1 = 0.63;
                }
                if (comboBox29.SelectedIndex == 5)
                {
                    t1 = 0.5;
                }
                // 2 показатель
                if (comboBox28.SelectedIndex == 0)
                {
                    t2 = 1.59;
                }
                if (comboBox28.SelectedIndex == 1)
                {
                    t2 = 1.33;
                }
                if (comboBox28.SelectedIndex == 2)
                {
                    t2 = 1.22;
                }
                if (comboBox28.SelectedIndex == 3)
                {
                    t2 = 1;
                }
                if (comboBox28.SelectedIndex == 4)
                {
                    t2 = 0.87;
                }
                if (comboBox28.SelectedIndex == 5)
                {
                    t2 = 0.74;
                }
                if (comboBox28.SelectedIndex == 5)
                {
                    t2 = 0.62;
                }
                // 3 показатель
                if (comboBox27.SelectedIndex == 0)
                {
                    t3 = 0.49;
                }
                if (comboBox27.SelectedIndex == 1)
                {
                    t3 = 0.6;
                }
                if (comboBox27.SelectedIndex == 2)
                {
                    t3 = 0.83;
                }
                if (comboBox27.SelectedIndex == 3)
                {
                    t3 = 1;
                }
                if (comboBox27.SelectedIndex == 4)
                {
                    t3 = 1.33;
                }
                if (comboBox27.SelectedIndex == 5)
                {
                    t3 = 1.91;
                }
                if (comboBox27.SelectedIndex == 5)
                {
                    t3 = 2.72;
                }
                // 4 показатель
                if (comboBox26.SelectedIndex == 0)
                {
                    t4 = 1;
                }
                if (comboBox26.SelectedIndex == 1)
                {
                    t4 = 1;
                }
                if (comboBox26.SelectedIndex == 2)
                {
                    t4 = 0.95;
                }
                if (comboBox26.SelectedIndex == 3)
                {
                    t4 = 1;
                }
                if (comboBox26.SelectedIndex == 4)
                {
                    t4 = 1.07;
                }
                if (comboBox26.SelectedIndex == 5)
                {
                    t4 = 1.15;
                }
                if (comboBox26.SelectedIndex == 5)
                {
                    t4 = 1.24;
                }
                // 5 показатель
                if (comboBox25.SelectedIndex == 0)
                {
                    t5 = 1;
                }
                if (comboBox25.SelectedIndex == 1)
                {
                    t5 = 1;
                }
                if (comboBox25.SelectedIndex == 2)
                {
                    t5 = 0.87;
                }
                if (comboBox25.SelectedIndex == 3)
                {
                    t5 = 1;
                }
                if (comboBox25.SelectedIndex == 4)
                {
                    t5 = 1.29;
                }
                if (comboBox25.SelectedIndex == 5)
                {
                    t5 = 1.81;
                }
                if (comboBox25.SelectedIndex == 5)
                {
                    t5 = 2.61;
                }
                // 6 показатель
                if (comboBox24.SelectedIndex == 0)
                {
                    t6 = 1.43;
                }
                if (comboBox24.SelectedIndex == 1)
                {
                    t6 = 1.3;
                }
                if (comboBox24.SelectedIndex == 2)
                {
                    t6 = 1.1;
                }
                if (comboBox24.SelectedIndex == 3)
                {
                    t6 = 1;
                }
                if (comboBox24.SelectedIndex == 4)
                {
                    t6 = 0.87;
                }
                if (comboBox24.SelectedIndex == 5)
                {
                    t6 = 0.73;
                }
                if (comboBox24.SelectedIndex == 5)
                {
                    t6 = 0.62;
                }
                // 7 показатель
                if (comboBox23.SelectedIndex == 0)
                {
                    t7 = 1;
                }
                if (comboBox23.SelectedIndex == 1)
                {
                    t7 = 1.43;
                }
                if (comboBox23.SelectedIndex == 2)
                {
                    t7 = 1.14;
                }
                if (comboBox23.SelectedIndex == 3)
                {
                    t7 = 1;
                }
                if (comboBox23.SelectedIndex == 4)
                {
                    t7 = 1;
                }
                if (comboBox23.SelectedIndex == 5)
                {
                    t7 = 1;
                }
                if (comboBox23.SelectedIndex == 5)
                {
                    t7 = 1;
                }

                double SF = k1 + k2 + k3 + k4 + k5;
                double EAF = t1 * t2 * t3 * t4 * t5 * t6 * t7;

                double E = B + 0.01 * SF;
                double PM = EAF * A * Math.Pow(Convert.ToDouble(textBox3.Text), E);

                double C = 3.67;
                double D = 0.28;
                double EAFns = t1 * t2 * t3 * t4 * t5 * t6;
                double PMns = EAFns * A * Math.Pow(Convert.ToDouble(textBox3.Text), E);
                double TM = t7 * C * Math.Pow(PMns, D+0.2*(E-B));
                label47.Text = Convert.ToString(PM);
                label45.Text = Convert.ToString(TM);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || comboBox30.SelectedIndex <= -1 || comboBox31.SelectedIndex <= -1 || comboBox32.SelectedIndex <= -1 || comboBox33.SelectedIndex <= -1 || comboBox34.SelectedIndex <= -1 || comboBox35.SelectedIndex <= -1 || comboBox36.SelectedIndex <= -1 || comboBox37.SelectedIndex <= -1 || comboBox38.SelectedIndex <= -1 || comboBox39.SelectedIndex <= -1 || comboBox40.SelectedIndex <= -1 || comboBox41.SelectedIndex <= -1 || comboBox42.SelectedIndex <= -1 || comboBox43.SelectedIndex <= -1 || comboBox44.SelectedIndex <= -1 || comboBox45.SelectedIndex <= -1 || comboBox46.SelectedIndex <= -1 || comboBox47.SelectedIndex <= -1 || comboBox48.SelectedIndex <= -1 || comboBox49.SelectedIndex <= -1 || comboBox50.SelectedIndex <= -1 || comboBox51.SelectedIndex <= -1)
            {
                MessageBox.Show("Ошибка ввода, проверьте значения");         
            }
            else
            {
                double A = 2.45;
                double B = 0.91;

                double k1 = 0;
                double k2 = 0;
                double k3 = 0;
                double k4 = 0;
                double k5 = 0;

                double t1 = 0;
                double t2 = 0;
                double t3 = 0;
                double t4 = 0;
                double t5 = 0;
                double t6 = 0;
                double t7 = 0;
                double t8 = 0;
                double t9 = 0;
                double t10 = 0;
                double t11 = 0;
                double t12 = 0;
                double t13 = 0;
                double t14 = 0;
                double t15 = 0;
                double t16 = 0;
                double t17 = 0;



                // 1 показатель
                if (comboBox41.SelectedIndex == 0)
                {
                    k1 = 6.20;
                }
                if (comboBox41.SelectedIndex == 1)
                {
                    k1 = 4.96;
                }
                if (comboBox41.SelectedIndex == 2)
                {
                    k1 = 3.72;
                }
                if (comboBox41.SelectedIndex == 3)
                {
                    k1 = 2.48;
                }
                if (comboBox41.SelectedIndex == 4)
                {
                    k1 = 1.24;
                }
                if (comboBox41.SelectedIndex == 5)
                {
                    k1 = 0;
                }
                // 2 показатель
                if (comboBox40.SelectedIndex == 0)
                {
                    k2 = 5.07;
                }
                if (comboBox40.SelectedIndex == 1)
                {
                    k2 = 4.05;
                }
                if (comboBox40.SelectedIndex == 2)
                {
                    k2 = 3.04;
                }
                if (comboBox40.SelectedIndex == 3)
                {
                    k2 = 2.03;
                }
                if (comboBox40.SelectedIndex == 4)
                {
                    k2 = 1.01;
                }
                if (comboBox40.SelectedIndex == 5)
                {
                    k2 = 0;
                }
                // 3 показатель
                if (comboBox39.SelectedIndex == 0)
                {
                    k3 = 7.07;
                }
                if (comboBox39.SelectedIndex == 1)
                {
                    k3 = 5.65;
                }
                if (comboBox39.SelectedIndex == 2)
                {
                    k3 = 4.24;
                }
                if (comboBox39.SelectedIndex == 3)
                {
                    k3 = 2.83;
                }
                if (comboBox39.SelectedIndex == 4)
                {
                    k3 = 1.41;
                }
                if (comboBox39.SelectedIndex == 5)
                {
                    k3 = 0;
                }
                // 4 показатель
                if (comboBox38.SelectedIndex == 0)
                {
                    k4 = 5.48;
                }
                if (comboBox38.SelectedIndex == 1)
                {
                    k4 = 4.38;
                }
                if (comboBox38.SelectedIndex == 2)
                {
                    k4 = 3.29;
                }
                if (comboBox38.SelectedIndex == 3)
                {
                    k4 = 2.19;
                }
                if (comboBox38.SelectedIndex == 4)
                {
                    k4 = 1.1;
                }
                if (comboBox38.SelectedIndex == 5)
                {
                    k4 = 0;
                }
                // 5 показатель
                if (comboBox37.SelectedIndex == 0)
                {
                    k5 = 7.8;
                }
                if (comboBox37.SelectedIndex == 1)
                {
                    k5 = 6.24;
                }
                if (comboBox37.SelectedIndex == 2)
                {
                    k5 = 4.68;
                }
                if (comboBox37.SelectedIndex == 3)
                {
                    k5 = 3.12;
                }
                if (comboBox37.SelectedIndex == 4)
                {
                    k5 = 1.56;
                }
                if (comboBox37.SelectedIndex == 5)
                {
                    k5 = 0;
                }
                // 1 показатель
                if (comboBox36.SelectedIndex == 0)
                {
                    t1 = 1.42;
                }
                if (comboBox36.SelectedIndex == 1)
                {
                    t1 = 1.29;
                }
                if (comboBox36.SelectedIndex == 2)
                {
                    t1 = 1;
                }
                if (comboBox36.SelectedIndex == 3)
                {
                    t1 = 0.85;
                }
                if (comboBox36.SelectedIndex == 4)
                {
                    t1 = 0.71;
                }
                if (comboBox36.SelectedIndex == 5)
                {
                    t1 = 1;
                }
                // 2 показатель
                if (comboBox35.SelectedIndex == 0)
                {
                    t2 = 1.22;
                }
                if (comboBox35.SelectedIndex == 1)
                {
                    t2 = 1.1;
                }
                if (comboBox35.SelectedIndex == 2)
                {
                    t2 = 1;
                }
                if (comboBox35.SelectedIndex == 3)
                {
                    t2 = 0.88;
                }
                if (comboBox35.SelectedIndex == 4)
                {
                    t2 = 0.81;
                }
                if (comboBox35.SelectedIndex == 5)
                {
                    t2 = 1;
                }
                // 3 показатель
                if (comboBox34.SelectedIndex == 0)
                {
                    t3 = 1.34;
                }
                if (comboBox34.SelectedIndex == 1)
                {
                    t3 = 1.15;
                }
                if (comboBox34.SelectedIndex == 2)
                {
                    t3 = 1;
                }
                if (comboBox34.SelectedIndex == 3)
                {
                    t3 = 0.88;
                }
                if (comboBox34.SelectedIndex == 4)
                {
                    t3 = 0.76;
                }
                if (comboBox34.SelectedIndex == 5)
                {
                    t3 = 1;
                }
                // 4 показатель
                if (comboBox33.SelectedIndex == 0)
                {
                    t4 = 1.29;
                }
                if (comboBox33.SelectedIndex == 1)
                {
                    t4 = 1.12;
                }
                if (comboBox33.SelectedIndex == 2)
                {
                    t4 = 1;
                }
                if (comboBox33.SelectedIndex == 3)
                {
                    t4 = 0.9;
                }
                if (comboBox33.SelectedIndex == 4)
                {
                    t4 = 0.81;
                }
                if (comboBox33.SelectedIndex == 5)
                {
                    t4 = 1;
                }
                // 5 показатель
                if (comboBox32.SelectedIndex == 0)
                {
                    t5 = 1.19;
                }
                if (comboBox32.SelectedIndex == 1)
                {
                    t5 = 1.09;
                }
                if (comboBox32.SelectedIndex == 2)
                {
                    t5 = 1;
                }
                if (comboBox32.SelectedIndex == 3)
                {
                    t5 = 0.91;
                }
                if (comboBox32.SelectedIndex == 4)
                {
                    t5 = 0.85;
                }
                if (comboBox32.SelectedIndex == 5)
                {
                    t5 = 1;
                }
                // 6 показатель
                if (comboBox31.SelectedIndex == 0)
                {
                    t6 = 1.2;
                }
                if (comboBox31.SelectedIndex == 1)
                {
                    t6 = 1.09;
                }
                if (comboBox31.SelectedIndex == 2)
                {
                    t6 = 1;
                }
                if (comboBox31.SelectedIndex == 3)
                {
                    t6 = 0.91;
                }
                if (comboBox31.SelectedIndex == 4)
                {
                    t6 = 0.84;
                }
                if (comboBox31.SelectedIndex == 5)
                {
                    t6 = 1;
                }
                // 7 показатель
                if (comboBox30.SelectedIndex == 0)
                {
                    t7 = 0.84;
                }
                if (comboBox30.SelectedIndex == 1)
                {
                    t7 = 0.92;
                }
                if (comboBox30.SelectedIndex == 2)
                {
                    t7 = 1;
                }
                if (comboBox30.SelectedIndex == 3)
                {
                    t7 = 1.1;
                }
                if (comboBox30.SelectedIndex == 4)
                {
                    t7 = 1.26;
                }
                if (comboBox30.SelectedIndex == 5)
                {
                    t7 = 1;
                }
                // 8 показатель
                if (comboBox46.SelectedIndex == 0)
                {
                    t8 = 1;
                }
                if (comboBox46.SelectedIndex == 1)
                {
                    t8 = 0.23;
                }
                if (comboBox46.SelectedIndex == 2)
                {
                    t8 = 1;
                }
                if (comboBox46.SelectedIndex == 3)
                {
                    t8 = 1.14;
                }
                if (comboBox46.SelectedIndex == 4)
                {
                    t8 = 1.28;
                }
                if (comboBox46.SelectedIndex == 5)
                {
                    t8 = 1;
                }
                // 9 показатель
                if (comboBox45.SelectedIndex == 0)
                {
                    t9 = 0.73;
                }
                if (comboBox45.SelectedIndex == 1)
                {
                    t9 = 0.87;
                }
                if (comboBox45.SelectedIndex == 2)
                {
                    t9 = 1;
                }
                if (comboBox45.SelectedIndex == 3)
                {
                    t9 = 1.17;
                }
                if (comboBox45.SelectedIndex == 4)
                {
                    t9 = 1.34;
                }
                if (comboBox45.SelectedIndex == 5)
                {
                    t9 = 1.74;
                }
                // 10 показатель
                if (comboBox44.SelectedIndex == 0)
                {
                    t10 = 1;
                }
                if (comboBox44.SelectedIndex == 1)
                {
                    t10 = 0.95;
                }
                if (comboBox44.SelectedIndex == 2)
                {
                    t10 = 1;
                }
                if (comboBox44.SelectedIndex == 3)
                {
                    t10 = 1.07;
                }
                if (comboBox44.SelectedIndex == 4)
                {
                    t10 = 1.15;
                }
                if (comboBox44.SelectedIndex == 5)
                {
                    t10 = 1.24;
                }
                // 11 показатель
                if (comboBox43.SelectedIndex == 0)
                {
                    t11 = 0.81;
                }
                if (comboBox43.SelectedIndex == 1)
                {
                    t11 = 0.91;
                }
                if (comboBox43.SelectedIndex == 2)
                {
                    t11 = 1;
                }
                if (comboBox43.SelectedIndex == 3)
                {
                    t11 = 1.11;
                }
                if (comboBox43.SelectedIndex == 4)
                {
                    t11 = 1.23;
                }
                if (comboBox43.SelectedIndex == 5)
                {
                    t11 = 1;
                }
                // 12 показатель
                if (comboBox42.SelectedIndex == 0)
                {
                    t12 = 1;
                }
                if (comboBox42.SelectedIndex == 1)
                {
                    t12 = 1;
                }
                if (comboBox42.SelectedIndex == 2)
                {
                    t12 = 1;
                }
                if (comboBox42.SelectedIndex == 3)
                {
                    t12 = 1.11;
                }
                if (comboBox42.SelectedIndex == 4)
                {
                    t12 = 1.29;
                }
                if (comboBox42.SelectedIndex == 5)
                {
                    t12 = 1.63;
                }
                // 13 показатель
                if (comboBox50.SelectedIndex == 0)
                {
                    t13 = 1;
                }
                if (comboBox50.SelectedIndex == 1)
                {
                    t13 = 1;
                }
                if (comboBox50.SelectedIndex == 2)
                {
                    t13 = 1;
                }
                if (comboBox50.SelectedIndex == 3)
                {
                    t13 = 1.05;
                }
                if (comboBox50.SelectedIndex == 4)
                {
                    t13 = 1.17;
                }
                if (comboBox50.SelectedIndex == 5)
                {
                    t13 = 1.46;
                }
                // 14 показатель
                if (comboBox49.SelectedIndex == 0)
                {
                    t14 = 1;
                }
                if (comboBox49.SelectedIndex == 1)
                {
                    t14 = 0.87;
                }
                if (comboBox49.SelectedIndex == 2)
                {
                    t14 = 1;
                }
                if (comboBox49.SelectedIndex == 3)
                {
                    t14 = 1.15;
                }
                if (comboBox49.SelectedIndex == 4)
                {
                    t14 = 1.3;
                }
                if (comboBox49.SelectedIndex == 5)
                {
                    t14 = 1;
                }
                // 15 показатель
                if (comboBox48.SelectedIndex == 0)
                {
                    t15 = 1.17;
                }
                if (comboBox48.SelectedIndex == 1)
                {
                    t15 = 1.09;
                }
                if (comboBox48.SelectedIndex == 2)
                {
                    t15 = 1;
                }
                if (comboBox48.SelectedIndex == 3)
                {
                    t15 = 0.9;
                }
                if (comboBox48.SelectedIndex == 4)
                {
                    t15 = 0.78;
                }
                if (comboBox48.SelectedIndex == 5)
                {
                    t15 = 1;
                }
                // 16 показатель
                if (comboBox47.SelectedIndex == 0)
                {
                    t16 = 1.22;
                }
                if (comboBox47.SelectedIndex == 1)
                {
                    t16 = 1.09;
                }
                if (comboBox47.SelectedIndex == 2)
                {
                    t16 = 1;
                }
                if (comboBox47.SelectedIndex == 3)
                {
                    t16 = 0.93;
                }
                if (comboBox47.SelectedIndex == 4)
                {
                    t16 = 0.86;
                }
                if (comboBox47.SelectedIndex == 5)
                {
                    t16 = 0.8;
                }
                // 17 показатель
                if (comboBox51.SelectedIndex == 0)
                {
                    t17 = 1.43;
                }
                if (comboBox51.SelectedIndex == 1)
                {
                    t17 = 1.14;
                }
                if (comboBox51.SelectedIndex == 2)
                {
                    t17 = 1;
                }
                if (comboBox51.SelectedIndex == 3)
                {
                    t17 = 1;
                }
                if (comboBox51.SelectedIndex == 4)
                {
                    t17 = 1;
                }
                if (comboBox51.SelectedIndex == 5)
                {
                    t17 = 1;
                }

                double SF = k1 + k2 + k3 + k4 + k5;
                double EAF = t1 * t2 * t3 * t4 * t5 * t6 * t7 * t8 * t9 * t10 * t11 * t12 * t13 * t14 * t15 * t16 * t17;

                double E = B + 0.01 * SF;
                double PM = EAF * A * Math.Pow(Convert.ToDouble(textBox4.Text), E);

                double C = 3.67;
                double D = 0.28;
                double EAFns = t1 * t2 * t3 * t4 * t5 * t6 * t7 * t8 * t9 * t10 * t11 * t12 * t13 * t14 * t15 * t16;
                double PMns = EAFns * A * Math.Pow(Convert.ToDouble(textBox4.Text), E);
                double TM = t17 * C * Math.Pow(PMns, D + 0.2 * (E - B));
                label54.Text = Convert.ToString(PM);
                label52.Text = Convert.ToString(TM);
            }
        }
    }
}
