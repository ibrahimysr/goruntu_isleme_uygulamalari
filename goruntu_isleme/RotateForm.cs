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
    public partial class RotateForm : Form
    {
        public int RotationAngle { get; private set; }

        public RotateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği döndürme açısını RotationAngle özelliğine atar
            RotationAngle = (int)numericUpDown1.Value;
            // Formu kapatır
            this.Close();
        }
    }
}
