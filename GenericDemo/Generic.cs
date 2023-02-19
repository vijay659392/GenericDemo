using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    //Generic means is general form
    //it does not specify any specific perticular data type
    //Gneric data type is work at run-time
    //using system,Collection.Generic;
    public class Generic
    {
        //<> = this is a place holder
        //T = this is a type
        public static void IntNum<T>(T[] array)
        {
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
