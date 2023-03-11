namespace Week7_FA
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;
    using System.Diagnostics.Tracing;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a file path: ");    //Ask user to enter file path
            string input = @"" + Console.ReadLine();            //Filepath
            string all_text = "";                               //Gets all the text from the file
            Regex validPath = new Regex(@"^[A-Za-d]{1}\D(\D[A-Za-z0-9]+)+\.\w{3}$");  //Formatted regex to only allow correct formatted file paths


            if (validPath.IsMatch(input))                    //Will continue if path matches regex
            {

                Console.WriteLine("File path is valid!");
                try                                                //If path name is valid, try and check if the path exists
                {
                    StreamReader sr = new StreamReader(input);         //Read our file so we can see the contents inside
                    Console.WriteLine("Opening File...");

                    string toAdd = "";
                    toAdd = sr.ReadLine();

                    while (toAdd != null)
                    {
                        if (toAdd != "")
                            all_text += " ";

                        all_text += toAdd;

                        toAdd = sr.ReadLine();
                    }

                    Console.WriteLine(all_text);

                    string[] words = all_text.Split(' ');          //Splits our words in the file to see how many words are in the file
                    Console.WriteLine("There are " + (words.Length - 1) + " words in the file.");
                }
                catch                                                           //Catch if the path does not exist
                {
                    Console.WriteLine("Unfortunately, that file does not exist.");
                }
            }
            else                                                    //Else the file path is not valid
            {
                Console.WriteLine("Not a valid file path");
            }





        }
    }
}