#pragma checksum "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\EditArtwork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f5c4e543e43df598375c91d191e2924c2710943"
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
#line 2 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\EditArtwork.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\EditArtwork.razor"
using FirstTier.Authentication;

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
#line 14 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\EditArtwork.razor"
       
    [Parameter]
    public string Id { get; set; }
    private int id;
    private bool isOwner;

    protected override async Task OnInitializedAsync()
    {
        id = Int32.Parse(Id);
        
        User user  = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            isOwner = user.ID == id;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
