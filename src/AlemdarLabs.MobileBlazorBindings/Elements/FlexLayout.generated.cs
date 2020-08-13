using AlemdarLabs.MobileBlazorBindings.Elements.Handlers;
using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using XFF = Xamarin.Forms;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class FlexLayout : Layout
    {
        static FlexLayout()
        {
            ElementHandlerRegistry.RegisterElementHandler<FlexLayout>(
                renderer => new FlexLayoutHandler(renderer, new XFF.FlexLayout()));
        }

        /// <summary>
        /// Gets or sets a value that controls how multiple rows or columns of child elements are aligned.
        /// </summary>
        [Parameter] public XFF.FlexAlignContent? AlignContent { get; set; }
        /// <summary>
        /// Gets or sets a value that controls how child elements are laid out within their row or column.
        /// </summary>
        /// <value>
        /// A value that controls how child elements are laid out within their row or column.
        /// </value>
        [Parameter] public XFF.FlexAlignItems? AlignItems { get; set; }
        /// <summary>
        /// Gets or sets the flex direction for child elements within this layout.
        /// </summary>
        /// <value>
        /// The flex direction for child elements within this layout.
        /// </value>
        [Parameter] public XFF.FlexDirection? Direction { get; set; }
        /// <summary>
        /// Gets or sets a value that that describes how child elements are justified when there is extra space around them.
        /// </summary>
        /// <value>
        /// A value that that describes how child elements are justified when there is extra space around them.
        /// </value>
        [Parameter] public XFF.FlexJustify? JustifyContent { get; set; }
        /// <summary>
        /// Gets or sets a value that controls whether the coordinates of child elements are specified in absolute or relative terms.
        /// </summary>
        /// <value>
        /// A value that controls whether the coordinates of child elements are specified in absolute or relative terms.
        /// </value>
        [Parameter] public XFF.FlexPosition? Position { get; set; }
        /// <summary>
        /// Gets or sets a value that controls whether and how child elements within this layout wrap.
        /// </summary>
        /// <value>
        /// A value that controls whether and how child elements within this layout wrap.
        /// </value>
        [Parameter] public XFF.FlexWrap? Wrap { get; set; }

        public new XFF.FlexLayout NativeControl => ((FlexLayoutHandler)ElementHandler).FlexLayoutControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if (AlignContent != null)
            {
                builder.AddAttribute(nameof(AlignContent), (int)AlignContent.Value);
            }
            if (AlignItems != null)
            {
                builder.AddAttribute(nameof(AlignItems), (int)AlignItems.Value);
            }
            if (Direction != null)
            {
                builder.AddAttribute(nameof(Direction), (int)Direction.Value);
            }
            if (JustifyContent != null)
            {
                builder.AddAttribute(nameof(JustifyContent), (int)JustifyContent.Value);
            }
            if (Position != null)
            {
                builder.AddAttribute(nameof(Position), (int)Position.Value);
            }
            if (Wrap != null)
            {
                builder.AddAttribute(nameof(Wrap), (int)Wrap.Value);
            }

            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);
    }
}
