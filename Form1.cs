using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        private List<Point> drawPoints = new List<Point>();
        public Form1()
        {
            InitializeComponent();

            // Подключаем события к панели
            panelDraw.Paint += panelDraw_Paint;
            panelDraw.MouseClick += panelDraw_MouseClick;
            buttonClear.Click += buttonClear_Click;
        }

        // Обработка клика мышью на панели
        private void panelDraw_MouseClick(object sender, MouseEventArgs e)
        {
            drawPoints.Add(e.Location);
            panelDraw.Invalidate(); // Перерисовать панель
        }

        // Рисование на панели
        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White); // Очищаем фон

            foreach (var point in drawPoints)
            {
                g.FillEllipse(Brushes.Blue, point.X - 2, point.Y - 2, 4, 4);
            }
        }

        // Очистка экрана
        private void buttonClear_Click(object sender, EventArgs e)
        {
            drawPoints.Clear();
            panelDraw.Invalidate(); // Перерисовать панель
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка нажата!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Controls.Remove(button1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Текст: " + textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Включаем тёмный режим
                this.BackColor = Color.FromArgb(45, 45, 48);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

                // Меняем цвет всех кнопок на тёмно-серый
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.DarkGray;
                        btn.ForeColor = Color.Black;
                    }
                    else if (ctrl is TextBox txt)
                    {
                        txt.BackColor = Color.Black;
                        txt.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                // Возвращаем светлый режим
                this.BackColor = SystemColors.Control;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

                // Возвращаем стандартные цвета кнопок и текстовых полей
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = SystemColors.Control;
                        btn.ForeColor = Color.Black;
                    }
                    else if (ctrl is TextBox txt)
                    {
                        txt.BackColor = SystemColors.Window;
                        txt.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Font currentFont = label2.Font;
            if (radioButton1.Checked)
            {
                label2.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold);
                label2.Text = "Текст: Жирный";
            }
            else if (radioButton2.Checked)
            {
                label2.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic);
                label2.Text = "Текст: Курсив";
            }
            else if (radioButton3.Checked)
            {
                label2.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);
                label2.Text = "Текст: Подчёркнутый";
            }
            else
            {
                label2.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
                label2.Text = "Текст: Обычный";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Красный":
                    this.BackColor = Color.Red;
                    break;
                case "Зелёный":
                    this.BackColor = Color.Green;
                    break;
                case "Синий":
                    this.BackColor = Color.Blue;
                    break;
                case "Без цвета":
                    this.BackColor = SystemColors.Control;
                    break;
                default:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Выбран элемент: " + listBox1.SelectedItem);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            // Создаем новый PictureBox
            TextBox pic = new TextBox();
            
            pic.Location = this.PointToClient(Cursor.Position); // Устанавливаем по месту клика
            pic.DoubleClick += TextBox_DoubleClick; // Подписываемся на удаление
            this.Controls.Add(pic); // Добавляем на форму

            
        }

        private void TextBox_DoubleClick(object sender, EventArgs e)
        {
            TextBox pic = sender as TextBox;
            if (pic != null)
            {
                this.Controls.Remove(pic);
                pic.Dispose();

            }
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Здесь происходит анимация, например, переключение цвета панели
            panel1.BackColor = panel1.BackColor == Color.LightBlue ? Color.LightGreen : Color.LightBlue;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Меняем интервал таймера, чтобы анимация была быстрее или медленнее
            timer1.Interval = (int)numericUpDown1.Value * 10; // Умножаем значение на 10 для настройки интервала таймера
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Очищаем все текстовые поля (TextBox) на форме
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear();  // Очищает каждый TextBox
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                label4.Text = "Привет! Сегодня " + DateTime.Now.ToShortDateString();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                string[] facts = {
                    "Пчёлы могут распознавать лица.",
                    "На Сатурне идёт дождь из алмазов.",
                    "У осьминога три сердца.",
                    "Свет от Солнца доходит до Земли за 8 минут.",
                    "Самая высокая гора — Эверест, 8848 м."
                };

                Random rnd = new Random();
                int index = rnd.Next(facts.Length);
                label5.Text = "Факт дня: " + facts[index];
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                label6.Text = $"Текущий размер окна: {this.Width} x {this.Height}";
            }
        }


    }
}