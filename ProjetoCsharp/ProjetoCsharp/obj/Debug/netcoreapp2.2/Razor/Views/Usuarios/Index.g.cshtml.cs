#pragma checksum "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b402fb9b3d86fc39807d15867637afc1a50a29f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Index), @"mvc.1.0.view", @"/Views/Usuarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Index.cshtml", typeof(AspNetCore.Views_Usuarios_Index))]
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
#line 1 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\_ViewImports.cshtml"
using ProjetoCsharp;

#line default
#line hidden
#line 2 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\_ViewImports.cshtml"
using ProjetoCsharp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b402fb9b3d86fc39807d15867637afc1a50a29f", @"/Views/Usuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d50e9d20adf147f1293a57643250c45ed0f153b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjetoCsharp.Models.Entidades.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(103, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(132, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b402fb9b3d86fc39807d15867637afc1a50a29f3849", async() => {
                BeginContext(155, 18, true);
                WriteLiteral("Criar Novo usuário");
                EndContext();
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
            EndContext();
            BeginContext(177, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(270, 38, false);
#line 16 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(308, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(364, 47, false);
#line 19 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.nomeUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 47, false);
#line 22 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(514, 57, true);
            WriteLiteral("\r\n\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(572, 41, false);
#line 26 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.idade));

#line default
#line hidden
            EndContext();
            BeginContext(613, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(731, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(780, 37, false);
#line 35 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(817, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(873, 46, false);
#line 38 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.nomeUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(919, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(975, 46, false);
#line 41 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1077, 40, false);
#line 44 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.idade));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1173, 78, false);
#line 47 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1272, 84, false);
#line 48 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1377, 82, false);
#line 49 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1498, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjetoCsharp.Models.Entidades.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591