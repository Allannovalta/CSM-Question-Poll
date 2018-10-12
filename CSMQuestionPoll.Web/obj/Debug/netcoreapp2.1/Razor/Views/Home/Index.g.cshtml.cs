#pragma checksum "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0793ee5e03e326cde56b6466900dde579073ce3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\_ViewImports.cshtml"
using CSMQuestionPoll.Web;

#line default
#line hidden
#line 2 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\_ViewImports.cshtml"
using CSMQuestionPoll.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
using CSMQuestionPoll.Web.Infrastructure.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0793ee5e03e326cde56b6466900dde579073ce3d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d72a094f9920e6ac82a0d8582615dcbfbabcdd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSMQuestionPoll.Web.ViewModels.Users.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(170, 385, true);
            WriteLiteral(@"

<div class=""container"">
    <h2>Users</h2>
    <p>Here is a paged list of all the users</p>
    <table class=""table"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email Address</th>
                <th>Gender</th>
                <th>Login Status</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 22 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
              
                foreach (User user in Model.Users.Items)
                {

#line default
#line hidden
            BeginContext(648, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(687, 13, false);
#line 26 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
               Write(user.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(700, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(728, 17, false);
#line 27 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
               Write(user.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(745, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(773, 11, false);
#line 28 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
               Write(user.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(784, 28, true);
            WriteLiteral("</td>\r\n                <td> ");
            EndContext();
            BeginContext(813, 16, false);
#line 29 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
                Write(user.LoginStatus);

#line default
#line hidden
            EndContext();
            BeginContext(829, 212, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    <a href=\"#\" onclick=\"confirmResetPassword()\" title=\"Reset Password\"><button type=\"button\" class=\"btn\"><i class=\"fas fa-key\"></i></button></a>\r\n                    ");
            EndContext();
            BeginContext(1041, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07604de9f4264f45b6daffad9a445241", async() => {
                BeginContext(1112, 76, true);
                WriteLiteral("<button type=\"button\" class=\"btn\"><i class=\"fas fa-pen-square\"></i></button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1050, "~/home/update-profile?userId=", 1050, 29, true);
#line 32 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1079, user.Id, 1079, 8, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1192, 379, true);
            WriteLiteral(@"
                    <a href=""#"" onclick=""confirmActivateAccount()"" title=""Activate Account""><button type=""button"" class=""btn""><i class=""fas fa-unlock-alt""></i></button></a>
                    <a href=""#"" onclick=""confirmDeleteUser()"" title=""Delete User""><button type=""button"" class=""btn""><i class=""fas fa-times""></i></button></a>
                </td>

            </tr>
");
            EndContext();
#line 38 "C:\Users\ALLAN_Novalta\Documents\Projects\CSMQuestionPoll\CSMQuestionPoll.Web\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1605, 147, true);
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"5\">\r\n            </tr>\r\n        </tfoot>\r\n     </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSMQuestionPoll.Web.ViewModels.Users.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
