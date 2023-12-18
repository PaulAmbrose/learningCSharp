using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pantryAppCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen mykitchen = new Kitchen();
            mykitchen.Name = "myKitchen";
            mykitchen.AddItems();
        }
    }
}
