#pragma checksum "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193f27f3fcd55fbf4fdf6dd9769235f096a73c6b"
// <auto-generated/>
#pragma warning disable 1591
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
using TodoListBlazorWasm.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
using TodoListBlazorWasm.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/taskEdit/{TaskId}")]
    public partial class TaskEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
 if (Task == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<TodoListBlazorWasm.Components.LoadingIndicator>(0);
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Task Edit: ");
#nullable restore
#line 16 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
__builder.AddContent(3, Task.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                     Task

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                                          SubmitTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"Name\">Name</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                                                         Task.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Task.Name = __value, Task.Name))));
                __builder2.AddAttribute(17, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Task.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\n            ");
                __Blazor.TodoListBlazorWasm.Pages.TaskEdit.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 23 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                                    ()=>Task.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(21, "\n            ");
                __builder2.AddMarkupContent(22, "<small id=\"nameHelp\" class=\"form-text text-muted\">Please enter task title here.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label for=\"Name\">Priority</label>\n            ");
                __Blazor.TodoListBlazorWasm.Pages.TaskEdit.TypeInference.CreateInputSelect_1(__builder2, 27, 28, "form-control", 29, 
#nullable restore
#line 28 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                                                           Task.Priority

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Task.Priority = __value, Task.Priority)), 31, () => Task.Priority, 32, (__builder3) => {
                    __builder3.AddMarkupContent(33, "<option>Select a priority</option>");
#nullable restore
#line 30 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                 foreach (string item in Enum.GetNames(typeof(Priority)))
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(34, "option");
                    __builder3.AddAttribute(35, "value", 
#nullable restore
#line 32 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                                    item

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 32 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
__builder3.AddContent(36, item);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 33 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(37, "\n            ");
                __Blazor.TodoListBlazorWasm.Pages.TaskEdit.TypeInference.CreateValidationMessage_2(__builder2, 38, 39, 
#nullable restore
#line 35 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
                                    ()=>Task.Priority

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\n            ");
                __builder2.AddMarkupContent(41, "<small id=\"nameHelp\" class=\"form-text text-muted\">Choose a priority which you want.</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n        ");
                __builder2.AddMarkupContent(43, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 40 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Asus\source\repos\TodoListBlazorWasm\TodoListBlazorWasm\Pages\TaskEdit.razor"
       
    [Parameter]
    public string TaskId { set; get; }

    private TaskUpdateRequest Task;

    protected async override Task OnInitializedAsync()
    {
        var taskDto = await TaskApiClient.GetTaskDetail(TaskId);
        Task = new TaskUpdateRequest();
        Task.Name = taskDto.Name;
        taskDto.Priority = taskDto.Priority;
    }

    private async Task SubmitTask(EditContext context)
    {
        var result = await TaskApiClient.UpdateTask(Guid.Parse(TaskId), Task);
        if (result)
        {
            ToastService.ShowSuccess($"{Task.Name} has been updated successfully.", "Success");
            NavigationManager.NavigateTo("/TaskList");
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
namespace __Blazor.TodoListBlazorWasm.Pages.TaskEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
