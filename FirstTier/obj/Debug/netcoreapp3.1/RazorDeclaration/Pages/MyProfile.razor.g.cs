#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e37651e884c19f1ef560a5631a56566eb076e27"
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
#line 2 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile/{id}")]
    public partial class MyProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 162 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
       

    [Parameter]
    public string Id { get; set; }
    private Account account = new Account();
    string errorMessage = "";
    private IList<Account> allAccounts;
    private IList<Artwork> artworks;
    private IList<Artwork> artworksToShow;
    int userId;
    bool isOwner;
    
    private string imagePathArtwork = "images/paleta.jpg";

    /*protected ConfirmBase DeleteConfirmation { get; set; }*/
    byte[] img;
    string imagePath = "images/painter-161318_640.png";

    private void Chat()
    {
        NavigationManager.NavigateTo("/Chat");
    }

    private void EditProfile()
    {
        NavigationManager.NavigateTo("/EditProfile");
    }

    private void DeleteProfile()
    {
        try
        {
            AccountService.RemoveAccountAsync(account.ID);
            ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


    private string PrepareSRC(Artwork artwork)
    {
        if (artwork.pictureBytes != null)
        {
            return "images/artwork" + artwork.id + ".jpg";
        }
        return "images/paleta.jpg";
    }
    private string PrepareSRCProfile(Account account)
    {
        if (account.Img != null)
        {
            return "images/profile" + account.ID + ".jpg";
        }
        return "images/defaultprofilepic.jpg";
    }

    protected override async Task OnInitializedAsync()
    {
        int id = Int32.Parse(Id); 
        account = await AccountService.GetAccountAsync(id);
        Console.WriteLine(account.ID);
        artworks = await ArtworkService.GetArtworksAsync();
        artworksToShow = artworks;
        User user  = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            isOwner = user.ID == account.ID;
        }

       
        /*if (account.Img != null)
        {
            imagePath= "images/profile" + account.ID + ".jpg";
        }
        imagePath  =  "images/defaultprofilepic.jpg";*/
        if (account.Img != null)
        {
            var ms = new MemoryStream();
            ms.Write(account.Img);
            Image.FromStream(ms).Save("wwwroot/images/profile"+account.ID+".jpg",ImageFormat.Jpeg);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArtworkService ArtworkService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountService AccountService { get; set; }
    }
}
#pragma warning restore 1591
