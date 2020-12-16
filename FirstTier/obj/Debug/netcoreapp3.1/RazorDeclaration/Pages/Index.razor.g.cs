#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "579b7c9d86dbe8a44d2539f9c449434813b1da0d"
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
#line 3 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\Index.razor"
 
    [Parameter]
    public string Id { get; set; }

    private int? maxPrice;
    private int? minPrice;
    private string? category;
    private string? title;
    private string? description;
    private string? author;
    private IList<Artwork> artworks;
    int id;
    Artwork artwork = new Artwork();
    private IList<Artwork> artworksToShow;
    //private IList<Artwork> searchedArtworksToShow;
    private string imagePath = "images/paleta.jpg";

    //for searching
    private string searchTerm;

    private string SearchTerm
    {
        get { return searchTerm; }
        set
        {
            searchTerm = value;
            FilterRecords();
        }
    }

    #region Pagination

    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    string data;
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

    private void SearchField()
    {
        if (searchTerm != null && searchTerm.Contains(artwork.title))
        {
           artworksToShow = artworks.Where(i => i.title.ToLower().Contains(SearchTerm.ToLower())).ToList();
        }
        else if (searchTerm != null && searchTerm.Contains(artwork.description))
        {
            artworksToShow= artworks.Where(i => i.description.ToLower().Contains(SearchTerm.ToLower())).ToList();
        }
        else if (searchTerm != null && searchTerm.Contains(artwork.author))
        {
            artworksToShow = artworks.Where(i => i.author.ToLower().Contains(SearchTerm.ToLower())).ToList();
        }
        else if (searchTerm != null && searchTerm.Contains(artwork.category))
        {
            artworksToShow = artworks.Where(i => i.category.ToLower().Contains(SearchTerm.ToLower())).ToList();
        }
        
        Console.WriteLine(title + "     " + description + "     " + author + "     " + category);

        refreshRecords(curPage);
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
