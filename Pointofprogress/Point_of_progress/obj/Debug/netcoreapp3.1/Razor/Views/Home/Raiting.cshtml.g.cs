#pragma checksum "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf0a7d1a9ee2079824111a48f8f2e20fd9f578f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Raiting), @"mvc.1.0.view", @"/Views/Home/Raiting.cshtml")]
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
#line 1 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\_ViewImports.cshtml"
using Point_of_progress;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\_ViewImports.cshtml"
using Point_of_progress.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf0a7d1a9ee2079824111a48f8f2e20fd9f578f", @"/Views/Home/Raiting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d378008d6236111cfa7186af264df9c942a82b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Raiting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Point_of_progress.Models.RaitingPage>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50%; margin-right:auto; margin:30px;display:inline-block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
  
    ViewData["Title"] = "Рейтинг";
    int i = 0;
    int j = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bf0a7d1a9ee2079824111a48f8f2e20fd9f578f3977", async() => {
                WriteLiteral(" \r\n    <header class=\"Title\">Рейтинг</header>\r\n");
#nullable restore
#line 13 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
     foreach(var item in Model.UserList)
    {
        i=i+1;

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"task\" style=\"width: 80%;  margin-left:auto; margin-right:auto;\">\r\n            <label class=\"texttaskT\" ><span style=\"color:#696969;\">");
#nullable restore
#line 17 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
                                                              Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span> ");
#nullable restore
#line 17 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
                                                                        Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span style=\"color:#FF00FF\">");
#nullable restore
#line 17 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
                                                                                                               Write(item.balance);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></label>");
#nullable restore
#line 17 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
                                                                                                                                                  
                if(item.name==Model.name) { j = i; }
            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n");
#nullable restore
#line 21 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n     <div style=\"display:inline-block; height:300px\"><header class=\"Title\" >");
#nullable restore
#line 23 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
                                                                       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Место: <span style=\"color:#FF00FF\">");
#nullable restore
#line 23 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
                                                                                                                      Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral(" из ");
#nullable restore
#line 23 "C:\Users\mayta\source\repos\Pointofprogress\Point_of_progress\Views\Home\Raiting.cshtml"
                                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </header>\r\n         <br><br><br><br><br><br><br><br><br>\r\n         </div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Point_of_progress.Models.RaitingPage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
