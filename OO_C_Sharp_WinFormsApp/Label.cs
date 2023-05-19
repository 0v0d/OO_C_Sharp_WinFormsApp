using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_C_Sharp_WinFormsApp
{

    public abstract class BaseLabel : Label
    {

        public BaseLabel()
        {

            AutoSize = true;
            TabStop = false;

        }

        public Label setLocation(int x, int y)
        {

            // 表示位置を指定する
            Location = new Point(x, y);

            return this;

        }

    }

    internal class PersonIdLabel : BaseLabel
    {

        private Person person;

        public PersonIdLabel(Person person)
        {

            Debug.Assert(person != null);

            this.person = person;

            Debug.Assert(this.person != null);

            Name = "id";
            Text = this.person.getId().ToString();

        }

    }

}