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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
        

        // Работа кнопки очистки полей
        private void Clear_Click(object sender, EventArgs e)
        {
            Distance__Value1.Text = "";
            Distance__Value2.Text = "";
            Distance__Value3.Text = "";
            Distance__Value4.Text = "";
            Distance__Value5.Text = "";
            Distance__Value6.Text = "";
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

                // Обработчик, что длина между одними и теми же городами не может быть разной
                if ((value1 != value3) || (value2 != value5) || (value6 != value4))
                {
                    MessageBox.Show("Длина между одними и теми же городами не может быть разной ");
                }
                    
                else
                {
                    int result = value1 + value2 + value3;
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
        

       

        