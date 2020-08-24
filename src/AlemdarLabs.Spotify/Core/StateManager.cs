using AlemdarLabs.Spotify.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlemdarLabs.Spotify.Core
{
    public static class StateManager
    {
        private static Song currentPlayingSong;
        public static Song CurrentPlayingSong { 
            get { return currentPlayingSong; }
            set
            {
                if (value != currentPlayingSong)
                {
                    currentPlayingSong = value;
                    ticks = 0;
                    IsPlaying = false;
                }
            }
        }

        public static int ticks = 0;
        public static int Ticks { 
            get { return ticks; } 
            set
            {
                ticks = value;

                if (StateHasChangedAsync != null)
                {
                    StateHasChangedAsync().GetAwaiter().GetResult();
                }
            }
        }
        public static bool IsPlaying { get; set; } = false;

        public static async Task StartStopPlaying()
        {
            if (!StateManager.IsPlaying)
            {
                StateManager.IsPlaying = true;

                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    StateManager.Ticks += 1;

                    // Stop playing when at the end.
                    if (StateManager.Ticks == currentPlayingSong.LengthInSeconds)
                        StateManager.IsPlaying = false;

                    // While the song is not over, return true for another tick.
                    return StateManager.Ticks <= currentPlayingSong.LengthInSeconds && StateManager.IsPlaying;
                });
            }
            else
            {
                // If it is currently playing, set it to false.
                StateManager.IsPlaying = false;
            }

            await Task.CompletedTask;
        }

        public static Func<Task> StateHasChangedAsync;

    }
}
