using Microsoft.AspNetCore.Components;

namespace NorthWind.Sales.Client.Blazor.Components.Alert
{
    public partial class AlertBorderComponent
    {
        [Parameter]
        public string Class { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
