using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listitem = new ListViewItem(new[] { $"{textBox1.Text}", $"{textBox2.Text}", $"{textBox3.Text}", $"{textBox4.Text}" });
            listView1.Items.Add(listitem);

        }


        public override string ToString()
        {
            return $"{textBox1.Text} {textBox2.Text} {textBox3.Text} {textBox4.Text}";
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (listView1.SelectedItems is null)
            {
                return;
            }

            var gelenKisi = listView1.SelectedItems;

            textBox1.Text = gelenKisi[0].SubItems[0].Text;
            textBox2.Text = gelenKisi[0].SubItems[1].Text;
            textBox3.Text = gelenKisi[0].SubItems[2].Text;
            textBox4.Text = gelenKisi[0].SubItems[3].Text;


        }
    }
}
