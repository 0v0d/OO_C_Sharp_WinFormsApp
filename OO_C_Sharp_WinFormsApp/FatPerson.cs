using System.Windows.Forms;

namespace OO_C_Sharp_WinFormsApp
{

    /// <summary>
    /// ���d�Ӗ��ȁw�l�x�I�u�W�F�N�g�ł��B
    /// </summary>
    public partial class FatPerson : Form
    {

        /// <summary>
        /// ID
        /// </summary>
        private int id;

        /// <summary>
        /// ��
        /// </summary>
        private String familyName;

        /// <summary>
        /// ��
        /// </summary>
        private String name;

        /// <summary>
        /// �a����
        /// </summary>
        private DateTime birthday;

        /// <summary>
        /// �C���[�W
        /// </summary>
        private Image image;

        /// <summary>
        /// �R���X�g���N�^�ł��B
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
             * ��
             */
            label3.Text = "��";
            addFamilyName(familyName);
            label4.Text = textBox1.Text = getFamilyName();

            /*
             * ��
             */
            label5.Text = "��";
            addName(name);
            label6.Text = textBox2.Text = getName();

            /*
             * �a����
             */
            addBirthday(new DateTime(yearOfBirth, monthOfBirth, dayOfBirth, 0, 0, 0));
            dateTimePicker1.Value = getBirthday();

            /*
             * �N��
             */
            label7.Text = "�N��";
            label8.Text = age().ToString();

            /*
             * �C���[�W
             */
            addImage(image);
            pictureBox1.Image = getImage();

            /*
             * �ۑ��{�^��
             */
            button1.Text = "���͂������e��ۑ�����";

            /*
             * �t�H�[��
             */
            Text = "���d�Ӗ��ȁw�l�x";

        }

        /// <summary>
        /// ID��Ԃ��܂��B
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
        /// ����Ԃ��܂��B
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
        /// ����Ԃ��܂��B
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
        /// �t���l�[����Ԃ��܂��B
        /// </summary>
        /// <returns></returns>
        public String fullName()
        {

            return getFamilyName() + " " + getName();

        }

        /// <summary>
        /// �a������Ԃ��܂��B
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
        /// �N���Ԃ��܂��B
        /// </summary>
        /// <returns></returns>
        public int age()
        {

            int age = DateTime.Today.Year - getBirthday().Year;

            // �a�����O�ł���ΔN��� 1 ������
            if (DateTime.Today.Month.CompareTo(getBirthday().Month) < 0
                || DateTime.Today.Month.Equals(getBirthday().Month) && DateTime.Today.Day.CompareTo(getBirthday().Day) < 0)
            {

                age--;

            }

            return age;

        }

        /// <summary>
        /// �C���[�W��Ԃ��܂��B
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
        /// �ۑ��{�^���̃N���b�N�C�x���g�ł��B
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            /*
             * ��
             */
            addFamilyName(textBox1.Text);
            label4.Text = getFamilyName();

            /*
             * ��
             */
            addName(textBox2.Text);
            label6.Text = getName();

            /*
             * �a����
             */
            addBirthday(dateTimePicker1.Value);
            dateTimePicker1.Value = getBirthday();

            /*
             * �N��
             */
            label8.Text = age().ToString();

            /*
             * �C���[�W
             */
            addImage(pictureBox1.Image);
            pictureBox1.Image = getImage();

        }

    }

}