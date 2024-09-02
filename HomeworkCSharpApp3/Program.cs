using System.Net.Sockets;
using System.Net;
using System.Text;

namespace HomeworkCSharpApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ChatServer.Server();
            }
            else
            {
                ChatClient.Client(args);
            }
        }
    }
}
