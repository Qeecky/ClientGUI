using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientGUI
{
    public interface IClientView
    {
        public void listen();

        public void set_client(TcpClient cl);
        public void show_message(String msg);
    }
}
