using Microsoft.AspNetCore.Components;

namespace NorthWind.Sales.Client.Blazor.Components.Card
{
    public partial class CardComponent
    {
        [Parameter]
        public string Title { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        public string Class_mb { get; set; } = "3";
    }
}
