// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAuthApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using BlazorAuthApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\_Imports.razor"
using BlazorAuthApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\Pages\Content.razor"
using BlazorAuthApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/content")]
    public partial class Content : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\Pages\Content.razor"
       

    private GraphClientState State;

    private string Status;
    private string Data = null;

    async Task FocusTeams()
    {
        try
        {
            this.State = new GraphClientState();
            if (this.State.AccessToken == null)
            {
                await Task.Delay(1);
                // var data = await JsRuntime.InvokeAsync<object>(identifier: "prmoiseFunction");
                var data = await JsRuntime.InvokeAsync<object>(identifier: "window.getAccessToken");
                // Data = data.ToString();
                await JsRuntime.InvokeVoidAsync("openDoc");
            }

            this.Status = "Success !!!";
        }
        catch (JSException e)
        {
            _ = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
