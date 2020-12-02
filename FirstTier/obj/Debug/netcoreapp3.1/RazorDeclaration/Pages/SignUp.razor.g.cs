#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b2e5aced1cc90ad0e8cf68a53aec8b28c148886"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
