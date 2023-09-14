using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace Spotify
{
    internal class Lettore
    {
        //private List<Content> content;
        // private string songInput;
        private int numberSongInput;
        private int visualInput;
        private string choice;
        private string menuChoice;
        private Song inPlaying;
        private List<Song> songs;
        public string currentAlbum;

        public Lettore(List<Song> s)
        {
            songs = s;
        }

        public void ShowArtists()
        {
            //NON è un dizionario, E' una TUPLA
            List<string> artists = (
                from a in songs
                select new { a.artist }).Select(a => a.artist).Distinct().OrderBy(a => a).ToList();




            int i = 0;
            foreach (var item in artists) //stampa le due proprietà che ho estratto
            {

                Console.WriteLine($" {i}  {item} ");

                i += 1;

            }
            Menu.ChoseNumber();
            visualInput = int.Parse(Console.ReadLine());
            string selectedArtist = artists[visualInput];
            ShowAlbum(selectedArtist);

        }

        public void ShowAlbum(string artist)
        {
            //NON è un dizionario, E' una TUPLA
            List<string> albums = (
                from a in songs
                where a.artist == artist
                select new { a.album }).Select(a => a.album).Distinct().OrderBy(a => a).ToList();
            int i = 0;

            foreach (var item in albums) //stampa le due proprietà che ho estratto
            {

                Console.WriteLine($" {i}  {item} ");

                i += 1;

            }
            Menu.ChoseNumber();
            visualInput = int.Parse(Console.ReadLine());
            string selectedAlbum = albums[visualInput];
            ShowSongs(selectedAlbum);



        }






        public void ShowSongs(string album)
        {

            List<string> titles = (
                from a in songs
                where a.album == album
                select new { a.title, a.album }).Select(a => a.title).Distinct().OrderBy(a => a).ToList();




            int i = 0;
            foreach (var item in titles) //stampa le due proprietà che ho estratto
            {

                Console.WriteLine($" {i}  {item} ");
                i += 1;

            }
            Menu.ChoseNumber();
            visualInput = int.Parse(Console.ReadLine());
            string selectedTitle = titles[visualInput];
            CurrentPlay(selectedTitle, album);

        }

        public void CurrentPlay(string selectsong,string title)
        {
            Song Test = (
                from a in songs
                where a.album == title && a.title == selectsong
                select a).FirstOrDefault();
           

            Console.WriteLine("- - - - - - - - - - - - - - ");
            //inPlaying = songs[numberInput];
            Console.WriteLine($"Now in Playing: {Test.title}");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Menu.ShowMenu();
            menuChoice = Scegli();
            //NextAction(menuChoice);
        }
        


        public void Start()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            ShowList();
            Console.WriteLine("choose number of content");
            numberSongInput = int.Parse(Console.ReadLine());

            CurrentPlay(numberSongInput);
            Console.WriteLine("- - - - - - - - - - - - - - ");



        }

        public void ShowList()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            int i = 0;
            foreach (var item in songs)
            {

                Console.WriteLine($"{i}  {item.title}");
                i += 1;

            }
            Console.WriteLine("- - - - - - - - - - - - - - ");

        }


        public void CurrentPlay(int numberInput)
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            inPlaying = songs[numberInput];
            Console.WriteLine($"Now in Playing: {inPlaying.title}");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Menu.ShowMenu();
            menuChoice = Scegli();
            NextAction(menuChoice);




        }

        public void Next()
        {
            if (numberSongInput < songs.Count - 1)
            {
                numberSongInput += 1;

            }
            else
            {
                numberSongInput = 0;
            }

            CurrentPlay(numberSongInput);


        }

        public void Previous()

        {
            if (numberSongInput > 0)
            {
                numberSongInput -= 1;

            }
            else
            {
                numberSongInput = songs.Count - 1;
            }

            CurrentPlay(numberSongInput);

        }

        public void Pause()
        {
            Console.Write("Now In Pause");
            Menu.ShowMenu();
            menuChoice = Scegli();
            NextAction(menuChoice);


        }


        public void Exit()
        {
            return;
        }

        public string Scegli()
        {
            //Menu.ShowMenu();
            menuChoice = Console.ReadLine();
            return menuChoice;
        }

        public void NextAction(string choice)
        {
            switch (choice)

            {
                case "f":
                    Next();

                    break;
                case "b":
                    Previous(); break;
                case "p":
                    Pause(); break;
                case "e":
                    Exit(); break;
                default:
                    Console.WriteLine("scelta sbagliata");
                    return;

            }

        }
    }
}

