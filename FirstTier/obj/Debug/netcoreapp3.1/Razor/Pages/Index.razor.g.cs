#pragma checksum "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f1207fd5c6e82dea2f69823320575112971a8c6"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12 row");
            __builder.AddAttribute(2, "id", "filters");
            __builder.AddMarkupContent(3, "\r\n    &nbsp;&nbsp;&nbsp;\r\n    ");
            __builder.AddMarkupContent(4, "<label style=\"color: white\">Filter by price:&nbsp;</label>\r\n    ");
            __builder.AddMarkupContent(5, "<label style=\"color: white\">min </label>\r\n  \r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "style", "width:150px");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                     minPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minPrice = __value, minPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    &nbsp;\r\n    ");
            __builder.AddMarkupContent(13, "<label style=\"color: white\">max </label>\r\n    ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "type", "number");
            __builder.AddAttribute(17, "style", "width:150px");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                     maxPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxPrice = __value, maxPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    &nbsp;&nbsp;&nbsp;\r\n    \r\n    ");
            __builder.AddMarkupContent(21, "<label style=\"color: white\">Filter by category: </label>\r\n   \r\n    ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                   category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category = __value, category));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "Paintings");
            __builder.AddContent(28, "Paintings");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "value", "Sculptures");
            __builder.AddContent(32, "Sculptures");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "option");
            __builder.AddAttribute(35, "value", "Prints");
            __builder.AddContent(36, "Prints");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "Photography");
            __builder.AddContent(40, "Photography");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "Drawings");
            __builder.AddContent(44, "Drawings");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "Graphics");
            __builder.AddContent(48, "Graphics");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "Media");
            __builder.AddContent(52, "Media");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "option");
            __builder.AddAttribute(55, "value", "Other");
            __builder.AddContent(56, "Other");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.OpenElement(58, "option");
            __builder.AddAttribute(59, "value", "All");
            __builder.AddContent(60, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n   \r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n    ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                      ExecuteFilter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.AddMarkupContent(66, "<span>Filter</span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "id", "artworks");
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 42 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
 if (artworksToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "    ");
            __builder.AddMarkupContent(73, "<p>\r\n    <em> Loading.. </em>\r\n    </p>\r\n");
#nullable restore
#line 47 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
}
else if (!artworksToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "    ");
            __builder.AddMarkupContent(75, "<p>\r\n        <em>No offers exist, Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 53 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col-12 row");
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 57 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
         foreach (var artwork in artworksToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "            ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "col-4");
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "id", "artworkElement");
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "id", "categoryElement");
            __builder.OpenElement(89, "label");
            __builder.AddAttribute(90, "style", "color: white");
            __builder.AddContent(91, 
#nullable restore
#line 61 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                                           artwork.category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "img");
            __builder.AddAttribute(94, "src", 
#nullable restore
#line 62 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                               PrepareSRC(@artwork)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(95, "alt", "picture");
            __builder.AddAttribute(96, "class", "img-thumbnail");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                                                                   ()=>ImageClick(artwork.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "<br>\r\n                    ");
            __builder.OpenElement(99, "label");
            __builder.AddAttribute(100, "id", "artworkTitleElement");
            __builder.AddContent(101, 
#nullable restore
#line 63 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                     artwork.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                    ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "id", "artworkPriceElement");
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "label");
            __builder.AddContent(107, 
#nullable restore
#line 65 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                            artwork.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(108, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n");
#nullable restore
#line 69 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(113, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 71 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
 
    private int? maxPrice;
    private int? minPrice;
    private string? category;
    private IList<Artwork> artworks;
    private IList<Artwork> artworksToShow;
    private string imagePath = "images/paleta.jpg";

    private void ImageClick(int id)
    {
        NavigationManager.NavigateTo("/ArtworkPage/"+id);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArtworkService ArtworkService { get; set; }
    }
}
#pragma warning restore 1591
