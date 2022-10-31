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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Продажа_товара". При необходимости она может быть перемещена или удалена.
            this.продажа_товараTableAdapter.Fill(this.практика_accessDataSet.Продажа_товара);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            продажаТовараBindingSource.EndEdit();
            продажа_товараTableAdapter.Update(практика_accessDataSet);
        }
    }
}
