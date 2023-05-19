using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_C_Sharp_WinFormsApp {

	public abstract class BaseLabel : Label {

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

	public class PersonIdLabel : BaseLabel, IObserver {

		private Person person;

		public PersonIdLabel(Person person)
		{

			Debug.Assert(person != null);

			this.person = person;

			Debug.Assert(this.person != null);

			Name = "id";
			Update();

		}

		public void Update()
		{
			Text = this.person.getId().ToString();
		}
	}

	public class PersonNameLabel : BaseLabel, IObserver {

		private Person person;

		public PersonNameLabel(Person person)
		{

			Debug.Assert(person != null);

			this.person = person;

			Debug.Assert(this.person != null);

			Name = "name";
			Update();

		}

		public void Update()
		{
			Text = person.getName();
		}
	}
}