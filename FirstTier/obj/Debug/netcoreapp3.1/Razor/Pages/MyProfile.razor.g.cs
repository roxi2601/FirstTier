#pragma checksum "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "988f6e72ca8dfb3c74b4e417d59f036be3fc3e9d"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container col-md-8 main-secction");
            __builder.AddAttribute(2, "style", "margin-top: 40px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\r\n            \r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row user-left-part");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-3 col-sm-3 col-xs-3 user-profil-part pull-left");
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
#line 21 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
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
            __builder.AddAttribute(32, "class", "col-md-12 col-sm-3 user-detail-section2 pull-left");
            __builder.AddMarkupContent(33, "\r\n                            <div class=\"border\"></div>\r\n                            ");
            __builder.AddMarkupContent(34, "<p>About me</p>\r\n                            ");
            __builder.OpenElement(35, "span");
            __builder.AddContent(36, 
#nullable restore
#line 30 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
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
#line 42 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                     account.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 42 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
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
#line 43 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
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
            __builder.AddAttribute(67, "class", "col-md-12 col-sm-6 col-xs-6 profile-header-section1 text-right pull-rigth");
            __builder.AddMarkupContent(68, "\r\n                             \r\n                                ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-info req-btn");
            __builder.AddAttribute(71, "type", "submit");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                                              Chat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, " Chat with me!");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "                          \r\n                                ");
            __builder.AddMarkupContent(75, "<button class=\"btn btn-info req-btn\" type=\"submit\"> Report me!</button> \r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                            \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                           \r\n                    ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "col-md-12");
            __builder.AddMarkupContent(81, "\r\n                                \r\n                             \r\n                            ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "row");
            __builder.AddMarkupContent(84, "\r\n                                ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "col-md-12  profile-tag-section text-center");
            __builder.AddMarkupContent(87, "\r\n                                    ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "row");
            __builder.AddMarkupContent(90, "\r\n                                        ");
            __builder.AddMarkupContent(91, @"<div class=""col-md-3 col-sm-3 profile-tag"">
                                            <a href=""\EditProfile""><i class=""fa fa-calendar-check-o"" aria-hidden=""true""></i>
                                                <p>edit profile</p></a>
                                        </div>
                                                 
                                        ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "col-md-3 col-sm-3 profile-tag");
            __builder.AddMarkupContent(94, "\r\n\r\n                                            ");
            __builder.OpenElement(95, "p");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                         DeleteProfile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "<i class=\"fa fa-address-book\" aria-hidden=\"true\"></i>\r\n                                                ");
            __builder.AddMarkupContent(98, "<p>delete profile</p>\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, " \r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                                ");
            __builder.AddMarkupContent(103, @"<div class=""col-md-4 img-main-rightPart"">
                                    <div class=""row"">

                                        <div class=""col-md-12 image-right"">

                                        </div>

                                    </div>
                                </div>

                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                           \r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                    ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "row");
            __builder.AddMarkupContent(108, "\r\n                        ");
            __builder.OpenElement(109, "table");
            __builder.AddAttribute(110, "class", "table");
            __builder.AddMarkupContent(111, "\r\n                            ");
            __builder.OpenElement(112, "thread");
            __builder.AddMarkupContent(113, "\r\n                                ");
            __builder.AddMarkupContent(114, "<tr>\r\n                                    <th>My artworks</th>\r\n                                </tr>\r\n");
#nullable restore
#line 95 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                 if (artworksToShow == null)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(115, "                                    ");
            __builder.AddMarkupContent(116, "<p>\r\n                                        <em> Loading.. </em>\r\n                                    </p>\r\n");
#nullable restore
#line 100 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                }
                                else if (!artworksToShow.Any())
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(117, "                                    ");
            __builder.AddMarkupContent(118, "<p>\r\n                                        <em>No offers exist, Please add some.</em>\r\n                                    </p>\r\n");
#nullable restore
#line 106 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "                                    ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "col-12 row");
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 110 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                         foreach (var artwork in artworksToShow)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "                                            ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "col-12");
            __builder.AddMarkupContent(126, "\r\n                                                ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "id", "artworkElement");
            __builder.AddMarkupContent(129, "\r\n                                                    ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "id", "categoryElement");
            __builder.OpenElement(132, "label");
            __builder.AddAttribute(133, "style", "color: white");
            __builder.AddContent(134, 
#nullable restore
#line 114 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                                                           artwork.category

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                                    ");
            __builder.OpenElement(136, "img");
            __builder.AddAttribute(137, "src", 
#nullable restore
#line 115 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                               PrepareSRC(@artwork)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(138, "alt", "picture");
            __builder.AddAttribute(139, "class", "img-thumbnail");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                                                    ");
            __builder.OpenElement(141, "label");
            __builder.AddAttribute(142, "id", "artworkTitleElement");
            __builder.AddContent(143, 
#nullable restore
#line 116 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                                     artwork.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                                                    ");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "id", "artworkPriceElement");
            __builder.AddMarkupContent(147, "\r\n                                                        ");
            __builder.OpenElement(148, "label");
            __builder.AddContent(149, 
#nullable restore
#line 118 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                                                artwork.price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(150, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#nullable restore
#line 122 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(155, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
#nullable restore
#line 124 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(157, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                            ");
            __builder.AddMarkupContent(159, "<tbody>\r\n                                   \r\n                            </tbody>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                           \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\HUAWEI\DNPexercises\FirstTier\FirstTier\Pages\MyProfile.razor"
       

    [Parameter]
    public string Id { get; set; }
    private Account account = new Account();
    string errorMessage = "";
    private IList<Account> allAccounts;
    private IList<Artwork> artworks;
    private IList<Artwork> artworksToShow;
    int userId;
    
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

    /*
    protected void DeleteProfile()
    {
        DeleteConfirmation.Show();
    }
    protected void ConfirmDelete(bool confirmed)
    {
        if (confirmed)
        {
            Account accountToRemove = allAccounts.First(a => a.ID == account.ID);
            AccountService.RemoveAccountAsync(account.ID);
            allAccounts.Remove(accountToRemove);
        }
    }
    */

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
