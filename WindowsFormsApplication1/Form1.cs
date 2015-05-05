using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Size = new Size(this.Width, this.Height);
            tabControl1.Location = new Point(0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            tabControl1.Size = control.Size;
            
        }
    }
}
