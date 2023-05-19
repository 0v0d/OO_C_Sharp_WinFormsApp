using System.Windows.Forms;

namespace OO_C_Sharp_WinFormsApp
{

    /// <summary>
    /// 多重責務な『人』オブジェクトです。
    /// </summary>
    public partial class FatPerson : Form
    {

        /// <summary>
        /// ID
        /// </summary>
        private int id;

        /// <summary>
        /// 姓
        /// </summary>
        private String familyName;

        /// <summary>
        /// 名
        /// </summary>
        private String name;

        /// <summary>
        /// 誕生日
        /// </summary>
        private DateTime birthday;

        /// <summary>
        /// イメージ
        /// </summary>
        private Image image;

        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="familyName"></param>
        /// <param name="name"></param>
        /// <param name="yearOfBirth"></param>
        /// <param name="monthOfBirth"></param>
        /// <param name="dayOfBirth"></param>
        /// <param name="image"></param>
        public FatPerson(int id, String familyName, String name, int yearOfBirth, int monthOfBirth, int dayOfBirth, Image image)
        {

            InitializeComponent();

            /*
             * ID
             */
            label1.Text = "ID";
            addId(id);
            label2.Text = getId().ToString();

            /*
             * 姓
             */
            label3.Text = "姓";
            addFamilyName(familyName);
            label4.Text = textBox1.Text = getFamilyName();

            /*
             * 名
             */
            label5.Text = "名";
            addName(name);
            label6.Text = textBox2.Text = getName();

            /*
             * 誕生日
             */
            addBirthday(new DateTime(yearOfBirth, monthOfBirth, dayOfBirth, 0, 0, 0));
            dateTimePicker1.Value = getBirthday();

            /*
             * 年齢
             */
            label7.Text = "年齢";
            label8.Text = age().ToString();

            /*
             * イメージ
             */
            addImage(image);
            pictureBox1.Image = getImage();

            /*
             * 保存ボタン
             */
            button1.Text = "入力した内容を保存する";

            /*
             * フォーム
             */
            Text = "多重責務な『人』";

        }

        /// <summary>
        /// IDを返します。
        /// </summary>
        /// <returns></returns>
        public int getId()
        {

            return id;

        }

        public void addId(int id)
        {

            this.id = id;

        }

        /// <summary>
        /// 姓を返します。
        /// </summary>
        /// <returns></returns>
        public String getFamilyName()
        {

            return familyName;

        }

        public void addFamilyName(String familyName)
        {

            this.familyName = familyName;

        }

        /// <summary>
        /// 名を返します。
        /// </summary>
        /// <returns></returns>
        public String getName()
        {

            return name;

        }

        public void addName(String name)
        {

            this.name = name;

        }

        /// <summary>
        /// フルネームを返します。
        /// </summary>
        /// <returns></returns>
        public String fullName()
        {

            return getFamilyName() + " " + getName();

        }

        /// <summary>
        /// 誕生日を返します。
        /// </summary>
        /// <returns></returns>
        public DateTime getBirthday()
        {

            return birthday;

        }

        public void addBirthday(DateTime birthday)
        {

            this.birthday = birthday;

        }

        /// <summary>
        /// 年齢を返します。
        /// </summary>
        /// <returns></returns>
        public int age()
        {

            int age = DateTime.Today.Year - getBirthday().Year;

            // 誕生日前であれば年齢から 1 を引く
            if (DateTime.Today.Month.CompareTo(getBirthday().Month) < 0
                || DateTime.Today.Month.Equals(getBirthday().Month) && DateTime.Today.Day.CompareTo(getBirthday().Day) < 0)
            {

                age--;

            }

            return age;

        }

        /// <summary>
        /// イメージを返します。
        /// </summary>
        /// <returns></returns>
        public Image getImage()
        {

            return image;

        }

        public void addImage(Image image)
        {

            this.image = image;

        }

        /// <summary>
        /// 保存ボタンのクリックイベントです。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            /*
             * 姓
             */
            addFamilyName(textBox1.Text);
            label4.Text = getFamilyName();

            /*
             * 名
             */
            addName(textBox2.Text);
            label6.Text = getName();

            /*
             * 誕生日
             */
            addBirthday(dateTimePicker1.Value);
            dateTimePicker1.Value = getBirthday();

            /*
             * 年齢
             */
            label8.Text = age().ToString();

            /*
             * イメージ
             */
            addImage(pictureBox1.Image);
            pictureBox1.Image = getImage();

        }

    }

}