#pragma checksum "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96a507d8390c0c3b6e655454304c8a5996c3af7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipe_index), @"mvc.1.0.view", @"/Views/Equipe/index.cshtml")]
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
#line 1 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/_ViewImports.cshtml"
using E_Player_AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/_ViewImports.cshtml"
using E_Player_AspNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a507d8390c0c3b6e655454304c8a5996c3af7e", @"/Views/Equipe/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"478f7698aaef06f7a2333b6ad8507d1074c8c1d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipe_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Equipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
  
    ViewData["Title"] = "Equipes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"titulo_pagina\">\n    <h1>Cadastro de ");
#nullable restore
#line 8 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
               Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n</div>\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96a507d8390c0c3b6e655454304c8a5996c3af7e4456", async() => {
                WriteLiteral(@"


        <div class=""campo"">
            <label>ID</label>
            <input type=""text"" name=""IdEquipe"" id=""IdEquipe""/>

        </div>
<div class=""campo"">

            <label>Nome</label>
            <input type=""text"" name=""Nome"" id=""Nome""/>
</div>

<div class=""campo"">
            <label>Imagem</label>
            <<input type=""file"" name=""Imagem"" id=""Imagem""/>

</div>

    <button type=""submit"">Cadastrar</button>
    

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
AddHtmlAttributeValue("", 165, Url.Action("Cadastrar"), 165, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<table class=\"table table-striped table-responsive\">\n\n    <thead>\n        <th>ID</th>\n        <th>Nome</th>\n        <th>Foto</th>\n    </thead>\n        <tbody>\n");
#nullable restore
#line 45 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
             foreach (Equipe equipe in ViewBag.Equipes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 48 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
                   Write(equipe.IdEquipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 49 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
                   Write(equipe.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1027, "\"", 1060, 2);
            WriteAttributeValue("", 1033, "/img/Equipes/", 1033, 13, true);
#nullable restore
#line 50 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
WriteAttributeValue("", 1046, equipe.Imagem, 1046, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1061, "\"", 1096, 4);
            WriteAttributeValue("", 1067, "Imagem", 1067, 6, true);
            WriteAttributeValue(" ", 1073, "da", 1074, 3, true);
            WriteAttributeValue(" ", 1076, "equipe", 1077, 7, true);
#nullable restore
#line 50 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
WriteAttributeValue(" ", 1083, equipe.Nome, 1084, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\"></td>\n\n                </tr>\n");
#nullable restore
#line 53 "/home/darth-vader/Documentos/Desenvolvimento de Sistemas/MVC/E-Player_AspNetCore/Views/Equipe/index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Equipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
