#pragma checksum "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\Shared\LessonTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01e3079ecaed75b1498bb6193b286675ba88f77f"
// <auto-generated/>
#pragma warning disable 1591
namespace TimeTable.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\_Imports.razor"
using TimeTable.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\Shared\LessonTable.razor"
using TimeTable;

#line default
#line hidden
#nullable disable
    public partial class LessonTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>LessonTable</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <td>Subject</td>\r\n            <td>Teacher</td>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 11 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\Shared\LessonTable.razor"
 foreach (var subject in DataAccess.GetTimeTableDay(Day).Subjects)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 14 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\Shared\LessonTable.razor"
             subject.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\Shared\LessonTable.razor"
             subject.Teacher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 18 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\Shared\LessonTable.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\201913\Source\Repos\320BlazorRep\TimeTable\Shared\LessonTable.razor"
       
    [Parameter]
    public string Day { get; set; } = "Monday";


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591