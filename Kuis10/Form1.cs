using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuis10
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double hasil = 0;
        string operasi = "";
        

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (operasi)
            {
                case "+":
                    txthasil.Text = ((double.Parse(txtangka1.Text) + double.Parse(txtangka2.Text))).ToString();
                    break;
                case "-":
                    txthasil.Text = ((double.Parse(txtangka1.Text) - double.Parse(txtangka2.Text))).ToString();
                    break;
                case "x":
                    txthasil.Text = ((double.Parse(txtangka1.Text) * double.Parse(txtangka2.Text))).ToString();
                    break;
                case ":":
                    txthasil.Text = ((double.Parse(txtangka1.Text) / double.Parse(txtangka2.Text))).ToString();
                    break;

                default:
                    break;
            }
            hasil = double.Parse(txthasil.Text);

        }

    }
}
