#pragma checksum "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4b97efb05b9e136218650969123315dd71b134"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formation_DetailsFormation), @"mvc.1.0.view", @"/Views/Formation/DetailsFormation.cshtml")]
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
#line 1 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\_ViewImports.cshtml"
using AvisFormationCore.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\_ViewImports.cshtml"
using AvisFormationCore.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4b97efb05b9e136218650969123315dd71b134", @"/Views/Formation/DetailsFormation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"802d4f62b6cb0204ebc238f171ffa81eff8d0ee3", @"/Views/_ViewImports.cshtml")]
    public class Views_Formation_DetailsFormation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DetailFormationModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning text-decoration-none text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LaisserUnAvis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Avis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
  
    ViewData["Title"] = Model.Formation.Nom;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"jumbotron text-center mb-3\">\r\n    <h1>");
#nullable restore
#line 8 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
   Write(Model.Formation.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
  Write(Model.Formation.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div>\r\n    la formation est notée ");
#nullable restore
#line 13 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
                      Write(Model.NoteMoyenne);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /5\r\n");
#nullable restore
#line 14 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
     for (int i = 1; i <= Model.NoteMoyenne; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"fa fa-star orange\"></span>\r\n");
#nullable restore
#line 17 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<p>Voici ce qu\'en disent les anciens élèves : </p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d4b97efb05b9e136218650969123315dd71b1346388", async() => {
                WriteLiteral("Laisser un avis");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idFormation", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
                                                                                                                                     WriteLiteral(Model.Formation.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idFormation"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idFormation", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idFormation"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
 foreach (var avis in Model.Formation.Avis)

{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"avis-block\">\r\n        <div>\r\n            ");
#nullable restore
#line 28 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
       Write(avis.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5\r\n");
#nullable restore
#line 29 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
             for (int i = 1; i <= avis.Notes; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"fa fa-star orange\"></span>\r\n");
#nullable restore
#line 32 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n            <i>\r\n                ");
#nullable restore
#line 36 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
           Write(avis.NomUtilisateur);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </i>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 40 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
       Write(avis.Commentaire);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 43 "C:\Users\slima\asp.net\repos\AvisFormationCore.Web\AvisFormationCore.Web\Views\Formation\DetailsFormation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailFormationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591