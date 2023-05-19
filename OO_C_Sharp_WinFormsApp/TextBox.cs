using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_C_Sharp_WinFormsApp
{

    public abstract class BaseTextBox : TextBox
    {

        public BaseTextBox()
        {

        }

        public TextBox setLocation(int x, int y)
        {

            // 表示位置を指定する
            Location = new Point(x, y);

            return this;

        }

    }

    public class FamilyNameTextBox : BaseTextBox
    {

        private Person person;

        public FamilyNameTextBox(Person person)
        {

            Debug.Assert(person != null);

            this.person = person;

            Debug.Assert(this.person != null);

            Name = "familyNameTextBox";
            Text = this.person.getFamilyName();

        }

    }

}
