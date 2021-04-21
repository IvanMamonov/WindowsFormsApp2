using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            {
                g.DrawLine(Pens.Black, new Point(1, 1), new Point(200, 100));

            }
        }

    }
}
