#pragma checksum "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51fb6ec68957f6980a2eebd499e3dac1781593cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_OrdenNombre), @"mvc.1.0.view", @"/Views/Clientes/OrdenNombre.cshtml")]
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
#nullable restore
#line 1 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\_ViewImports.cshtml"
using LAB0DS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\_ViewImports.cshtml"
using LAB0DS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51fb6ec68957f6980a2eebd499e3dac1781593cb", @"/Views/Clientes/OrdenNombre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"321321fa5d59a7bc14f4baa9daf4b16a3c383ace", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_OrdenNombre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LAB0DS.Models.ClientesModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
  
    ViewData["Title"] = "OrdenNombre";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Clientes</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51fb6ec68957f6980a2eebd499e3dac1781593cb3828", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Telefono }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 47 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Telefono }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 48 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Telefono }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\daslu\Desktop\Tercer Ciclo\Estructura de Datos I\Git Hub\LAB0-DS\LAB0DS\Views\Clientes\OrdenNombre.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LAB0DS.Models.ClientesModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
