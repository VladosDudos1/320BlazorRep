#pragma checksum "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a3ad1614a24690db22261c934005120fbfd837f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProject.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using BlazorProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\_Imports.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
using BlazorProject.Data;

#line default
#line hidden
#nullable disable
    public partial class ListTimetable2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "<thead><tr><th>Id</th>\r\n            <th>Subject</th>\r\n            <th>Teacher</th>\r\n            <th>Classroom</th></tr></thead>\r\n    ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 13 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
         if (TimetableService.GetItem(Day) != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
             foreach (var table in TimetableService.GetItem(Day))
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 18 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
                         table.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n                    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 19 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
                         table.Subject

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 20 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
                         table.NameTeacher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 21 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
                         table.Classroom

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\nasur\source\repos\BlazorProject\BlazorProject\Shared\ListTimetable2.razor"
       
    [Parameter]
    public string Day { get; set; } = "Monday";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
