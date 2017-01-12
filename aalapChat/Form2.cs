using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//for socket
using System.Net.Sockets;//for socket

namespace aalapChat
{
    
    public partial class MainChatBox : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
         
        private dbSet dbNew = new dbSet();
        private friend[] frndsInfoArray;
        private Button[] buttonArray;
        private int totalFrds=0,activeFrdMemId,msgLimit=0;

        public MainChatBox()
        {
            InitializeComponent();
            dbNew.getAllUsers();
            AutoCompleteText();
            sck = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress,true);
        }

        public String GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily==AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    String receivedMessage = eEncoding.GetString(receivedData);

                    chatListBox.Items.Add("Friend: "+receivedMessage);
                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length,SocketFlags.None,ref epRemote, new AsyncCallback(MessageCallBack),buffer);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }


        private void MainChatBox_Load(object sender, EventArgs e)
        {
            //this.Controls.Add(contactPanel);
            //contactPanel_Paint(object sender);
        }

        private void createConButton()
        {
            int horizotal = 3;
            int vertical = 3;
            string query;
            query = "SELECT * FROM `convtable` WHERE msgTo = ' " + dbSet.mem_id() + " ' OR msgForm = ' " + dbSet.mem_id() + "' ";
            totalFrds = dbNew.getFrdsNumber(query);

            buttonArray = new Button[totalFrds];
                   frndsInfoArray = new friend[totalFrds];
            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(334, 50);
                buttonArray[i].Location = new Point(horizotal, vertical);
                buttonArray[i].Text = (dbNew.getFrndUname(i));
                buttonArray[i].Visible = true;
                buttonArray[i].BackColor = Color.SkyBlue;
                buttonArray[i]. Click += new EventHandler(ButtonClick);
                vertical = vertical + 55;
                contactPanel.Controls.Add(buttonArray[i]); //adding the button into the panel named"contactPanel"

                //adding information to friend class.
                //frndsInfoArray[i].UserName = buttonArray[i].Text;

            }

        }
        private void ButtonClick(object sender, EventArgs e)
        {
            chatListBox.Items.Clear();
            Button btn = (Button)sender;
            activeFrdMemId= dbNew.ActiveFrdMemId("SELECT `mem_id`  FROM `membertable` WHERE `user_name` = '"+ btn.Text+"'");
            chatListBox.Items.Add(activeFrdMemId.ToString());
            btn.Enabled = false;

            if (msgLimit>0)
                {
                    msgLimit = 0;
                }
        }

        private void form2label_Click(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (msgBox.Text.Length != 0)
            {
                //write the code to send msg
                try
                {
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] msg = new byte[1500];
                    msg = enc.GetBytes(msgBox.Text);

                    sck.Send(msg);
                    chatListBox.Items.Add("You: "+msgBox.Text);

                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.ToString());
                }
                string query = "INSERT INTO `msgtable`( `msg_form`, `msg_to`, `text`) VALUES (" + dbSet.mem_id() + " , " + activeFrdMemId + " , '" + msgBox.Text + "')";
                dbNew.addMemberToContact(query);
            }
            else
            {
                MessageBox.Show("No Text in Message Box");
            }
            msgBox.Clear();
        }

        private void msgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void myProfile_Click(object sender, EventArgs e)
        {
            dbSet.showMyInfo();
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            editPanel.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            editPanel.Visible = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string st = dbSet.mem_id().ToString();
            MessageBox.Show(st);
        }

        private void contactPanel_Paint(object sender, PaintEventArgs e)
        {
            createConButton();
        }

        private void add_frd_Click(object sender, EventArgs e)
        {
            int id = dbNew.ActiveFrdMemId("SELECT `mem_id`  FROM `membertable` WHERE `user_name` = '" + textBox1.Text + "'");

            dbNew.addMemberToContact("INSERT INTO `convtable`(`msgForm`, `msgTo`) VALUES ( " + dbSet.mem_id() + " , " +id+ " )");
            this.Controls.Clear();
            this.InitializeComponent();
            this.dbNew.getAllUsers();
            this.AutoCompleteText();
            //sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        }
        public void AutoCompleteText()
        {
            int infoIndex = 0; 
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            while (infoIndex < dbNew.getAllUserInfoIndex())
            {
                coll.Add(dbNew.getOthersname(infoIndex));
                infoIndex++;
            }
            textBox1.AutoCompleteCustomSource = coll;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbNew.allUserInfo);
            DV.RowFilter = String.Format("user_name LIKE '%{0}%' ", textBox1.Text);
        }

        private void StartChat_Click(object sender, EventArgs e)
        {
            try
            {
                int MyPort = dbSet.mem_id();
                MyPort = MyPort + 79;
                int FrdsPort = activeFrdMemId;
                FrdsPort = FrdsPort + 79;

                epLocal = new IPEndPoint(IPAddress.Parse(GetLocalIp()), Convert.ToInt32(MyPort));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(GetLocalIp()), Convert.ToInt32(FrdsPort));
                sck.Connect(epRemote);

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ShowOldMsg_Click(object sender, EventArgs e)
        {
            msgLimit = msgLimit + 10;
            string query = "SELECT  `msg_form`, `msg_to`, `text` FROM `msgtable` WHERE `msg_form` = "+activeFrdMemId+" AND `msg_to` = "+dbSet.mem_id()+" OR `msg_to` = "+activeFrdMemId+"  AND `msg_form` = "+dbSet.mem_id()+" ORDER BY `datetime` LIMIT "+msgLimit+" ";
            int size= dbNew.setMsgTable(query);

            for (int i = 0; i < size; i++)
            {
                chatListBox.Items.Add(dbNew.getTextMsg(i, activeFrdMemId, dbSet.mem_id()));
            }
        }
    }
}
