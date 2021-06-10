using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie
{
    class Vhs : Movie
    {
        //properties
        public int CurrentTime { get; set; } = 0;

        //constructor inhierites from base Movie
        public Vhs(string Title, int Runtime, Genre genre, List<string> Scenes) 
            : base(Title, Runtime, genre, Scenes)
        {
            CurrentTime = 0;
        }

        //Methods
        public void Rewind()
        {
            CurrentTime = 0;
        }

        public override void Play()
        {
            Console.WriteLine("Playing Movie Scenes:");
            for (int i = 0; i < Scenes.Count; i++)
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
