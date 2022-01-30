using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics.CodeAnalysis;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentTextArea
    {
        [Parameter]
        public bool Disabled { get; set; } = false;

        [Parameter]
        public bool Readonly { get; set; } = false;

        [Parameter]
        public bool Required { get; set; } = false;

        [Parameter]
        public bool Autofocus { get; set; } = false;

        [Parameter]
        public Resize Resize { get; set; } = Resize.None;

        [Parameter]
        public Appearance Appearance { get; set; } = Appearance.Neutral;

        [Parameter]
        public string Placeholder { get; set; } = "";

        [Parameter]
        public RenderFragment? ChildContent { get; set; }
        
        protected override bool TryParseValueFromString(string? value, out string? result, [NotNullWhen(false)] out string? validationErrorMessage)
        {
            result = value;
            validationErrorMessage = null;
            return true;
        }
    }
}
