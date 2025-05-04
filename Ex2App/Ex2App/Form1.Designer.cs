using MySql.Data.MySqlClient;

namespace Ex2App
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
            fileSystemWatcher1 = new FileSystemWatcher();
            tabPage2 = new TabPage();
            groupBox5 = new GroupBox();
            dataGridView3 = new DataGridView();
            groupBox4 = new GroupBox();
            button11 = new Button();
            button10 = new Button();
            label15 = new Label();
            groupBox3 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            button9 = new Button();
            richTextBox1 = new RichTextBox();
            label14 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label19 = new Label();
            label18 = new Label();
            button8 = new Button();
            label17 = new Label();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox11 = new TextBox();
            textBox9 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            tabPage1 = new TabPage();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button5 = new Button();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            textBox10 = new TextBox();
            textBox12 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            button7 = new Button();
            button3 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            tabControl1 = new TabControl();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(896, 472);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "XML FTP";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView3);
            groupBox5.Location = new Point(305, 276);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(388, 196);
            groupBox5.TabIndex = 94;
            groupBox5.TabStop = false;
            groupBox5.Text = "XML file content";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 22);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(376, 168);
            dataGridView3.TabIndex = 3;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button11);
            groupBox4.Controls.Add(button10);
            groupBox4.Location = new Point(6, 276);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(293, 190);
            groupBox4.TabIndex = 93;
            groupBox4.TabStop = false;
            groupBox4.Text = "Process control";
            // 
            // button11
            // 
            button11.Location = new Point(6, 49);
            button11.Name = "button11";
            button11.Size = new Size(173, 22);
            button11.TabIndex = 1;
            button11.Text = "Cancel current operation";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(6, 22);
            button10.Name = "button10";
            button10.Size = new Size(173, 22);
            button10.TabIndex = 0;
            button10.Text = "Execute manual import";
            button10.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(766, 457);
            label15.Name = "label15";
            label15.Size = new Size(124, 15);
            label15.TabIndex = 91;
            label15.Text = "©Codrina Lisaru, 2025";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(573, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(317, 255);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Events log";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 19);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(305, 230);
            dataGridView2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button9);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(305, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 255);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Database config";
            // 
            // button9
            // 
            button9.Location = new Point(6, 98);
            button9.Name = "button9";
            button9.Size = new Size(88, 23);
            button9.TabIndex = 10;
            button9.Text = "Connect";
            button9.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(235, 48);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(6, 24);
            label14.Name = "label14";
            label14.Size = new Size(105, 15);
            label14.TabIndex = 4;
            label14.Text = "Connection string:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(textBox14);
            groupBox1.Controls.Add(textBox13);
            groupBox1.Controls.Add(textBox11);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Location = new Point(6, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 255);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "FTP config";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(45, 193);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 19);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Manually";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(45, 172);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Automatically";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 179);
            label19.Name = "label19";
            label19.Size = new Size(28, 15);
            label19.TabIndex = 13;
            label19.Text = "Run";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(185, 215);
            label18.Name = "label18";
            label18.Size = new Size(50, 15);
            label18.TabIndex = 12;
            label18.Text = "minutes";
            // 
            // button8
            // 
            button8.Location = new Point(6, 147);
            button8.Name = "button8";
            button8.Size = new Size(86, 23);
            button8.TabIndex = 9;
            button8.Text = "Connect";
            button8.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 215);
            label17.Name = "label17";
            label17.Size = new Size(123, 15);
            label17.TabIndex = 10;
            label17.Text = "Check for new files in ";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(135, 210);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(44, 23);
            textBox14.TabIndex = 11;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(98, 118);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(189, 23);
            textBox13.TabIndex = 8;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(98, 93);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(189, 23);
            textBox11.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(98, 68);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(189, 23);
            textBox9.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(98, 43);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(189, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(189, 23);
            textBox4.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 123);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 3;
            label13.Text = "XML file path";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 98);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 3;
            label12.Text = "Password";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 72);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 2;
            label11.Text = "User";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 46);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 1;
            label10.Text = "Port";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 21);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 0;
            label9.Text = "Address";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox10);
            tabPage1.Controls.Add(textBox12);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(textBox8);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button7);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(896, 472);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Main";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(767, 164);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 111;
            button1.Text = "Save content as xlsx";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(750, 348);
            dataGridView1.TabIndex = 109;
            // 
            // button6
            // 
            button6.Location = new Point(260, 77);
            button6.Name = "button6";
            button6.Size = new Size(55, 23);
            button6.TabIndex = 108;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(577, 52);
            button5.Name = "button5";
            button5.Size = new Size(62, 23);
            button5.TabIndex = 107;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(174, 77);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(81, 23);
            textBox7.TabIndex = 106;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(81, 23);
            textBox2.TabIndex = 105;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(471, 52);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 101;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(471, 27);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(100, 23);
            textBox12.TabIndex = 100;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(366, 52);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 99;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(366, 27);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 98;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 97;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 96;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 8);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 104;
            label2.Text = "id - primary key";
            // 
            // button4
            // 
            button4.Location = new Point(577, 26);
            button4.Name = "button4";
            button4.Size = new Size(62, 23);
            button4.TabIndex = 103;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button7
            // 
            button7.Location = new Point(767, 106);
            button7.Name = "button7";
            button7.Size = new Size(122, 23);
            button7.TabIndex = 110;
            button7.Text = "View table content";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button3
            // 
            button3.Location = new Point(9, 13);
            button3.Name = "button3";
            button3.Size = new Size(74, 62);
            button3.TabIndex = 102;
            button3.Text = "Connect to database";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(500, 7);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 95;
            label8.Text = "Sales";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 8);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 94;
            label7.Text = "Month";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(298, 8);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 93;
            label6.Text = "Code";
            // 
            // button2
            // 
            button2.Location = new Point(767, 135);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 92;
            button2.Text = "Save content as pdf";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(774, 456);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 90;
            label5.Text = "©Codrina Lisaru, 2025";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 80);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 89;
            label4.Text = "DELETE data";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 54);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 88;
            label3.Text = "UPDATE data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 87;
            label1.Text = "CREATE data";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(904, 500);
            tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 521);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Codrina's application";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FileSystemWatcher fileSystemWatcher1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button5;
        private TextBox textBox7;
        private TextBox textBox2;
        private TextBox textBox10;
        private TextBox textBox12;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox3;
        private TextBox textBox1;
        private Label label2;
        private Button button4;
        private Button button7;
        private Button button3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TabPage tabPage2;
        private Label label15;
        private GroupBox groupBox3;
        private DataGridView dataGridView2;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        private Label label14;
        private GroupBox groupBox1;
        private TextBox textBox13;
        private TextBox textBox11;
        private TextBox textBox9;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button8;
        private Button button9;
        private GroupBox groupBox4;
        private Button button11;
        private Button button10;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label19;
        private Label label18;
        private TextBox textBox14;
        private Label label17;
        private GroupBox groupBox5;
        private DataGridView dataGridView3;
    }
}