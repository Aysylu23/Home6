using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home6
{

    internal class Logger
    {
        private Queue<(string, string)> log = new Queue<(string, string)>();
        public void AddLog(string number, string operation)
        {
            log.Enqueue(new(number, operation));
        }
        public string GetLog()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" StackTrace: ");
            foreach (var item in log)
            {
                sb.Append(item.ToString());
                sb.Append(" ");
            }
            return sb.ToString();
        }

    }
}
