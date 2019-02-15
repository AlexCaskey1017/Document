using System;
using System.IO;

namespace documentChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*display document followed by a blank line*/

            Console.WriteLine("Document");

            Console.WriteLine("");

            /*promt user for a document name*/

            string nameInput;
            Console.Write("what would you like to name the document");
            nameInput = Console.ReadLine();
            Console.WriteLine("you entered", nameInput);

            string contentInput;
            Console.Write("What is this document for?");
            contentInput = Console.ReadLine();
            Console.WriteLine("the content is", contentInput);

            /*make users input a text file*/

            try
            {
                TextWriter tw = new StreamWriter("d:/nameInput.txt", true);
                tw.WriteLine("contentInput");
                tw.Close();
                Console.WriteLine(nameInput, "was successfully saved. The document contains", contentInput, "characters.");

            }
            catch (Exception e)
            {
                Console.Write(e);
            }

            Console.Read();

        }
    }
}
