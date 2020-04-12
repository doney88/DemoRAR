using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoRAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnRAR_Click(object sender, EventArgs e)
        {
            RARHelper.UnRAR(this.txtUnRARFolder.Text, this.txtRARFilePath.Text, this.txtRARFileName.Text);
        }
    }


}
