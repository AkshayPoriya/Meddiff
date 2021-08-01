using System;

namespace Change_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Path path = new Path("/a/b/c/d");
            path.CD("../x");
            Console.WriteLine(path.current_path);
            path.CD("../../../medd/iff/technologies");
            Console.WriteLine(path.current_path);
            path.CD("../../..");
            Console.WriteLine(path.current_path);
            path.CD("../");
            Console.WriteLine(path.current_path);
        }
    }
}
