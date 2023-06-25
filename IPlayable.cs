using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTasks
{
    internal interface IPlayable
    {
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
    }

    internal class MusicPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Puse the music Player ");
        }

        public void Play()
        {
            Console.WriteLine("Play the music Player ");
        }

        public void Stop()
        {
            Console.WriteLine("Stop the music Player ");

        }
    }
    internal class VideoPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Puse the Video Player ");
        }

        public void Play()
        {
            Console.WriteLine("Play the Video Player ");
        }

        public void Stop()
        {
            Console.WriteLine("Stop the Video Player ");
        }
    }
}
