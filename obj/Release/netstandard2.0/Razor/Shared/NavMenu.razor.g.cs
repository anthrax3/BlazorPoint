#pragma checksum "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac9e7d49ac4f8ed4ada76cb3c7d2d94df9e9d56a"
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
#line 5 "C:\Users\smj\source\repos\lms\_Imports.razor"
using Microsoft.JSInterop;

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
#line 1 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
using lms.Models;

#line default
#line hidden
#line 2 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
using Newtonsoft.Json;

#line default
#line hidden
#line 3 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
using System.Net.Http;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 6 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(6, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.AddMarkupContent(9, "<div class=\"col text-center\">\r\n    <img src=\"img/logo.png\" alt=\"logo\">\r\n</div>\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(10, "<div class=\"col text-center\">\r\n    <p class=\"h5\" style=\"color:white\">License Management System</p>\r\n</div>\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "userInfo");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<div class=\"userAvatar\">\r\n        <img src=\"img/user.png\">\r\n    </div>\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "username");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "h3");
            __builder.AddContent(19, 
#line 23 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
             username

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", 
#line 28 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
            );
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 28 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
            ));
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "ul");
            __builder.AddAttribute(28, "class", "nav flex-column");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "nav-item px-3");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "class", "nav-link");
            __builder.AddAttribute(35, "href", "");
            __builder.AddAttribute(36, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 31 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
            ));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(38, "\r\n                <img src=\"img/sideMenu04.png\"> &nbsp; Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "class", "nav-item px-3");
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "default.aspx/licenses");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "\r\n                <img src=\"img/sideMenu02.png\"> &nbsp; Licenses\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "nav-item px-3");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "class", "nav-link");
            __builder.AddAttribute(56, "href", "default.aspx/tasks/Not Started");
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "\r\n                <img src=\"img/sideMenu01.png\"> &nbsp; Tasks\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "li");
            __builder.AddAttribute(62, "class", "nav-item px-3");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(64);
            __builder.AddAttribute(65, "class", "nav-link");
            __builder.AddAttribute(66, "href", "../SitePages/Home.aspx");
            __builder.AddAttribute(67, "target", "_blank");
            __builder.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(69, "\r\n                <img src=\"img/sideMenu03.png\"> &nbsp; Admin Portal\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.OpenElement(72, "li");
            __builder.AddAttribute(73, "class", "nav-item px-3");
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(75);
            __builder.AddAttribute(76, "class", "nav-link");
            __builder.AddAttribute(77, "href", "../_layouts/closeConnection.aspx?loginasanotheruser=true");
            __builder.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(79, "\r\n                <img src=\"img/logout.png\"> &nbsp; Logout\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 58 "C:\Users\smj\source\repos\lms\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;
    string username = "";

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override async Task OnInitializedAsync()
    {
        HttpClient Http = new HttpClient();
        Root root = new Root();
        Http.DefaultRequestHeaders.Add("Accept", "application/json");
        string temp = await Http.GetStringAsync(Navigator.BaseUri + Settings.BaseURL + "_api/web/currentuser");
        root = JsonConvert.DeserializeObject<Root>(temp);
        //Setting Global Variables
        Settings.Id = root.Id;
        Settings.LoginName = root.LoginName;
        Settings.Title = root.Title;
        username = root.Title;
        StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigator { get; set; }
    }
}
#pragma warning restore 1591
