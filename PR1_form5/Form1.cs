using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_form5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            label2.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            label1.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            label2.ForeColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
        }

    }
}
