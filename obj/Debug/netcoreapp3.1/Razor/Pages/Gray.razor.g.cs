#pragma checksum "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\Pages\Gray.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4128c4dd91f3e37a876c66c184120a770ee895d"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/gray")]
    public partial class Gray : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p>This is your Customised channel/ group tab!</p>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Recent messages in my mailbox</h1>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\Pages\Gray.razor"
                                          GetMessages

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Display Messages");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "h1");
            __builder.AddContent(8, 
#nullable restore
#line 13 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\Pages\Gray.razor"
     AccessToken

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\HamsaDevarajegowda\Desktop\BlazorAuthApp\BlazorAuthApp\Pages\Gray.razor"
      
    protected string AccessToken = null;

    protected void GetMessages()
    {
        NavigationManager.NavigateTo("auth.start.html");
        // this.SignInProcess();
    }

    private void SignInProcess()
    {
        if (string.IsNullOrEmpty(this.AccessToken))
        {
            _ = this.GetAccessToken(true);
        }
    }

    private string GetAccessToken(bool promptConsent = false)
    {
        if (promptConsent)
        {
            AccessToken = "test token";
            NavigationManager.NavigateTo("auth.start.html");
        }
        return "temp token";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591