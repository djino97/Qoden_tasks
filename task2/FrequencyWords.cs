using System;
using System.Collections.Generic;



    class FrequencyWords
    {
        public List<string> words;
        public List<int> points;

        List<double> numberOfReps;

        string[] InputWords;
        string tmpWord;

        int counter; 
        int indexMaxRepsWord;
        int maxRepsWord;

        public void DefinitionOfFrequencyWords(String[] inputString)
        {
            int i;

            words = new List<string>();
            numberOfReps = new List<double>();
            points = new List<int>();

            indexMaxRepsWord = 0;
            InputWords = inputString;

            int countWords = InputWords.Length; 

            while (true)
            {
                tmpWord = null;
                counter = 0;
                

                for (i = 0; i < countWords; i++)
                    GetRepsWords(i);


                numberOfReps.Add(counter);

                if (counter > maxRepsWord)
                {
                    maxRepsWord = counter;
                    indexMaxRepsWord = numberOfReps.Count - 1;
                }

                counter = 0;

                foreach (var w in InputWords)
                {
                    if (w != " ")
                        break;
                    else
                        counter++;
                }

                if (counter == countWords)
                    break;
            }

            double gradingScale = 0;
            
            int maxValueScale = 10;

            for(i = 0; i < numberOfReps.Count; i++)
            {
                numberOfReps[i] = GetFrequency(i, countWords);

                if (i == indexMaxRepsWord)
                    gradingScale = numberOfReps[i]/ maxValueScale;
            }

            double numberPoints;

            foreach (var number in numberOfReps)
            {
                numberPoints = number / gradingScale;

                points.Add((int)Math.Round(numberPoints));
            }

            SortingTheFrequencyOfRepsWordsInAscending();

            AlignmentOfTheColumnsWords();
        }


        private void SortingTheFrequencyOfRepsWordsInAscending()
        {
            int tmpPoint;
            int countPoints;
            string word;
            double tmpNumberOfReps;

            countPoints = points.Count;

            while (true)
            {

                for (int i = 0; i + 1 < countPoints; i++)
                {
                    if (numberOfReps[i] > numberOfReps[i + 1])
                    {
                        tmpPoint = points[i + 1];
                        points[i + 1] = points[i];
                        points[i] = tmpPoint;

                        tmpNumberOfReps = numberOfReps[i + 1];
                        numberOfReps[i + 1] = numberOfReps[i];
                        numberOfReps[i] = tmpNumberOfReps;

                        word = words[i + 1];
                        words[i + 1] = words[i];
                        words[i] = word;
                    }
                }

                if (countPoints != 0)
                    countPoints--;
                else
                    break;
            }
        }

        private void GetRepsWords(int index)
        {
            string word = InputWords[index];

            if (word != " ")
            {
                if (tmpWord != null && tmpWord == word)
                {
                    InputWords[index] = " ";
                    counter++;
                }
                else if (tmpWord == null)
                {
                    words.Add(word);
                    tmpWord = word;
                    InputWords[index] = " ";

                    counter++;
                }
            }
        }

        private double GetFrequency(int index, int count)
        {
            return numberOfReps[index] / count;
        }

        private void AlignmentOfTheColumnsWords()
        {
            int tmpMaxLetters = 0;

            foreach (string word in words)
                tmpMaxLetters = CompareLenghtWords(word, tmpMaxLetters);

            for (int i = 0; i < words.Count; i++)
                AddLenghtWords(tmpMaxLetters, i);

        }


        private int CompareLenghtWords(string word, int tmpMaxLetters)
        {
            int countLetters = 0;

            foreach (char letter in word)
                countLetters++;

            if (tmpMaxLetters < countLetters)
                tmpMaxLetters = countLetters;

            return tmpMaxLetters;
        }


        private void AddLenghtWords(int tmpMaxLetters, int index)
        {
            int diff;

            if (words[index].Length < tmpMaxLetters)
            {
                diff = tmpMaxLetters - words[index].Length;

                for (int y = 0; y < diff; y++)
                    words[index] = '_' + words[index];
            }
        }
    }