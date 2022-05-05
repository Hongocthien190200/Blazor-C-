// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
