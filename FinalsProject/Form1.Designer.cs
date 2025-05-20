using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace FinalsProject
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
            ComboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            ComboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // ComboBox1
            // 
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(12, 186);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(151, 23);
            ComboBox1.TabIndex = 0;
            ComboBox1.Text = "Select Currency";
            ComboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 320);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(388, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(124, 239);
            button1.Name = "button1";
            button1.Size = new Size(151, 35);
            button1.TabIndex = 3;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(57, 154);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "From this currency";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(249, 154);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 5;
            label2.Text = "To this Currency";
            label2.Click += label2_Click;
            // 
            // ComboBox2
            // 
            ComboBox2.FormattingEnabled = true;
            ComboBox2.Location = new Point(249, 186);
            ComboBox2.Name = "ComboBox2";
            ComboBox2.Size = new Size(151, 23);
            ComboBox2.TabIndex = 6;
            ComboBox2.Text = "Select Currency";
            ComboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(57, 23);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 7;
            label3.Text = "Currency Calculator💰";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(176, 293);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 8;
            label4.Text = "Result:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(168, 108);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 34);
            ClientSize = new Size(413, 375);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ComboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ComboBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency Converter💰";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox ComboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
