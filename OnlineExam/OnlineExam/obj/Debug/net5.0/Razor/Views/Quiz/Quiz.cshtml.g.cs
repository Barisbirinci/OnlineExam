#pragma checksum "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d03c3a74bfabe2c22230fbc2ceb2393181e95e73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Quiz), @"mvc.1.0.view", @"/Views/Quiz/Quiz.cshtml")]
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
#line 1 "D:\asp\OnlineExam\OnlineExam\Views\_ViewImports.cshtml"
using OnlineExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\asp\OnlineExam\OnlineExam\Views\_ViewImports.cshtml"
using OnlineExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03c3a74bfabe2c22230fbc2ceb2393181e95e73", @"/Views/Quiz/Quiz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c26b38a268148b41f8d27cf9435d899b998ac06", @"/Views/_ViewImports.cshtml")]
    public class Views_Quiz_Quiz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineExam.Models.Table.QuizViewTable>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Quiz.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
  
    ViewData["Title"] = "Take Exam";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br />\n<br />\n\n<div class=\"text-center\">\n    <h2 class=\"display-5\">");
#nullable restore
#line 10 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                     Write(Model.QuizTable.Title.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n</div>\n\n<br />\n\n<div class=\"container col-8 offset-2\" style=\"padding:30px; text-align:center\">");
#nullable restore
#line 15 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                                                                         Write(Model.QuizTable.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<br />\n\n<div id=\"questionSection\" class=\"container row\">\n");
#nullable restore
#line 20 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
     for (int i = 0; i < Model.QuestionTableList.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"border container col-5 bg-light\" style=\"padding:30px; border-radius:20px; margin-bottom:20px;\">\n            <div");
            BeginWriteAttribute("id", " id=\"", 579, "\"", 595, 2);
            WriteAttributeValue("", 584, "question+", 584, 9, true);
#nullable restore
#line 23 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 593, i, 593, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div class=\"form-group row\">\n                    <label>");
#nullable restore
#line 25 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                       Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 25 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                              Write(Model.QuestionTableList[i].QuestionText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n\n                <br />\n\n                <div>\n                    <label style=\"overflow:hidden;\" for=\"A\"");
            BeginWriteAttribute("onclick", " onclick=\"", 856, "\"", 888, 4);
            WriteAttributeValue("", 866, "answerOnClick(", 866, 14, true);
#nullable restore
#line 31 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 880, i, 880, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 882, ",", 882, 1, true);
            WriteAttributeValue(" ", 883, "\'A\')", 884, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 889, "\"", 907, 3);
            WriteAttributeValue("", 894, "question+", 894, 9, true);
#nullable restore
#line 31 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 903, i, 903, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 905, "+A", 905, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 908, "\"", 938, 3);
            WriteAttributeValue("", 916, "form-control", 916, 12, true);
            WriteAttributeValue(" ", 928, "custom+", 929, 8, true);
#nullable restore
#line 31 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 936, i, 936, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">A) ");
#nullable restore
#line 31 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                                                                                                                                             Write(Model.QuestionTableList[i].AnswerA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                    <label style=\"overflow:hidden;\" for=\"B\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1046, "\"", 1078, 4);
            WriteAttributeValue("", 1056, "answerOnClick(", 1056, 14, true);
#nullable restore
#line 32 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1070, i, 1070, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1072, ",", 1072, 1, true);
            WriteAttributeValue(" ", 1073, "\'B\')", 1074, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1079, "\"", 1097, 3);
            WriteAttributeValue("", 1084, "question+", 1084, 9, true);
#nullable restore
#line 32 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1093, i, 1093, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1095, "+B", 1095, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1098, "\"", 1128, 3);
            WriteAttributeValue("", 1106, "form-control", 1106, 12, true);
            WriteAttributeValue(" ", 1118, "custom+", 1119, 8, true);
#nullable restore
#line 32 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1126, i, 1126, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">B) ");
#nullable restore
#line 32 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                                                                                                                                             Write(Model.QuestionTableList[i].AnswerB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                    <label style=\"overflow:hidden;\" for=\"C\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1236, "\"", 1268, 4);
            WriteAttributeValue("", 1246, "answerOnClick(", 1246, 14, true);
#nullable restore
#line 33 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1260, i, 1260, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1262, ",", 1262, 1, true);
            WriteAttributeValue(" ", 1263, "\'C\')", 1264, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1269, "\"", 1287, 3);
            WriteAttributeValue("", 1274, "question+", 1274, 9, true);
#nullable restore
#line 33 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1283, i, 1283, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1285, "+C", 1285, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1288, "\"", 1318, 3);
            WriteAttributeValue("", 1296, "form-control", 1296, 12, true);
            WriteAttributeValue(" ", 1308, "custom+", 1309, 8, true);
#nullable restore
#line 33 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1316, i, 1316, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">C) ");
#nullable restore
#line 33 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                                                                                                                                             Write(Model.QuestionTableList[i].AnswerC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                    <label style=\"overflow:hidden;\" for=\"D\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1426, "\"", 1458, 4);
            WriteAttributeValue("", 1436, "answerOnClick(", 1436, 14, true);
#nullable restore
#line 34 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1450, i, 1450, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1452, ",", 1452, 1, true);
            WriteAttributeValue(" ", 1453, "\'D\')", 1454, 5, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1459, "\"", 1477, 3);
            WriteAttributeValue("", 1464, "question+", 1464, 9, true);
#nullable restore
#line 34 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1473, i, 1473, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1475, "+D", 1475, 2, true);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 1478, "\"", 1508, 3);
            WriteAttributeValue("", 1486, "form-control", 1486, 12, true);
            WriteAttributeValue(" ", 1498, "custom+", 1499, 8, true);
#nullable restore
#line 34 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1506, i, 1506, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">D) ");
#nullable restore
#line 34 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
                                                                                                                                             Write(Model.QuestionTableList[i].AnswerD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 38 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<br />\n\n<div class=\"form-group row\">\n    <div class=\"col-4 offset-4\">\n        <button id=\"completeBtn\" onclick=\"CompleteQuiz();\" class=\"btn btn-info form-control\">Complete the Quiz</button>\n    </div>\n</div>\n\n<div style=\"visibility:hidden\">\n");
#nullable restore
#line 50 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
     for(int i=0; i<Model.QuestionTableList.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <input");
            BeginWriteAttribute("value", " value=\"", 1945, "\"", 1994, 1);
#nullable restore
#line 52 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 1953, Model.QuestionTableList[i].CorrectAnswer, 1953, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1995, "\"", 2010, 2);
            WriteAttributeValue("", 2000, "correct+", 2000, 8, true);
#nullable restore
#line 52 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
WriteAttributeValue("", 2008, i, 2008, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 53 "D:\asp\OnlineExam\OnlineExam\Views\Quiz\Quiz.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d03c3a74bfabe2c22230fbc2ceb2393181e95e7315192", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03c3a74bfabe2c22230fbc2ceb2393181e95e7316371", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineExam.Models.Table.QuizViewTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
