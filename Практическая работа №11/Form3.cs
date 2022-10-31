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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "практика_accessDataSet.Учёт_товара_на_складах". При необходимости она может быть перемещена или удалена.
            this.учёт_товара_на_складахTableAdapter.Fill(this.практика_accessDataSet.Учёт_товара_на_складах);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            учётТовараНаСкладахBindingSource.EndEdit();
            учёт_товара_на_складахTableAdapter.Update(практика_accessDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
    }
}
