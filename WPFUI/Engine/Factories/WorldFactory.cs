using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(2, 1, "Weenie Hut Jr", "Real Loewen get in here", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Weenie_Hut_jr.png");
            newWorld.AddLocation(1, 1, "Pineapple House", "Spongebobs house he lives in here", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Pineapple_House.png");
            newWorld.AddLocation(0, 1, "Bikini Bottom", "Ohhh die Bikinii Bottom", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Bikini_Bottom.png");
            newWorld.AddLocation(-1, 1, "Chum Bucket", "Mid Food L L L ", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Chum_Bucket.png");

            newWorld.AddLocation(0, 0, "Home", "this is your home", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Home.png");

            newWorld.AddLocation(2, -1, "Bubble Park", "Park for Bubble Fun", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Bubble_Park.png");
            newWorld.AddLocation(1, -1, "Bubble Office", "Working Class Bubble Work here", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Bubble_Office.png");
            newWorld.AddLocation(0, -1, "Bubble Town", "Welcome to Bubble Town", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Bubble_Town.png");
            newWorld.AddLocation(-1, -1, "Bubble Jail", "Bad Bubbles be here", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Bubble_Jail.png");

            newWorld.AddLocation(0, -2, "Rock Bottom", "The next bus leaves in 5 Seconds", "C:\\Users\\Fries\\source\\repos\\c-RPG\\WPFUI\\Engine\\Models\\Images\\Locations\\Rock_Bottom.png");

            return newWorld;
        }
    }
}
