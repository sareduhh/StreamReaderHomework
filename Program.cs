using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderHomework
{
    class Program
    {


        static void Main(string[] args)
        {

           
        //Create an instance of StreamReader
        StreamReader reader = new StreamReader("..\\..\\..\\StreamReaderHomework.txt");
            string line = reader.ReadToEnd();

            //print the first line only
             Console.WriteLine(line);
            
            string vowels = line.Replace("a", "A").Replace("e", "E").Replace("i", "I").Replace("o", "O").Replace("u", "U");

            Console.WriteLine(vowels);

     
            reader.Close();

       


        }


    }
    
}
