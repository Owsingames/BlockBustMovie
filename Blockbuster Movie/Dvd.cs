using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie
{
    class Dvd : Movie
    {
        public Dvd(string Title, int Runtime, Genre genre, List<string> Scenes) 
            : base(Title, Runtime, genre, Scenes)
        {
           
        }

        public override void Play()
        {
            Console.WriteLine("Playing Movie Scenes:");
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(Scenes[i]);
            } 
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Runtime: " + Runtime);
        }
    }
}
