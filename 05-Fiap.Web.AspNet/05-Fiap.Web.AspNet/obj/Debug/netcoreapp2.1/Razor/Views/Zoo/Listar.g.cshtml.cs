#pragma checksum "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "880c1e7e85185d4e7ca08ac46ae86a13be876471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zoo_Listar), @"mvc.1.0.view", @"/Views/Zoo/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zoo/Listar.cshtml", typeof(AspNetCore.Views_Zoo_Listar))]
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
#line 1 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880c1e7e85185d4e7ca08ac46ae86a13be876471", @"/Views/Zoo/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"269873a930527f28ca0fb92f300679416b9399e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Zoo_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Zoo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::_05_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(63, 21, true);
            WriteLiteral("\r\n<h2>Listar</h2>\r\n\r\n");
            EndContext();
            BeginContext(84, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("mensagem", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12892aacecd843e2988fc57065920b52", async() => {
            }
            );
            ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper = CreateTagHelper<global::_05_Fiap.Web.AspNet.TagHelpers.MensagemTagHelper>();
            __tagHelperExecutionContext.Add(___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper);
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
     WriteLiteral(TempData["msg"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper.Texto = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("texto", ___05_Fiap_Web_AspNet_TagHelpers_MensagemTagHelper.Texto, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(130, 178, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Jaulas</th>\r\n        <th>Tipo</th>\r\n        <th>Data Abertura</th>\r\n        <th>Opções</th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 20 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(349, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(380, 9, false);
#line 23 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(389, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(413, 11, false);
#line 24 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
           Write(item.Jaulas);

#line default
#line hidden
            EndContext();
            BeginContext(424, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(448, 27, false);
#line 25 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
           Write(item.EntidadeAdministradora);

#line default
#line hidden
            EndContext();
            BeginContext(475, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(499, 37, false);
#line 26 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
           Write(item.DataAbertura.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(536, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(577, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa04df91d0d946baaa7fab2372eb3ae0", async() => {
                BeginContext(649, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
                                                                WriteLiteral(item.Zooo);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(659, 76, true);
            WriteLiteral("\r\n                <!-- Botão para acionar modal -->\r\n                <button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 735, "\"", 771, 3);
            WriteAttributeValue("", 745, "churros.value", 745, 13, true);
            WriteAttributeValue(" ", 758, "=", 759, 2, true);
#line 30 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"
WriteAttributeValue(" ", 760, item.Zooo, 761, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(772, 181, true);
            WriteLiteral(" type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#modalExemplo\">\r\n                    Remover\r\n                </button>\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\logonrmlocal\Desktop\AnotacaoC\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Zoo\Listar.cshtml"

    }

#line default
#line hidden
            BeginContext(962, 731, true);
            WriteLiteral(@"</table>


<!-- Modal -->
<div class=""modal fade"" id=""modalExemplo"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Confirmação</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Fechar"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Deseja Realmente Excluir?        
            </div>
            <div class=""modal-footer"">
                ");
            EndContext();
            BeginContext(1693, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c72407ba262c4012b3242e11574681b5", async() => {
                BeginContext(1720, 287, true);
                WriteLiteral(@"
                    <input type=""hidden"" name=""id"" id=""churros"" />
                    <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Não</button>
                    <button type=""submit"" class=""btn btn-danger"">Sim</button>
                   
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2014, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Zoo>> Html { get; private set; }
    }
}
#pragma warning restore 1591