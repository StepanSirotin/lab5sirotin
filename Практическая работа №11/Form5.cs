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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Предложения_перед_покупкой". При необходимости она может быть перемещена или удалена.
            this.предложения_перед_покупкойTableAdapter.Fill(this.практика_accessDataSet.Предложения_перед_покупкой);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Проверка_товара". При необходимости она может быть перемещена или удалена.
            this.проверка_товараTableAdapter.Fill(this.практика_accessDataSet.Проверка_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.практика_accessDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.практика_accessDataSet.Клиенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.EndEdit();
            клиентыTableAdapter.Update(практика_accessDataSet);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            товарBindingSource.EndEdit();
            клиентыTableAdapter.Update(практика_accessDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            проверкаТовараBindingSource.EndEdit();
            проверка_товараTableAdapter.Update(практика_accessDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            предложенияПередПокупкойBindingSource.EndEdit();
            предложения_перед_покупкойTableAdapter.Update(практика_accessDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
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

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
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

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                dataGridView4.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView4.ColumnCount; j++)
                    if (dataGridView4.Rows[i].Cells[j].Value != null)
                        if (dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))
                        {
                            dataGridView4.Rows[i].Selected = true;
                            break;
                        }
            }
        }
    }
}
