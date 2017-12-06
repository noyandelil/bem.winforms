using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();

            for (int i = 0; i < 50; i++)
            {

                listBox1.Items.Add(random.Next());
            }

        }
        private Random rnd = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                var random2 = new Random();
                listBox1.Items.Add(random2.Next());
            }
            
        }
    }
}
