using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__11
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.практика_accessDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this.практика_accessDataSet.Оплата);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.практика_accessDataSet.Товар);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            товарBindingSource.EndEdit();
            товарTableAdapter.Update(практика_accessDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            оплатаBindingSource.EndEdit();
            оплатаTableAdapter.Update(практика_accessDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            сотрудникиBindingSource.EndEdit();
            сотрудникиTableAdapter.Update(практика_accessDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox2.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                dataGridView3.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                    if (dataGridView3.Rows[i].Cells[j].Value != null)
                        if (dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(textBox3.Text))
                        {
                            dataGridView3.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
