#pragma checksum "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6620a9dfad61c8a2141f9d281fa58ce43411ceb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_CreateContact), @"mvc.1.0.view", @"/Views/Contact/CreateContact.cshtml")]
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
#line 1 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\_ViewImports.cshtml"
using ContactManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\_ViewImports.cshtml"
using ContactManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6620a9dfad61c8a2141f9d281fa58ce43411ceb8", @"/Views/Contact/CreateContact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8dced1fc9f73dcb9697cb2283dc2700ac4debe6", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_CreateContact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactManager.Models.Contact>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
  
    ViewData["Title"] = "Create Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
Write(Html.ValidationSummary(true, "",new {  @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
   Write(Html.LabelFor(model => model.Company, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
       Write(Html.EditorFor(model => model.Company, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
       Write(Html.ValidationMessageFor(model => model.Company, "Contact must have company name.", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 22 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
   Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
       Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
       Write(Html.ValidationMessageFor(model => model.Name, "Contact must have a name.", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 29 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
   Write(Html.LabelFor(model => model.PhoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
       Write(Html.EditorFor(model => model.PhoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
       Write(Html.ValidationMessageFor(model => model.PhoneNumber, "Contact must have a phone number.", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 36 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
   Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 48 "C:\Users\HP\OneDrive\Documents\ContactManagerProgramAssignment\ContactManager\ContactManager\Views\Contact\CreateContact.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactManager.Models.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
