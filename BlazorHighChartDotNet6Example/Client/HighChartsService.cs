using Highsoft.Web.Mvc.Charts.Rendering;
using Microsoft.JSInterop;

namespace BlazorHighChartDotNet6Example.Client
{
    public class HighChartsService 
    {
        private readonly IJSRuntime _jsRuntime;

        public HighChartsService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        
        public async Task RenderChart(HighchartsRenderer renderer) => await _jsRuntime.InvokeVoidAsync("FunctionX", (object)renderer.GetJsonOptionsForBlazor());
    }
}
