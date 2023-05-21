using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PILaba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Rows.Add("1. Удобство работы (пользовательский интерфейс)","0,6","1", "0", "5", "0");
            dataGridView1.Rows.Add("2. Новизна (соответствие современным требованиям)","0,1", "4", "0", "2", "0");
            dataGridView1.Rows.Add("3. Соответствие профилю деятельности заказчика", "0,56", "5", "0", "1", "0");
            dataGridView1.Rows.Add("4. Ресурсная эффективность", "0,545", "1", "0", "2", "0");
            dataGridView1.Rows.Add("5. Надежность (защита данных)", "0,78", "2", "0", "3", "0");
            dataGridView1.Rows.Add("6. Скорость доступа к данным", "0,59", "3", "0", "4", "0");
            dataGridView1.Rows.Add("7. Гибкость настройки", "0,34", "4", "0", "5", "0");
            dataGridView1.Rows.Add("8. Обучаемость персонала", "0,32", "3", "0", "1", "0");
            dataGridView1.Rows.Add("9. Соотношение стоимость/возможности", "0,87", "1", "0", "2", "0");
            dataGridView1.AllowUserToAddRows = false;

            //План-работ
            dataGridView2.Rows.Add("Сделать курсовую работу","Студент","5","100");
            dataGridView3.Rows.Add("Сделать курсовую работу", "Студент", "5", dataGridView3[3, 0].Value = DateTime.Now.ToShortDateString(), Convert.ToDateTime(dataGridView3[4, 0].Value));
            dataGridView3.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;

            //Затраты
            dataGridView4.AllowUserToAddRows = false;
            dataGridView5.AllowUserToAddRows = false;
            dataGridView6.AllowUserToAddRows = false;

            //Эксплуатация
            dataGridView9.AllowUserToAddRows = false;
            dataGridView7.AllowUserToAddRows = false;
            dataGridView8.AllowUserToAddRows = false;
            dataGridView9.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView9.RowTemplate.Height = 60;
            dataGridView9.Rows.Add("Основная и дополнительная зарплата с отчислениями во", "0", "0");
            dataGridView9.Rows.Add("Амортизационные отчисления", "0", "0");
            dataGridView9.Rows.Add("Затраты на электроэнергию", "0", "0");
            dataGridView9.Rows.Add("Затраты на текущий ремонт", "0", "0");
            dataGridView9.Rows.Add("Затраты на материалы", "0", "0");
            dataGridView9.Rows.Add("Накладные расходы", "0", "0");

            //Эффективность
            dataGridView10.AllowUserToAddRows = false;
            dataGridView11.AllowUserToAddRows = false;
            dataGridView10.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView10.RowTemplate.Height = 60;
            dataGridView11.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView11.RowTemplate.Height = 60;
            dataGridView10.Rows.Add("Себестоимость (текущие эксплуатационные затраты), руб.", "0", "0");
            dataGridView10.Rows.Add("Суммарные затраты, связанные с внедрением проекта, руб.", "0", "0");
            dataGridView10.Rows.Add("Приведенные затраты на единицу работ, руб.", "0", "0");
            dataGridView10.Rows.Add("Приведенные затраты на единицу работ, руб.", "0", "0");
            dataGridView11.Rows.Add("Затраты на разработку и внедрение проекта, руб.", "0");
            dataGridView11.Rows.Add("Общие эксплуатационные затраты, руб.", "0");
            dataGridView11.Rows.Add("Экономический эффект, руб.", "0");
            dataGridView11.Rows.Add("Коэфициент экономической эффективности", "0");
            dataGridView11.Rows.Add("Срок окупаемости, лет", "0");
        }
       
        
        //КТУ
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dataGridView1.CurrentCell.ColumnIndex)
            {
                case 1:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
                    break;
                case 2:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
                    break;
                case 3:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
                    break;
                case 4:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
                    break;
                case 5:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
                    break;
                default:
                    break;
            }

        }
        
        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != ',')
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double value1 = Convert.ToDouble(dataGridView1["Column2", i].Value);
                int value2 = Convert.ToInt32(dataGridView1["Column3", i].Value);
                int value3 = Convert.ToInt32(dataGridView1["Column5", i].Value);
                if (0 <= value1 && value1 <= 1)
                {
                    if (0 <= value2 && value2 <= 5|| 0 <= value3 && value3 <= 5)
                    {
                        dataGridView1["Column4", i].Value = value1 * value2;
                        dataGridView1["Column6", i].Value = value1 * value3;

                    }
                    else
                    {
                        MessageBox.Show("Оценка качества проекта может иметь значение от 1 до 5!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Коэффициент весомости может иметь значение в диапозоне от 0 до 1!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

            }
            label5.Text = "0";
            label6.Text = "0";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                label5.Text = Convert.ToString(double.Parse(label5.Text) + double.Parse(dataGridView1["Column4", i].Value.ToString()));
                label6.Text = Convert.ToString(double.Parse(label6.Text) + double.Parse(dataGridView1["Column6", i].Value.ToString()));
            }
            double A = Convert.ToDouble(label5.Text) / Convert.ToDouble(label6.Text);
            if (A>1)
            {
                label8.Visible = true;
            }
            else { label9.Visible = true; }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Rows.Add("1. Удобство работы (пользовательский интерфейс)", "0,0", "0", "0", "0","0");
            dataGridView1.Rows.Add("2. Новизна (соответствие современным требованиям)", "0,0", "0", "0", "0","0");
            dataGridView1.Rows.Add("3. Соответствие профилю деятельности заказчика", "0,0", "0", "0", "0", "0");
            dataGridView1.Rows.Add("4. Ресурсная эффективность", "0,0", "0", "0", "0", "0");
            dataGridView1.Rows.Add("5. Надежность (защита данных)", "0,0", "0", "0", "0", "0");
            dataGridView1.Rows.Add("6. Скорость доступа к данным", "0,0", "0", "0", "0", "0");
            dataGridView1.Rows.Add("7. Гибкость настройки", "0,0", "0", "0", "0", "0");
            dataGridView1.Rows.Add("8. Обучаемость персонала", "0,0", "0", "0", "0", "0");
            dataGridView1.Rows.Add("9. Соотношение стоимость/возможности", "0,0", "0", "0", "0", "0");
        }




        //План-работ
        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dataGridView2.CurrentCell.ColumnIndex)
            {
                case 0:
                    e.Control.KeyPress -= new KeyPressEventHandler(word_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(word_KeyPress);
                    break;
                case 1:
                    e.Control.KeyPress -= new KeyPressEventHandler(word_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(word_KeyPress);
                    break;
                case 2:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView2_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView2_KeyPress);
                    break;
                case 3:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView2_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView2_KeyPress);
                    break;
                default:
                    break;
            }
        }
        private void word_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != ',')
                e.Handled = false;
        }
        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != ',')
                e.Handled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView3["Column16", 0].Value = Convert.ToDateTime(dataGridView3["Column15", 0].Value).AddDays(Convert.ToInt32(dataGridView2["Column9", 0].Value)-1);
            dataGridView3["Column16", 0].Value = dataGridView3["Column16", 0].Value;
            try
            {
                for (int i = 1; i < dataGridView3.RowCount; i++)
                {
                    DateTime datan = Convert.ToDateTime(dataGridView3["Column15", i].Value);
                    DateTime datak = Convert.ToDateTime(dataGridView3["Column16", i].Value);


                    for (int p = 1; p < dataGridView2.RowCount; p++)
                    {
                        datan = Convert.ToDateTime(dataGridView3["Column16", i - 1].Value);
                        dataGridView3["Column15", i].Value = datan;
                        datak = Convert.ToDateTime(datan).AddDays(Convert.ToInt32(dataGridView2["Column9", p].Value) - 1);
                        dataGridView3["Column16", i].Value = datak;
                    }

                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView4.Rows.Add(dataGridView2["Column8", i].Value);
                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView7.Rows.Add(dataGridView2["Column8", i].Value);
                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView8.Rows.Add(dataGridView2["Column8", i].Value);
                }
            }
            catch
            {
                MessageBox.Show("Не все данные заполнены! Проверьте их!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(textBox1.Text,textBox2.Text, textBox3.Text, textBox4.Text);
            dataGridView3.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt64(textBox4.Text) > 100)
            {
                textBox4.Text = "100";
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                dataGridView2.Rows.RemoveAt(i);
                i--;
                while (dataGridView2.Rows.Count == 0)
                    continue;
            }
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                dataGridView3.Rows.RemoveAt(i);
                i--;
                while (dataGridView3.Rows.Count == 0)
                    continue;
            }
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
        }



        //Затраты

        private void dataGridView4_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dataGridView4.CurrentCell.ColumnIndex)
            {
                case 1:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 2:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 3:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 4:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                default:
                    break;
            }
        }
        private void dataGridView4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != ',')
                e.Handled = true;
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                dataGridView4.Rows.RemoveAt(i);
                i--;
                while (dataGridView4.Rows.Count == 0)
                    continue;
            }
            for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
            {
                dataGridView5.Rows.RemoveAt(i);
                i--;
                while (dataGridView5.Rows.Count == 0)
                    continue;
            }
            for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
            {
                dataGridView6.Rows.RemoveAt(i);
                i--;
                while (dataGridView6.Rows.Count == 0)
                    continue;
            }
            dataGridView4.Rows.Clear();
            dataGridView5.Rows.Clear();
            dataGridView6.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Надо доделать

            try
            {
                dataGridView4.Rows.Add(textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    int symm = Convert.ToInt32(dataGridView5["Column24", i].Value) * Convert.ToInt32(dataGridView5["Column25", i].Value);
                    dataGridView5["Column26", i].Value = symm;
                }
            }
            catch
            {
                MessageBox.Show("Нет данных! Колонка #Сумма# не может быть заполнена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView5.Rows.Add(textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text);
                for (int i = 0; i < dataGridView5.RowCount; i++)
                {
                    int symm = Convert.ToInt32(dataGridView5["Column24", i].Value) * Convert.ToInt32(dataGridView5["Column25", i].Value);
                    dataGridView5["Column26", i].Value = symm;
                }
            }
            catch
            {
                MessageBox.Show("Нет данных! Колонка #Сумма# не может быть заполнена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView6.Rows.Add(textBox10.Text, textBox9.Text);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }
        
        //Эксплуатация
              

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView7.Rows.Count - 1; i++)
            {
                dataGridView7.Rows.RemoveAt(i);
                i--;
                while (dataGridView7.Rows.Count == 0)
                    continue;
            }
            for (int i = 0; i < dataGridView8.Rows.Count - 1; i++)
            {
                dataGridView8.Rows.RemoveAt(i);
                i--;
                while (dataGridView8.Rows.Count == 0)
                    continue;
            }
            dataGridView7.Rows.Clear();
            dataGridView8.Rows.Clear();
            dataGridView9.Rows.Clear();
            dataGridView9.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView9.RowTemplate.Height = 60;
            dataGridView9.Rows.Add("Основная и дополнительная зарплата с отчислениями во", "0", "0");
            dataGridView9.Rows.Add("Амортизационные отчисления", "0", "0");
            dataGridView9.Rows.Add("Затраты на электроэнергию", "0", "0");
            dataGridView9.Rows.Add("Затраты на текущий ремонт", "0", "0");
            dataGridView9.Rows.Add("Затраты на материалы", "0", "0");
            dataGridView9.Rows.Add("Накладные расходы", "0", "0");
            
        }

        private void dataGridView7_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dataGridView7.CurrentCell.ColumnIndex)
            {
                case 1:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 2:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 3:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 4:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                default:
                    break;
            }
        }

        private void dataGridView8_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dataGridView7.CurrentCell.ColumnIndex)
            {
                case 1:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 2:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 3:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                case 4:
                    e.Control.KeyPress -= new KeyPressEventHandler(dataGridView4_KeyPress);
                    e.Control.KeyPress += new KeyPressEventHandler(dataGridView4_KeyPress);
                    break;
                default:
                    break;
            }
        }


        //Эффективность

    }
}
