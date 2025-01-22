using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace S_2_l_2
{
    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 cls = new Class1();
            int i = 0;
            cls.ShowMessageBox(i);
            MessageBox.Show($"The Value in i is {i}");
        }
    }
}
