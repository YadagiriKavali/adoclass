#pragma checksum "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df695c688072b4a1ad69a2a7b4f8425b3c3ed9a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountHolders_GetAccountsRegisteredonaGivenDate), @"mvc.1.0.view", @"/Views/AccountHolders/GetAccountsRegisteredonaGivenDate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountHolders/GetAccountsRegisteredonaGivenDate.cshtml", typeof(AspNetCore.Views_AccountHolders_GetAccountsRegisteredonaGivenDate))]
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
#line 1 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\_ViewImports.cshtml"
using TWelletDemoApp;

#line default
#line hidden
#line 2 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\_ViewImports.cshtml"
using TWelletDemoApp.Models;

#line default
#line hidden
#line 1 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df695c688072b4a1ad69a2a7b4f8425b3c3ed9a7", @"/Views/AccountHolders/GetAccountsRegisteredonaGivenDate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fb2dc77b32ea448f1bdfab4073ef0f34fec7885", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountHolders_GetAccountsRegisteredonaGivenDate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<TWelletDemoApp.Models.AccountHolderDT>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAccountsRegisteredonaGivenDate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
  
    ViewData["Title"] = "Get Accounts Registered on a Given Date";

#line default
#line hidden
            BeginContext(156, 359, true);
            WriteLiteral(@"<!-- Include Bootstrap CSS -->


<style>

    .small-td {
        font-size: 0.8rem; /* Adjust font size */
        padding: 5px; /* Adjust padding */
    }

    .table-hover tbody tr:hover {
        background-color: moccasin; /* Change the hover background color to red */
    }
</style>
<div class=""row"">
    <div class='col-sm-5'>
        ");
            EndContext();
            BeginContext(515, 414, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fb831899f334fae94b2c3e0fb5b4d20", async() => {
                BeginContext(581, 341, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""date"" style="" font:bold;font-size:large"">Select Date:</label>
                <input type=""date"" id=""date"" name=""date"" class=""form-control mb-2"" required />
                <button type=""submit"" class=""btn btn-lg btn-primary"">Search</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(929, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
#line 33 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
 if (ViewBag.ErrorMessage != null)
{

#line default
#line hidden
            BeginContext(992, 51, true);
            WriteLiteral("    <div class=\"alert alert-danger mt-3\">\r\n        ");
            EndContext();
            BeginContext(1044, 20, false);
#line 36 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
   Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(1064, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 38 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
}


#line default
#line hidden
#line 45 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
 if (Model != null && Model.Any())
{

#line default
#line hidden
            BeginContext(1228, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1232, 4685, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddf4f876c3ac4239966e301fc6ccaab7", async() => {
                BeginContext(1274, 727, true);
                WriteLiteral(@"

        <table class=""table table table-striped table-hover table-sm text-center"">
            <thead class=""text-center"" style=""background-color: #3254a8; color: white;"">
                <tr>
                    <th scope=""col"">AccountHolderId</th>
                    <th scope=""col"">Mobile No</th>
                    <th scope=""col"">POI Type</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">POI Email</th>
                    <th scope=""col"">Created Date<div style=""font-size:10px"">(YYYY-MM-DD)</div></th>
                    <th scope=""col"">Decision</th>
                    <th scope=""col"">Remark</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 63 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(2066, 47, true);
                WriteLiteral("                <tr>\r\n                    <td >");
                EndContext();
                BeginContext(2114, 20, false);
#line 66 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                    Write(item.AccountHolderId);

#line default
#line hidden
                EndContext();
                BeginContext(2134, 32, true);
                WriteLiteral("</td>\r\n                    <td >");
                EndContext();
                BeginContext(2167, 26, false);
#line 67 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                    Write(item.AccountHolderMobileno);

#line default
#line hidden
                EndContext();
                BeginContext(2193, 32, true);
                WriteLiteral("</td>\r\n                    <td >");
                EndContext();
                BeginContext(2226, 12, false);
#line 68 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                    Write(item.POIType);

#line default
#line hidden
                EndContext();
                BeginContext(2238, 57, true);
                WriteLiteral("</td>\r\n                    <td style=\"font-weight:bold\" >");
                EndContext();
                BeginContext(2296, 26, false);
#line 69 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                                             Write(item.AccountHolderFullName);

#line default
#line hidden
                EndContext();
                BeginContext(2322, 32, true);
                WriteLiteral("</td>\r\n                    <td >");
                EndContext();
                BeginContext(2355, 13, false);
#line 70 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                    Write(item.Poiemail);

#line default
#line hidden
                EndContext();
                BeginContext(2368, 32, true);
                WriteLiteral("</td>\r\n                    <td >");
                EndContext();
                BeginContext(2401, 40, false);
#line 71 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                    Write(item.CreatedDate?.ToString("yyyy-MM-dd"));

#line default
#line hidden
                EndContext();
                BeginContext(2441, 304, true);
                WriteLiteral(@"</td>

                    <!-- Decision (Approve/Reject) -->
                    <td>
                        <div class=""d-flex align-items-center"">
                            <div class=""form-check form-check-inline"">
                                <input class=""form-check-input"" type=""radio""");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2745, "\"", 2779, 2);
                WriteAttributeValue("", 2750, "approve-", 2750, 8, true);
#line 77 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 2758, item.AccountHolderId, 2758, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 2780, "\"", 2818, 3);
                WriteAttributeValue("", 2787, "decision[", 2787, 9, true);
#line 77 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 2796, item.AccountHolderId, 2796, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 2817, "]", 2817, 1, true);
                EndWriteAttribute();
                BeginContext(2819, 25, true);
                WriteLiteral(" value=\"Approve\" required");
                EndContext();
                BeginWriteAttribute("onchange", " onchange=\"", 2844, "\"", 2892, 3);
                WriteAttributeValue("", 2855, "toggleRemark(\'", 2855, 14, true);
#line 77 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 2869, item.AccountHolderId, 2869, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 2890, "\')", 2890, 2, true);
                EndWriteAttribute();
                BeginContext(2893, 66, true);
                WriteLiteral(">\r\n                                <label class=\"form-check-label\"");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 2959, "\"", 2994, 2);
                WriteAttributeValue("", 2965, "approve-", 2965, 8, true);
#line 78 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 2973, item.AccountHolderId, 2973, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2995, 202, true);
                WriteLiteral(">Approve</label>\r\n                            </div>\r\n                            <div class=\"form-check form-check-inline\">\r\n                                <input class=\"form-check-input\" type=\"radio\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3197, "\"", 3230, 2);
                WriteAttributeValue("", 3202, "reject-", 3202, 7, true);
#line 81 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 3209, item.AccountHolderId, 3209, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3231, "\"", 3269, 3);
                WriteAttributeValue("", 3238, "decision[", 3238, 9, true);
#line 81 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 3247, item.AccountHolderId, 3247, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 3268, "]", 3268, 1, true);
                EndWriteAttribute();
                BeginContext(3270, 24, true);
                WriteLiteral(" value=\"Reject\" required");
                EndContext();
                BeginWriteAttribute("onchange", " onchange=\"", 3294, "\"", 3342, 3);
                WriteAttributeValue("", 3305, "toggleRemark(\'", 3305, 14, true);
#line 81 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 3319, item.AccountHolderId, 3319, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 3340, "\')", 3340, 2, true);
                EndWriteAttribute();
                BeginContext(3343, 66, true);
                WriteLiteral(">\r\n                                <label class=\"form-check-label\"");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 3409, "\"", 3443, 2);
                WriteAttributeValue("", 3415, "reject-", 3415, 7, true);
#line 82 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 3422, item.AccountHolderId, 3422, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3444, 109, true);
                WriteLiteral(">Reject</label>\r\n                            </div>\r\n                        </div>\r\n                        ");
                EndContext();
                BeginContext(3554, 70, false);
#line 85 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                   Write(Html.ValidationMessage("decision", "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3624, 259, true);
                WriteLiteral(@"
                    </td>

                    <!-- Remark Input (Only required when Reject is selected) -->
                    <td>
                        <div class=""d-flex"">
                            <input type=""text"" class=""form-control w-100""");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3883, "\"", 3916, 2);
                WriteAttributeValue("", 3888, "remark-", 3888, 7, true);
#line 91 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 3895, item.AccountHolderId, 3895, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 3917, "\"", 3953, 3);
                WriteAttributeValue("", 3924, "remark[", 3924, 7, true);
#line 91 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 3931, item.AccountHolderId, 3931, 21, false);

#line default
#line hidden
                WriteAttributeValue("", 3952, "]", 3952, 1, true);
                EndWriteAttribute();
                BeginContext(3954, 203, true);
                WriteLiteral(" placeholder=\"Please enter reason for rejection\" required disabled\r\n                                   onkeydown=\"return preventSpace(event);\" />\r\n                        </div>\r\n                        ");
                EndContext();
                BeginContext(4158, 68, false);
#line 94 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                   Write(Html.ValidationMessage("remark", "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(4226, 1366, true);
                WriteLiteral(@"
                    </td>

                    <script>
                        function toggleRemark(accountHolderId) {
                            const remarkInput = document.getElementById(`remark-${accountHolderId}`);
                            const approveRadio = document.getElementById(`approve-${accountHolderId}`);
                            const rejectRadio = document.getElementById(`reject-${accountHolderId}`);

                            if (approveRadio.checked) {
                                remarkInput.disabled = true;
                                remarkInput.value = ""Approved""; // Clear input when Approve is selected
                            } else if (rejectRadio.checked) {
                                remarkInput.disabled = false;
                                remarkInput.placeholder = ""Please enter reason for rejection""; // Enable input with specific placeholder when Reject is selected
                            }
                        }

            ");
                WriteLiteral(@"            function preventSpace(event) {
                            // Prevent space key from being entered
                            if (event.key === ' ') {
                                event.preventDefault();
                            }
                        }
                    </script>



                </tr>
");
                EndContext();
#line 123 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"

                }

#line default
#line hidden
                BeginContext(5613, 297, true);
                WriteLiteral(@"            </tbody>
        </table>
        <div class=""row"">
            <div class=""col-10"">

            </div>
            <div class=""col-2"">
                <button type=""submit"" class=""btn btn-primary btn-block mt-3 mb-3"">Update</button>
            </div>
        </div>

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5917, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 137 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(5931, 60, true);
            WriteLiteral("    <p>No account holders found for the selected date.</p>\r\n");
            EndContext();
#line 141 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
}

#line default
#line hidden
            BeginContext(5994, 27, true);
            WriteLiteral("\r\n<ul class=\"pagination\">\r\n");
            EndContext();
#line 144 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
     for (var i = 1; i <= Model.PageCount; i++)
    {

#line default
#line hidden
            BeginContext(6077, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 6088, "\"", 6146, 2);
            WriteAttributeValue("", 6096, "page-item", 6096, 9, true);
#line 146 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue(" ", 6105, i == Model.PageNumber ? "active" : "", 6106, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6147, 35, true);
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6182, "\"", 6282, 1);
#line 147 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
WriteAttributeValue("", 6189, Url.Action("GetAccountsRegisteredonaGivenDate", new { page = i, pageSize = Model.PageSize }), 6189, 93, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6283, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(6285, 1, false);
#line 147 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
                                                                                                                                 Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(6286, 21, true);
            WriteLiteral("</a>\r\n        </li>\r\n");
            EndContext();
#line 149 "D:\Yadagiri\Core\TWelletDemoApp\TWelletDemoApp\Views\AccountHolders\GetAccountsRegisteredonaGivenDate.cshtml"
    }

#line default
#line hidden
            BeginContext(6314, 7, true);
            WriteLiteral("</ul>\r\n");
            EndContext();
            BeginContext(7004, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<TWelletDemoApp.Models.AccountHolderDT>> Html { get; private set; }
    }
}
#pragma warning restore 1591
