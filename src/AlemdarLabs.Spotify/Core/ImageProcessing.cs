using FFImageLoading.Forms;
using System.Linq;
using System.Threading.Tasks;
using XFF = Xamarin.Forms;

namespace AlemdarLabs.Spotify.Core
{
    public static class ImageProcessing
    {
        public static async Task<XFF.Color> GetDominantColor(CachedImage cachedImage)
        {
            //var palette = await CrossColorThief.Current.GetPalette(cachedImage.Source);
            //var quantizedColor = palette.FirstOrDefault();

            //return XFF.Color.FromRgba(
            //        r: quantizedColor.Color.R,
            //        g: quantizedColor.Color.G,
            //        b: quantizedColor.Color.B,
            //        a: quantizedColor.Color.A
            //    );

            return XFF.Color.Black;
        }
    }
}
