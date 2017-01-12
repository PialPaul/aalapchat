using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aalapChat
{
    public  class person
    {
        private string name;
        private string userName;
        private int memId;
        private string email;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public int MemId
        {
            get
            {
                return memId;
            }
            set
            {
                memId = value;
            }

        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

    }



    public  class mySelf : person
    {
        public void showMySelf()
        {
           string me = "Name: "+this.Name+"\n"+"User Name: "+this.UserName+"\n"+"E-mail: "+this.Email+"\n";
            //string me = "Name: " +person.Name + "\n" + "User Name: " +person. UserName + "\n" + "E-mail: " +person. Email + "\n";
            MessageBox.Show(me);
        }
        public int geMyMemId()
        {
            return MemId;
        }
    }


    public class friend : person
    {
        public string showMyFrnds()
        {
            string frnds = "Name: " + this.Name + "\n" + "User Name: " + this.UserName + "\n" + "E-mail: " + this.Email + "\n";
            return frnds;
        }

    }

}
