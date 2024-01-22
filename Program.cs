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

            /*Test1 - Able to create a kitchen, complete with places for food to be stored:
            fridge, freezer, store cupboards, fruit bowl*/
            
            Kitchen mykitchen = new Kitchen();
                //Console.WriteLine(mykitchen.Name);
            //mykitchen.fridge.Add("A testItem");
                //Console.WriteLine("This is the fridge, in which I have stored " + mykitchen.fridge[0]);

            //Test3
            mykitchen.AddItems(mykitchen);


            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
