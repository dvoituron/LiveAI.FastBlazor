using LiveAI.FastBlazor.Helpers;
using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentIcon
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();

            this.ClassMapper.Add($"icon-size-{Size.ToAttributeValue()}");
        }       

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
        public string ViewBox { get; set; } = "0 0 24 24";

        /// <summary>
        /// Child content of component.
        /// </summary>
        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;
    }
}
