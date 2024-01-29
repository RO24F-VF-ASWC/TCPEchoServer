using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPEchoClient
{
    public class EchoClient
    {
        private const int PORT = 7;
        private const string HOST = "localhost";
        public EchoClient() { }
        public void Start()
        {
            using (TcpClient socket = new TcpClient(HOST, PORT))
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string str = "I'll send this message";
                Console.WriteLine("Sending: " + str);

                sw.WriteLine(str);
                sw.Flush();

                String? inStr = sr.ReadLine();
                Console.WriteLine("Receiving: " + inStr);
            }

        }
    }
}
