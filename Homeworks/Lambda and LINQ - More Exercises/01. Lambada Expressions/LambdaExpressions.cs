using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lambada_Expressions
{
    class LambdaExpressions
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine()
                .Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<string, string>> registry = 
                new Dictionary<string, Dictionary<string, string>>();

            var selector = "";
            var selectorObject = "";
            var property = "";

            while (line[0] != "lambada")
            {
                if (line[0] != "dance")
                {
                    selector = line[0];
                    selectorObject = line[1];
                    property = line[2];

                    if (!registry.ContainsKey(selector))
                    {
                        registry[selector] = new Dictionary<string, string>();
                    }
                    registry[selector][selectorObject] = property;
                }
                else
                {
                    registry = registry
                        .ToDictionary(x => x.Key, x => x.Value
                            .ToDictionary(y => y.Key,
                                y => y.Key + "." + y.Value));
                }

                line = Console.ReadLine()
                        .Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var select in registry)
            {
                foreach (var selectObject in select.Value)
                {
                    Console.WriteLine("{0} => {1}.{2}", select.Key, selectObject.Key, selectObject.Value);
                }
            }
        }
    }
}
