#pragma checksum "D:\CodeKentucky\DnDLetItRoll\DnDLetItRoll.UI\Views\Races\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "201cf45ac3bf3877ba52697c9c70a041ffef21a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Races_Create), @"mvc.1.0.view", @"/Views/Races/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"201cf45ac3bf3877ba52697c9c70a041ffef21a6", @"/Views/Races/Create.cshtml")]
    public class Views_Races_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DnDLetItRoll.Domain.Models.Race>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CodeKentucky\DnDLetItRoll\DnDLetItRoll.UI\Views\Races\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Race</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""StatIncreased"" class=""control-label""></label>
                <input asp-for=""StatIncreased"" class=""form-control"" />
                <span asp-validation-for=""StatIncreased"" class=""text-da");
            WriteLiteral(@"nger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""IncreaseAmount"" class=""control-label""></label>
                <input asp-for=""IncreaseAmount"" class=""form-control"" />
                <span asp-validation-for=""IncreaseAmount"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Size"" class=""control-label""></label>
                <input asp-for=""Size"" class=""form-control"" />
                <span asp-validation-for=""Size"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Speed"" class=""control-label""></label>
                <input asp-for=""Speed"" class=""form-control"" />
                <span asp-validation-for=""Speed"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Languages"" class=""control-label""></label>
                <input asp-for=""Languag");
            WriteLiteral(@"es"" class=""form-control"" />
                <span asp-validation-for=""Languages"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""RacialTraits"" class=""control-label""></label>
                <input asp-for=""RacialTraits"" class=""form-control"" />
                <span asp-validation-for=""RacialTraits"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 67 "D:\CodeKentucky\DnDLetItRoll\DnDLetItRoll.UI\Views\Races\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DnDLetItRoll.Domain.Models.Race> Html { get; private set; }
    }
}
#pragma warning restore 1591
