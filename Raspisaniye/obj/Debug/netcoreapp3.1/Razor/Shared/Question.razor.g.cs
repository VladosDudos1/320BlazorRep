#pragma checksum "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\Shared\Question.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db8eb8ac3f3aeed27ef8cbb964bfb7fb27620b3b"
// <auto-generated/>
#pragma warning disable 1591
namespace Raspisaniye.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Raspisaniye;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\_Imports.razor"
using Raspisaniye.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\Shared\Question.razor"
using Raspisaniye.Services;

#line default
#line hidden
#nullable disable
    public partial class Question : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "border p-5");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "h3");
#nullable restore
#line 5 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\Shared\Question.razor"
__builder.AddContent(4, QuestionHeader);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "p");
#nullable restore
#line 6 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\Shared\Question.razor"
__builder.AddContent(7, QuestionBody);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "placeholder", "Answer");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\Shared\Question.razor"
                                                                         Answer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Answer = __value, Answer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\chudo\source\repos\Raspisaniye\Raspisaniye\Shared\Question.razor"
       
    [Parameter]
    public string QuestionHeader { get; set; }

    [Parameter]
    public string QuestionBody { get; set; }

    private string _answer;

    private string Answer
    {
        get => _answer;
        set
        {
            _answer = value;
            LocalStorageSave();
        }
    }

    LocalStorageService storage;

    protected override void OnInitialized()
    {
        storage = new LocalStorageService(Reader);
        LocalStorageLoad();
    }

    public async void LocalStorageSave()
    {
        await storage.SetStringAsync(QuestionHeader, Answer);

    }

    public async void LocalStorageLoad()
    {
        try
        {
            _answer = await storage.GetStringAsync(QuestionHeader);
            StateHasChanged();
        }
        catch
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Reader { get; set; }
    }
}
#pragma warning restore 1591
