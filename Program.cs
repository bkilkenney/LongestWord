using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercise asks for the longest word in each of these two sentences, output 1 result per line
            "Some line with text"
            "Another line"*/

            string sentence = "I have a dream.";
            int sentenceLength = sentence.Length;

            string[] sentenceArray = sentence.Split(' ');
            //splitting on the charecter SPACE

            string longWord = "";
            foreach (string word in sentenceArray) 
            
            {
                int wordLength = word.Length;
                int longWordLength = longWord.Length;

                if (wordLength > longWordLength)
                {
                    longWordLength = wordLength;
                    longWord = word;
                }
                

                //For each word we need to count the chars and find the longest word
            }
            Console.WriteLine(longWord);
        }
    }
}
