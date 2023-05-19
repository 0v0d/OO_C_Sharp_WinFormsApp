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
					"三木",
					// String name
					"崇行",
					// int yearOfBirth
					1969,
					// int monthOfBirth
					12,
					// int dayOfBirth
					18,
					// Image image
					Properties.Resources.image_01_60x80)));

			/*
			 * フォーム
			 */
			Text = "単一責務な『人』";

			ResumeLayout(false);

			PerformLayout();

		}

	}

}