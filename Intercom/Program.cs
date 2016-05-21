using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intercom
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = createArrayForTest();

            var test = new List<object>();
            test = Flatten(list);

            outputList(test);

            Console.ReadLine();
        }

        private static List<object> createArrayForTest()
        {
            var list = new List<object>();

            list.Add(new List<object> { 1 });
            list.Add(2);
            list.Add(new List<object> { new List<object> { 3, new List<object> { 1, 2, 3, 4, 5, 6 } , 4 }, 5 });
            list.Add(new List<object> { new List<object> { new List<object> {5256,6549684,121 },351651 } ,1,1,10,002,64});
            list.Add(new List<object> { new List<object> { new List<object> { 6 } ,6666} ,1234});
            list.Add(7);
            list.Add(8);
            list.Add(new List<object> { });

            return list;
        }

        private static void outputList(List<object> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static List<object> Flatten(List<object> list)
        {
            var result = new List<object>();
            foreach (var item in list)
            {
                if (item is List<object>)
                {
                    result.AddRange(Flatten(item as List<object>));
                }
                else
                {
                    result.Add(item);                    
                }
            }
            return result;
        }
    }
}
