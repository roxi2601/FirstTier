#pragma checksum "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "453a30d8d6371527c574ef2d17caf06255d3e613"
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
#nullable restore
#line 8 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using System.Collections.ObjectModel;

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
            __builder.AddMarkupContent(5, "<label style=\"color: white\">min </label>\r\n\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "class", "form-control");
            __builder.AddAttribute(8, "type", "number");
            __builder.AddAttribute(9, "style", "width:150px");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
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
#line 20 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                     maxPrice

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxPrice = __value, maxPrice, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    &nbsp;&nbsp;&nbsp;\r\n\r\n    ");
            __builder.AddMarkupContent(21, "<label style=\"color: white\">Filter by category: </label>\r\n\r\n    ");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
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
            __builder.AddMarkupContent(62, "\r\n\r\n    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\r\n    ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
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
            __builder.AddAttribute(70, "class", "row col-md-3 pull-right");
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "text");
            __builder.AddAttribute(74, "id", "txtSearch");
            __builder.AddAttribute(75, "placeholder", "Search...");
            __builder.AddAttribute(76, "class", "form-control");
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                                                          SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n\r\n");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "id", "artworks");
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 80 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
     if (artworksToShow == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "        ");
            __builder.AddMarkupContent(85, "<p>\r\n            <em> Loading.. </em>\r\n        </p>\r\n");
#nullable restore
#line 85 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
    }
    else if (!artworksToShow.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "        ");
            __builder.AddMarkupContent(87, "<p>\r\n            <em>No offers exist, Please add some.</em>\r\n        </p>\r\n");
