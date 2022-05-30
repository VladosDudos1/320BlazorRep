#pragma checksum "C:\Users\USER\source\repos\Schedule\Schedule\Pages\SchedulePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbd2ec6ceb3eed5f4474359cbe633467084d446d"
// <auto-generated/>
#pragma warning disable 1591
namespace Schedule.Pages
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
#nullable restore
#line 2 "C:\Users\USER\source\repos\Schedule\Schedule\Pages\SchedulePage.razor"
using Schedule.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/schedule")]
    public partial class SchedulePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Schedule.Shared.InputDay>(0);
            __builder.AddAttribute(1, "OnClickCallback", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 5 "C:\Users\USER\source\repos\Schedule\Schedule\Pages\SchedulePage.razor"
                            GetScheduleDay

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenComponent<Schedule.Shared.Lessons>(3);
            __builder.AddAttribute(4, "Day", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Schedule.Data.ScheduleDay>(
#nullable restore
#line 6 "C:\Users\USER\source\repos\Schedule\Schedule\Pages\SchedulePage.razor"
              Day

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\USER\source\repos\Schedule\Schedule\Pages\SchedulePage.razor"
       

    private ScheduleDay Day;

    private void GetScheduleDay(string selectedDay)
    {
        Day = ScheduleService.GetScheduleDay(selectedDay);

        if (Day == null)
            Day = new ScheduleDay
            {
                DayName = selectedDay
            };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.ScheduleService ScheduleService { get; set; }
    }
}
#pragma warning restore 1591
