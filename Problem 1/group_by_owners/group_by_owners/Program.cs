using System;
using System.Collections.Generic;

namespace group_by_owners
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfKeyValuePairs;
            Console.WriteLine("Enter no of file owner pairs: ");
            noOfKeyValuePairs = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> fileOwnerDictionary = new Dictionary<string, string>();
            Console.WriteLine("Enter FileName OwnerName pairs seprated by space");
            for (int i = 0; i < noOfKeyValuePairs; i++)
            {
                string[] keyValue = Console.ReadLine().Split(' ');
                fileOwnerDictionary.Add(keyValue[0], keyValue[1]);
            }
            Dictionary<string, List<string>> ownerFileDictionary = new Dictionary<string, List<string>>();
            foreach (KeyValuePair<string, string> fileOwner in fileOwnerDictionary)
            {
                if (ownerFileDictionary.ContainsKey(fileOwner.Value))
                {
                    ownerFileDictionary[fileOwner.Value].Add(fileOwner.Key);
                }
                else
                {
                    ownerFileDictionary.Add(fileOwner.Value, new List<string>() { fileOwner.Key });
                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, List<string>> ownerFile in ownerFileDictionary)
            {
                Console.Write(ownerFile.Key + " : ");
                for (int i = 0; i < ownerFile.Value.Count; i++)
                {
                    Console.Write(ownerFile.Value[i]);
                    if (i != ownerFile.Value.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}