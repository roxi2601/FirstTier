#pragma checksum "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c194166c7e0e987da73620652bc3b35f1afb0e46"
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
#line 2 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using System.Drawing.Imaging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container col-md-8 main-section");
            __builder.AddAttribute(2, "style", "margin-top: 40px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n            \r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row user-left-part");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-3 col-sm-3 col-xs-3 user-profile-part pull-left");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row ");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-12 col-md-12-sm-12 col-xs-12 user-image text-center");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", 
#nullable restore
#line 21 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                   PrepareSRCProfile(account)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(21, "style", "border-radius: 50%; width: 150px; height: 150px; margin-top: 20px");
            __builder.AddAttribute(22, "alt", "picture");
            __builder.AddAttribute(23, "class", "img-thumbnail");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddMarkupContent(26, "<div class=\"col-md-12 col-sm-12 col-xs-12 user-detail-section1 text-center\">\r\n                        <div class=\"aboutme \"><i class=\"fa fa-user-o\" aria-hidden=\"true\"></i> </div>\r\n                    </div>\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row user-detail-row");
            __builder.AddAttribute(29, "style", "margin-top: 80px");
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-12 col-sm-12 user-detail-section2 pull-left");
            __builder.AddMarkupContent(33, "\r\n                            <div class=\"border\"></div>\r\n                            ");
            __builder.AddMarkupContent(34, "<p>About me</p>\r\n                            ");
            __builder.OpenElement(35, "span");
            __builder.AddContent(36, 
#nullable restore
#line 30 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                   account.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                            \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "col-md-9 profile-right-section");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row profile-right-section-row");
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-12 profile-header");
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row");
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "col-md-8 col-sm-6 col-xs-6 profile-header-section1 pull-left");
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.OpenElement(57, "h1");
            __builder.AddContent(58, 
#nullable restore
#line 42 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                     account.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 42 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                        account.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                ");
            __builder.OpenElement(62, "p");
            __builder.AddContent(63, 
#nullable restore
#line 43 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                    account.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-md-12 col-sm-6 col-xs-6 profile-header-section1 text-right pull-right");
            __builder.AddMarkupContent(68, "\r\n                             \r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(69);
            __builder.AddAttribute(70, "Policy", "LoggedUser");
            __builder.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(72, "\r\n");
#nullable restore
#line 48 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                             if (!isOwner)
                                                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(73, "                                ");
                __builder2.OpenElement(74, "button");
                __builder2.AddAttribute(75, "class", "btn btn-info req-btn");
                __builder2.AddAttribute(76, "type", "submit");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                                              Chat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(78, " Chat with me!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, " \r\n");
#nullable restore
#line 51 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(80, "                                                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\r\n                                                         \r\n");
#nullable restore
#line 54 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                  if (!isOwner)
                                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(82, "                                                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(83);
            __builder.AddAttribute(84, "Policy", "LoggedButNotAdmin");
            __builder.AddAttribute(85, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(86, "\r\n                                                                ");
                __builder2.AddMarkupContent(87, "<button class=\"btn btn-info req-btn\" type=\"submit\"> Report me!</button> \r\n                                                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 59 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "                                \r\n                                \r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                            \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                           \r\n                    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "col-md-12");
            __builder.AddMarkupContent(95, "\r\n                                \r\n                             \r\n                            ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "row");
            __builder.AddMarkupContent(98, "\r\n                                ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "col-md-12  profile-tag-section text-center");
            __builder.AddMarkupContent(101, "\r\n                                    ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "row");
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 74 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                         if (isOwner) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                                        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "col-md-3 col-sm-3 profile-tag");
            __builder.AddMarkupContent(108, "\r\n\r\n\r\n                                            ");
            __builder.OpenElement(109, "a");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                         profileClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(111, "<i class=\"fa fa-calendar-check-o\" aria-hidden=\"true\"></i>\r\n                                                ");
            __builder.AddMarkupContent(112, "<p>edit profile</p>");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 82 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                                        ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "col-md-3 col-sm-3 profile-tag");
            __builder.AddMarkupContent(118, "\r\n                                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(119);
            __builder.AddAttribute(120, "Policy", "admin");
            __builder.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(122, "\r\n                                                ");
                __builder2.OpenElement(123, "p");
                __builder2.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                             DeleteProfile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(125, "<i class=\"fa fa-address-book\" aria-hidden=\"true\"></i>\r\n                                                    ");
                __builder2.AddMarkupContent(126, "<p>delete profile</p>\r\n                                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(128, "\r\n");
#nullable restore
#line 89 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                             if (isOwner)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(129, "                                                ");
            __builder.OpenElement(130, "p");
            __builder.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                             DeleteProfile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(132, "<i class=\"fa fa-address-book\" aria-hidden=\"true\"></i>\r\n                                                    ");
            __builder.AddMarkupContent(133, "<p>delete profile</p>\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
#nullable restore
#line 94 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(135, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                                ");
            __builder.AddMarkupContent(139, @"<div class=""col-md-4 img-main-rightPart"">
                                    <div class=""row"">

                                        <div class=""col-md-12 image-right"">

                                        </div>

                                    </div>
                                </div>

                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                       \r\n                           \r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                    ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "row");
            __builder.AddMarkupContent(144, "\r\n                        ");
            __builder.OpenElement(145, "table");
            __builder.AddAttribute(146, "class", "table");
            __builder.AddMarkupContent(147, "\r\n                            ");
            __builder.OpenElement(148, "thread");
            __builder.AddMarkupContent(149, "\r\n                                ");
            __builder.AddMarkupContent(150, "<tr>\r\n                                    <th>My artworks</th>\r\n                                </tr>\r\n");
#nullable restore
#line 119 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                 if (artworksToShow == null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(151, "                                    ");
            __builder.AddMarkupContent(152, "<p>\r\n                                        <em> Loading.. </em>\r\n                                    </p>\r\n");
#nullable restore
#line 124 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                }
                                else if (!artworksToShow.Any())
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(153, "                                    ");
            __builder.AddMarkupContent(154, "<p>\r\n                                        <em>No offers exist, Please add some.</em>\r\n                                    </p>\r\n");
#nullable restore
#line 130 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "                                    ");
            __builder.OpenElement(156, "div");
            __builder.AddAttribute(157, "class", "col-12 row");
            __builder.AddMarkupContent(158, "\r\n");
#nullable restore
#line 134 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                         foreach (var artwork in artworksToShow)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(159, "                                            ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "col-12");
            __builder.AddMarkupContent(162, "\r\n                                                ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "id", "artworkElement");
            __builder.AddMarkupContent(165, "\r\n                                                    ");
            __builder.OpenElement(166, "div");
            __builder.AddAttribute(167, "id", "categoryElement");
            __builder.OpenElement(168, "label");
            __builder.AddAttribute(169, "style", "color: white");
            __builder.AddContent(170, 
#nullable restore
#line 138 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                                                           artwork.category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                                                    ");
            __builder.OpenElement(172, "img");
            __builder.AddAttribute(173, "src", 
#nullable restore
#line 139 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                               PrepareSRC(artwork)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(174, "alt", "picture");
            __builder.AddAttribute(175, "class", "img-thumbnail");
            __builder.AddAttribute(176, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 139 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                                                                                  () => ImageClick(artwork.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n                                                    ");
            __builder.OpenElement(178, "label");
            __builder.AddAttribute(179, "id", "artworkTitleElement");
            __builder.AddContent(180, 
#nullable restore
#line 140 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                                     artwork.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n                                                    ");
            __builder.OpenElement(182, "div");
            __builder.AddAttribute(183, "id", "artworkPriceElement");
            __builder.AddMarkupContent(184, "\r\n                                                        ");
            __builder.OpenElement(185, "label");
            __builder.AddContent(186, 
#nullable restore
#line 142 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                artwork.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(187, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n");
#nullable restore
#line 146 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(192, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(193, "\r\n");
#nullable restore
#line 148 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(194, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(195, "\r\n                            ");
            __builder.AddMarkupContent(196, "<tbody>\r\n                                   \r\n                            </tbody>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n                           \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 162 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
       

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
    
    private void ImageClick(int id)
    {
        NavigationManager.NavigateTo("/ArtworkPage/"+id);
    }

    private async Task profileClick()
    {
        User user = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            NavigationManager.NavigateTo("/EditProfile/"+user.ID);
        }
        
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
        
        artworksToShow = artworks.Where(artwork => artwork.userId==id).ToList();
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
