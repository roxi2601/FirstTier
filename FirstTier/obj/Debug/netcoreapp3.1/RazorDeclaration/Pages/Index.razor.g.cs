#pragma checksum "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17ee089b9c0b49efa90cb0c1d601a84d65502967"
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
#line 3 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
 
    private int? maxPrice;
    private int? minPrice;
    private string? category;
    private IList<Artwork> artworks;
    private IList<Artwork> artworksToShow;
    private string imagePath = "images/paleta.jpg";

    private Task OnValueChanged(string value)
    {
       
        category = value;
        return Task.CompletedTask;
    }

    private string PrepareSRC(Artwork artwork)
    {
        if (artwork.pictureBytes != null)
        {
           return "images/artwork" + artwork.id+".jpg";
        }
        return "images/paleta.jpg";
    }

    private void ExecuteFilter()
    {
        if (maxPrice==null && minPrice==null && (category==null || category.Equals("All")))
        {
            artworksToShow = artworks;
        }
        else if (maxPrice != null && minPrice==null && (category==null || category.Equals("All")))
        {
            artworksToShow = artworks.Where(artwork => artwork.price < maxPrice).ToList();
        } 
        else if (maxPrice != null && minPrice!=null && (category==null || category.Equals("All")))
        {
            artworksToShow = artworks.Where(artwork => artwork.price < maxPrice && artwork.price>minPrice).ToList();
        }
        else if (maxPrice == null && minPrice!=null && (category==null || category.Equals("All")))
        {
            artworksToShow = artworks.Where(artwork => artwork.price > minPrice).ToList();
        }
        else if (maxPrice == null && minPrice==null && category!=null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.category.Equals(category)).ToList();
        }
        else if (maxPrice != null && minPrice!=null && category!=null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.price > minPrice && artwork.price<maxPrice && artwork.category.Equals(category)).ToList();
        }
        else if (maxPrice == null && minPrice!=null && category!=null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.price > minPrice && artwork.category.Equals(category)).ToList();
        }
        else if (maxPrice != null && minPrice==null && category!=null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.price<maxPrice && artwork.category.Equals(category)).ToList();
        }
        Console.WriteLine(category+"     "+minPrice+"     "+maxPrice);
    }

    protected  override async Task OnInitializedAsync()
    {

        artworks = await ArtworkService.GetArtworksAsync();
            artworksToShow = artworks;
        /*artworksToShow = new List<Artwork>();*/
        /*Artwork deleteItLater = new Artwork();
        deleteItLater.price = 30;
        deleteItLater.title = "Title";
        deleteItLater.category = "Paintings";
        Artwork deleteItLater1 = new Artwork();
        deleteItLater1.price = 30;
        deleteItLater1.title = "Title";
        deleteItLater1.category = "Paintings";
        Artwork deleteItLater2 = new Artwork();
        deleteItLater2.price = 30;
        deleteItLater2.title = "Title";
        deleteItLater2.category = "Paintings";
        Artwork deleteItLater3 = new Artwork();
        deleteItLater3.price = 30;
        deleteItLater3.title = "Title";
        deleteItLater3.category = "Paintings";
        Artwork deleteItLater4 = new Artwork();
        deleteItLater4.price = 30;
        deleteItLater4.title = "Title";
        deleteItLater4.category = "Paintings";
        Artwork deleteItLater5 = new Artwork();
        deleteItLater5.price = 30;
        deleteItLater5.title = "Title";
        deleteItLater5.category = "Paintings";
        Artwork deleteItLater6 = new Artwork();
        deleteItLater6.price = 30;
        deleteItLater6.title = "Title";
        deleteItLater6.category = "Paintings";
        artworksToShow.Add(deleteItLater);
        artworksToShow.Add(deleteItLater1);
        artworksToShow.Add(deleteItLater2);
        artworksToShow.Add(deleteItLater3);
        artworksToShow.Add(deleteItLater4);
        artworksToShow.Add(deleteItLater5);
        artworksToShow.Add(deleteItLater6);*/
        foreach (var artwork in artworksToShow)
        {
            if (artwork.pictureBytes != null)
            {
                var ms = new MemoryStream();
                ms.Write(artwork.pictureBytes);
                Image.FromStream(ms).Save("wwwroot/images/artwork"+artwork.id+".jpg",ImageFormat.Jpeg);
            }
            
        }
        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArtworkService ArtworkService { get; set; }
    }
}
#pragma warning restore 1591
