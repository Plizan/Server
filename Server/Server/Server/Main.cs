using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Buffer;

namespace Server
{
    class Main
    {
        IPAddress iPAddress = IPAddress.Parse("118.37.68.159");

        public Main(string[] args)
        {
            Init();
        }

        private void Init()
        {
            {
                TPlayer player = new TPlayer();
            }
        }
    }
}
