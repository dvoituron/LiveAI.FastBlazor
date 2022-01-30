using Microsoft.AspNetCore.Components;
using System;
using System.Diagnostics.CodeAnalysis;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentTextField
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
        public int Size { get; set; } = 1;

        [Parameter]
        public Appearance Appearance { get; set; } = Appearance.Neutral;

        [Parameter]
        public TextFieldType TextFieldType { get; set; } = TextFieldType.Text;

        [Parameter]
        public string Placeholder { get; set; } = "";

        [Parameter]
        public int MinLength { get; set; } = 0;

        [Parameter]
        public int MaxLength { get; set; } = int.MaxValue;

        [Parameter]
        public bool Spellcheck { get; set; } = false;

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
