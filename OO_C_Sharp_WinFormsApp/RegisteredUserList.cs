using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OO_C_Sharp_WinFormsApp
{

    /// <summary>
    /// �o�^�ςݗ��p��
    /// </summary>
    public partial class RegisteredUserList : Form
    {

        private PersonDataBase userList = PersonDataBase.get();

        public RegisteredUserList()
        {

            InitializeComponent();

            SuspendLayout();

            method4Test(); // �e�X�g�p�̃��\�b�h�i���Ɨp�j �������[�X���ɍ폜�i�������̓��b�N�I�u�W�F�N�g�Ŏ����j

            initialize();

            /*
             * �t�H�[��
             */
            Text = "�o�^�ςݗ��p��";

            ResumeLayout(false);

            PerformLayout();

        }

        private void method4Test()
        {

            userList.save(NullPerson.get());

            userList.removeAll();

        }

        private void initialize()
        {

            removeAll();

            int userCount = userList.count();

            if (userCount > 0)
            {

                int x = 20;
                int y = 20;
                int incrementalValueOfX = 800 / userCount - 100;
                int incrementalValueOfY = 450 / userCount - 50;

                foreach (Person user in userList.list())
                {

                    PersonPanel personPanel = new PersonPanel(user);

                    Controls.Add(personPanel);

                    personPanel.setLocation(x, y).bringToFront(); // �R���g���[���̒ǉ����ɍőO�ʂ֔z�u����ƌ��ʂ��Ȃ��̂Œǉ���ɂ���

                    x += incrementalValueOfX;
                    y += incrementalValueOfY;

                }

            }

        }

        /// <summary>
        ///  Makes the control display by setting the visible property to true
        /// </summary>
        public RegisteredUserList show()
        {

            // �����ɕ\���O�̏������L�q�ł��܂�

            // �\������
            Show();

            return this;

        }

        /// <summary>
        ///  Brings this control to the front of the zorder.
        /// </summary>
        public RegisteredUserList bringToFront()
        {

            // �őO�ʂɔz�u����
            BringToFront();

            return this;

        }

        /// <summary>
        /// ���X�g�̌�����Ԃ��܂��B
        /// </summary>
        /// <returns></returns>
        public int count()
        {

            return Controls.Count;

        }

        /// <summary>
        /// ���X�g���󂩂ǂ�����Ԃ��܂��B
        /// </summary>
        /// <returns>��̏ꍇ true</returns>
        public bool isEmpty()
        {

            return count() == 0;

        }

        /// <summary>
        /// ���ׂẴf�[�^��j�����܂��B
        /// </summary>
        /// <returns></returns>
        private RegisteredUserList removeAll()
        {

            int removeCount = count();

            while (removeCount-- > 0)
            {

                Controls.RemoveAt(removeCount);

            }

            return this;

        }

        public RegisteredUserList save(PersonPlaceRegister personPlaceRegister)
        {

            Debug.Assert(personPlaceRegister != null);

            userList.save(personPlaceRegister.getPerson());

            return this;

        }

        public RegisteredUserList saveTemporary(PersonPlaceRegister personPlaceRegister)
        {

            Debug.Assert(personPlaceRegister != null);

            // ���ꎞ�ۑ��͖�����

            return this;

        }

    }

}