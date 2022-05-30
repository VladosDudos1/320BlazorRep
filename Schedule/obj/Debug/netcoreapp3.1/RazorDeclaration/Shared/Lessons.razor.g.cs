// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\Lessons.razor"
using Schedule.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\Lessons.razor"
using Schedule.Data;

#line default
#line hidden
#nullable disable
    public partial class Lessons : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\USER\source\repos\Schedule\Schedule\Shared\Lessons.razor"
       

    [Parameter]
    public ScheduleDay Day { get; set; }

    private void EnableEditing(bool flag, Subject subject)
    {
        subject.IsEditing = flag;
    }

    private void UpdateSubject(Subject subject)
    {
        EnableEditing(false, subject);

        ScheduleService.SaveScheduleDay(Day);
    }

    private void DeleteSubject(Subject subject) => ScheduleService.DeleteSubject(Day, subject);

    private void AddNewRow()
    {
        if (Day == null)
            return;
        var subject = ScheduleService.AddNewSubject(Day);
        EnableEditing(true, subject);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ScheduleService ScheduleService { get; set; }
    }
}
#pragma warning restore 1591
