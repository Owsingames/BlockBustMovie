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
            //0
            //list of scenes - Movie - men of honor
            List<string> menOfHonorScenes = new List<string>();
            menOfHonorScenes.Add("1 - Inspired");
            menOfHonorScenes.Add("2 - Bootcamp");
            menOfHonorScenes.Add("3 - Under water knife fight");
            menOfHonorScenes.Add("4 - A Hero emerges");
            menOfHonorScenes.Add("5 - Final Battle");
            movieList.Add(new Dvd("Men of Honor", 160, Genre.Drama, menOfHonorScenes));

            //1
            //list of scenes - Gladiator
            List<string> scenesGladiator = new List<string>();
            scenesGladiator.Add("1 - Opening Battle");
            scenesGladiator.Add("2 - Betrayal by a false brother");
            scenesGladiator.Add("3 - From slave to rival");
            scenesGladiator.Add("4 - End of the Emporer");
            scenesGladiator.Add("5 - The Glory of Rome");
            movieList.Add(new Dvd("Gladiator", 210, Genre.Drama, scenesGladiator));

            //2
            //List of scenes - Spaceballs
            List<string> spaceballScene = new List<string>();
            spaceballScene.Add("1 - We move for no body...");
            spaceballScene.Add("2 - Comb the Desert");
            spaceballScene.Add("3 - Friend or Foe");
            spaceballScene.Add("4 - I did not see that coming");
            spaceballScene.Add("5 - A happy ending");
            movieList.Add(new Dvd("Spaceballs", 135, Genre.Comedy, spaceballScene));

            //3
            //List of scenes - Princess Bride
            List<string> princesBrideScenes = new List<string>();
            princesBrideScenes.Add("1 - The Dred Prince Roberts");
            princesBrideScenes.Add("2 - INCONVICEIBLE");
            princesBrideScenes.Add("3 - Life after death");
            princesBrideScenes.Add("4 - Battle at Kings castle");
            princesBrideScenes.Add("5 - Happy ending");
            movieList.Add(new Dvd("Princess Bride", 90, Genre.Comedy, princesBrideScenes));
            
            //Lsit of scenes - The Martian
            List<string> transformersScenes = new List<string>();
            transformersScenes.Add("1 - To earth");
            transformersScenes.Add("2 - Wrong place, Wrong time");
            transformersScenes.Add("3 - AutoBots Assemble");
            transformersScenes.Add("4 - King vs King");
            transformersScenes.Add("5 - Earths new protector");
            movieList.Add(new Dvd("The Martian", 210, Genre.Action, transformersScenes));

            //List of scenes Demon slayer
            List<string> demonSlayerScenes = new List<string>();
            demonSlayerScenes.Add("1 - The train");
            demonSlayerScenes.Add("2 - Meeting Kyojuro");
            demonSlayerScenes.Add("3 - Wake up!");
            demonSlayerScenes.Add("4 - Akaza - Upper Demon");
            demonSlayerScenes.Add("5 - Report");
            movieList.Add(new Dvd("Demon Slayer: Mugen Train", 180, Genre.Action, demonSlayerScenes));

            //List of scenes Howles Moving Castle
            List<string> howelsMovingCastleScenes = new List<string>();
            howelsMovingCastleScenes.Add("1 - A mysterious castle");
            howelsMovingCastleScenes.Add("2 - Stranger times, Stranger people");
            howelsMovingCastleScenes.Add("3 - Who is Howel");
            howelsMovingCastleScenes.Add("4 - I've been here be for...");
            howelsMovingCastleScenes.Add("5 - Was it all a dream");
            movieList.Add(new Vhs("Howels Moving Castle", 144, Genre.Romance, howelsMovingCastleScenes));

            //List of scenes Spirited Away
            List<string> spiritedAwayScenes = new List<string>();
            spiritedAwayScenes.Add("1 - Moving to a new place");
            spiritedAwayScenes.Add("2 - The Spirit Realm");
            spiritedAwayScenes.Add("3 - The Bathhouse");
            spiritedAwayScenes.Add("4 - Finding her name");
            spiritedAwayScenes.Add("5 - Coming Home");
            movieList.Add(new Vhs("Spirited Away", 135, Genre.Romance, spiritedAwayScenes));

            //List of scenes - Nightmare on elm street
            List<string> nightmareElmStreetScenes = new List<string>();
            nightmareElmStreetScenes.Add("1 - Spring break");
            nightmareElmStreetScenes.Add("2 - What is happening...");
            nightmareElmStreetScenes.Add("3 - Don't go to sleep!");
            nightmareElmStreetScenes.Add("4 - We have to get out of here");
            nightmareElmStreetScenes.Add("5 - Its to late...");
            movieList.Add(new Vhs("Nightmare on Elm street", 90, Genre.Horror, nightmareElmStreetScenes));

            //List of scenes - IT
            List<string> itScenes = new List<string>();
            itScenes.Add("1 - The setting");
            itScenes.Add("2 - What we have in common");
            itScenes.Add("3 - Memories");
            itScenes.Add("4 - IT feeds on fear");
            itScenes.Add("5 - Over Coming fear.");
            movieList.Add(new Vhs("IT.", 120, Genre.Horror, itScenes));
        }        
    }
}
