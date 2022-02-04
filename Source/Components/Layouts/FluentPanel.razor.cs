using LiveAI.FastBlazor.Helpers;
using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentPanel
    {
        private bool _isOpen = false;

        protected override void OnInitialized()
        {
            ClassMapper.Add(Class)
                       .Add("panel-main");
            StyleMapper.Add(Style);

            base.OnInitialized();
        }

        [Parameter]
        public EventCallback<bool> OnOpenChanged { get; set; }

        [Parameter]
        public RenderFragment? Body { get; set; }

        [Parameter]
        public RenderFragment? Header { get; set; }

        [Parameter]
        public RenderFragment? Footer { get; set; }

        [Parameter]
        public bool DisplayCloseButton { get; set; } = true;
        
        public bool IsOpen
        {
            get
            {
                return _isOpen;
            }
            private set
            {
                if (_isOpen != value)
                {
                    _isOpen = value;
                    OnOpenChanged.InvokeAsync(_isOpen);
                }
            }
        }

        public void Show()
        { 
            IsOpen = true;
        }

        public void Close()
        {
            IsOpen = false;
        }

        protected virtual void CloseButton_Click()
        {
            IsOpen = false;
        }
    }
}
