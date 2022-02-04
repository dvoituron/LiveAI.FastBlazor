using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentButton
    {
        protected override void OnInitialized()
        {
            ClassMapper.Add(Class);
            StyleMapper.AddIf($"width: {Width}", () => !String.IsNullOrEmpty(Width))
                       .Add(Style);
            base.OnInitialized();
        }

        [Parameter]
        public Appearance Appearance { get; set; } = Appearance.Neutral;

        [Parameter]
        public bool Disabled { get; set; } = false;

        [Parameter]
        public bool Autofocus { get; set; } = false;

        [Parameter]
        public string IconStart { get; set; } = "";

        [Parameter]
        public string IconEnd { get; set; } = "";

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public string? Width { get; set; }

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
