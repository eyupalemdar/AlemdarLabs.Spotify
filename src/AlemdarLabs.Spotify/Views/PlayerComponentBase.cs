using AlemdarLabs.Spotify.Core;
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

        public int TicksLeft { get { return Song.LengthInSeconds - StateManager.Ticks; } }

        public async Task OnAudioSliderDragComplete(double newTicks)
        {
            StateManager.Ticks = Convert.ToInt32(newTicks);

            StateHasChanged();
            await Task.CompletedTask;
        }
    }
}
