using System.ComponentModel;

namespace OO_C_Sharp_WinFormsApp
{

    partial class FatPerson
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();

            ((ISupportInitialize) pictureBox1).BeginInit();

            SuspendLayout();

            /*
             * ID
             */
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 30);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";

            /*
             * 姓
             */
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 60);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 60);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;

            /*
             * 名
             */
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 90);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 90);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 7;

            /*
             * 誕生日
             */
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;

            /*
             * 年齢
             */
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 120);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 9;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 120);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 10;
            label8.Text = "label8";

            /*
             * イメージ
             */
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(310, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 80);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;

            /*
             * 保存ボタン
             */
            // 
            // button1
            // 
            button1.Location = new Point(220, 170);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;

            /*
             * フォーム
             */
            // 
            // fatPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fatPerson";
            Text = "fatPerson";

            ((ISupportInitialize) pictureBox1).EndInit();

            ResumeLayout(false);

            PerformLayout();

        }

        #endregion

        /*
         * ID
         */
        private Label label1;
        private Label label2;

        /*
         * 姓
         */
        private Label label3;
        private Label label4;
        private TextBox textBox1;

        /*
         * 名
         */
        private Label label5;
        private Label label6;
        private TextBox textBox2;

        /*
         * 誕生日
         */
        private DateTimePicker dateTimePicker1;

        /*
         * 年齢
         */
        private Label label7;
        private Label label8;

        /*
         * イメージ
         */
        private PictureBox pictureBox1;

        /*
         * 保存ボタン
         */
        private Button button1;

    }

}