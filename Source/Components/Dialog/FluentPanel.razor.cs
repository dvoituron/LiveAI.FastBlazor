using LiveAI.FastBlazor.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentPanel
    {
        private bool _isOpen;

        protected override void OnInitialized()
        {
            _isOpen = IsOpen;

            ClassMapper.Add(Class)
                       .Add("panel-main");
            StyleMapper.Add(Style);

            base.OnInitialized();
        }

        [Parameter]
        public EventCallback<bool> OnIsOpenChanged { get; set; }

        [Parameter]
        public RenderFragment? Body { get; set; }

        [Parameter]
        public RenderFragment? Header { get; set; }

        [Parameter]
        public RenderFragment? Footer { get; set; }

        [Parameter]
        public bool DisplayCloseButton { get; set; } = true;

        [Parameter]
        public EventCallback<bool> IsOpenChanged { get; set; }

        [Parameter]
        public bool IsOpen { get; set; }

        protected async override Task OnParametersSetAsync()
        {
            if (_isOpen != IsOpen)
            {
                _isOpen = IsOpen;
                await OnIsOpenChanged.InvokeAsync(IsOpen);
            }
        }

        protected async virtual Task OpenAsync()
        {
            IsOpen = true;
            await IsOpenChanged.InvokeAsync(IsOpen);
        }

        protected async virtual Task CloseAsync()
        {
            IsOpen = false;
            await IsOpenChanged.InvokeAsync(IsOpen);
        }
    }
}
