#pragma checksum "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e82c1c9d5f53a4560ad1b5da887a3a9fd0af55d1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddArtwork")]
    public partial class AddArtwork : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "addArtworkForm");
            __builder.AddMarkupContent(2, "\r\n              \r\n    ");
            __builder.AddMarkupContent(3, "<p style=\"font-family: \'Montserrat\', sans-serif; font-size: 25px; text-align: center; color: white\">Add the artwork</p>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                    newArtwork

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                                PerformSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "xmlns", "http://www.w3.org/1999/html");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    \r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-12 row");
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "col-6");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "img");
                __builder2.AddAttribute(21, "src", 
#nullable restore
#line 22 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                        imagePath

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(22, "class", "img-thumbnail");
                __builder2.AddAttribute(23, "alt", "picture");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-6");
                __builder2.AddMarkupContent(28, "\r\n            \r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "style", "color:red");
                __builder2.AddContent(31, 
#nullable restore
#line 26 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                    errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.AddMarkupContent(36, "<label style=\"color: white\">Title:</label><br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(37);
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                        newArtwork.title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newArtwork.title = __value, newArtwork.title))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newArtwork.title));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-group");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.AddMarkupContent(46, "<label style=\"color: white\">Author:</label><br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                        newArtwork.author

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newArtwork.author = __value, newArtwork.author))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newArtwork.author));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, " \r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.AddMarkupContent(56, "<label style=\"color: white\">Price:</label><br>\r\n                ");
                __Blazor.FirstTier.Pages.AddArtwork.TypeInference.CreateInputNumber_0(__builder2, 57, 58, 
#nullable restore
#line 37 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                          newArtwork.price

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newArtwork.price = __value, newArtwork.price)), 60, () => newArtwork.price);
                __builder2.AddMarkupContent(61, "<label style=\"color: white\"> €</label>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddMarkupContent(65, "\r\n                ");
                __builder2.AddMarkupContent(66, "<label style=\"color: white\">Category:</label><br>\r\n                ");
                __Blazor.FirstTier.Pages.AddArtwork.TypeInference.CreateInputSelect_1(__builder2, 67, 68, 
#nullable restore
#line 41 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                                ()=>newArtwork.category

#line default
#line hidden
#nullable disable
                , 69, 
#nullable restore
#line 42 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                     newArtwork.category

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 43 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                             (string value) => OnValueChanged(value )

#line default
#line hidden
#nullable disable
                ), 71, (__builder3) => {
                    __builder3.AddMarkupContent(72, "\r\n                    ");
                    __builder3.AddMarkupContent(73, "<option value=\"Paintings\">Paintings</option>\r\n                    ");
                    __builder3.AddMarkupContent(74, "<option value=\"Sculptures\">Sculptures</option>\r\n                    ");
                    __builder3.AddMarkupContent(75, "<option value=\"Prints\">Prints</option>\r\n                    ");
                    __builder3.AddMarkupContent(76, "<option value=\"Photography\">Photography</option>\r\n                    ");
                    __builder3.AddMarkupContent(77, "<option value=\"Drawings\">Drawings</option>\r\n                    ");
                    __builder3.AddMarkupContent(78, "<option value=\"Graphics\">Graphics</option>\r\n                    ");
                    __builder3.AddMarkupContent(79, "<option value=\"Media\">Media</option>\r\n                    ");
                    __builder3.AddMarkupContent(80, "<option value=\"Other\">Other</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(81, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n            ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.AddMarkupContent(86, "<label style=\"color: white\">Description:</label><br>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(87);
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                            newArtwork.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newArtwork.description = __value, newArtwork.description))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newArtwork.description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "form-group");
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.AddMarkupContent(96, "<label style=\"color: white\">Choose picture:</label>\r\n                ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(97);
                __builder2.AddAttribute(98, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 60 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                     HandleFileSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n            \r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n         \r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n     \r\n");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "col-12 row");
                __builder2.AddMarkupContent(105, "\r\n    ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col-6");
                __builder2.AddMarkupContent(108, "\r\n        ");
                __builder2.OpenElement(109, "button");
                __builder2.AddAttribute(110, "class", "btn button");
                __builder2.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
                                             Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(112, "\r\n            ");
                __builder2.AddMarkupContent(113, "<span>Cancel</span>\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.AddMarkupContent(116, "<div class=\"col-6\">\r\n        <button class=\"btn button\" type=\"submit\">\r\n            <span>Create</span>\r\n        </button>\r\n    </div>\r\n");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(118, " \r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\tanki\DNPexercises\FirstTier\FirstTier\Pages\AddArtwork.razor"
       

    Artwork newArtwork = new Artwork();
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
        //later change to /Artwork!!!!!!!!!
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
namespace __Blazor.FirstTier.Pages.AddArtwork
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ValueExpression", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
