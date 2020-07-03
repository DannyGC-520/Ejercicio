#pragma checksum "/Users/danny/Desktop/projects/Ejercicio/Views/Number/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acd8e216cf530ad20a1818b3ecda1e6a8939ea3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Number_Index), @"mvc.1.0.view", @"/Views/Number/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Number/Index.cshtml", typeof(AspNetCore.Views_Number_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acd8e216cf530ad20a1818b3ecda1e6a8939ea3b", @"/Views/Number/Index.cshtml")]
    public class Views_Number_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ejercicio.Models.Number>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("content m-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 20, true);
            WriteLiteral("\n<html lang=\"en\">\n  ");
            EndContext();
            BeginContext(57, 386, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd8e216cf530ad20a1818b3ecda1e6a8939ea3b3210", async() => {
                BeginContext(63, 373, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
    <title>Números Par e Impar</title>
  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(443, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(444, 802, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acd8e216cf530ad20a1818b3ecda1e6a8939ea3b4754", async() => {
                BeginContext(470, 397, true);
                WriteLiteral(@"

<h1>Números Pares</h1><br>

<form action=""/Number/index"" method=""POST"">    
    <div class=""form-group row"">
    <label class=""col-sm-2 col-form-label col-md-1"" for=""name"">Número:</label>
    <input class=""form-control col-md-3 m-1"" type=""number"" name=""InitalValue"" placeholder=""Ingrese un número"" min=""1""/>
    <input class=""btn btn-primary"" type=""submit"" value=""Generar"" />
    </div>
</form>
");
                EndContext();
#line 21 "/Users/danny/Desktop/projects/Ejercicio/Views/Number/Index.cshtml"
 if(Model!=null){

#line default
#line hidden
                BeginContext(885, 180, true);
                WriteLiteral("<table class=\"table table-bordered\">\n    <thead>\n        <tr>\n            <th scope=\"col\" >Número</th>\n            <th scope=\"col\">Tipo</th>\n        </tr>\n    </thead>\n    <tbody>\n");
                EndContext();
#line 30 "/Users/danny/Desktop/projects/Ejercicio/Views/Number/Index.cshtml"
     foreach(var number in Model){

#line default
#line hidden
                BeginContext(1100, 41, true);
                WriteLiteral("        <tr>\n            <th scope=\"row\">");
                EndContext();
                BeginContext(1142, 12, false);
#line 32 "/Users/danny/Desktop/projects/Ejercicio/Views/Number/Index.cshtml"
                       Write(number.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1154, 22, true);
                WriteLiteral("</th>\n            <td>");
                EndContext();
                BeginContext(1177, 11, false);
#line 33 "/Users/danny/Desktop/projects/Ejercicio/Views/Number/Index.cshtml"
           Write(number.Type);

#line default
#line hidden
                EndContext();
                BeginContext(1188, 20, true);
                WriteLiteral("</td>\n        </tr>\n");
                EndContext();
#line 35 "/Users/danny/Desktop/projects/Ejercicio/Views/Number/Index.cshtml"
    }

#line default
#line hidden
                BeginContext(1214, 22, true);
                WriteLiteral("    </tbody>\n</table>\n");
                EndContext();
#line 38 "/Users/danny/Desktop/projects/Ejercicio/Views/Number/Index.cshtml"
}

#line default
#line hidden
                BeginContext(1238, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1246, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ejercicio.Models.Number>> Html { get; private set; }
    }
}
#pragma warning restore 1591