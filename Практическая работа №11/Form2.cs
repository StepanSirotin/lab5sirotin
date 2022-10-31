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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Предложения_перед_покупкой". При необходимости она может быть перемещена или удалена.
            this.предложения_перед_покупкойTableAdapter.Fill(this.практика_accessDataSet.Предложения_перед_покупкой);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.практика_accessDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Проверка_товара". При необходимости она может быть перемещена или удалена.
            this.проверка_товараTableAdapter.Fill(this.практика_accessDataSet.Проверка_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.практика_accessDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Обслуживание_клиентов". При необходимости она может быть перемещена или удалена.
            this.обслуживание_клиентовTableAdapter.Fill(this.практика_accessDataSet.Обслуживание_клиентов);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            обслуживаниеКлиентовBindingSource.EndEdit();
            обслуживание_клиентовTableAdapter.Update(практика_accessDataSet);
      }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }
    }
}
