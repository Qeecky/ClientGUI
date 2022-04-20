using System.Net.Sockets;

namespace ClientGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client = null;
        StreamReader sr = null;
        public void listen()
        {
            sr = new StreamReader(client.GetStream());
            String response = "";
            try
            {
                while ((response = sr.ReadLine()) != "")
                {
                    //Console.WriteLine(response);
                    
                }
            }
            catch (System.ObjectDisposedException e)
            {
                //Console.WriteLine("Error! You can't read anymore!");
            }
        }

        public void set_client(TcpClient cl)
        {
            client = cl;
        }
        public void show_message(String msg)
        {
            //Console.WriteLine(msg);
        }
        private void Username_label_Click(object sender, EventArgs e)
        {

        }
    }
}