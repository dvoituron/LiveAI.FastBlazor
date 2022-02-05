using Microsoft.AspNetCore.Components;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentBadge
    {
        [Parameter]
        public Color Color { get; set; } = Color.Highlight;

        [Parameter]
        public Fill Fill { get; set; } = Fill.Highlight;

        [Parameter]
        public Appearance Appearance { get; set; } = Appearance.Neutral;

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
    }
}