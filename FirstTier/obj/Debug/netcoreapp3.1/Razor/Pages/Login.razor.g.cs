#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57c525608dd78baa734107fc5858cf54ee32edd"
// <auto-generated/>
#pragma warning disable 1591
namespace FirstTier.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using FirstTier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using FirstTier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
                __builder2.AddAttribute(4, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n            ");
                    __builder3.OpenElement(6, "div");
                    __builder3.AddAttribute(7, "id", "loginForm");
                    __builder3.AddMarkupContent(8, "\r\n              \r\n                ");
                    __builder3.AddMarkupContent(9, "<p style=\"font-family: \'Montserrat\', sans-serif; font-size: 25px; text-align: center; color: white\">Art Web Shop</p>\r\n\r\n                ");
                    __builder3.OpenElement(10, "div");
                    __builder3.AddAttribute(11, "class", "form-group");
                    __builder3.AddMarkupContent(12, "\r\n                    ");
                    __builder3.AddMarkupContent(13, "<label style=\"color: white\">Username:</label>\r\n                    ");
                    __builder3.OpenElement(14, "input");
                    __builder3.AddAttribute(15, "class", "form-control");
                    __builder3.AddAttribute(16, "type", "text");
                    __builder3.AddAttribute(17, "placeholder", "username");
                    __builder3.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor"
                                                                                                username

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(20, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\r\n                ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "form-group");
                    __builder3.AddMarkupContent(24, "\r\n                    ");
                    __builder3.AddMarkupContent(25, "<label style=\"color: white\">Password:</label>\r\n                    ");
                    __builder3.OpenElement(26, "input");
                    __builder3.AddAttribute(27, "class", "form-control");
                    __builder3.AddAttribute(28, "type", "password");
                    __builder3.AddAttribute(29, "placeholder", "password");
                    __builder3.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor"
                                                                                                    password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "style", "color:red");
                    __builder3.AddContent(36, 
#nullable restore
#line 27 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor"
                                        errorMessage

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(37, "\r\n                ");
                    __builder3.OpenElement(38, "button");
                    __builder3.AddAttribute(39, "class", "btn button");
                    __builder3.AddAttribute(40, "type", "submit");
                    __builder3.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor"
                                                                   PerformLogin

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(42, "\r\n                    ");
                    __builder3.AddMarkupContent(43, "<span>Login</span>\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(44, "\r\n                ");
                    __builder3.OpenElement(45, "button");
                    __builder3.AddAttribute(46, "class", "btn button");
                    __builder3.AddAttribute(47, "type", "submit");
                    __builder3.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor"
                                                                   NavigateToSignUp

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(49, "\r\n                    ");
                    __builder3.AddMarkupContent(50, "<span>Join us</span>\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(51, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n           \r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;
    private bool isAuthorized;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            await ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
            isAuthorized = true;
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            errorMessage = e.Message;
        }
    }

    private void NavigateToSignUp()
    {
        NavigationManager.NavigateTo("/SignUp");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591