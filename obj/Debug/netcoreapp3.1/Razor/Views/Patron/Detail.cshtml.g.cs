#pragma checksum "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73d3c93ad3f6692f5e960d0f02f9c0e4ffc5842b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patron_Detail), @"mvc.1.0.view", @"/Views/Patron/Detail.cshtml")]
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
#line 1 "D:\VisualStudio Projects\Github\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio Projects\Github\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73d3c93ad3f6692f5e960d0f02f9c0e4ffc5842b", @"/Views/Patron/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Patron_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Web.Models.Patron.PatronDetailModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container"">
    <div class=""header clearfix detailHeading"">
        <h2 class=""text-muted"">Patron Information</h2>
    </div>

    <div class=""jumbotron"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div>
                    <h2>");
#nullable restore
#line 13 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                    Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"patronContact\">\r\n                        <div id=\"patronTel\">Library Card ID: ");
#nullable restore
#line 15 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                        Write(Model.LibraryCardId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronAddress\">Address: ");
#nullable restore
#line 16 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                    Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronTel\">Telephone: ");
#nullable restore
#line 17 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                  Write(Model.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronDate\">Member Since: ");
#nullable restore
#line 18 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                      Write(Model.MemberSince);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div id=\"patronLibrary\">Home Library: ");
#nullable restore
#line 19 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                         Write(Model.HomeLibrary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 20 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                         if (@Model.OverdueFees > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronHasFees\">Current Fees Due: $");
#nullable restore
#line 22 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                                  Write(Model.OverdueFees);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 23 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div id=\"patronNoFees\">No Fees Currently Due.</div>\r\n");
#nullable restore
#line 27 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently Checked Out</h4>\r\n");
#nullable restore
#line 34 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                 if (@Model.AssetsCheckedOut.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronAssets\">\r\n                        <ul>\r\n");
#nullable restore
#line 38 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                             foreach (var checkout in @Model.AssetsCheckedOut)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
#nullable restore
#line 41 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                               Write(checkout.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - (Library Asset ID: ");
#nullable restore
#line 41 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                                                 Write(checkout.LibraryAsset.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                    <ul>\r\n                                        <li>\r\n                                            Since: ");
#nullable restore
#line 44 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                              Write(checkout.Since);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                        <li>\r\n                                            Due: ");
#nullable restore
#line 47 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                            Write(checkout.Until);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </li>\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 51 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 54 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items currently checked out.</div>\r\n");
#nullable restore
#line 58 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                <h4>Assets Currently On Hold</h4>\r\n");
#nullable restore
#line 64 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                 if (@Model.Holds.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div id=\"patronHolds\">\r\n                        <ul>\r\n");
#nullable restore
#line 68 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                             foreach (var hold in @Model.Holds)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 70 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                               Write(hold.LibraryAsset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Placed ");
#nullable restore
#line 70 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                                                                 Write(hold.HoldPlaced.ToString("yy-dd-MM - HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 71 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </div>\r\n");
#nullable restore
#line 74 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>No items on hold.</div>\r\n");
#nullable restore
#line 78 "D:\VisualStudio Projects\Github\Library\Views\Patron\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Web.Models.Patron.PatronDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
