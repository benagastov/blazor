// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorOnGitHubPages.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/content/BlazorOnGitHubPages/_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "/content/BlazorOnGitHubPages/_Imports.razor"
using System.Net.Http.Json

#nullable disable
    ;
#nullable restore
#line 3 "/content/BlazorOnGitHubPages/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 4 "/content/BlazorOnGitHubPages/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 5 "/content/BlazorOnGitHubPages/_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 6 "/content/BlazorOnGitHubPages/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http

#nullable disable
    ;
#nullable restore
#line 7 "/content/BlazorOnGitHubPages/_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "/content/BlazorOnGitHubPages/_Imports.razor"
using BlazorOnGitHubPages

#nullable disable
    ;
#nullable restore
#line 9 "/content/BlazorOnGitHubPages/_Imports.razor"
using BlazorOnGitHubPages.Shared

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "/content/BlazorOnGitHubPages/Pages/Index.razor"
      "/"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/content/BlazorOnGitHubPages/Pages/Index.razor"
       
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("eval", @"
                (function() {
                    const ctx = document.getElementById('stockChart');
                    
                    const data = {
                        labels: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun'],
                        datasets: [{
                            label: 'Stock Price (USD)',
                            data: [150, 165, 155, 180, 175, 190],
                            borderColor: 'rgb(75, 192, 192)',
                            tension: 0.1
                        }]
                    };

                    const config = {
                        type: 'line',
                        data: data,
                        options: {
                            responsive: true,
                            plugins: {
                                title: {
                                    display: true,
                                    text: 'Monthly Stock Prices'
                                }
                            }
                        }
                    };

                    new Chart(ctx, config);
                })()
            ");
        }
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "/content/BlazorOnGitHubPages/Pages/Index.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "/content/BlazorOnGitHubPages/Pages/Index.razor"
                   JSRuntime

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
