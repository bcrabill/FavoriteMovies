#pragma checksum "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Projects\FavoriteMovies\Views\MovieDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2699dc613d1f4474ca5d29949ec5419a06242585"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MovieDetails), @"mvc.1.0.view", @"/Views/MovieDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MovieDetails.cshtml", typeof(AspNetCore.Views_MovieDetails))]
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
#line 1 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Projects\FavoriteMovies\Views\_ViewImports.cshtml"
using FavoriteMovies;

#line default
#line hidden
#line 2 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Projects\FavoriteMovies\Views\_ViewImports.cshtml"
using FavoriteMovies.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2699dc613d1f4474ca5d29949ec5419a06242585", @"/Views/MovieDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab2990090e9517127530ae4cc83f6412a360b80", @"/Views/_ViewImports.cshtml")]
    public class Views_MovieDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FavoriteMovies.Models.Movie>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 20, true);
            WriteLiteral("\r\n<html>\r\n    \r\n    ");
            EndContext();
            BeginContext(56, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2699dc613d1f4474ca5d29949ec5419a062425853419", async() => {
                BeginContext(62, 142, true);
                WriteLiteral("\r\n        <link rel=\"stylesheet\" href=\"site.css\" type =\"text/css\">\r\n        <meta charset=\'utf-8\'>\r\n        <title>Movie Details</title>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(211, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(217, 334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2699dc613d1f4474ca5d29949ec5419a062425854759", async() => {
                BeginContext(223, 140, true);
                WriteLiteral("\r\n        <div class = movieDetails>\r\n        <h1>Welcome to the Favorite Movie collector Details Page</h1>\r\n        \r\n        <h2>Title is ");
                EndContext();
                BeginContext(364, 11, false);
#line 14 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Projects\FavoriteMovies\Views\MovieDetails.cshtml"
                Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(375, 28, true);
                WriteLiteral("</h2>\r\n        <h2>Starring ");
                EndContext();
                BeginContext(404, 11, false);
#line 15 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Projects\FavoriteMovies\Views\MovieDetails.cshtml"
                Write(Model.Actor);

#line default
#line hidden
                EndContext();
                BeginContext(415, 26, true);
                WriteLiteral("</h2>\r\n        <img src = ");
                EndContext();
                BeginContext(442, 12, false);
#line 16 "C:\Users\Bryan\Desktop\Coding_Dojo\C Sharp\Projects\FavoriteMovies\Views\MovieDetails.cshtml"
              Write(Model.Poster);

#line default
#line hidden
                EndContext();
                BeginContext(454, 90, true);
                WriteLiteral(" alt =\"movie poster\">\r\n        <p>Is this the correct movie?</p>\r\n        </div>\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FavoriteMovies.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
