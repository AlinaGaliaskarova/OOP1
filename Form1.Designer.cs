namespace OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            progressBar1 = new ProgressBar();
            trackBar1 = new TrackBar();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            файл = new ToolStripMenuItem();
            выход = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            tabPage2 = new TabPage();
            label5 = new Label();
            tabPage3 = new TabPage();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            radioButton3 = new RadioButton();
            panelDraw = new Panel();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(102, 67);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 0;
            button1.Text = "кнопка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 162);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "Текст:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(53, 162);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Темная тема";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            radioButton1.Location = new Point(427, 289);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Жирный";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            radioButton2.Location = new Point(427, 319);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Курсив";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Красный", "Зелёный", "Синий", "Без цвета" });
            comboBox1.Location = new Point(649, 484);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "элемент 1", "элемент 2", "элемент 3" });
            listBox1.Location = new Point(405, 522);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 64);
            listBox1.TabIndex = 7;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(687, 319);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(251, 29);
            progressBar1.TabIndex = 8;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(687, 374);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(251, 56);
            trackBar1.TabIndex = 9;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.Location = new Point(40, 349);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 246);
            panel1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файл, выход });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1447, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // файл
            // 
            файл.Name = "файл";
            файл.Size = new Size(125, 24);
            файл.Text = "Очистить поля";
            файл.Click += clearFieldsToolStripMenuItem_Click;
            // 
            // выход
            // 
            выход.Name = "выход";
            выход.Size = new Size(67, 24);
            выход.Text = "Выход";
            выход.Click += Exit_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.ItemSize = new Size(100, 30);
            tabControl1.Location = new Point(599, 129);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(436, 125);
            tabControl1.TabIndex = 12;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.AllowDrop = true;
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(428, 87);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Приветствие";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 35);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(428, 87);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Факт дня";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 40);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 0;
            label5.Text = "label5";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(428, 87);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Размер окна";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 40);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(65, 289);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(427, 386);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 14;
            label2.Text = "Изменяемый текст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(759, 273);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 15;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 204);
            radioButton3.Location = new Point(427, 349);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(136, 24);
            radioButton3.TabIndex = 16;
            radioButton3.TabStop = true;
            radioButton3.Text = "Подчёркнутый ";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // panelDraw
            // 
            panelDraw.BackColor = SystemColors.Window;
            panelDraw.Location = new Point(984, 434);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(250, 125);
            panelDraw.TabIndex = 17;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(1026, 566);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(173, 29);
            buttonClear.TabIndex = 18;
            buttonClear.Text = "Очистить экран";
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 669);
            Controls.Add(buttonClear);
            Controls.Add(panelDraw);
            Controls.Add(radioButton3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(trackBar1);
            Controls.Add(progressBar1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "OOP";
            DoubleClick += Form1_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private TrackBar trackBar1;
        public System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файл;
        private ToolStripMenuItem выход;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton3;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panelDraw;
        private Button buttonClear;
    }
}
