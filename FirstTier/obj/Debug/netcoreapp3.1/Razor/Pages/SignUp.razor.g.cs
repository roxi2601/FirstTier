#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2e5aced1cc90ad0e8cf68a53aec8b28c148886"
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
#line 2 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using FirstTier.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/SignUp")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                    newAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                                PerformSignUp

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "xmlns", "http://www.w3.org/1999/html");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "id", "registerForm");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<h3 id=\"AddUser\" xmlns=\"http://www.w3.org/1999/html\" style=\"font-family: \'Montserrat\', sans-serif; font-size: 25px; text-align: center; color: black\"> Join us!</h3>\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-12 row");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenElement(17, "span");
                __builder2.AddAttribute(18, "class", "col-6");
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddAttribute(22, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(23, "\r\n                    Username: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                            newAccount.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.username = __value, newAccount.username))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "span");
                __builder2.AddAttribute(32, "class", "col-6");
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group ");
                __builder2.AddAttribute(36, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(37, "\r\n                    First name: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                            newAccount.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.FirstName = __value, newAccount.FirstName))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        \r\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-12 row");
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.OpenElement(49, "span");
                __builder2.AddAttribute(50, "class", "col-6");
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddAttribute(54, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(55, "\r\n                    Last name: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                            newAccount.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.LastName = __value, newAccount.LastName))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "span");
                __builder2.AddAttribute(64, "class", "col-6");
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group ");
                __builder2.AddAttribute(68, "style", "font-family: -webkit-body;  color:black;");
                __builder2.AddMarkupContent(69, "\r\n                    Description: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                            newAccount.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.Description = __value, newAccount.Description))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        \r\n        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "col-12 row");
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.OpenElement(81, "span");
                __builder2.AddAttribute(82, "class", "col-6");
                __builder2.AddMarkupContent(83, "\r\n                ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "form-group");
                __builder2.AddAttribute(86, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(87, "\r\n                    Password: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(88);
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                            newAccount.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAccount.Password = __value, newAccount.Password))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAccount.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n            ");
                __builder2.OpenElement(95, "span");
                __builder2.AddAttribute(96, "class", "col-6");
                __builder2.AddMarkupContent(97, "\r\n                ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "form-group ");
                __builder2.AddAttribute(100, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(101, "\r\n                    Confirm password: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(102);
                __builder2.AddAttribute(103, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 63 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                             ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ConfirmPassword = __value, ConfirmPassword))));
                __builder2.AddAttribute(105, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n        \r\n         ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "col-12 row");
                __builder2.AddMarkupContent(112, "\r\n             ");
                __builder2.OpenElement(113, "span");
                __builder2.AddAttribute(114, "class", "col-6 ");
                __builder2.AddMarkupContent(115, "\r\n                  ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group ");
                __builder2.AddAttribute(118, "style", "font-family: -webkit-body;  color:black; ");
                __builder2.AddMarkupContent(119, "\r\n                  Choose profile picture: <br>\r\n                  ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(120);
                __builder2.AddAttribute(121, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 72 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                       HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(122, "\r\n");
#nullable restore
#line 73 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                 if (file != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(123, "                    ");
                __builder2.OpenElement(124, "p");
                __builder2.AddContent(125, "Name: ");
                __builder2.AddContent(126, 
#nullable restore
#line 75 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                              file.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n");
#nullable restore
#line 76 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(128, "\r\n                  ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                  ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\r\n                    ");
                __builder2.OpenElement(131, "span");
                __builder2.AddAttribute(132, "class", "col-6");
                __builder2.AddMarkupContent(133, "\r\n                        ");
                __builder2.AddMarkupContent(134, @"<p class=""actions"">
                            <button class=""buttonCreateAccount"" type=""submit"">
                               
                                <span>Create account</span>
                            </button>
                        </p>
                        ");
                __builder2.OpenElement(135, "div");
                __builder2.AddAttribute(136, "style", "color:red");
                __builder2.AddContent(137, 
#nullable restore
#line 87 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
                                                errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor"
       
    private Account newAccount = new Account();
    
    public string ConfirmPassword ="";
   
    
    private bool isAuthorized;
    
    IFileListEntry file;
    byte[] Img;
    string imagePath = "images/profilepic.png";
    
    
    private string errorMessage;
    async Task PerformSignUp()
    {
        errorMessage = "";
        try
        {
            if (string.IsNullOrEmpty(newAccount.FirstName) || string.IsNullOrEmpty(newAccount.LastName))
            {
                throw new Exception("Specify first and last name");
            }
            
            if (string.IsNullOrEmpty(newAccount.username))
            {
                throw new Exception("Username cannot be empty");
            }
            if (!newAccount.Password.Equals(ConfirmPassword))
            {
                throw new Exception("Passwords don't match, try to type them again");
            }
    if (newAccount.username.Length<3 || newAccount.Password.Length<6)
            {
                throw  new Exception("Username and password have to contain at least 3 signs");
            }
            newAccount.SecurityLevel = newAccount.username.Equals("admin") ? 5 : 3; //if admin securitylevel=5, else security=3
  
    await AccountService.AddAccountAsync(newAccount);
            NavigationManager.NavigateTo("/login");
        }
        catch (NullReferenceException e)
        {
            errorMessage = "you should fulfill all the fields";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            errorMessage = e.Message;
        }
        
    }


    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            Img = ms.ToArray();
            newAccount.Img = Img;
            Image.FromStream(ms).Save("wwwroot/images/temporary.jpg",ImageFormat.Jpeg);
            imagePath = "images/temporaryProfile.jpg";
        }
    }
    
    /*[CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if(!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/");
        }
    }*/

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
