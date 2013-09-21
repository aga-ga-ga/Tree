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

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString( oneTree.Grow() );
            textBox1.Text += " apples in the tree";
        }

       
    }
}
