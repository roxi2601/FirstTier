#pragma checksum "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f001caf2867128fbee223e3c7d4507c926eef345"
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
#line 3 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditProfile/{id}")]
    public partial class EditProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 17 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
 if (!isOwner)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<h3 style=\"color: red\">Access denied</h3>\r\n");
#nullable restore
#line 20 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 23 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                    updateAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                                   PerformUpdate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "xmlns", "http://www.w3.org/1999/html");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "id", "registerForm");
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.AddMarkupContent(15, "<h3 id=\"AddUser\" xmlns=\"http://www.w3.org/1999/html\" style=\"font-family: \'Montserrat\', sans-serif; font-size: 25px; text-align: center; color: black\"> Edit profile </h3>\r\n        ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-12 row");
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "span");
                __builder2.AddAttribute(20, "class", "col-6");
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddAttribute(24, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(25, "\r\n                    Username: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                            updateAccount.username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateAccount.username = __value, updateAccount.username))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateAccount.username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "span");
                __builder2.AddAttribute(34, "class", "col-6");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group ");
                __builder2.AddAttribute(38, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(39, "\r\n                    First name: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                            updateAccount.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateAccount.FirstName = __value, updateAccount.FirstName))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateAccount.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        \r\n        ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-12 row");
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenElement(51, "span");
                __builder2.AddAttribute(52, "class", "col-6");
                __builder2.AddMarkupContent(53, "\r\n                ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddAttribute(56, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(57, "\r\n                    Last name: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                            updateAccount.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateAccount.LastName = __value, updateAccount.LastName))));
                __builder2.AddAttribute(61, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateAccount.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.OpenElement(65, "span");
                __builder2.AddAttribute(66, "class", "col-6");
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group ");
                __builder2.AddAttribute(70, "style", "font-family: -webkit-body;  color:black;");
                __builder2.AddMarkupContent(71, "\r\n                    Description: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                            updateAccount.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateAccount.Description = __value, updateAccount.Description))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateAccount.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n        \r\n        ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-12 row");
                __builder2.AddMarkupContent(82, "\r\n            ");
                __builder2.OpenElement(83, "span");
                __builder2.AddAttribute(84, "class", "col-6");
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddAttribute(88, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(89, "\r\n                    Password: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(90);
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                            updateAccount.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => updateAccount.Password = __value, updateAccount.Password))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => updateAccount.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n            ");
                __builder2.OpenElement(97, "span");
                __builder2.AddAttribute(98, "class", "col-6");
                __builder2.AddMarkupContent(99, "\r\n                ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group ");
                __builder2.AddAttribute(102, "style", "font-family: -webkit-body;  color:black");
                __builder2.AddMarkupContent(103, "\r\n                    Confirm password: <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(104);
                __builder2.AddAttribute(105, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                             ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(106, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ConfirmPassword = __value, ConfirmPassword))));
                __builder2.AddAttribute(107, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ConfirmPassword));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(108, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n        \r\n        ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "col-12 row");
                __builder2.AddMarkupContent(114, "\r\n            ");
                __builder2.OpenElement(115, "span");
                __builder2.AddAttribute(116, "class", "col-6 ");
                __builder2.AddMarkupContent(117, "\r\n                ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "form-group ");
                __builder2.AddAttribute(120, "style", "font-family: -webkit-body;  color:black; ");
                __builder2.AddMarkupContent(121, "\r\n                    Choose profile picture: <br>\r\n                    ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(122);
                __builder2.AddAttribute(123, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 77 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                         HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n");
#nullable restore
#line 78 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                     if (file != null)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(125, "                        ");
                __builder2.OpenElement(126, "p");
                __builder2.AddContent(127, "Name: ");
                __builder2.AddContent(128, 
#nullable restore
#line 80 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                  file.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n");
#nullable restore
#line 81 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(130, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n            ");
                __builder2.OpenElement(133, "span");
                __builder2.AddAttribute(134, "class", "col-6");
                __builder2.AddMarkupContent(135, "\r\n                ");
                __builder2.OpenElement(136, "p");
                __builder2.AddAttribute(137, "class", "actions");
                __builder2.AddMarkupContent(138, "\r\n                    ");
                __builder2.OpenElement(139, "button");
                __builder2.AddAttribute(140, "class", "buttonCreateAccount");
                __builder2.AddAttribute(141, "type", "submit");
                __builder2.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                                                                PerformUpdate

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(143, "\r\n                               \r\n                        ");
                __builder2.AddMarkupContent(144, "<span>Update profile</span>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(145, "\r\n                           ");
                __builder2.OpenElement(146, "button");
                __builder2.AddAttribute(147, "class", "buttonCreateAccount");
                __builder2.AddAttribute(148, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                                                          profileClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(149, "\r\n                                                                                                                       \r\n                               ");
                __builder2.AddMarkupContent(150, "<span>Back to profile</span> ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n                ");
                __builder2.OpenElement(153, "div");
                __builder2.AddAttribute(154, "style", "color:red");
                __builder2.AddContent(155, 
#nullable restore
#line 95 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
                                        errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(158, " \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(160, "\r\n");
#nullable restore
#line 100 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
   

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "D:\dnp1\FirstTier\FirstTier\Pages\EditProfile.razor"
       
    [Parameter]
    public string Id { get; set; }
    private Account updateAccount = new Account();
    private int userId;
    private bool isOwner;
    public string ConfirmPassword ="";
   
    
    private bool isAuthorized;
    
    IFileListEntry file;
    byte[] Img;
    string imagePath = "images/profilepic.png";
    
    
    private string errorMessage;

    private async Task profileClick()
    {
        User user = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            NavigationManager.NavigateTo("/Profile/"+user.ID);
        }
        
    }

    async Task PerformUpdate()
    {
        errorMessage = "";
        try
        {
            if (string.IsNullOrEmpty(updateAccount.FirstName) || string.IsNullOrEmpty(updateAccount.LastName))
            {
                throw new Exception("Specify first and last name");
            }
            
            if (string.IsNullOrEmpty(updateAccount.username))
            {
                throw new Exception("Username cannot be empty");
            }
            if (!updateAccount.Password.Equals(ConfirmPassword))
            {
                throw new Exception("Passwords don't match, try to type them again");
            }
    if (updateAccount.username.Length<3 || updateAccount.Password.Length<6)
            {
                throw  new Exception("Username and password have to contain at least 3 signs");
            }
            updateAccount.SecurityLevel = updateAccount.username.Equals("admin") ? 5 : 3; //if admin securitylevel=5, else security=3
  
    await AccountService.UpdateAccountAsync(updateAccount);
            
            User user = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
            if (user != null)
            {
              //NavigationManager.NavigateTo("/Profile/"+user.ID);
               // NavigationManager.NavigateTo("/");
                errorMessage = "Edit done!";
            }

        }
        catch (NullReferenceException e)
        {
            errorMessage = "you should fill in all the fields";
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
            updateAccount.Img = Img;
            Image.FromStream(ms).Save("wwwroot/images/temporary.jpg",ImageFormat.Jpeg);
            imagePath = "images/temporaryProfile.jpg";
        }
    }


    protected async override Task OnInitializedAsync()
    {
        userId = Int32.Parse(Id);
        try
        {
            updateAccount = await AccountService.GetAccountAsync(userId);
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
        User user  = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            isOwner = user.ID == userId;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
