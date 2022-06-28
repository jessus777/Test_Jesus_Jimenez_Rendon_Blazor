using Microsoft.AspNetCore.Components.Web;

namespace NorthWind.Sales.Client.Blazor.Pages
{
    public partial class CreateMathOperation
    {
        ErrorBoundary ErrorBoundaryRef;
        CreateMathOperationDTO MathOperation = new CreateMathOperationDTO();

        void Recover()
        {
            ErrorBoundaryRef.Recover();
        }
    }
}
