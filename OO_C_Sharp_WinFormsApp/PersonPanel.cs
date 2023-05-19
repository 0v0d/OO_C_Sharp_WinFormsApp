using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace OO_C_Sharp_WinFormsApp
{

    public class PersonPanel : Panel
    {

        Person person;

        public PersonPanel(Person person)
        {

            this.person = person;

            int tabIndex = 0;

            /*
             * ID
             */
            Controls.Add(createIdLabel());
            Controls.Add(createId(person));

            /*
             * 姓
             */
            Controls.Add(createFamilyNameLabel());
            Controls.Add(createFamilyName());
            Controls.Add(createFamilyNameTextBox(person, tabIndex++));

            /*
             * 名
             */
            Controls.Add(createNameLabel());
            Controls.Add(createName());
            Controls.Add(createNameTextBox(tabIndex++));

            /*
             * 誕生日
             */
            Controls.Add(createBirthdayDateTimePicker(tabIndex++));

            /*
             * 年齢
             */
            Controls.Add(createAgeLabel());
            Controls.Add(createAge());

            /*
             * イメージ
             */
            Controls.Add(createImagePictureBox());

            /*
             * 保存ボタン
             */
            Controls.Add(createSaveButton(tabIndex++));

            /*
             * フォーム
             */
            Location = new Point(20, 20);
            ClientSize = new Size(400, 225);
            BorderStyle = BorderStyle.Fixed3D;
            Name = "personPanel";
            Text = person.fullName();

        }

        /// <summary>
        /// Initializes a new instance of the <see cref='System.Drawing.Point'/> class with the specified coordinates.
        /// </summary>
        public PersonPanel setLocation(int x, int y)
        {

            // 表示位置を指定する
            Location = new Point(x, y);

            return this;

        }

        /// <summary>
        ///  Brings this control to the front of the zorder.
        /// </summary>
        public PersonPanel bringToFront()
        {

            // 最前面に配置する
            BringToFront();

            return this;

        }

        /// <summary>
        /// idLabel
        /// </summary>
        /// <returns></returns>
        private Label createIdLabel()
        {

            Label label = new Label();

            label.AutoSize = true;
            label.Location = new Point(30, 30);
            label.Name = "idLabel";
            label.Size = new Size(38, 15);
            label.TabStop = false;
            label.Text = "ID";

            return label;

        }

        /// <summary>
        /// id
        /// </summary>
        /// <returns></returns>
        private Label createId(Person person)
        {

            Label label = new PersonIdLabel(person).setLocation(100, 30);

            label.Size = new Size(38, 15);

            return label;

        }

        /// <summary>
        /// familyNameLabel
        /// </summary>
        /// <returns></returns>
        private Label createFamilyNameLabel()
        {

            Label label = new Label();

            label.AutoSize = true;
            label.Location = new Point(30, 60);
            label.Name = "familyNameLabel";
            label.Size = new Size(38, 15);
            label.TabStop = false;
            label.Text = "姓";

            return label;

        }

        /// <summary>
        /// familyName
        /// </summary>
        /// <returns></returns>
        private Label createFamilyName()
        {

            Label label = new Label();

            label.AutoSize = true;
            label.Location = new Point(100, 60);
            label.Name = "familyName";
            label.Size = new Size(38, 15);
            label.TabStop = false;
            label.Text = person.getFamilyName();

            return label;

        }

        /// <summary>
        /// familyNameTextBox
        /// </summary>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        private TextBox createFamilyNameTextBox(Person person, int tabIndex)
        {

            TextBox textBox = new FamilyNameTextBox(person).setLocation(170, 58);

            textBox.Size = new Size(100, 23);
            textBox.TabIndex = tabIndex;

            return textBox;

        }

        /// <summary>
        /// nameLabel
        /// </summary>
        /// <returns></returns>
        private Label createNameLabel()
        {

            Label label = new Label();

            label.AutoSize = true;
            label.Location = new Point(30, 90);
            label.Name = "nameLabel";
            label.Size = new Size(38, 15);
            label.TabStop = false;
            label.Text = "名";

            return label;

        }

        /// <summary>
        /// name
        /// </summary>
        /// <returns></returns>
        private Label createName()
        {

            Label label = new Label();

            label.AutoSize = true;
            label.Location = new Point(100, 90);
            label.Name = "name";
            label.Size = new Size(38, 15);
            label.TabStop = false;
            label.Text = person.getName();

            return label;

        }

        /// <summary>
        /// nameTextBox
        /// </summary>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        private System.Windows.Forms.TextBox createNameTextBox(int tabIndex)
        {

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();

            textBox.Location = new Point(170, 88);
            textBox.Name = "nameTextBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = tabIndex;
            textBox.Text = person.getName();

            return textBox;

        }

        /// <summary>
        /// birthdayDateTimePicker
        /// </summary>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        private DateTimePicker createBirthdayDateTimePicker(int tabIndex)
        {

            DateTimePicker dateTimePicker = new DateTimePicker();

            dateTimePicker.Location = new Point(170, 118);
            dateTimePicker.Name = "birthdayDateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = tabIndex;
            dateTimePicker.Value = person.getBirthday();

            return dateTimePicker;

        }

        /// <summary>
        /// ageLabel
        /// </summary>
        /// <returns></returns>
        private Label createAgeLabel()
        {

            Label label = new Label();

            label.AutoSize = true;
            label.Location = new Point(30, 120);
            label.Name = "ageLabel";
            label.Size = new Size(38, 15);
            label.TabStop = false;
            label.Text = "年齢";

            return label;

        }

        /// <summary>
        /// age
        /// </summary>
        /// <returns></returns>
        private Label createAge()
        {

            Label label = new Label();

            label.AutoSize = true;
            label.Location = new Point(100, 120);
            label.Name = "age";
            label.Size = new Size(38, 15);
            label.TabStop = false;
            label.Text = person.age().ToString();

            return label;

        }

        /// <summary>
        /// imagePictureBox
        /// </summary>
        /// <returns></returns>
        private PictureBox createImagePictureBox()
        {

            PictureBox pictureBox = new PictureBox();

            ((System.ComponentModel.ISupportInitialize) pictureBox).BeginInit();

            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(310, 30);
            pictureBox.Name = "imagePictureBox";
            pictureBox.Size = new Size(60, 80);
            pictureBox.TabStop = false;
            pictureBox.Image = person.getImage();

            ((System.ComponentModel.ISupportInitialize) pictureBox).EndInit();

            return pictureBox;

        }

        /// <summary>
        /// saveButton
        /// </summary>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        private Button createSaveButton(int tabIndex)
        {

            Button button = new Button();

            button.Location = new Point(220, 170);
            button.Name = "saveButton";
            button.Size = new Size(150, 23);
            button.TabIndex = tabIndex;
            button.Text = "入力した内容を保存する";
            button.UseVisualStyleBackColor = true;
            button.Click += saveButton_Click;

            return button;

        }

        private void saveButton_Click(object? sender, EventArgs e)
        {

            /*
             * 姓
             */
            // TODO どのようにすればデータを設定できるのか考える

            /*
             * 名
             */
            // TODO どのようにすればデータを設定できるのか考える

            /*
             * 誕生日
             */
            // TODO どのようにすればデータを設定できるのか考える

            /*
             * イメージ
             */
            // TODO どのようにすればデータを設定できるのか考える

        }

    }

}
