#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b68323294b25df0ce964060b3a43b307472b834d"
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
#line 2 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
using Microsoft.VisualBasic.CompilerServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ArtworkPage/{id}")]
    public partial class ArtworkPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "artwork");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-12 row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-6");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "id", "artworkTitleElement");
            __builder.OpenElement(11, "h1");
            __builder.AddContent(12, 
#nullable restore
#line 14 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                               artwork.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-6");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "id", "artworkAuthorElement");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "h1");
            __builder.AddAttribute(22, "style", "text-align: right");
            __builder.AddContent(23, 
#nullable restore
#line 18 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                               artwork.author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-6");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "src", 
#nullable restore
#line 22 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                        imagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "img-thumbnail");
            __builder.AddAttribute(33, "alt", "picture");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "id", "categoryElement");
            __builder.OpenElement(37, "label");
            __builder.AddAttribute(38, "style", "color: white");
            __builder.AddContent(39, 
#nullable restore
#line 23 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                                                   artwork.category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-6");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "container");
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-12 row");
            __builder.AddMarkupContent(50, "\r\n                    \r\n                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "col-3");
            __builder.AddMarkupContent(53, "\r\n                         ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                           () => ProfileClick(artwork.userId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "\r\n                             ");
            __builder.AddMarkupContent(57, "<span>See owner</span>\r\n                             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-3");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 35 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                         if (isOwner)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                            ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                              Edit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.AddMarkupContent(67, "<span>Edit</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 40 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "col-3");
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(74);
            __builder.AddAttribute(75, "Policy", "admin");
            __builder.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(77, "\r\n                            ");
                __builder2.OpenElement(78, "button");
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                              Delete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(80, "\r\n                                ");
                __builder2.AddMarkupContent(81, "<span>Delete</span>\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 48 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                         if (isOwner)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                            ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                              Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(87, "\r\n                                ");
            __builder.AddMarkupContent(88, "<span>Delete</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 53 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                    ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-3");
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 56 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                         if (!isOwner)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(96);
            __builder.AddAttribute(97, "Policy", "LoggedButNotAdmin");
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(99, "\r\n                                ");
                __builder2.OpenElement(100, "button");
                __builder2.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                                  Report

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(102, "\r\n                                    ");
                __builder2.AddMarkupContent(103, "<span>Report</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 63 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(106, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                    ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "col-3");
            __builder.AddMarkupContent(110, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(111);
            __builder.AddAttribute(112, "Policy", "LoggedUser");
            __builder.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(114, "\r\n");
#nullable restore
#line 67 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                             if (!isOwner)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(115, "                                ");
                __builder2.OpenElement(116, "button");
                __builder2.AddAttribute(117, "style", "background-color: black");
                __builder2.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                                                                  Chat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(119, "\r\n\r\n                                    ");
                __builder2.AddMarkupContent(120, "<span style=\"color: white\">Contact</span>\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\r\n");
#nullable restore
#line 73 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"

                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(122, "                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n                    ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "col-12");
            __builder.AddMarkupContent(127, "\r\n                        ");
            __builder.OpenElement(128, "h3");
            __builder.AddAttribute(129, "style", "text-align: right");
            __builder.AddContent(130, 
#nullable restore
#line 78 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                                       artwork.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(131, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                    ");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "id", "descriptionElement");
            __builder.AddMarkupContent(136, "\r\n                        ");
            __builder.AddMarkupContent(137, "<h5 style=\"color: white\">Description</h5>\r\n                        ");
            __builder.OpenElement(138, "p");
            __builder.AddAttribute(139, "style", "color: white");
            __builder.AddContent(140, 
#nullable restore
#line 83 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                                 artwork.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n       ");
            __builder.OpenElement(146, "label");
            __builder.AddAttribute(147, "style", "color: red");
            __builder.AddContent(148, 
#nullable restore
#line 89 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
                                  errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\ArtworkPage.razor"
       
    [Parameter]
    public string Id { get; set; }

    bool isOwner;
    string errorMessage = "";

    int id;

    Artwork artwork = new Artwork();
    string imagePath = "images/temporary.jpg";


    private void ProfileClick(int id)
    {
        NavigationManager.NavigateTo("/Profile/"+id);
    }

    public void Chat()
    {
        NavigationManager.NavigateTo("/Chat");
    }

    public void Delete()
    {
        try
        {
            ArtworkService.DeleteArtworkAsync(id);
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }
    public void Edit()
    {
        NavigationManager.NavigateTo("/EditArtwork/"+id);
    }
    public void Report()
    {
        //HERE IS PLACE FOR MELANIA'S IMPLEMENTATION OF REPORTING/NOTIFICATIONS FUNCTIONALITY
    }

    protected override async Task OnInitializedAsync()
    {
        
        id = Int32.Parse(Id);
        artwork = await ArtworkService.GetArtworkAsync(id);
        imagePath = "images/artwork" + artwork.id+".jpg";
         User user  = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            isOwner = user.ID == artwork.userId;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ArtworkService ArtworkService { get; set; }
    }
}
#pragma warning restore 1591
