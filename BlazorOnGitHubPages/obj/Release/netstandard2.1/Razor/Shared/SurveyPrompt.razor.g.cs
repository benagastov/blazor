#pragma checksum "/content/BlazorOnGitHubPages/Shared/SurveyPrompt.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "41792ffa435551b1e393b713226e0527862979dda4e496cbfc0f378e1ac1fbac"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorOnGitHubPages.Shared
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
    #nullable restore
    public partial class SurveyPrompt : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#nullable restore
#line 3 "/content/BlazorOnGitHubPages/Shared/SurveyPrompt.razor"
             Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\n        Please take our\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2127014\">brief survey</a>\n    </span>\n    and tell us what you think.\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/content/BlazorOnGitHubPages/Shared/SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter]
    public string Title { get; set; }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
