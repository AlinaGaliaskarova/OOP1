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

            // ���������� ������� � ������
            panelDraw.Paint += panelDraw_Paint;
            panelDraw.MouseClick += panelDraw_MouseClick;
            buttonClear.Click += buttonClear_Click;
        }

        // ��������� ����� ����� �� ������
        private void panelDraw_MouseClick(object sender, MouseEventArgs e)
        {
            drawPoints.Add(e.Location);
            panelDraw.Invalidate(); // ������������ ������
        }

        // ��������� �� ������
        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White); // ������� ���

            foreach (var point in drawPoints)
            {
                g.FillEllipse(Brushes.Blue, point.X - 2, point.Y - 2, 4, 4);
            }
        }

        // ������� ������
        private void buttonClear_Click(object sender, EventArgs e)
        {
            drawPoints.Clear();
            panelDraw.Invalidate(); // ������������ ������
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������ ������!", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Controls.Remove(button1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "�����: " + textBox1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // �������� ����� �����
                this.BackColor = Color.FromArgb(45, 45, 48);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;

                // ������ ���� ���� ������ �� ����-�����
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
                // ���������� ������� �����
                this.BackColor = SystemColors.Control;
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;

                // ���������� ����������� ����� ������ � ��������� �����
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
                label2.Text = "�����: ������";
            }
            else if (radioButton2.Checked)
            {
                label2.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic);
                label2.Text = "�����: ������";
            }
            else if (radioButton3.Checked)
            {
                label2.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Underline);
                label2.Text = "�����: ������������";
            }
            else
            {
                label2.Font = new Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular);
                label2.Text = "�����: �������";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "�������":
                    this.BackColor = Color.Red;
                    break;
                case "������":
                    this.BackColor = Color.Green;
                    break;
                case "�����":
                    this.BackColor = Color.Blue;
                    break;
                case "��� �����":
                    this.BackColor = SystemColors.Control;
                    break;
                default:
                    this.BackColor = SystemColors.Control;
                    break;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("������ �������: " + listBox1.SelectedItem);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            // ������� ����� PictureBox
            TextBox pic = new TextBox();
            
            pic.Location = this.PointToClient(Cursor.Position); // ������������� �� ����� �����
            pic.DoubleClick += TextBox_DoubleClick; // ������������� �� ��������
            this.Controls.Add(pic); // ��������� �� �����

            
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
            // ����� ���������� ��������, ��������, ������������ ����� ������
            panel1.BackColor = panel1.BackColor == Color.LightBlue ? Color.LightGreen : Color.LightBlue;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // ������ �������� �������, ����� �������� ���� ������� ��� ���������
            timer1.Interval = (int)numericUpDown1.Value * 10; // �������� �������� �� 10 ��� ��������� ��������� �������
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ������� ��� ��������� ���� (TextBox) �� �����
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear();  // ������� ������ TextBox
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                label4.Text = "������! ������� " + DateTime.Now.ToShortDateString();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                string[] facts = {
                    "����� ����� ������������ ����.",
                    "�� ������� ��� ����� �� �������.",
                    "� ��������� ��� ������.",
                    "���� �� ������ ������� �� ����� �� 8 �����.",
                    "����� ������� ���� � �������, 8848 �."
                };

                Random rnd = new Random();
                int index = rnd.Next(facts.Length);
                label5.Text = "���� ���: " + facts[index];
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                label6.Text = $"������� ������ ����: {this.Width} x {this.Height}";
            }
        }


    }
}