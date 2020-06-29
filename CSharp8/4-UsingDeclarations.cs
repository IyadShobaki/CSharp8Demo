using System.IO;

namespace CSharp8
{
    public static class UsingDeclarationsDemo
    {
        public static int ConvertFiles()
        {
            int output = 0;

            // The traditional way without using declarations
            //// using statement handling the dispose of StreamReader
            //using (var inputFile = new StreamReader(@"D:\C#Projects\Temp\TestFile.txt"))
            //{

            //    // using statement handling the dispose of StreamWriter
            //    using (var outputFile = new StreamWriter(@"D:\C#Projects\Temp\OutputFile.txt"))
            //    {
            //        string line;
            //        while ((line = inputFile.ReadLine()) != null)
            //        {
            //            outputFile.WriteLine(line);
            //            output += 1;
            //        }
            //    }
            //}

            // Using declarations
            using StreamReader inputFile = new StreamReader(@"D:\C#Projects\Temp\TestFile.txt");
            using StreamWriter outputFile = new StreamWriter(@"D:\C#Projects\Temp\OutputFile.txt");

            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                outputFile.WriteLine(line);
                output += 1;
            }

            return output;
        }
    }
}
