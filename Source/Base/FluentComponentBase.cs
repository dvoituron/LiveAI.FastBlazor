using LiveAI.FastBlazor.Helpers;
using Microsoft.AspNetCore.Components;
using System;

namespace LiveAI.FastBlazor.Base
{
    public abstract class FluentComponentBase : ComponentBase
    {       
        /// <summary>
        /// User styles, applied on top of the component's own classes and styles.
        /// </summary>
        [Parameter]
        public string? Style { get; set; }

        /// <summary>
        /// Mapper to compute a component style based on <see cref="StyleMapper.AddIf(string, Func{bool})"/> methods.
        /// </summary>
        protected virtual StyleMapper StyleMapper { get; } = new StyleMapper();

        /// <summary>
        /// Use Tag to attach any user data object to the component for your convenience.
        /// </summary>
        [Parameter]
        public object? Tag { get; set; } = null;

        /// <summary>
        /// Gets or sets a collection of additional attributes that will be applied to the created element.
        /// </summary>
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}
