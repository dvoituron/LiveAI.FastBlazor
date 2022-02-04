using LiveAI.FastBlazor.Helpers;
using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentStackPanel
    {
        protected override void OnInitialized()
        {
            ClassMapper.Add(Class)
                       .AddIf("stack-horizontal",() =>  Orientation == Orientation.Horizontal)
                       .AddIf("stack-vertical", () => Orientation == Orientation.Vertical);

            StyleMapper.AddIf($"align-items: {GetHorizontalAlignment()}", () => Orientation == Orientation.Vertical)

                       .AddIf($"justify-content: {GetHorizontalAlignment()}", () => Orientation == Orientation.Horizontal)
                       .AddIf($"align-items: {GetVerticalAlignment()}", () => Orientation == Orientation.Horizontal)

                       .AddIf($"gap: {Gap}px", () => Gap.HasValue)
                       .AddIf($"width: {Width}", () => !String.IsNullOrEmpty(Width))
                       .AddIf($"flex-wrap: wrap", () => IsWrap)

                       .Add(Style);

            base.OnInitialized();
        }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public HorizontalAlignment HorizontalAlignment { get; set; } = HorizontalAlignment.Left;

        [Parameter]
        public VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Top;

        [Parameter]
        public Orientation Orientation { get; set; } = Orientation.Vertical;

        [Parameter]
        public string? Width { get; set; } = "100%";

        [Parameter]
        public bool IsWrap { get; set; } = false;

        [Parameter]
        public int? Gap { get; set; } = 10;

        private string GetHorizontalAlignment()
        {
            switch (HorizontalAlignment)
            {
                case HorizontalAlignment.Left:
                    return "start";
                case HorizontalAlignment.Center:
                    return "center";
                case HorizontalAlignment.Right:
                    return "end";
                default:
                    return "start";
            }
        }

        private string GetVerticalAlignment()
        {
            switch (VerticalAlignment)
            {
                case VerticalAlignment.Top:
                    return "start";
                case VerticalAlignment.Center:
                    return "center";
                case VerticalAlignment.Bottom:
                    return "end";
                default:
                    return "start";
            }
        }
    }
}
