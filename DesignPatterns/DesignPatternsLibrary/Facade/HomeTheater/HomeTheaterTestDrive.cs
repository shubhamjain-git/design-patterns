using System;

namespace DesignPatternsLibrary.Facade.HomeTheater
{
    public class HomeTheaterTestDrive : IDesignPattern
    {
        public HomeTheaterTestDrive()
        {
            Console.WriteLine("!!Welcome to Sam's Home Theature!!");
        }

        public void RunExample()
        {
            Amplifier amp = new Amplifier("Top-Class Amplifier");
            Tuner tuner = new Tuner("Top-Class Tuner", amp);
            DvdPlayer dvd = new DvdPlayer("Top-Class DVD Player", amp);
            CdPlayer cd = new CdPlayer("Top-Class CD Player", amp);
            Projector projector = new Projector("Top-Class Projector", dvd);
            Screen screen = new Screen("Theater Screen");
            TheaterLights lights = new TheaterLights("Theater Lights");
            PopcornPopper popper = new PopcornPopper("Popcorn Popper");
            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd,
                projector, screen, lights, popper);

            homeTheater.WatchMovie("Coolie No. 1");
            homeTheater.EndMovie();
        }
    }
}
