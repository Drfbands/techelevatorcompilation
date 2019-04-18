using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WordSearch
{
    public class Io
    {
        public bool ProcessFile(string filePath, string wordToSearch, string caseSensitive)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                int lineCount = 0;

                // Read the file until the end of the stream is reached
                // EndOfStream is a "marker" that the stream uses to determine 
                //4. Loop through each line in the file
                while (!sr.EndOfStream)
                {
                    // Read in a single line
                    lineCount++;
                    string line = sr.ReadLine();
                    if (caseSensitive == "Y")
                    {

                        bool searchstring = line.Contains(wordToSearch);


                        if (searchstring == true)

                            //5. If the line contains the search string, print it out along with its line number
                            if (searchstring == true)
                            {
                                Console.WriteLine(lineCount + " " + line);
                            }
                    }
                    else
                    {
                        wordToSearch = wordToSearch.ToLower();
                        wordToSearch = wordToSearch.ToLower();

                        string linelowercase = line.ToLower();
                        bool returnLine = linelowercase.Contains(wordToSearch);

                        if (returnLine == true)
                        {
                            Console.WriteLine(lineCount + " " + line);
                        }

                    }



                }

            }
            return true;
        }
    }
}
