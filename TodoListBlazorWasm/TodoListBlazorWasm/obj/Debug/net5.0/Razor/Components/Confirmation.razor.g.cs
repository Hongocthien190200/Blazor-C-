#pragma checksum "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "befaa55710b83c2dcf1fb2d965e448fc9a2bcea9"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoListBlazorWasm.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using TodoListBlazorWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using TodoListBlazorWasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\_Imports.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    public partial class Confirmation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "modal-title");
            __builder.AddAttribute(14, "id", "exampleModalLabel");
#nullable restore
#line 7 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
__builder.AddContent(15, ConfirmationTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
                                  () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-body");
#nullable restore
#line 14 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
__builder.AddContent(27, ConfirmationMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-footer");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-secondary");
            __builder.AddAttribute(34, "data-dismiss", "modal");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
                                  () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\n                    Cancel\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n                ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
                                  () => OnConfirmationChange(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\n                    Delete\n                ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
      }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Components\Confirmation.razor"
       
    protected bool ShowConfirmation { get; set; }

    [Parameter]
    public string ConfirmationTitle { get; set; } = "Confirm Delete";

    [Parameter]
    public string ConfirmationMessage { get; set; } = "Are you sure you want to delete";

    [Parameter]
    public EventCallback<bool> ConfirmationChanged { get; set; }

    public void Show()
    {
        ShowConfirmation = true;
        StateHasChanged();
    }
    protected async Task OnConfirmationChange(bool value)
    {
        ShowConfirmation = false;
        await ConfirmationChanged.InvokeAsync(value);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
