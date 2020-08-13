using AlemdarLabs.Spotify.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlemdarLabs.Spotify.Views
{
    public partial class PlayerComponentBase : ComponentBase
    {
        public PlayerComponentBase()
        {
        }

        [Parameter] public Song Song { get; set; }
        [Parameter] public EventCallback OnClose { get; set; }

        public bool IsPlaying { get; set; }
        public int Ticks { get; set; } = 0;
        public int TicksLeft { get { return Song.LengthInSeconds - Ticks; } }

        public async Task StartStopPlaying()
        {
            if (!IsPlaying)
            {
                IsPlaying = true;

                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    Ticks += 1;

                    // Stop playing when at the end.
                    if (Ticks == Song.LengthInSeconds)
                        IsPlaying = false;

                    StateHasChanged();

                    // While the song is not over, return true for another tick.
                    return Ticks <= Song.LengthInSeconds && IsPlaying;
                });
            }
            else
            {
                // If it is currently playing, set it to false.
                IsPlaying = false;
            }

            StateHasChanged();
            await Task.CompletedTask;
        }
        public async Task OnAudioSliderDragComplete(double newTicks)
        {
            Ticks = Convert.ToInt32(newTicks);

            StateHasChanged();
            await Task.CompletedTask;
        }
    }
}
