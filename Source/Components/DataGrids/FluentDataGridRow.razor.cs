using Microsoft.AspNetCore.Components;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentDataGridRow<TItem>
    {
        [Parameter]
        public int? RowIndex { get; set; }

        [Parameter]
        public string? GridTemplateColumns { get; set; } = null;

        [Parameter]
        public DataGridRowType RowType { get; set; } = DataGridRowType.Default;
        
        [Parameter]
        public TItem? RowData { get; set; }

        [Parameter]
        public IEnumerable<ColumnDefinition<TItem>>? ColumnDefinitions { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}