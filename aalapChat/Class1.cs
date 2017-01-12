using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace aalapChat
{
   
    public class dbSet
    {
        private MySqlConnection con;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int i = 0, numOfFrds = 0;
        private DataTable dt, contactsTable, frndInfoTable,msgTable;
        public DataTable allUserInfo,frdsMemId;


        public static mySelf myInfo = new mySelf(); //my info is saved.

        public dbSet()
        {
            server = "localhost";
            database = "aalapdb";
            uid = "root";
            
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            con = new MySqlConnection(connectionString);
        }

        ~dbSet()
        {
            con.Dispose();
            MessageBox.Show("Terminated");
        }
        public void addMemberToContact(String query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                IAsyncResult result = cmd.BeginExecuteNonQuery();
                cmd.EndExecuteNonQuery(result);
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void sendQuery(string query)
        {
            try
            {
                i = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;

                //IAsyncResult result = cmd.BeginExecuteNonQuery();
                //cmd.EndExecuteNonQuery(result);

                dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt); //dt gets all the table returned by sql
                con.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                i = -1;
            }
        }

        public int getFrdsNumber(string query)
        {
            try
            {
                numOfFrds = 0;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                contactsTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(contactsTable); //dt gets all the table returned by sql
                con.Close();
                numOfFrds = Convert.ToInt32(contactsTable.Rows.Count.ToString());
                
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            return numOfFrds;
        }
        public void getAllUsers()
        {
            string query = "SELECT user_name FROM `membertable`"; // select er por chilo: `mem_id`, `name` , 
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                allUserInfo = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(allUserInfo); 
                con.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public int getAllUserInfoIndex()
        {
            int a = 0;
            a=Convert.ToInt32(allUserInfo.Rows.Count.ToString());
            return a;
        }

        public string getOthersname(int indexInt)
        {
            string info=allUserInfo.Rows[indexInt]["user_name"].ToString();
            return info;
        }
        public int registerRow(string query)
        {
            sendQuery(query);
            if (i != -1)
            {
                i = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            return i;
        }

        public int loginRow(string query)
        {

            sendQuery(query);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i >0)
            {       
                myInfo.Name = dt.Rows[0]["name"].ToString();
                myInfo.UserName = dt.Rows[0]["user_name"].ToString();
                myInfo.MemId = Convert.ToInt32(dt.Rows[0]["mem_id"].ToString());
                myInfo.Email = dt.Rows[0]["email"].ToString();

                
            }

            return i;
        }
        public int frndsMemId(int j)
        {
            if (int.Parse(contactsTable.Rows[j]["msgTo"].ToString()) != mem_id())
            {
                return int.Parse(contactsTable.Rows[j]["msgTo"].ToString());
            }
            else if (int.Parse(contactsTable.Rows[j]["msgForm"].ToString()) != mem_id())
            {
                return int.Parse(contactsTable.Rows[j]["msgForm"].ToString());
            }
            else
            {
                MessageBox.Show("No Friends");
                return 0;
            }
        }
        public int ActiveFrdMemId(string query)
        {

            //string query = "SELECT user_name FROM `membertable`"; // select er por chilo: `mem_id`, `name` , 
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                frdsMemId = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(frdsMemId);
                con.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return int.Parse(frdsMemId.Rows[0]["mem_id"].ToString());
        }
        public int setMsgTable(String query)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                msgTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(msgTable);
                con.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return Convert.ToInt32(msgTable.Rows.Count.ToString());
        }

        public String getTextMsg(int index,int activeFrandId, int myId)
        {
            if (int.Parse(msgTable.Rows[index]["msg_form"].ToString()) == myId)
            {
                return "You: " + msgTable.Rows[index]["text"].ToString();
            }
            else if (int.Parse(msgTable.Rows[index]["msg_form"].ToString()) == activeFrandId)
            {
                return "Friend: " + msgTable.Rows[index]["text"].ToString();
            }
            else
            {
                return null;
            }
        }

        public string getFrndUname(int index)
        {
            try
            {
                string query = "SELECT `name` , `email` , `user_name` FROM `membertable` WHERE `mem_id` = '" + frndsMemId(index) + " ' ";
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                frndInfoTable = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(frndInfoTable); //dt gets all the table returned by sql
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            return frndInfoTable.Rows[i]["user_name"].ToString();
        }


        public static void showMyInfo()
        {
            myInfo.showMySelf();
        }
        public static int mem_id()
        {
            return myInfo.geMyMemId();
        }

    }
}
