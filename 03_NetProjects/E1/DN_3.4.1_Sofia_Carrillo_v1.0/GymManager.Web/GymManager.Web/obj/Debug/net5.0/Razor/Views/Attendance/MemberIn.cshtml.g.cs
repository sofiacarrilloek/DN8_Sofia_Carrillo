#pragma checksum "D:\1. PUNTO SINGULAR\Academia\DN_Sofia_Carrillo\03_NetProjects\E1\DN_3.4.1_Sofia_Carrillo_v1.0\GymManager.Web\GymManager.Web\Views\Attendance\MemberIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe69d55ea6a0872dfebee79b638c13ec2ceae252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_MemberIn), @"mvc.1.0.view", @"/Views/Attendance/MemberIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe69d55ea6a0872dfebee79b638c13ec2ceae252", @"/Views/Attendance/MemberIn.cshtml")]
    public class Views_Attendance_MemberIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/EventsModal.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex flex-column h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"en\" class=\"h-100\">\r\n     \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe69d55ea6a0872dfebee79b638c13ec2ceae2523738", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 324, "\"", 334, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""Mark Otto, Jacob Thornton, and Bootstrap contributors"">
    <meta name=""generator"" content=""Hugo 0.88.1"">
    <title>Gym Manager MemberIn</title>

    <link rel=""canonical"" href=""https://getbootstrap.com/docs/5.1/examples/sticky-footer-navbar/"">



    <!-- Bootstrap core CSS -->
    <link rel=""stylesheet"" href=""../Bootstrap/css/bootstrap.min.css""/>
    <!-- Favicons -->

    <meta name=""theme-color"" content=""#7952b3"">


    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            user-select: none;
         
        }

        ");
                WriteLiteral("@media (min-width: 768px) {\r\n            .bd-placeholder-img-lg {\r\n                font-size: 3.5rem;\r\n            }\r\n        }\r\n\r\n        main > .container {\r\n            padding: 60px 15px 0;\r\n        }\r\n    </style>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe69d55ea6a0872dfebee79b638c13ec2ceae2526035", async() => {
                WriteLiteral(@"


    <header>
        <!-- Fixed navbar class=""border border-secondary border-3 rounded-circle -->
        <nav class=""navbar navbar-expand-md navbar-dark fixed-top bg-secondary font-monospace"" >
            <div class=""container-fluid"" >

               <img class=""navbar-brand rounded-circle"" src=""../Bootstrap/Images/GymLogo.jpg""  width=""40px"" height=""50px"" />

                <a class=""navbar-brand"" href=""#"" >Gym Manager</a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarCollapse"">
                    <ul class=""navbar-nav me-auto mb-2 mb-md-0"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
");
                WriteLiteral(@"                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""#"">Link</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled"">Disabled</a>
                        </li>
                    </ul>
                    <form class=""d-flex"">
                        <input class=""form-control me-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <button class=""btn btn-outline-success"" type=""submit"">Search</button>
                    </form>
                </div>
            </div>
        </nav>
    </header>

    <!-- Begin page content -->
    <main class=""flex-shrink-0"">
        <div class=""container"">
            <h1 class=""mt-5"" id=""Title1"">MemberIn</h1>

            <form>
                <div class=""row"">
                        <div class=""col"">
                        <h5 >Id: </h5>
                  ");
                WriteLiteral(@"      </div>
                </div>
                <div class=""row"">
                    <div class=""col col-md-3"">
                        <input id=""InputText"" type=""text"" class=""form-control"" placeholder=""Put your Id here""  >
                    </div>
                    <div class=""col col-md-2"">
                         <button type=""button"" id=""SubmitButton"" class=""btn btn-primary"">Submit</button>
                        
                    </div>

                </div>
            </form>
        
            

                <img src=""../Bootstrap/Images/LogoFundacion.jpg"" />

            <p class=""lead"">Pin a footer to the bottom of the viewport in desktop browsers with this custom HTML and CSS. A fixed navbar has been added with <code class=""small"">padding-top: 60px;</code> on the <code class=""small"">main &gt; .container</code>.</p>
            <p>Back to <a href=""/docs/5.1/examples/sticky-footer/"">the default sticky footer</a> minus the navbar.</p>
            
        </d");
                WriteLiteral(@"iv>
        
    </main>
    
    <!--Modal-->
    <div class=""modal"" tabindex=""-1"" id=""exampleModal"">
      <div class=""modal-dialog"">
        <div class=""modal-content"">
          <div class=""modal-header"">
            <h5 class=""modal-title"">Modal title</h5>
            <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
          </div>
          <div class=""modal-body"" >
            <p id=""MessageModalContent""> Modal body text goes here.</p>
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
            <button type=""button"" class=""btn btn-primary"">Save changes</button>
          </div>
        </div>
      </div>
    </div>

    <footer class=""footer mt-auto py-3 bg-light"">
        <div class=""container"">
            <span class=""text-muted"">Place sticky footer content here.</span>
        </div>
    </footer>


    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe69d55ea6a0872dfebee79b638c13ec2ceae25210634", async() => {
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <script src=\"../Bootstrap/js/bootstrap.bundle.js\"></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
