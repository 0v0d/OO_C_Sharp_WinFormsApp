using System.Windows.Forms;

namespace OO_C_Sharp_WinFormsApp
{

	public partial class PersonForm : Form
	{

		public PersonForm()
		{

			InitializeComponent();

			SuspendLayout();

			Controls.Add(new PersonPanel(new PersonModel(
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
					Properties.Resources.image_01_60x80)));

			/*
			 * �t�H�[��
			 */
			Text = "�P��Ӗ��ȁw�l�x";

			ResumeLayout(false);

			PerformLayout();

		}

	}

}