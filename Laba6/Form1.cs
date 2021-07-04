using System;
using System.Windows.Forms;
//создать программу таким образом, чтобы координаты курсора мыши выводились в заголовке главного окна приложения. 
//Добавить текстовое поле (TextBox). Дополните обработчик движения мыши таким образом, чтобы в текстовом поле отображалась сумма координат указателя мыши.
//Добавить 2 текстовых поля куда вводятся переменные.
//Добавить кнопку по нажатию которой сумма элементов отобразиться в заголовке главного окна.

namespace Laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            int s = X + Y;
            this.Text = "X - " + X.ToString() + " Y - " + Y.ToString();
            textBox1.Text = s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));
        }
    }
}
