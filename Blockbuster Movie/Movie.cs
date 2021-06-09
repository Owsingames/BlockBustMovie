using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie
{
    //genre of movie
    public enum Genre
    {
        Drama = 1,
        Comedy = 2,
        Horror = 3,
        Romance = 4,
        Action = 5
    }

    abstract class Movie
    {
        //properties
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        //constructor
        public Movie(string Title, int Runtime, Genre Genre, List<string> Scenes)
        {
            this.Title = Title;
            this.Runtime = Runtime;
            this.Genre = Genre;
            this.Scenes = Scenes;

        }

        //display movie info 
        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Runtime: " + Runtime);
        }

        //display all movie scenes
        public virtual void PrintScenes()
        {
            Console.WriteLine($"{Title} Scenes");
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");

            }
        }

        public virtual void Play()
        {
            Console.WriteLine("Playing movie");
            PrintScenes();

        }
    }
}
