#pragma checksum "/content/BlazorOnGitHubPages/Shared/MainLayout.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d30858ad4f232c6eba4fda9086d2a72aac96e193170afc7a3f449a5d22f24db9"
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
    public partial class MainLayout : LayoutComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<global::BlazorOnGitHubPages.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\n    </div>\n\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "content px-4");
            __builder.AddMarkupContent(12, "\n        ");
            __builder.AddContent(13, 
#nullable restore
#line 13 "/content/BlazorOnGitHubPages/Shared/MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591