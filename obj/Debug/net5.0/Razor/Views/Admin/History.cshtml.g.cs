#pragma checksum "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "79ff9f122f316e033911234e50c0d7552976a605a5eb348d7422caf03e5d4649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_History), @"mvc.1.0.view", @"/Views/Admin/History.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\_ViewImports.cshtml"
using pcg;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\_ViewImports.cshtml"
using pcg.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"79ff9f122f316e033911234e50c0d7552976a605a5eb348d7422caf03e5d4649", @"/Views/Admin/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"194cce456bb1ecb3f0b4e04e1a27dcf9c36236045229457aa128b29d50bb1d71", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pcg.Models.VariationModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
  
    ViewData["Title"] = "History";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card"">
    <div class=""table-container"">
<h1 style=""text-align:center"">Tasks Log</h1>
<input class=""form-control"" type=""text"" id=""search"" placeholder=""Search here"" onkeyup=""searchTable()"">
<table class=""custom-table"">
    <thead>
        <tr>
            <th class=""text-center text-uppercase"">Log No.</th>
            <th class=""text-center text-uppercase"">Task No.</th>
            <th class=""text-center text-uppercase"">Assigned/Forwarded</th>
            <th class=""text-center text-uppercase"">Added By</th>
            <th class=""text-center text-uppercase"">Client/Site</th>
            <th class=""text-center text-uppercase"">Status</th>
            <th class=""text-center text-uppercase"">Date Start</th>
            <th class=""text-center text-uppercase"">Date Forwarded</th>
            <th class=""text-center text-uppercase"">Date Received</th>
            <th class=""text-center text-uppercase"">Date Completed</th>         
        </tr>
    </thead>
    <tbody id=""myTable"" class=""view");
            WriteLiteral("bag-data\">\r\n");
#nullable restore
#line 26 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
         foreach (System.Data.DataRow dr in ViewBag.Tasklog.Rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 29 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["LogId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 30 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["TaskId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 31 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["Name"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 32 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["AddedBy"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 33 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["Client"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                                                    Write(dr["Site"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 34 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["Status"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 35 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["DateStart"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 36 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["DateFwd"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 37 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["DateRcv"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center text-nowrap\">");
#nullable restore
#line 38 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
                                           Write(dr["DateClr"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Eric\Desktop\pcg\pcg\pcg\Views\Admin\History.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
    </div>
</div>
<script>
    function searchTable() {
        var input, filter, table, tr, td, i, txtValue;
        input = document.getElementById(""search"");
        filter = input.value.toUpperCase();
        table = document.getElementById(""myTable"");
        tr = table.getElementsByTagName(""tr"");

        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName(""td"");
            for (var j = 0; j < td.length; j++) {
                if (td[j]) {
                    txtValue = td[j].textContent || td[j].innerText;
                    if (txtValue.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = """";
                        break;
                    } else {
                        tr[i].style.display = ""none"";
                    }
                }
            }
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pcg.Models.VariationModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
