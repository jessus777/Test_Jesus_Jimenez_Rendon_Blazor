using Microsoft.AspNetCore.Components;

namespace NorthWind.Sales.Client.Blazor.Components.Modal
{
    public partial class ModalComponent
    {
        [Parameter]
        public string Title { get; set; } = "";
        [Parameter]
        public string IdComponent { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public bool HasOptions { get; set; } = false;
    }
}