#nullable restore
#line 91 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "        ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-12 row");
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 95 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
             foreach (var artwork in artworksToShow)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-4");
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "id", "artworkElement");
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "id", "categoryElement");
            __builder.AddMarkupContent(101, "\r\n                            ");
            __builder.OpenElement(102, "label");
            __builder.AddAttribute(103, "style", "color: white");
            __builder.AddContent(104, 
#nullable restore
#line 100 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                         artwork.category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                        ");
            __builder.OpenElement(107, "img");
            __builder.AddAttribute(108, "src", 
#nullable restore
#line 102 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                   PrepareSRC(artwork)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(109, "alt", "picture");
            __builder.AddAttribute(110, "class", "img-thumbnail");
            __builder.AddAttribute(111, "style", "height: 230px");
            __builder.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 102 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                                                                                            () => ImageClick(artwork.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "<br>\r\n                        ");
            __builder.OpenElement(114, "label");
            __builder.AddAttribute(115, "id", "artworkTitleElement");
            __builder.AddContent(116, 
#nullable restore
#line 103 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                         artwork.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                        ");
            __builder.OpenElement(118, "div");
            __builder.AddAttribute(119, "id", "artworkPriceElement");
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.OpenElement(121, "label");
            __builder.AddContent(122, 
#nullable restore
#line 105 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                    artwork.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(123, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 109 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(128, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n");
#nullable restore
#line 111 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(130, " ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "pagination");
            __builder.AddMarkupContent(133, "\r\n             ");
            __builder.OpenElement(134, "button");
            __builder.AddAttribute(135, "class", "btn btn-custom");
            __builder.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                       async ()=>await NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(137, "Prev");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 114 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
              for (int i = startPage; i <= endPage; i++)
             {
                 var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(139, "                 ");
            __builder.OpenElement(140, "button");
            __builder.AddAttribute(141, "class", "btn" + " btn-custom" + " pagebutton" + " " + (
#nullable restore
#line 117 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                            currentPage==curPage?"btn-danger":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                                                                              async () =>await refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(143, "\r\n                     ");
            __builder.AddContent(144, 
#nullable restore
#line 118 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                      currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(145, "\r\n                 ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 120 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
             }

#line default
#line hidden
#nullable disable
            __builder.AddContent(147, "             ");
            __builder.OpenElement(148, "button");
            __builder.AddAttribute(149, "class", "btn btn-custom");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 121 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
                                                       async ()=>await NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(151, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 127 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
 
    [Parameter]
    public string Id { get; set; }
    
    private int? maxPrice;
    private int? minPrice;
    private string? category;
    private IList<Artwork> artworks;
    int id;
    Artwork artwork = new Artwork();
    private IList<Artwork> artworksToShow;
    private string imagePath = "images/paleta.jpg";

    //for searching
    private string searchTerm;
    private string SearchTerm {
        get { return searchTerm; }
        set { searchTerm = value; FilterRecords(); }
    }
    #region Pagination
    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    string sortColumnName = "ID";
    string sortDir = "DESC";
    #endregion

    private void ImageClick(int id)
    {
        NavigationManager.NavigateTo("/ArtworkPage/" + id);
    }

    private string PrepareSRC(Artwork artwork)
    {
        if (artwork.pictureBytes != null)
        {
            return "images/artwork" + artwork.id + ".jpg";
        }
        return "images/paleta.jpg";
    }

    protected async Task Delete()
    {
        await ArtworkService.DeleteArtworkAsync(id);
        artworks = await ArtworkService.ListAllAsync((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
    }
    private void ExecuteFilter()
    {
        if (maxPrice == null && minPrice == null && (category == null || category.Equals("All")))
        {
            artworksToShow = artworks;
        }
        else if (maxPrice != null && minPrice == null && (category == null || category.Equals("All")))
        {
            artworksToShow = artworks.Where(artwork => artwork.price < maxPrice).ToList();
        }
        else if (maxPrice != null && minPrice != null && (category == null || category.Equals("All")))
        {
            artworksToShow = artworks.Where(artwork => artwork.price < maxPrice && artwork.price > minPrice).ToList();
        }
        else if (maxPrice == null && minPrice != null && (category == null || category.Equals("All")))
        {
            artworksToShow = artworks.Where(artwork => artwork.price > minPrice).ToList();
        }
        else if (maxPrice == null && minPrice == null && category != null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.category.Equals(category)).ToList();
        }
        else if (maxPrice != null && minPrice != null && category != null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.price > minPrice && artwork.price < maxPrice && artwork.category.Equals(category)).ToList();
        }
        else if (maxPrice == null && minPrice != null && category != null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.price > minPrice && artwork.category.Equals(category)).ToList();
        }
        else if (maxPrice != null && minPrice == null && category != null && !category.Equals("All"))
        {
            artworksToShow = artworks.Where(artwork => artwork.price < maxPrice && artwork.category.Equals(category)).ToList();
        }
        Console.WriteLine(category + "     " + minPrice + "     " + maxPrice);
    }

    protected override async Task OnInitializedAsync()
    {
        artworks = await ArtworkService.GetArtworksAsync();
        artworks = artworks.Reverse().ToList();
        artworksToShow = artworks;
        foreach (var artwork in artworksToShow)
        {
            if (artwork.pictureBytes != null)
            {
                var ms = new MemoryStream();
                ms.Write(artwork.pictureBytes);
                Image.FromStream(ms).Save("wwwroot/images/artwork" + artwork.id + ".jpg", ImageFormat.Jpeg);
            }
            if (searchTerm != null)
            {
                //display total page buttons
                pagerSize = 3;
                pageSize = 2;
                curPage = 1;
                artworks = await ArtworkService.ListAllAsync((curPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
                totalRecords = await ArtworkService.CountAsync(searchTerm);
                totalPages = (int) Math.Ceiling(totalRecords / (decimal) pageSize);
                SetPagerSize("forward");
            }
        }
    }
    
     private bool isSortedAscending;
    private string activeSortColumn;
    private async Task<List<Artwork>> SortRecords(string columnName, string dir)
    {
        return await ArtworkService.ListAllAsync((curPage - 1) * pageSize, pageSize, columnName, dir, searchTerm);
    }
    private async Task SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            artworks = await SortRecords(columnName, "ASC");
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                artworks = await SortRecords(columnName, "DESC");
            }
            else
            {
                artworks = await SortRecords(columnName, "ASC");
            }
            isSortedAscending = !isSortedAscending;
        }
        sortColumnName = columnName;
        sortDir = isSortedAscending ? "ASC" : "DESC";
    }
    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }
    
    public async Task refreshRecords(int currentPage)
    {
        artworks = await ArtworkService.ListAllAsync((currentPage - 1) * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        curPage = currentPage;
        this.StateHasChanged();
    }
    
    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
        else
        {
            startPage = 1;
            endPage = totalPages;
        }
    }
    
    public void FilterRecords()
    {
        endPage = 0;
        this.OnInitializedAsync().Wait();
    }
    public async Task NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
            }
        }
        else if (direction == "previous")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
            }
        }
        await refreshRecords(curPage);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArtworkService ArtworkService { get; set; }
    }
}
#pragma warning restore 1591
