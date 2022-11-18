using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp18_14
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        AboutBox1 aboutBox1 = new AboutBox1();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;

            form2.richTextBox1.Text = aboutBox1.textBoxDescription.Text;
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                text = form2.richTextBox1.Text;
                aboutBox1.textBoxDescription.Text = text;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aboutBox1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Выйти из программы ?", "Запрос",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
