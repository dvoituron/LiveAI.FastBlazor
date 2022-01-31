using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentAnchor
    {
        [Parameter]
        public string? Href { get; set; }

        [Parameter]
        public Appearance? Appearance { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}
