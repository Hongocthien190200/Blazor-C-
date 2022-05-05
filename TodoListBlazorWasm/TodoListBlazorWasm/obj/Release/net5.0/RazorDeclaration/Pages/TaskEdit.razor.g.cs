// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoListBlazorWasm.Pages
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
#nullable restore
#line 2 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
using TodoList.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
using TodoList.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
using TodoListBlazorWasm.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
using TodoListBlazorWasm.Sevices;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/taskEdit/{TaskId}")]
    public partial class TaskEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
        [Parameter]
            public string TaskId { set; get; }

            private TaskUpdateRequest Task;

            protected async override Task OnInitializedAsync()
            {
                var taskDto = await TaskApiClient.GetTaskDetail(TaskId);
                Task.Name = taskDto.Name;
                taskDto.Priority = taskDto.Priority;
            }

            private async Task SubmitTask(EditContext context)
            {
                var result = await TaskApiClient.UpdateTask(Guid.Parse(TaskId), Task);
                if (result)
                {
                    ToastService.ShowSuccess($"{Task.Name} has been updated successfully.", "Success");
                    NavigationManager.NavigateTo("/taskList");
                }
                else
                {
                    ToastService.ShowError($"An error occurred in progress. Please contact to administrator.", "Error");

                }
            } 
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskApiClient TaskApiClient { get; set; }
    }
}
#pragma warning restore 1591
