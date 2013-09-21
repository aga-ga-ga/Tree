using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_TP_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tree oneTree = new Tree();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString( oneTree.Grow() );
            textBox1.Text += " apples in the tree";
            textBox2.Text = Convert.ToString(oneTree.alldropedApples);
            textBox2.Text += " droped and they have ";
            textBox2.Text += Convert.ToString(oneTree.allStoneInAllDropedApples);
            textBox2.Text += " stones";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(oneTree.Shake());
            textBox1.Text += " apples in the tree";
            textBox2.Text = Convert.ToString(oneTree.alldropedApples);
            textBox2.Text += " droped and they have ";
            textBox2.Text += Convert.ToString(oneTree.allStoneInAllDropedApples);
            textBox2.Text += " stones";
        }
    }
}
