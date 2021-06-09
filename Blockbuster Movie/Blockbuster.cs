using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Movie
{
    class Blockbuster
    {
        public List<Movie> movieList { get; set; } = new List<Movie>();
        public Blockbuster()
        {
            //list of scenes - Movie - men of honor
            List<string> scenesMenOfHonor = new List<string>();
            scenesMenOfHonor.Add("1 - Inspired");
            scenesMenOfHonor.Add("2 - Bootcamp");
            scenesMenOfHonor.Add("3 - Under water knife fight");
            scenesMenOfHonor.Add("4 - A Hero emerges");
            scenesMenOfHonor.Add("5 - Final Battle");
            movieList.Add(new Dvd("Men of Honor", 160, Genre.Drama, scenesMenOfHonor));

            //list of scenes - Gladiator
            List<string> scenesGladiator = new List<string>();
            scenesGladiator.Add("1 - Opening Battle");
            scenesGladiator.Add("2 - Betrayal by a false brother");
            scenesGladiator.Add("3 - From slave to rival");
            scenesGladiator.Add("4 - End of the Emporer");
            scenesGladiator.Add("5 - The Glory of Rome");
            movieList.Add(new Dvd("Gladiator", 210, Genre.Drama, scenesGladiator));
           

            //List of scenes - Spaceballs
            List<string> scenesSpaceballs = new List<string>();
            scenesSpaceballs.Add("1 - We move for no body...");
            scenesSpaceballs.Add("2 - Comb the Desert");
            scenesSpaceballs.Add("3 - Friend of Foe");
            scenesSpaceballs.Add("4 - I did not see that coming...");
            scenesSpaceballs.Add("5 - A happy ending");
            movieList.Add(new Dvd("Spaceballs", 135, Genre.Comedy, scenesSpaceballs));

            //List of scenes - Princess Bride
            List<string> scenesPrincesBride = new List<string>();
            scenesPrincesBride.Add("1 - The Dred Prince Roberts");
            scenesPrincesBride.Add("2 - INCONVICEIBLE");
            scenesPrincesBride.Add("3 - Life after death");
            scenesPrincesBride.Add("4 - Battle at Kings castle");
            scenesPrincesBride.Add("5 - Happy ending");
            movieList.Add(new Dvd("Princes Bride", 90, Genre.Comedy, scenesPrincesBride));

            //Lsit of scenes - The Martian
            List<string> scenesTransformers = new List<string>();
            scenesPrincesBride.Add("1 - To earth");
            scenesPrincesBride.Add("2 - Wrong place, Wrong time");
            scenesPrincesBride.Add("3 - AutoBots Assemble");
            scenesPrincesBride.Add("4 - King vs King");
            scenesPrincesBride.Add("5 - Earths new protector");
            movieList.Add(new Dvd("The Martian", 210, Genre.Action, scenesTransformers));

            //List of scenes Demon slayer
            List<string> scenesDemonSlayer = new List<string>();
            scenesPrincesBride.Add("1 - The train");
            scenesPrincesBride.Add("2 - Meeting Kyojuro");
            scenesPrincesBride.Add("3 - Wake up!");
            scenesPrincesBride.Add("4 - Akaza - Upper Demon");
            scenesPrincesBride.Add("5 - Report");
            movieList.Add(new Vhs("Demon Slayer: Mugen Train", 180, Genre.Action, scenesDemonSlayer));

            //List of scenes Howles Moving Castle
            List<string> scenesHowelsMovingCastle = new List<string>();
            scenesPrincesBride.Add("1 - A mysterious castle");
            scenesPrincesBride.Add("2 - Stranger times, Stranger people");
            scenesPrincesBride.Add("3 - Who is Howel");
            scenesPrincesBride.Add("4 - I've been here be for...");
            scenesPrincesBride.Add("5 - Was it all a dream");
            movieList.Add(new Vhs("Howels Moving Castle", 144, Genre.Romance, scenesHowelsMovingCastle));

            //List of scenes Spirited Away
            List<string> scenesSpiritedAway = new List<string>();
            scenesPrincesBride.Add("1 - Moving to a new place");
            scenesPrincesBride.Add("2 - The Spirit Realm");
            scenesPrincesBride.Add("3 - The Bathhouse");
            scenesPrincesBride.Add("4 - Finding her name");
            scenesPrincesBride.Add("5 - Coming Home");
            movieList.Add(new Vhs("Spirited Away", 135, Genre.Romance, scenesSpiritedAway));

            //List of scenes - Nightmare on elm street
            List<string> scenesNightmareElmStreet = new List<string>();
            scenesPrincesBride.Add("1 - Spring break");
            scenesPrincesBride.Add("2 - What is happening...");
            scenesPrincesBride.Add("3 - Don't go to sleep!");
            scenesPrincesBride.Add("4 - We have to get out of here");
            scenesPrincesBride.Add("5 - Its to late...");
            movieList.Add(new Vhs("Nightmare on Elm street", 90, Genre.Horror, scenesNightmareElmStreet));

            //List of scenes - IT
            List<string> scenesIt = new List<string>();
            scenesPrincesBride.Add("1 - The setting");
            scenesPrincesBride.Add("2 - What we have in common");
            scenesPrincesBride.Add("3 - Memories");
            scenesPrincesBride.Add("4 - IT feeds on fear");
            scenesPrincesBride.Add("5 - Over Coming fear.");
            movieList.Add(new Vhs("IT.", 120, Genre.Horror, scenesIt));
        }        
    }
}
