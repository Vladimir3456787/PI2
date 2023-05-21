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
            dataGridView1.Rows.Add("1. Удобство работы (пользовательский интерфейс)");
            dataGridView1.Rows.Add("2. Новизна (соответствие современным требованиям)");
            dataGridView1.Rows.Add("3. Соответствие профилю деятельности заказчика");
            dataGridView1.Rows.Add("4. Ресурсная эффективность");
            dataGridView1.Rows.Add("5. Надежность (защита данных)");
            dataGridView1.Rows.Add("6. Скорость доступа к данным");
            dataGridView1.Rows.Add("7. Гибкость настройки");
            dataGridView1.Rows.Add("8. Обучаемость персонала");
            dataGridView1.Rows.Add("9. Соотношение стоимость/возможности");
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            switch (dataGridView1.CurrentCell.ColumnIndex)
            {
                case 0:
                    e.Control.KeyPress -= Stolb3_KeyPress;
                    e.Control.KeyPress += Stolb3_KeyPress;
                    break;
                case 1:
                    e.Control.KeyPress -= Stolb2_KeyPress;
                    e.Control.KeyPress += Stolb2_KeyPress;                   
                    break;
                case 2:
                    e.Control.KeyPress -= Stolb2_KeyPress;
                    e.Control.KeyPress += Stolb2_KeyPress;
                    break;
                case 3:
                    e.Control.KeyPress -= Stolb3_KeyPress;
                    e.Control.KeyPress += Stolb3_KeyPress;
                    break;
                case 4:
                    e.Control.KeyPress -= Stolb3_KeyPress;
                    e.Control.KeyPress += Stolb3_KeyPress;
                    break;
                case 5:
                    e.Control.KeyPress -= Stolb3_KeyPress;
                    e.Control.KeyPress += Stolb3_KeyPress;
                    break;
            }
        }
        private void Stolb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar != 48 && e.KeyChar != 57) && e.KeyChar != 96)
                e.Handled = true;
        }
        private void Stolb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 53) && e.KeyChar != 96)
                e.Handled = true;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<dataGridView1.Columns.Count-1; i++)
            {
                dataGridView1["Column4", i].Value = Convert.ToDouble(dataGridView1["Column2", i].Value) * Convert.ToInt64(dataGridView1["Column3", i].Value);
               
            }
            
        }
    }
}
