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
    public partial class Matrix_5x5 : Form
    {
        public Matrix_5x5()
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
        private void Clear_Click(object sender, EventArgs e)
        {
            Distance_Value1.Text = "";
            Distance_Value2.Text = "";
            Distance_Value3.Text = "";
            Distance_Value4.Text = "";
            Distance_Value5.Text = "";
            Distance_Value6.Text = "";
            Distance_Value7.Text = "";
            Distance_Value8.Text = "";
            Distance_Value9.Text = "";
            Distance_Value10.Text = "";
            Distance_Value11.Text = "";
            Distance_Value12.Text = "";
            Distance_Value13.Text = "";
            Distance_Value14.Text = "";
            Distance_Value15.Text = "";
            Distance_Value16.Text = "";
            Distance_Value17.Text = "";
            Distance_Value18.Text = "";
            Distance_Value19.Text = "";
            Distance_Value20.Text = "";
        }
        private void changeSizeOfMatrix_Click(object sender, EventArgs e)
        {
            Presave chooseForm = new Presave();
            chooseForm.Show();
            this.Close();
        }
        private int Solve(int[] array)
        {
            int solve = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < solve)
                {
                    solve = array[i];

                }
            }
            return solve;
        }
        private void Calc_Click(object sender, EventArgs e)
        {

            try
            {
                //Счет значений, введенных пользователем
                int value1 = int.Parse(Distance_Value1.Text);
                int value2 = int.Parse(Distance_Value2.Text);
                int value3 = int.Parse(Distance_Value3.Text);
                int value4 = int.Parse(Distance_Value4.Text);
                int value5 = int.Parse(Distance_Value5.Text);
                int value6 = int.Parse(Distance_Value6.Text);
                int value7 = int.Parse(Distance_Value7.Text);
                int value8 = int.Parse(Distance_Value8.Text);
                int value9 = int.Parse(Distance_Value9.Text);
                int value10 = int.Parse(Distance_Value10.Text);
                int value11 = int.Parse(Distance_Value11.Text);
                int value12 = int.Parse(Distance_Value12.Text);
                int value13 = int.Parse(Distance_Value13.Text);
                int value14 = int.Parse(Distance_Value14.Text);
                int value15 = int.Parse(Distance_Value15.Text);
                int value16 = int.Parse(Distance_Value16.Text);
                int value17 = int.Parse(Distance_Value17.Text);
                int value18 = int.Parse(Distance_Value18.Text);
                int value19 = int.Parse(Distance_Value19.Text);
                int value20 = int.Parse(Distance_Value20.Text);


                // Обработчик, что длина между одними и теми же городами не может быть разной
                if ((value1 != value5) 
                    || (value9 != value2) 
                    || (value3 != value13) 
                    || (value4 != value17) 
                    || (value10 != value6) 
                    || (value7 != value14)
                    || (value11 != value15)
                    || (value18 != value8)
                    || (value20 != value16)
                    || (value19 != value12))
                {
                    MessageBox.Show("Длина между одними и теми же городами не может быть разной ");
                }
                else
                {
                    int[] arrayOfAnswers = new int[24];

                    arrayOfAnswers[0] = value1 + value10 + value11 + value20 + value17;
                    arrayOfAnswers[1] = value1 + value10 + value12 + value16 + value13;
                    arrayOfAnswers[2] = value1 + value14 + value15 + value16 + value4;
                    arrayOfAnswers[3] = value1 + value14 + value16 + value12 + value9;
                    arrayOfAnswers[4] = value1 + value18 + value19 + value15 + value13;
                    arrayOfAnswers[5] = value1 + value18 + value20 + value11 + value9;

                    arrayOfAnswers[6] = value2 + value6 + value7 + value20 + value17;
                    arrayOfAnswers[7] = value2 + value6 + value8 + value16 + value13;
                    arrayOfAnswers[8] = value2 + value15 + value14 + value18 + value17;
                    arrayOfAnswers[9] = value2 + value15 + value16 + value8 + value5;
                    arrayOfAnswers[10] = value2 + value19 + value18 + value13 + value14;
                    arrayOfAnswers[11] = value2 + value19 + value20 + value7 + value5;

                    arrayOfAnswers[12] = value3 + value7 + value6 + value19 + value17;
                    arrayOfAnswers[13] = value3 + value7 + value8 + value12 + value9;
                    arrayOfAnswers[14] = value3 + value11 + value10 + value18 + value17;
                    arrayOfAnswers[15] = value3 + value11 + value12 + value8 + value5;
                    arrayOfAnswers[16] = value3 + value20 + value18 + value10 + value9;
                    arrayOfAnswers[17] = value3 + value20 + value19 + value6 + value5;

                    arrayOfAnswers[18] = value4 + value8 + value6 + value15 + value13;
                    arrayOfAnswers[19] = value4 + value8 + value7 + value11 + value9;
                    arrayOfAnswers[20] = value4 + value12 + value10 + value14 + value13;
                    arrayOfAnswers[21] = value4 + value12 + value11 + value7 + value5;
                    arrayOfAnswers[22] = value4 + value16 + value14 + value10 + value9;
                    arrayOfAnswers[23] = value4 + value16 + value15 + value6 + value5;

                    MessageBox.Show("Длина кратчайшего пути составляет: " + Solve(arrayOfAnswers));
                }

            }

            catch
            {
                MessageBox.Show("Все поля матрицы должны быть заполнены");
            }
        }


    }
}
