using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientGUI
{
    public class ClientModel
    {
        IClientView view;
        TcpClient tcpClient;
        StreamWriter streamWriter;
        public ClientModel(IClientView view, String ip)
        {
            this.view = view;
            this.ip = ip;
        }
        String ip;
        public void connect()
        {
            tcpClient = new TcpClient();
            IPAddress address = IPAddress.Parse(ip);
            tcpClient.Connect(address, 3000);
            streamWriter = new StreamWriter(tcpClient.GetStream());
            view.set_client(tcpClient);
            Thread listener = new Thread(new ThreadStart(view.listen));
            listener.Start();
        }

        public void close_connection()
        {
            tcpClient.Close();
        }

        public void send_msg(String msg)
        {
            streamWriter.WriteLine(msg);
            streamWriter.Flush();
        }
    }
}

