#pragma checksum "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fdc4d6a1eb8bb69edccdcebf1694427216e1c47"
// <auto-generated/>
#pragma warning disable 1591
namespace lms.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 2 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\smj\source\repos\lms\_Imports.razor"
using lms;

#line default
#line hidden
#line 7 "C:\Users\smj\source\repos\lms\_Imports.razor"
using lms.Shared;

#line default
#line hidden
#line 8 "C:\Users\smj\source\repos\lms\_Imports.razor"
using lms.Constants;

#line default
#line hidden
#line 1 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 2 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
using System.Net.Http;

#line default
#line hidden
#line 4 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
using Models;

#line default
#line hidden
    public class MyTasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "id", "MyTasksTable");
            __builder.AddAttribute(5, "class", "table dataTable table-striped table-bordered");
            __builder.AddAttribute(6, "cellspacing", "0");
            __builder.AddAttribute(7, "width", "100%");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, @"<thead>
            <tr>
                <th>#</th>
                <th>Task</th>
                <th>Description</th>
                <th>Assigned Date</th>
                <th>Priority</th>
                <th>Status</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#line 20 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
             if (values != null)
            {
                foreach (var task in values)
                {

#line default
#line hidden
            __builder.AddContent(12, "                    ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#line 25 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                             task.Id

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#line 26 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                             task.Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", (
#line 28 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                                      Navigator.BaseUri

#line default
#line hidden
            ) + "/" + (
#line 28 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                                                         task.Body

#line default
#line hidden
            ));
            __builder.AddContent(25, "Task Link");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#line 30 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                             task.Created

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#line 31 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                             task.Priority

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#line 32 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                             task.Status

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#line 34 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
                }
            }

#line default
#line hidden
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    <br>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 40 "C:\Users\smj\source\repos\lms\Shared\MyTasks.razor"
       
    [Parameter]
    public string filter { get; set; } = "Not Started";
    private Root root = new Root();
    private List<Value> values = new List<Value>();

    protected override async Task OnInitializedAsync()
    {
        bool x = await jsRun.InvokeAsync<bool>("dataTableDestroy");
        root = null;
        await GetMyTasksAsync(filter);
        bool y = await jsRun.InvokeAsync<bool>("dataTableCreate");
    }

     protected override async Task OnParametersSetAsync()
    {
        bool x = await jsRun.InvokeAsync<bool>("dataTableDestroy");
        root = null;
        await GetMyTasksAsync(filter);
        bool y = await jsRun.InvokeAsync<bool>("dataTableCreate");
    }

    private async Task GetMyTasksAsync(string status)
    {
        string response = string.Empty;
        HttpClient Http = new HttpClient();
        string uid = Settings.Id.ToString();
        Http.DefaultRequestHeaders.Add("Accept", "application/json");
        response = await Http.GetStringAsync(Navigator.BaseUri+Settings.BaseURL + "_api/web/lists(guid'" + Settings.TasksListGuid + "')/items?$select=*,AssignedTo/Title&$expand=AssignedTo&$filter=AssignedToId eq '" + uid + "' and Status eq '" + status + "'&$orderby=ID desc");
        root = JsonConvert.DeserializeObject<Root>(response);
        values = root.value;
        StateHasChanged();
    }

    public async Task OnReload()
    {
        bool x = await jsRun.InvokeAsync<bool>("dataTableDestroy");
        root = null;
        await GetMyTasksAsync(filter);
        bool y = await jsRun.InvokeAsync<bool>("dataTableCreate");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRun { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigator { get; set; }
    }
}
#pragma warning restore 1591
