using LiveAI.FastBlazor.Helpers;
using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentIcon
    {
        //protected string ClassName => new CssMapper().Add(Class)
        //                                             .Add($"mud-icon-size-{Size.ToDescriptionString()}");

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        /// <summary>
        /// User styles, applied on top of the component's own classes and styles.
        /// </summary>
        [Parameter]
        public string? Class { get; set; }

        /// <summary>
        /// Mapper to compute a component class based on <see cref="StyleMapper.AddIf(string, Func{bool})"/> methods.
        /// </summary>
        protected virtual StyleMapper ClassMapper { get; } = new StyleMapper();

        /// <summary>
        /// Icon to be used can either be svg paths.
        /// </summary>
        [Parameter]
        public string Icon { get; set; } = "";

        /// <summary>
        /// Title of the icon used for accessibility.
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "";

        /// <summary>
        /// The Size of the icon.
        /// </summary>
        [Parameter]
        public IconSize Size { get; set; } = IconSize.Medium;

        /// <summary>
        /// The color of the component. It supports the theme colors.
        /// </summary>
        //[Parameter]
        //public Color Color { get; set; } = Color.Inherit;

        /// <summary>
        /// The viewbox size of an svg element.
        /// </summary>
        [Parameter]
        public string ViewBox { get; set; } = "0 0 20 20";

        /// <summary>
        /// Child content of component.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}
