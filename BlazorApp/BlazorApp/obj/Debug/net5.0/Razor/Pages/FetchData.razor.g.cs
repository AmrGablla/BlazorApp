#pragma checksum "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a8c9b6c3a8a0f0b7b7d3833584991863c79a25c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Employee Page</h1>\r\n \r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGrid<Employee>>(1);
            __builder.AddAttribute(2, "Count", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor"
                    count

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "style", "height:400px");
            __builder.AddAttribute(4, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 8 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                       employees

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "LoadData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.LoadDataArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.LoadDataArgs>(this, 
#nullable restore
#line 8 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                                             LoadData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                                                                     false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor"
                                                                                                                            false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ColumnWidth", "150px");
            __builder.AddAttribute(9, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Employee>>(10);
                __builder2.AddAttribute(11, "Property", "FirstName");
                __builder2.AddAttribute(12, "Title", "First Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Employee>>(14);
                __builder2.AddAttribute(15, "Property", "LastName");
                __builder2.AddAttribute(16, "Title", "Last Name");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGridColumn<Employee>>(18);
                __builder2.AddAttribute(19, "Property", "BirthDate");
                __builder2.AddAttribute(20, "Title", "Birth Date");
                __builder2.AddAttribute(21, "Template", (Microsoft.AspNetCore.Components.RenderFragment<Employee>)((data) => (__builder3) => {
                    __builder3.AddContent(22, 
#nullable restore
#line 14 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor"
                 String.Format("{0:d}", data.BirthDate)

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\Workspace\SSS\BlazorApp\BlazorApp\BlazorApp\Pages\FetchData.razor"
       
    int count;
    IEnumerable<Employee> employees;

    async Task LoadData(LoadDataArgs args)
    {
        employees = service.GetEmployees();
        count = 1;

        StateHasChanged();
    }

    void OnClick()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EmployeeService service { get; set; }
    }
}
#pragma warning restore 1591
