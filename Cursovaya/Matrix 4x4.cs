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
    public partial class Matrix_4x4 : Form
    {
        public Matrix_4x4()
        {
            InitializeComponent();
        }

        // Обработчик событий Keypress на запрет любых символов, кроме цифр
        private void Distance_is_number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Расстояние может содержать только целые положительные числовые значения");
            }
        }
        private int minf(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Distance__Value1.Text = "";
            Distance__Value2.Text = "";
            Distance__Value3.Text = "";
            Distance__Value4.Text = "";
            Distance__Value5.Text = "";
            Distance__Value6.Text = "";
            Distance__Value7.Text = "";
            Distance__Value8.Text = "";
            Distance__Value9.Text = "";
            Distance__Value10.Text = "";
            Distance__Value11.Text = "";
            Distance__Value12.Text = "";
        }
        private void Calc_Click(object sender, EventArgs e)
        {

            try
            {
                //Счет значений, введенных пользователем
                int value1 = int.Parse(Distance__Value1.Text);
                int value2 = int.Parse(Distance__Value2.Text);
                int value3 = int.Parse(Distance__Value3.Text);
                int value4 = int.Parse(Distance__Value4.Text);
                int value5 = int.Parse(Distance__Value5.Text);
                int value6 = int.Parse(Distance__Value6.Text);
                int value7 = int.Parse(Distance__Value7.Text);
                int value8 = int.Parse(Distance__Value8.Text);
                int value9 = int.Parse(Distance__Value9.Text);
                int value10 = int.Parse(Distance__Value10.Text);
                int value11 = int.Parse(Distance__Value11.Text);
                int value12 = int.Parse(Distance__Value12.Text);

                // Обработчик, что длина между одними и теми же городами не может быть разной
                if ((value1 != value4) || (value7 != value2) || (value3 != value10) || (value5 != value8) || (value6 != value11) || (value12 != value9))
                {
                    MessageBox.Show("Длина между одними и теми же городами не может быть разной ");
                }
                else {
                    int result = minf(value1 + value2 + value11 + value12, value1 + value3 + value8 + value9, value2 + value3 + value5 + value6);


                    MessageBox.Show("Длина кратчайшего пути составляет: " + result);
                }
                
            }

            catch
            {
                MessageBox.Show("Все поля матрицы должны быть заполнены");
            }
        }

        private void changeSizeOfMatrix_Click(object sender, EventArgs e)
        {
            Presave chooseForm = new Presave();
            chooseForm.Show();
            this.Close();
        }
    }
}
