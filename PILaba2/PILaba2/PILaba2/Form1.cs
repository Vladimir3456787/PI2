using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PILaba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Rows.Add("1. Удобство работы (пользовательский интерфейс)","0,6","1","","5");
            dataGridView1.Rows.Add("2. Новизна (соответствие современным требованиям)","0,1", "4", "", "2");
            dataGridView1.Rows.Add("3. Соответствие профилю деятельности заказчика", "0,56", "5", "", "1");
            dataGridView1.Rows.Add("4. Ресурсная эффективность", "0,545", "1", "", "2");
            dataGridView1.Rows.Add("5. Надежность (защита данных)", "0,78", "2", "", "3");
            dataGridView1.Rows.Add("6. Скорость доступа к данным", "0,59", "3", "", "4");
            dataGridView1.Rows.Add("7. Гибкость настройки", "0,34", "4", "", "5");
            dataGridView1.Rows.Add("8. Обучаемость персонала", "0,32", "3", "", "1");
            dataGridView1.Rows.Add("9. Соотношение стоимость/возможности", "0,87", "1", "", "2");
            dataGridView1.AllowUserToAddRows = false;
        }

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
                if (0 < value1 && value1 < 1)
                {
                    if (1 <= value2 && value2 <= 5|| 1 <= value3 && value3 <= 5)
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

        
    }
}
