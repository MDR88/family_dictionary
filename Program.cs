using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define a Dictionary that contains information about several members of your family. 
            //Use the following example as a template.
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
            {"name", "Stacey"},
            {"age", "46"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
            {"name", "Frank"},
            {"age", "52"}
            });
            myFamily.Add("dad", new Dictionary<string, string>(){
            {"name", "Frank"},
            {"age", "75"}
            });
            myFamily.Add("mom", new Dictionary<string, string>(){
            {"name", "Diana"},
            {"age", "70"}
            });
            foreach(var family in myFamily)
            {
                //Next, iterate over each item in myFamily and produce the following output.
            System.Console.WriteLine($"{family.Value["name"]} is my {family.Key} and is {family.Value["age"]} years old");

            }

        }
    }
}
