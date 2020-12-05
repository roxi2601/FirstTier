#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29d565a511a0bf4aa330a88dd817e0e69c65258c"
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
#line 2 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\EditProfile.razor"
       
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
