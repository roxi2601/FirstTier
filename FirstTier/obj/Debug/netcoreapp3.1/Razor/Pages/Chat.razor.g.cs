#pragma checksum "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da77a3bbe7aff81120f2afe6ddf0e27375d7a62"
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
#line 5 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
using FirstTier.Chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
using FirstTier.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
using FirstTier.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
using FirstTier.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
using System.Net;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Chat</h3>\r\n<hr>\r\n\r\n\r\n");
#nullable restore
#line 17 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
     if (!_isChatting)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "        ");
            __builder.AddMarkupContent(2, "<label class=\"user\">User:</label><br>\r\n        ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "style", "color: white");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                                        account.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => account.username = __value, account.username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                         ChatRoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "<span class=\"oi oi-chat\" aria-hidden=\"true\"></span>Start Chat");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 23 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"

        // Error messages
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
         if (_message != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "invalid-feedback");
            __builder.AddContent(18, 
#nullable restore
#line 27 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                           _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "small");
            __builder.AddAttribute(21, "id", "emailHelp");
            __builder.AddAttribute(22, "class", "form-text text-muted");
            __builder.AddContent(23, 
#nullable restore
#line 28 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                                                _message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 29 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
         
    }
    else
    {
        // banner to show current user

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(28, "role", "alert");
            __builder.AddAttribute(29, "style", "color: red");
            __builder.AddMarkupContent(30, "\r\n            <span class=\"oi oi-person mr-2\" aria-hidden=\"true\"></span>\r\n            ");
            __builder.OpenElement(31, "span");
            __builder.AddContent(32, "You are connected as ");
            __builder.OpenElement(33, "b");
            __builder.AddContent(34, 
#nullable restore
#line 36 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                           account.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-sm btn-warning ml-md-auto");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                                                         DisconnectAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Disconnect");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 39 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
    
        // display messages

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "id", "scrollbox");
            __builder.AddAttribute(45, "style", "color: white");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 42 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
             foreach (var item in _messages)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                 if (item.IsNotice)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                    ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "alert alert-info");
            __builder.AddContent(50, 
#nullable restore
#line 46 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                                   item.messageBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 47 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", 
#nullable restore
#line 50 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                 item.CSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "user");
            __builder.AddContent(58, 
#nullable restore
#line 51 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                           item.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "msg");
            __builder.AddContent(62, 
#nullable restore
#line 52 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                          item.messageBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 54 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, "            <hr>\r\n            ");
            __builder.OpenElement(66, "textarea");
            __builder.AddAttribute(67, "style", "color: white");
            __builder.AddAttribute(68, "class", "input-lg");
            __builder.AddAttribute(69, "placeholder", "Enter your comment");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                                                                                     _newMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _newMessage = __value, _newMessage));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "style", "color: white");
            __builder.AddAttribute(75, "class", "btn btn-default");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
                                                                             () => SendAsync(_newMessage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "Send");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n");
#nullable restore
#line 60 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\dnp1\FirstTier\FirstTier\Pages\Chat.razor"
       
    [Parameter]
    // user data
    public string Id { get; set; }
    private Account account = new Account();
    private bool isUser;
    
    /*message data
    private Message message = new Message();*/
    
    // flag to indicate chat status
    private bool _isChatting = false;

    // on-screen message
    private string _message;

    // new message input
    private string _newMessage;

    // list of messages in chat
    private List<Message> _messages = new List<Message>();

    private string _hubUrl;
    private HubConnection _hubConnection;

    string errorMessage = "";
    
    public async Task ChatRoom()
    {
        HttpClientHandler clientHandler = new HttpClientHandler();
        clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

        // Pass the handler to httpclient(from you are calling api)
        HttpClient client = new HttpClient(clientHandler);
        
        // check if user is valid
        User user  = ((UserCustomAuthenticationStateProvider) AuthenticationStateProvider).GetCurrentUser();
        if (user != null)
        {
            isUser = user.ID == account.ID;
        }

        try
        {
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, errors) => { return true; };

    // Start chatting and force refresh UI.
            _isChatting = true;
            await Task.Delay(1);

            // Create the chat client
            string baseUrl = NavigationManager.BaseUri;

            _hubUrl = baseUrl.TrimEnd('/') + ChatHub.HubUrl;

            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_hubUrl)
                .Build();

            _hubConnection.On<string, string>("Broadcast", BroadcastMessage);

            await _hubConnection.StartAsync();

            await SendAsync($"[Notice] {account.username} joined chat room.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            _message = $"ERROR: Failed to start chat client: {e.Message}";
            _isChatting = false;
        }
    }

    private void BroadcastMessage(string name, string message)
    {
        bool isMine = name.Equals(account.username, StringComparison.OrdinalIgnoreCase);

        _messages.Add(new Message(name, message, isMine));

        // Inform blazor the UI needs updating
        StateHasChanged();
    }

    private async Task DisconnectAsync()
    {
        if (_isChatting)
        {
            await SendAsync($"[Notice] {account.username} left chat room.");

            await _hubConnection.StopAsync();
            await _hubConnection.DisposeAsync();

            _hubConnection = null;
            _isChatting = false;
        }
    }

    private async Task SendAsync(string message)
    {
        if (_isChatting && !string.IsNullOrWhiteSpace(message))
        {
            await _hubConnection.SendAsync("Broadcast", account.username, message);

            _newMessage = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChatService ChatService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
