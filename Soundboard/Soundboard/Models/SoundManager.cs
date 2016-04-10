using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundboard.Models
{
    public class SoundManager
    {

        public static void GetAllSounds(ObservableCollection<Sound> observableSounds)
        {
            var sounds = GetSounds();
            observableSounds.Clear();

            sounds.ForEach(s => observableSounds.Add(s));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> observableSounds, SoundCategory category)
        {
            var allSounds = GetSounds();
            var filteredSounds = allSounds.Where(p => p.Category == category).ToList();
            observableSounds.Clear();
            filteredSounds.ForEach(s => observableSounds.Add(s));
        }
        private static List<Sound> GetSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("Cow", SoundCategory.Animals));
            sounds.Add(new Sound("Cat", SoundCategory.Animals));

            sounds.Add(new Sound("Gun", SoundCategory.Cartoons));
            sounds.Add(new Sound("Spring", SoundCategory.Cartoons));

            sounds.Add(new Sound("Clock", SoundCategory.Taunts));
            sounds.Add(new Sound("LOL", SoundCategory.Taunts));

            sounds.Add(new Sound("Ship", SoundCategory.Warnings));
            sounds.Add(new Sound("Siren", SoundCategory.Warnings));

            return sounds;
        }

        public static void GetSoundsByName(ObservableCollection<Sound> observableSounds, string name)
        {
            var allSounds = GetSounds();
            var filteredSounds = allSounds.Where(p => p.Name == name).ToList();
            observableSounds.Clear();

            filteredSounds.ForEach(s => observableSounds.Add(s));
        }
    }
}
