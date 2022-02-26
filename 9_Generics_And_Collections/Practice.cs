using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Generics_And_Collections
{
    public class Practice
    {
        public int? value_1 = null;
        public int value_2 = 8;

        public void practiceNullable()
        {
            value_1 = value_2; // works
            if (value_1.HasValue) { Console.WriteLine(value_1.Value); }
            value_2 = value_1 ?? default;
            //    value_2 = value_1; // not works
        }
        public static void practiceEnum()
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

            var b = (Season)1;
            Console.WriteLine(b);  // output: Summer

            var c = (Season)7;
            Console.WriteLine(c);  // output: 4

            Months month = Months.February;
            Console.WriteLine($"Integral value of {month} is {(int)month}");  // output: Integral value of Autumn is 2
        }

        public static void PracticeArrayList()
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");
            foreach (var item in myAL)
            {
                Console.WriteLine(item);
            }
            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.WriteLine("    Capacity: {0}", myAL.Capacity);
            Console.Write("    Values:");

        }

        public static void PracticeLists()
        {
            List<string> dinosaurs = new List<string>();

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");
            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);

            Console.WriteLine("\nContains(\"Deinonychus\"): {0}",
                dinosaurs.Contains("Deinonychus"));

            Console.WriteLine("\nInsert(2, \"Compsognathus\")");
            dinosaurs.Insert(2, "Compsognathus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            // Shows accessing the list using the Item property.
            Console.WriteLine("\ndinosaurs[3]: {0}", dinosaurs[3]);

            Console.WriteLine("\nRemove(\"Compsognathus\")");
            dinosaurs.Remove("Compsognathus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            dinosaurs.TrimExcess();
            Console.WriteLine("\nTrimExcess()");
            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);

            dinosaurs.Clear();
            Console.WriteLine("\nClear()");
            Console.WriteLine("Capacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);

        }

        public static void PracticeDictionary()
        {
            // Create a new dictionary of strings, with string keys.
            //
            Dictionary<string, string> openWith =
                new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // The Add method throws an exception if the new key is
            // already in the dictionary.
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // The Item property is another name for the indexer, so you
            // can omit its name when accessing elements.
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            // The indexer can be used to change the value associated
            // with a key.
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.",
                openWith["rtf"]);

            // If a key does not exist, setting the indexer for that key
            // adds a new key/value pair.
            openWith["doc"] = "winword.exe";

            // The indexer throws an exception if the requested key is
            // not in the dictionary.
            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.",
                    openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            // When a program often has to try keys that turn out not to
            // be in the dictionary, TryGetValue can be a more efficient
            // way to retrieve values.
            string value = "";
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}",
                    openWith["ht"]);
            }

            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            // To get the values alone, use the Values property.
            Dictionary<string, string>.ValueCollection valueColl =
                openWith.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            Dictionary<string, string>.KeyCollection keyColl =
                openWith.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }
        }
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December

    }


}
