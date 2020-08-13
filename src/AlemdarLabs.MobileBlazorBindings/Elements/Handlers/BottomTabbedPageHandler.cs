using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Handlers
{
    public partial class BottomTabbedPageHandler : TabbedPageHandler
    {
        partial void Initialize(NativeComponentRenderer renderer)
        {
            //RegisterEvent(
            //    eventName: "oncurrentpagechanged",
            //    setId: id => CurrentPageChangedId = id,
            //    clearId: id => { if (CurrentPageChangedId == id) { CurrentPageChangedId = 0; } });
            //BottomTabbedPageControl.CurrentPageChanged += (s, e) => 
            //{
            //    if (CurrentPageChangedId != default)
            //    {
            //        renderer.Dispatcher.InvokeAsync(() => renderer.DispatchEventAsync(CurrentPageChangedId, null, e));
            //    }
            //};
        }

        public ulong CurrentPageChangedId { get; set; }

    }
}
