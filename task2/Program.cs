using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {

        static void Main(string[] args)
        {
            String[] inputString = Console.ReadLine().Split(' ');
            FrequencyWords frequencyWords = new FrequencyWords();
            frequencyWords.DefinitionOfFrequencyWords(inputString);

            Console.Write("\n");

            for (int i = 0; i < frequencyWords.words.Count; i++)
            {
                Console.Write(frequencyWords.words[i] + " ");

                    for(int y=0; y < frequencyWords.points[i]; y++)
                          Console.Write(".");

                Console.Write("\n");
            }
        }
    }

