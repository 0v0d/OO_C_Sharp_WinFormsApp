using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_C_Sharp_WinFormsApp
{

	public interface Person
	{

		/// <summary>
		/// IDを返します。
		/// </summary>
		/// <returns></returns>
		int getId();

		/// <summary>
		/// 姓を返します。
		/// </summary>
		/// <returns></returns>
		String getFamilyName();

		Person addFamilyName(String familyName);

		/// <summary>
		/// 名を返します。
		/// </summary>
		/// <returns></returns>
		String getName();

		Person addName(String name);

		/// <summary>
		/// フルネームを返します。
		/// </summary>
		/// <returns></returns>
		String fullName();

		/// <summary>
		/// 誕生日を返します。
		/// </summary>
		/// <returns></returns>
		DateTime getBirthday();

		Person addBirthday(DateTime birthday);

		/// <summary>
		/// 年齢を返します。
		/// </summary>
		/// <returns></returns>
		int age();

		/// <summary>
		/// イメージを返します。
		/// </summary>
		/// <returns></returns>
		Image getImage();

		Person addImage(Image image);

	}

	/// <summary>
	/// 単一責務な『人』オブジェクトです。
	/// </summary>
	public class PersonModel : Person
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
		public PersonModel(int id, String familyName, String name, int yearOfBirth, int monthOfBirth, int dayOfBirth, Image image)
		{

			/*
			 * ID
			 */
			addId(id);

			/*
			 * 姓
			 */
			addFamilyName(familyName);

			/*
			 * 名
			 */
			addName(name);

			/*
			 * 誕生日
			 */
			addBirthday(new DateTime(yearOfBirth, monthOfBirth, dayOfBirth, 0, 0, 0));

			/*
			 * イメージ
			 */
			addImage(image);

		}

		public int getId()
		{

			return id;

		}

		public Person addId(int id)
		{

			this.id = id;

			return this;

		}

		public String getFamilyName()
		{

			return familyName;

		}

		public Person addFamilyName(String familyName)
		{

			this.familyName = familyName;

			return this;

		}

		public String getName()
		{

			return name;

		}

		public Person addName(String name)
		{

			this.name = name;

			return this;

		}

		public String fullName()
		{

			return getFamilyName() + " " + getName();

		}

		public DateTime getBirthday()
		{

			return birthday;

		}

		public Person addBirthday(DateTime birthday)
		{

			this.birthday = birthday;

			return this;

		}

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

		public Image getImage()
		{

			return image;

		}

		public Person addImage(Image image)
		{

			this.image = image;

			return this;

		}

	}

}