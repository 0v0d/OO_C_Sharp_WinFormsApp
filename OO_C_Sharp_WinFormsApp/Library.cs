using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
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

    public partial class Library : Form, Place
    {

        /// <summary>
        /// 利用者登録
        /// </summary>
        private RegisterUser registerUser = NullRegisterUser.get();
        /// <summary>
        /// 登録済み利用者
        /// </summary>
        private RegisteredUserList registeredUserList = new RegisteredUserList();
        private int id;
        private String name;

        public Library(int id, String name)
        {

            InitializeComponent();

            addId(id);
            Text = addName(name).getName();

            if (registeredUserList.isEmpty())
            {

                // 登録済み利用者がいない場合は、利用者登録画面を表示する
                showRegisterUser();

            }
            else
            {

                // 登録済み利用者の一覧を表示する
                showRegisteredUserList();

            }

        }

        private RegisterUser showRegisterUser()
        {

            if (registerUser is NullObject)
            {

                registerUser = new RegisterUser(this);

            }

            return registerUser.show().bringToFront();

        }

        private RegisteredUserList showRegisteredUserList()
        {

            return registeredUserList.show().bringToFront();

        }

        public int getId()
        {

            return id;

        }

        public Place addId(int id)
        {

            Debug.Assert(id >= 0);

            this.id = id;

            Debug.Assert(this.id >= 0);

            return this;

        }

        public String getName()
        {

            return name;

        }

        public Place addName(String name)
        {

            Debug.Assert(name != null);

            this.name = name;

            Debug.Assert(this.name != null);

            return this;

        }

        public Place add(PlaceRegister placeRegister)
        {

            Debug.Assert(placeRegister != null);

            // この場所にふさわしいかどうかを決めることができる
            if (placeRegister.getPlace() is Library)
            {

                if (placeRegister is PersonPlaceRegister)
                {

                    register(placeRegister as PersonPlaceRegister);

                }

            }

            return this;

        }

        private void register(PersonPlaceRegister? personPlaceRegister)
        {

            if (personPlaceRegister.getStatus().Equals(SaveStatus.Complete))
            {

                // DBに永続化する
                registeredUserList.save(personPlaceRegister);

            }
            else
            {

                // 一時保存用のDBに永続化する
                registeredUserList.saveTemporary(personPlaceRegister);

            }

        }

    }

}