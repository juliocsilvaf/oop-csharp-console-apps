using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //add logic here
            StreamReader strReader = null;
            SortedDictionary<char, int> myChars = new SortedDictionary<char, int>();
            try
            {
                strReader = new StreamReader(@"..\..\characters.txt");
                while (strReader.EndOfStream==false)
                {
                    //Console.WriteLine((char)strReader.Read());
                    char c = (char)strReader.Read();
                    if (myChars.ContainsKey(c) == true)
                    {
                        myChars[c] = myChars[c] + 1;
                    }
                    else
                    {
                        myChars.Add(c, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something has gone wrong!");
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (strReader != null)
                {
                    strReader.Close();
                }
            }

            //read myChars and write to text file
            StreamWriter strWriter = null;
            try
            {
                strWriter = new StreamWriter(@"..\..\character-count.txt", false);
                foreach (KeyValuePair<char, int> kv in myChars)
                {
                    strWriter.WriteLine($"{kv.Key} {kv.Value}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                if (strWriter != null)
                {
                    strWriter.Close();  
                }
            }




            Console.ReadKey();
        }
    }
}
