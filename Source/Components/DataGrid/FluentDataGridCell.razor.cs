using Microsoft.AspNetCore.Components;

namespace LiveAI.FastBlazor.Components
{
    public partial class FluentDataGridCell
    {
        // FAST Attributes
        [Parameter]
        public DataGridCellType CellType { get; set; } = DataGridCellType.Default;

        [Parameter]
        public int GridColumn { get; set; }

        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object>? AdditionalAttributes { get; set; }
    }
}