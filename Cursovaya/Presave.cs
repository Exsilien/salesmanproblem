using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursovaya
{
    public partial class Presave : Form
    {
        public Presave()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedSizeOfMatrix = comboBox1.GetItemText(comboBox1.SelectedItem);
            switch(selectedSizeOfMatrix)
            {
                case "3x3":
                    Form1 form3x3 = new Form1();
                    form3x3.Show();
                    this.Close();
                    break;
                case "4x4":
                    Matrix_4x4 form4x4 = new Matrix_4x4();
                    form4x4.Show();
                    this.Close();
                    break;
                case "5x5":
                    Matrix_5x5 form5x5 = new Matrix_5x5();
                    form5x5.Show();
                    this.Close();
                    break;
                default:
                    MessageBox.Show("Вы должны выбрать размер именно из списка, нажав на него левой кнопкой мыши");
                    break;
            }
            
        }
    }
}
