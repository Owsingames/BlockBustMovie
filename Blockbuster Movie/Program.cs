using System;
using System.Collections.Generic;

namespace Blockbuster_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool onContinue = true;
            while(onContinue == true)
            {
                Console.WriteLine("--Welcome to Block Buster Video--");
                Console.WriteLine();
                Blockbuster myMovies = new Blockbuster();
                for (int i = 0; i < myMovies.movieList.Count; i++)
                {
                    Console.WriteLine($"{i} : {myMovies.movieList[i].Title}");
                }
                Console.WriteLine();
                //get and validate user input
                var index = GetUserInput("Please select a movie you want to watch using the index");
                

                //compare user input to moive and print information about movie
                for (int i = 0; i < myMovies.movieList.Count; i++)
                {
                    if (index == i)
                    {
                        //print movie info
                        myMovies.movieList[i].PrintInfo();

                        //ask user if they want to watch movie
                        Console.WriteLine("Would you like to watch this movie? (y/n)");
                        string userAnswer = Console.ReadLine().ToLower().Trim();
                        if(userAnswer == "y" || userAnswer == "yes")
                        {
                            myMovies.movieList[i].Play();
                        }
                        else
                        {
                            onContinue = PickAgain();
                        }
                    }

                }
                onContinue = PickAgain();
            
            }
        }

        public static int GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine().ToLower().Trim();
            try
            {
                int index = int.Parse(input);
                if(index <= 9 && index >= 0)
                {
                    Console.WriteLine("num is: " + index);
                    return index;
                }
                else
                {
                    return GetUserInput("Please enter a valid number for the movie you would like to watch");
                }

            }
            catch (FormatException)
            {
                
                return GetUserInput("Please select a valid numder for the movie you would like to watch");
            }
        }

        public static bool PickAgain()
        {
            Console.WriteLine("Would you like to watch another movie? (y/n)");
            string input = Console.ReadLine().ToLower().Trim();

            if(input == "yes"|| input == "y")
            {
                Console.Clear();
                return true;
            }
            else if(input == "no" || input == "n")
            {
                Console.WriteLine("Goodbye.");
                return false;
            }
            else
            {
                Console.WriteLine("I did not understand, would you like to watch another movie? (y/n)");
                return PickAgain();
            }
        }

        public static bool CheckMovieList(List<Movie> movies, string input)
        {
            foreach(Movie m in movies)
            {
               
                if (m.Title == input)
                {
                    return true;
                }

            }
            return false;
        }

        public static void WatchMovie()
        {

        }

    }
}
