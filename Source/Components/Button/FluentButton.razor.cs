﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentButton
    {
        [Parameter]
        public Appearance Appearance { get; set; } = Appearance.Neutral;

        [Parameter]
        public bool Disabled { get; set; } = false;

        [Parameter]
        public bool Autofocus { get; set; } = false;

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? AdditionalAttributes { get; set; }

        [Parameter] 
        public EventCallback<MouseEventArgs> OnClick { get; set; }

        protected async Task OnClickHandler(MouseEventArgs e)
        {
            if (Disabled)
                return;
            else
                await OnClick.InvokeAsync(e);
        }
    }
}
