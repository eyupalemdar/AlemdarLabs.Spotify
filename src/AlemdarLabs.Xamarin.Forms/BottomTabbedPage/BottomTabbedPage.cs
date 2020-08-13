using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using XFF = Xamarin.Forms;

namespace AlemdarLabs.XF.BottomTabbedPage
{
    public partial class BottomTabbedPage : XFF.TabbedPage
    {
        public BottomTabbedPage()
        {
            if (XFF.Device.RuntimePlatform == XFF.Device.Android)
            {
                On<XFF.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            }
        }
    }
}