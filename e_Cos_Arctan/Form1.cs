using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Cos_Arctan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void tbLength_TextChanged(object sender, EventArgs e)
        {
            if (tbX.Text == "" || tbLength.Text == "")
            {
                MessageBox.Show("Error!!     inputs is empty");
            }
            else
            {
                double x, eSum = 1, arcSum = 0, cosSum = 1, degX;
                double pE = 1, fE = 1, pA = 1, fA = 1, pC = 1, fC = 1, sign = 1;
                int n;
                n = Convert.ToInt32(tbLength.Text);
                x = Convert.ToDouble(tbX.Text);
                degX = x * (3.142 / 180.0);
                pE = x;
                arcSum = degX;
                for (int i = n - 1; i > 0; --i)
                {
                    eSum = 1 + x * eSum / i;
                }
                for (int i = 1; i <= n; i++)
                {
                    arcSum = arcSum + ((sign * pA) / fA);

                    fA = 2 * i + 1;
                    pA = pA * degX * degX;
                    sign = sign * -1;
                    fC = fC * (2 * i - 1) * (2 * i);
                    pC = pC * degX * degX;
                    cosSum = cosSum + sign * pC / fC;
                }
                lExp.Text = Convert.ToString(eSum);
                lArctan.Text = Convert.ToString(arcSum);
                lCos.Text = Convert.ToString(cosSum);
            }
        }
    }
}
