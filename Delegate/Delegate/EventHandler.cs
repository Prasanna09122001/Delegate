using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void DelEventHandler();
    internal class EventHandler
    {
        public static event DelEventHandler del;
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("usa");
        }
        public static void Uk()
        {
            Console.WriteLine("uk");
        }
        public static void EventImplement()
        {
            del += new DelEventHandler(India);
            del += new DelEventHandler(USA);
            del += new DelEventHandler(Uk);
            del.Invoke();
        }
    }
}
