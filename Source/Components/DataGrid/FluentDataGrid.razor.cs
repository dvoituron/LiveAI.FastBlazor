using Microsoft.AspNetCore.Components;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentDataGrid<TItem>
    {
        // FAST Attributes
        [Parameter]
        public GenerateHeaderOptions? GenerateHeader { get; set; } = GenerateHeaderOptions.Default;

        [Parameter]
        public string? GridTemplateColumns { get; set; } = "";
        
        [Parameter]
        public List<TItem>? RowsData { get; set; }

        [Parameter]
        public IEnumerable<ColumnDefinition<TItem>>? ColumnDefinitions { get; set; }

        [Parameter]
        public RenderFragment<ColumnDefinition<TItem>>? HeaderCellTemplate { get; set; } = null;

        [Parameter]
        public RenderFragment<TItem>? RowItemTemplate { get; set; } = null;
        
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}