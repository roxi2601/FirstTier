#pragma checksum "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57307c0fd01604395c321e9519856505f8771f73"
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
#line 2 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditArtwork/{id}")]
    public partial class EditArtwork : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\dnp1\FirstTier\FirstTier\Pages\EditArtwork.razor"
       
    [Parameter]
    public string Id { get; set; }
    private int id;
    private bool isOwner;
    private Artwork artwork = new Artwork();
    
    IFileListEntry file;
    byte[] img;
    string imagePath = "images/paleta.jpg";
    string errorMessage = "";

    private Task OnValueChanged(string value)
    {
        artwork.category = value;
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
            artwork.pictureBytes = img;
            Image.FromStream(ms).Save("wwwroot/images/artwork"+artwork.id+".jpg",ImageFormat.Jpeg);
            imagePath = "images/artwork"+artwork.id+".jpg";
            
        }
    }
    
    private void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }
    
    async Task PerformEdit()
    {
        if (string.IsNullOrEmpty(artwork.title))
        {
            errorMessage = "Title field cannot be empty";
        }
        if (string.IsNullOrEmpty(artwork.author))
        {
            artwork.author = "Author not specified";
        }
        if (string.IsNullOrEmpty(artwork.description))
        {
            artwork.description = "";
        }
        if (artwork.category == null)
        {
            artwork.category = "Painting";
        }
        try
        {
            await ArtworkService.EditArtwork(artwork);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.StackTrace);
            errorMessage = e.Message;
        }
        NavigationManager.NavigateTo("/");
    }
    
    protected override async Task OnInitializedAsync()
    {
        id = Int32.Parse(Id);
        try
        {
            artwork = await ArtworkService.GetArtworkAsync(id);
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
        if (artwork.pictureBytes != null)
        {
            imagePath = "images/artwork" + artwork.id + ".jpg";
        }

        User user  = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            isOwner = user.ID == artwork.userId;
        }
        
    }
    /* for searching
    protected async Task UpdateArtworks()
    {
        await ArtworkService.GetArtworksAsync();
        NavigationManager.NavigateTo("/artworkPage");
    }*/


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArtworkService ArtworkService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
