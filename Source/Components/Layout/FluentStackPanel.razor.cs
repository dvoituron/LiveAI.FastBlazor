using LiveAI.FastBlazor.Helpers;
using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentStackPanel
    {
        protected override void OnInitialized()
        {
            StyleMapper.Add(Style)
                       .AddIf("align-items", GetAlignment(), () => Orientation == Orientation.Vertical)
                       .AddIf("justify-content", GetAlignment(), () => Orientation == Orientation.Horizontal)
                       .AddIf("gap", $"{Gap}px", () => Gap > 0);

            base.OnInitialized();
        }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public AlignmentItems AlignmentItems { get; set; } = AlignmentItems.Left;

        [Parameter]
        public Orientation Orientation { get; set; } = Orientation.Vertical;

        [Parameter]
        public uint Gap { get; set; } = 10;

        private string GetAlignment()
        {
            switch (AlignmentItems)
            {
                case AlignmentItems.Left:
                    return "start";
                case AlignmentItems.Center:
                    return "center";
                case AlignmentItems.Right:
                    return "end";
                default:
                    return "start";
            }
        }
    }
}
