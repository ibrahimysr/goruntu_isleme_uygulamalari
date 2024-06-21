using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goruntu_isleme
{
    public partial class girisform : Form
    {
        public girisform()
        {
            InitializeComponent();
        }
        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!islem) {
                this.Opacity += 0.009;
            }
 
            if(this.Opacity ==1)
            {
                islem = true;
            }
            if(islem)
            {
                this.Opacity -= 0.009;
                if(this.Opacity ==0)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    timer1.Enabled = false;

                }
            }
        }
    }
}
