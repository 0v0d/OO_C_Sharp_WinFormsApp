using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_C_Sharp_WinFormsApp
{

    /// <summary>
    /// 利用者登録
    /// </summary>
    public partial class RegisterUser : Form
    {

        private Place place = NullPlace.get();
        private Person person = NullPerson.get();
        private PlaceRegister placeRegister = NullPersonPlaceRegister.get();
        private Status status = new Status();

        public RegisterUser(Place place)
        {

            Debug.Assert(place != null);

            this.place = place;

            Debug.Assert(this.place != null);

            InitializeComponent();

            Text = "利用者登録";

        }

        /// <summary>
        ///  Makes the control display by setting the visible property to true
        /// </summary>
        public virtual RegisterUser show()
        {

            if (person is NullObject)
            {

                // 編集中でなければ新規に利用者を作成する
                Controls.Add(new PersonPanel(person = new ExtendedPerson()));

                // データ登録用のオブジェクトを生成する
                placeRegister = new PersonPlaceRegister(place, person).setStatus(status.addValue(SaveStatus.Temporary));

            }

            // 表示する
            Show();

            return this;

        }

        /// <summary>
        ///  Brings this control to the front of the zorder.
        /// </summary>
        public virtual RegisterUser bringToFront()
        {

            // 最前面に配置する
            BringToFront();

            return this;

        }

        /// <summary>
        /// 一時保存
        /// </summary>
        /// <returns></returns>
        public virtual RegisterUser save()
        {

            place.add(placeRegister);

            return this;

        }

        /// <summary>
        /// 登録
        /// </summary>
        /// <returns></returns>
        public virtual RegisterUser register()
        {

            place.add(placeRegister.setStatus(status.addValue(SaveStatus.Complete)));

            return this;

        }

        /// <summary>
        /// 登録終了
        /// </summary>
        /// <returns></returns>
        public virtual RegisterUser finish()
        {

            Controls.RemoveAt(0);

            person = NullPerson.get();

            return hide();

        }

        /// <summary>
        ///  Hides the control by setting the visible property to false;
        /// </summary>
        public virtual RegisterUser hide()
        {

            // 非表示にする
            Hide();

            return this;

        }

    }

    public class NullRegisterUser : RegisterUser, NullObject
    {

        private static RegisterUser registerUser = new NullRegisterUser();

        private NullRegisterUser() : base(NullPlace.get())
        {

        }

        public static RegisterUser get()
        {

            return registerUser;

        }

        public override RegisterUser show()
        {

            return this;

        }

        public override RegisterUser bringToFront()
        {

            return this;

        }

        public override RegisterUser register()
        {

            return this;

        }

        public override RegisterUser finish()
        {

            return this;

        }

        public override RegisterUser hide()
        {

            return this;

        }

    }

}