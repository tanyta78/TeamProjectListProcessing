namespace ListProcessingApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class StartUp
    {
        public static void Main()
        {

            List<string> wordsList =
                Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            bool finish = false;

            while (!finish)// тук също е изменено спрямо оригинала
            {

                string commandLine = Console.ReadLine();
                var commandList = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string command = commandList[0];


                switch (command)
                {
                    case "append":
                        Append(wordsList, commandList);
                        break;
                    case "prepend":
                        PrepEnd(wordsList, commandList);
                        break;
                    case "insert":
                        Insert(wordsList, commandList);
                        break;
                    case "delete":
                        Delete(wordsList, commandList);
                        break;
                    case "roll":
                        Roll(wordsList, commandList);
                        break;
                    case "sort":
                        Sort(wordsList, commandList);
                        break;
                    case "reverse":
                        Reverse(wordsList, commandList);
                        break;
                    case "count":
                        Count(wordsList, commandList);
                        break;
                    case "end":
                        if (commandList.Count != 1)
                        {
                            Console.WriteLine("Error: invalid command parameters");
                        }
                        else
                        {
                            Console.WriteLine("Finished");
                            finish = true;// и тук има разлика в съответствие с горната
                        }

                        break;
                    default:
                        Console.WriteLine("Error: invalid command");
                        break;
                }


            }
        }

        private static void Count(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                string wordToCount = commandList[1];
                int countOfOcurrence = wordsList.Count(a => a == wordToCount);
                Console.WriteLine(countOfOcurrence);
            }
        }

        private static void Reverse(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 1)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                wordsList.Reverse();
                PrintWordsList(wordsList);
            }
        }

        private static void Sort(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 1)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                wordsList.Sort();
                PrintWordsList(wordsList);
            }
        }

        private static void Roll(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                string direction = commandList[1];
                if (direction == "left")
                {
                    RollLeft(wordsList);
                }
                else if (direction == "right")
                {
                    RollRight(wordsList);
                }
                else
                {
                    Console.WriteLine("Error: invalid command parameters");
                }
            }
        }

        private static void RollRight(List<string> wordsList)
        {
            int lastIndex = wordsList.Count - 1;
            var lastItemToMoveToTheLeft = wordsList[lastIndex];
            wordsList.RemoveAt(lastIndex);
            wordsList.Insert(0, lastItemToMoveToTheLeft);
            PrintWordsList(wordsList);
        }

        private static void RollLeft(List<string> wordsList)
        {
            string leftWord = wordsList[0];
            wordsList.RemoveAt(0);
            wordsList.Add(leftWord);
            PrintWordsList(wordsList);
        }

        private static void Delete(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            try
            {
                int index = int.Parse(commandList[1]);
                if (index < 0 || wordsList.Count - 1 < index)
                {
                    Console.WriteLine("Error: invalid index {0}", index);
                }
                else
                {
                    wordsList.RemoveAt(index);
                    PrintWordsList(wordsList);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
        }


        private static void Insert(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 3)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                try
                {
                    int index = int.Parse(commandList[1]);
                    if (index < 0 || wordsList.Count - 1 < index)
                    {
                        Console.WriteLine("Error: invalid index {0}", index);
                    }
                    else
                    {
                        string wordToInsert = commandList[2];
                        wordsList.Insert(index, wordToInsert);
                        PrintWordsList(wordsList);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: invalid command parameters");
                }
            }

        }

        private static void PrepEnd(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }

            var strToPrepEnd = commandList[1];
            wordsList.Insert(0, strToPrepEnd);
            PrintWordsList(wordsList);
        }

        private static void Append(List<string> wordsList, List<string> commandList)
        {
            if (commandList.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }

            var strToAppend = commandList[1];
            wordsList.Add(strToAppend);
            PrintWordsList(wordsList);
        }

        private static void PrintWordsList(List<string> wordList)
        {
            Console.WriteLine(string.Join(" ", wordList));
        }
    }
}


