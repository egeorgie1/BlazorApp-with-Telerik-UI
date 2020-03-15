#pragma checksum "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39873f176d73c8f93b8a688f59d80846a6834794"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorWebAssemblyApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using BlazorWebAssemblyApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\elena\source\repos\BlazorWebAssemblyApp\BlazorWebAssemblyApp\Pages\Index.razor"
       
        MarkupString helloString;

        void SayHelloHandler()
        {
            string msg = string.Format("Hello from <strong>Telerik Blazor</strong> at {0}.<br /> Now you can use C# to write front-end!", DateTime.Now);
            helloString = new MarkupString(msg);
        }

       
       IEnumerable<Presentation> MyData = Index.InitializeDataCollection();

       static List<Presentation> InitializeDataCollection()
       {
         List<Presentation> presentations = new List<Presentation>();

         presentations.Add(new Presentation {Id = 1,  Topic = "CSS selectors", Speaker = "Ivan Ivanov", Date = DateTime.Now.AddDays(1), Preference = "Interesting" });
         presentations.Add(new Presentation { Id = 5,  Topic = "HTML5", Speaker = "Georgi Ivanov", Date = DateTime.Now.AddDays(2), Preference = "No value" });
         presentations.Add(new Presentation { Id = 8,  Topic = "JavaScript", Speaker = "Maria Petrova", Date = DateTime.Now.AddDays(3), Preference = "Going" });
         presentations.Add(new Presentation { Id = 70, Topic = "NativeScript", Speaker = "Petar Petrov", Date = DateTime.Now.AddDays(4), Preference = "No value" });

         return presentations;
       }

    public class Presentation
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public string Speaker { get; set; }
        public DateTime Date { get; set; }
        public string Preference { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
