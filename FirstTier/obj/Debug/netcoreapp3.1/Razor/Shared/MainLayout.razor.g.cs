#pragma checksum "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f249c0ec0a0844f0cfe0fcf8cc311a413d8d6d97"
// <auto-generated/>
#pragma warning disable 1591
namespace FirstTier.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using FirstTier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dnp1\FirstTier\FirstTier\_Imports.razor"
using FirstTier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
using FirstTier.Pages;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(2);
            __builder.AddAttribute(3, "Policy", "LoggedUser");
            __builder.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, "<li><a class=\"oi oi-home\" href=\"/\"> Home</a> </li>\r\n            ");
                __builder2.AddMarkupContent(7, "<li><a class=\"oi oi-heart\" href=\"/ContactUs\"> Contact us</a> </li>\r\n            ");
                __builder2.AddMarkupContent(8, "<li style=\"float:right\">\r\n                <a class=\"active\" href=\"/login\"> Log in</a>\r\n            </li>\r\n\r\n        ");
            }
            ));
            __builder.AddAttribute(9, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<li><a class=\"oi oi-home\" href=\"/\"> Home</a> </li>\r\n            ");
                __builder2.OpenElement(12, "li");
                __builder2.OpenElement(13, "a");
                __builder2.AddAttribute(14, "class", "oi oi-person");
                __builder2.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
                                                  profileClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "style", "color: white");
                __builder2.AddContent(17, " My Profile");
                __builder2.CloseElement();
                __builder2.AddContent(18, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<li><a class=\"oi oi-plus\" href=\"/AddArtwork\"> Add new artwork</a> </li>\r\n            ");
                __builder2.AddMarkupContent(21, "<li><a class=\"oi oi-heart\" href=\"/ContactUs\"> Contact us</a> </li>\r\n\r\n            ");
                __builder2.OpenElement(22, "li");
                __builder2.AddAttribute(23, "style", "float:right");
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "a");
                __builder2.AddAttribute(26, "class", "active");
                __builder2.AddAttribute(27, "href", "/");
                __builder2.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
                                                     PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(29, " Log out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n   \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, " \r\n");
            __builder.AddContent(34, 
#nullable restore
#line 43 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
 Body

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\dnp1\FirstTier\FirstTier\Shared\MainLayout.razor"
      
    private Account account = new Account();
    int id;
    
    
    private async Task profileClick()
    {
       
        User user = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
           NavigationManager.NavigateTo("/Profile/"+user.ID,true);
        }
      
    }

    protected override Task OnInitializedAsync()
    {
        return  Task.CompletedTask;
    }

    public async Task PerformLogout()
    {
        try
        {
            ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
