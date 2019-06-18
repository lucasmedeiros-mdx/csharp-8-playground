using System.IO;

namespace Playground.NetCore
{
    public class UsingDeclarations
    {
        public void CurrentUsingDeclarations()
        {
            using (var file = new FileStream("input.txt", FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    var s = reader.ReadToEnd();

                    // Do something with data
                }
            }
        }
    }
}
