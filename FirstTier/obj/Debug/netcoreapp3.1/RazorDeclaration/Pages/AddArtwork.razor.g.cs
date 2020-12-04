#pragma checksum "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85fc9d15bb498dc418061ddc8fba0b1e13be865b"
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
#line 1 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using FirstTier;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\_Imports.razor"
using FirstTier.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
           [Authorize(Policy ="LoggedUser" )]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddArtwork")]
    public partial class AddArtwork : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
       
     [Parameter]
     public Artwork newArtwork { get; set; }

    IFileListEntry file;
    byte[] img;
    string imagePath = "images/paleta.jpg";
    
    private string errorMessage;

    private Task OnValueChanged(string value)
    {
        newArtwork.category = value;
        return Task.CompletedTask;
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

    protected override Task OnInitializedAsync()
    {
        newArtwork = new Artwork();
        return Task.CompletedTask;
    }

    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            var ms = new MemoryStream();
            await file.Data.CopyToAsync(ms);
            img = ms.ToArray();
            newArtwork.pictureBytes = img;
            Image.FromStream(ms).Save("wwwroot/images/temporary.jpg",ImageFormat.Jpeg);
            imagePath = "images/temporary.jpg";
            
         
    //to display picture should we save each one we get here separately or
    //create one file which will be overwritten with bytes we want to display each time system request picture.
    //one file for every picture entity like "profile picture", "NewArtworkPicture" 
        }
    }

    async Task PerformSave()
    {
        newArtwork.userId = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser().ID;
        if (string.IsNullOrEmpty(newArtwork.title))
        {
            errorMessage = "Title field cannot be empty";
        }
        if (string.IsNullOrEmpty(newArtwork.author))
        {
            newArtwork.author = "Author not specified";
        }
        if (string.IsNullOrEmpty(newArtwork.description))
        {
            newArtwork.description = "";
        }
        if (newArtwork.category == null)
        {
            newArtwork.category = "Painting";
        }
        try
        {
            await ArtworkService.AddArtwork(newArtwork);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
            errorMessage = e.Message;
        }
        NavigationManager.NavigateTo("/");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArtworkService ArtworkService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
