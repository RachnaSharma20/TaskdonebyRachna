#pragma checksum "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0c7cd3caddab4ddb2b3593bd811e702a96fba40f1619e0280fa1837c8a6943b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserSave), @"mvc.1.0.view", @"/Views/User/UserSave.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0c7cd3caddab4ddb2b3593bd811e702a96fba40f1619e0280fa1837c8a6943b2", @"/Views/User/UserSave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"74552029520681211639b34e2be28890c2d2b192f172d9a9c608452d85bead7d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_UserSave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
  
    Layout = "_NewLayout";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h2>Add User</h2>\r\n");
#nullable restore
#line 7 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
 if (ViewBag.Messages != null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"alert-success\">\r\n        ");
            Write(
#nullable restore
#line 10 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
         ViewBag.Message.ToString()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
}

#line default
#line hidden
#nullable disable

#nullable restore
#line 13 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
 using (Html.BeginForm("UserSave", "User", FormMethod.Post))
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group col col-4\">\r\n            <label for=\"email\">Name:</label>\r\n            ");
            Write(
#nullable restore
#line 18 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
             Html.TextBox("Name", null, new { @class = "form-control", @placeholder="Please Enter Name"})

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 19 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
             Html.ValidationMessage("Name")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col col-4\">\r\n            <label>Email:</label>\r\n            ");
            Write(
#nullable restore
#line 23 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
             Html.TextBox("Email", null, new { @class = "form-control", type = "email", @placeholder = "Please Enter Email" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 24 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
             Html.ValidationMessage("Email")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group col col-4\">\r\n            <label>Password:</label>\r\n            ");
            Write(
#nullable restore
#line 28 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
             Html.Password("Password", null, new { @class = "form-control", @placeholder = "Please Enter Password" })

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n            ");
            Write(
#nullable restore
#line 29 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
             Html.ValidationMessage("Password")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\" style=\"float:right;\">\r\n        <button type=\"submit\" class=\"btn btn-primary\" >Submit</button>\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
        
    
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n\r\n<div id=\"userListContainer\">\r\n    ");
            Write(
#nullable restore
#line 42 "C:\Users\rachn\Source\Repos\EmployeeManagement\EmployeeManagement\Views\User\UserSave.cshtml"
     await Html.PartialAsync("_UserList", ViewData["users"] as List<UserModel>)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
