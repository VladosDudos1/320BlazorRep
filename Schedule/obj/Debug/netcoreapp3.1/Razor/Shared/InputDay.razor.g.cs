#pragma checksum "C:\Users\USER\source\repos\Schedule\Schedule\Shared\InputDay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc0e47775ebbe6df74e5fc746d6e852be7e80c42"
// <auto-generated/>
#pragma warning disable 1591
namespace Schedule.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Schedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USER\source\repos\Schedule\Schedule\_Imports.razor"
using Schedule.Shared;

#line default
#line hidden
#nullable disable
    public partial class InputDay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\InputDay.razor"
                                         () => OnClickCallback.InvokeAsync(day)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\InputDay.razor"
                        day

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => day = __value, day));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 5 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\InputDay.razor"
             foreach (var i in ScheduleService.GetDays())
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "class", "dropdown-item");
            __builder.AddContent(13, 
#nullable restore
#line 7 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\InputDay.razor"
                                               i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 8 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\InputDay.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\InputDay.razor"
       
    private string day;

    [Parameter]
    public EventCallback<string> OnClickCallback { get; set; }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ScheduleService ScheduleService { get; set; }
    }
}
#pragma warning restore 1591
