#pragma checksum "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c18563b3c2853e1ec34cb7dea84da74e8aa3acd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_Delete), @"mvc.1.0.view", @"/Views/Usuarios/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuarios/Delete.cshtml", typeof(AspNetCore.Views_Usuarios_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18563b3c2853e1ec34cb7dea84da74e8aa3acd3", @"/Views/Usuarios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d50e9d20adf147f1293a57643250c45ed0f153b", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoCsharp.Models.Entidades.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(91, 189, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Você tem certeza que deseja deletar este usuário?</h3>\r\n<div>\r\n    <h4>Usuario</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(281, 38, false);
#line 15 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(319, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(383, 34, false);
#line 18 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(417, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(480, 47, false);
#line 21 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nomeUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(527, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(591, 43, false);
#line 24 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nomeUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(634, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(697, 47, false);
#line 27 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(744, 59, true);
            WriteLiteral("\r\n        </dt>\r\n        \r\n        <dd class=\"col-sm-10\">\r\n");
            EndContext();
            BeginContext(865, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 33 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
             if (Model.TipoUsuario == 1)
            {

#line default
#line hidden
            BeginContext(924, 46, true);
            WriteLiteral("                <label>Administrador</label>\r\n");
            EndContext();
#line 36 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
            }
            else if(Model.TipoUsuario == 2)
            {

#line default
#line hidden
            BeginContext(1045, 40, true);
            WriteLiteral("                <label>Técnico</label>\r\n");
            EndContext();
#line 40 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
            }
            else if(Model.TipoUsuario == 3)
            {

#line default
#line hidden
            BeginContext(1160, 48, true);
            WriteLiteral("                <label>Usuário Simples</label>\r\n");
            EndContext();
#line 44 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
            }

#line default
#line hidden
            BeginContext(1223, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1286, 41, false);
#line 48 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.idade));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1391, 37, false);
#line 51 "C:\Users\Casa\source\repos\ProjetoCsharp\ProjetoCsharp\Views\Usuarios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.idade));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1466, 165, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c18563b3c2853e1ec34cb7dea84da74e8aa3acd39006", async() => {
                BeginContext(1492, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1575, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c18563b3c2853e1ec34cb7dea84da74e8aa3acd39479", async() => {
                    BeginContext(1597, 17, true);
                    WriteLiteral("Voltar para lista");
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
                BeginContext(1618, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1631, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoCsharp.Models.Entidades.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
