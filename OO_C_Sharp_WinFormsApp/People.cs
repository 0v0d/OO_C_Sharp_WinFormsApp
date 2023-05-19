using System;
using System.Windows.Forms;

namespace OO_C_Sharp_WinFormsApp
{

    public partial class People : Form
    {

        public People()
        {

            InitializeComponent();

            SuspendLayout();

            PersonPanel personPanel = new PersonPanel(new PersonModel(
                // int id
                1,
                // String familyName
                "�O��",
                // String name
                "���s",
                // int yearOfBirth
                1969,
                // int monthOfBirth
                12,
                // int dayOfBirth
                18,
                // Image image
                Properties.Resources.image_01_60x80));

            Controls.Add(new PersonPanel(NullPerson.get()));
            Controls.Add(personPanel.setLocation(320, 145));
            personPanel.bringToFront(); // �R���g���[���̒ǉ����ɍőO�ʂ֔z�u����ƌ��ʂ��Ȃ��̂Œǉ���ɂ���

            /*
             * �t�H�[��
             */
            Text = "�l�X";

            ResumeLayout(false);

            PerformLayout();

        }

    }

}