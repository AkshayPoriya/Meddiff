using System;
using System.Collections.Generic;
using System.Text;

namespace Change_Directory
{
    class Path
    {
        public string current_path;
        public Path(string path)
        {
            if (isValidPath(path))
            {
                current_path = path;
            }
            else
            {
                Console.WriteLine("Please enter a valid path!");
                current_path = "/";
            }
        }
        public void CD(string path)
        {
            if (!isValidPath(path))
            {
                Console.WriteLine("Please enter a valid path!");
                return;
            }
            string[] currentRoots = current_path.Substring(1).Split('/');
            int crIndex = currentRoots.Length-1;
            string[] newRoots = path.Split('/');
            bool flag = true;
            int nrIndex = 0;
            for(int i = 0; i < newRoots.Length; i++)
            {
                if (newRoots[i] == "..")
                {
                    currentRoots[crIndex] = "";
                    newRoots[i] = "";
                    if (crIndex > 0)
                    {
                        crIndex--;
                    }
                    else
                    {
                        flag = false;
                        nrIndex = i;
                        break;
                    }
                    newRoots[i] = "";
                }
            }
            List<string> newPathIfFlagFalse = new List<string>() ;
            string ans = "";
            if (!flag)
            {
                if (newRoots[nrIndex + 1] == "..")
                {
                    Console.WriteLine("Please enter a valid path!");
                    return;
                }
                else
                {
                    for (int i = nrIndex + 1; i < newRoots.Length; i++)
                    {
                        if (newRoots[i] != "..")
                        {
                            newPathIfFlagFalse.Add(newRoots[i]);
                        }
                        else
                        {
                            if (newPathIfFlagFalse.Count == 0)
                            {
                                Console.WriteLine("Please enter a valid path!");
                                return;
                            }
                            newPathIfFlagFalse.RemoveAt(newPathIfFlagFalse.Count - 1);
                        }
                    }
                }
                foreach(string root in newPathIfFlagFalse)
                {
                    ans += "/" + root;
                }
            }
            else
            {
                foreach(string root in currentRoots)
                {
                    if (root != "")
                    {
                        ans += "/" + root;
                    }
                }
                foreach (string root in newRoots)
                {
                    if (root != "")
                    {
                        ans += "/" + root;
                    }
                }
            }
            current_path = ans;
        }
        public bool isValidPath(string path)
        {
            foreach(char ch in path)
            {
                if (!(ch >= 'a' && ch <= 'z') && !(ch >= 'A' && ch <= 'Z') && !(ch == '.') && !(ch == '/'))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
