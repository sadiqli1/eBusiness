#pragma checksum "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e64fc2d12df16cf4d48d135357fb8d6524c44e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 3 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\_ViewImports.cshtml"
using eBusiness2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\_ViewImports.cshtml"
using eBusiness2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e64fc2d12df16cf4d48d135357fb8d6524c44e0", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70f185f69e5ed894811a72fbbf35463f7a35b01b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ready-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <main id=""main"">

    <!-- ======= Blog Header ======= -->
    <div class=""header-bg page-area"">
      <div class=""container position-relative"">
        <div class=""row"">
          <div class=""col-md-12 col-sm-12 col-xs-12"">
            <div class=""slider-content text-center"">
              <div class=""header-bottom"">
                <div class=""layer2"">
                  <h1 class=""title2"">My Blog</h1>
                </div>
                <div class=""layer3"">
                  <h2 class=""title3"">Profesional Blog Page</h2>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div><!-- End Blog Header -->

    <!-- ======= Blog Page ======= -->
    <div class=""blog-page area-padding"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-lg-4 col-md-4"">
            <div class=""page-head-blog"">
              <div class=""single-blog-page"">
                <!-- search option start -->
       ");
            WriteLiteral("         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e64fc2d12df16cf4d48d135357fb8d6524c44e05939", async() => {
                WriteLiteral(@"
                  <div class=""search-option"">
                    <input type=""text"" placeholder=""Search..."">
                    <button class=""button"" type=""submit"">
                      <i class=""bi bi-search""></i>
                    </button>
                  </div>
                ");
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
            WriteLiteral(@"
                <!-- search option end -->
              </div>
              <div class=""single-blog-page"">
                <!-- recent start -->
                <div class=""left-blog"">
                  <h4>recent post</h4>
                  <div class=""recent-post"">
                    <!-- start single post -->
                    <div class=""recent-single-post"">
                      <div class=""post-img"">
                        <a href=""#"">
                          <img src=""assets/img/blog/1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1938, "\"", 1944, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                      </div>
                      <div class=""pst-content"">
                        <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                      </div>
                    </div>
                    <!-- End single post -->
                    <!-- start single post -->
                    <div class=""recent-single-post"">
                      <div class=""post-img"">
                        <a href=""#"">
                          <img src=""assets/img/blog/2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2502, "\"", 2508, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                      </div>
                      <div class=""pst-content"">
                        <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                      </div>
                    </div>
                    <!-- End single post -->
                    <!-- start single post -->
                    <div class=""recent-single-post"">
                      <div class=""post-img"">
                        <a href=""#"">
                          <img src=""assets/img/blog/3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3066, "\"", 3072, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                      </div>
                      <div class=""pst-content"">
                        <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                      </div>
                    </div>
                    <!-- End single post -->
                    <!-- start single post -->
                    <div class=""recent-single-post"">
                      <div class=""post-img"">
                        <a href=""#"">
                          <img src=""assets/img/blog/4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3630, "\"", 3636, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                      </div>
                      <div class=""pst-content"">
                        <p><a href=""#""> Redug Lerse dolor sit amet consect adipis elit.</a></p>
                      </div>
                    </div>
                    <!-- End single post -->
                  </div>
                </div>
                <!-- recent end -->
              </div>
              <div class=""single-blog-page"">
                <div class=""left-blog"">
                  <h4>categories</h4>
                  <ul>
                    <li>
                      <a href=""#"">Portfolio</a>
                    </li>
                    <li>
                      <a href=""#"">Project</a>
                    </li>
                    <li>
                      <a href=""#"">Design</a>
                    </li>
                    <li>
                      <a href=""#"">wordpress</a>
                    </li>
                    <li>
                      <");
            WriteLiteral(@"a href=""#"">Joomla</a>
                    </li>
                    <li>
                      <a href=""#"">Html</a>
                    </li>
                    <li>
                      <a href=""#"">Website</a>
                    </li>
                  </ul>
                </div>
              </div>
              <div class=""single-blog-page"">
                <div class=""left-blog"">
                  <h4>archive</h4>
                  <ul>
                    <li>
                      <a href=""#"">07 July 2016</a>
                    </li>
                    <li>
                      <a href=""#"">29 June 2016</a>
                    </li>
                    <li>
                      <a href=""#"">13 May 2016</a>
                    </li>
                    <li>
                      <a href=""#"">20 March 2016</a>
                    </li>
                    <li>
                      <a href=""#"">09 Fabruary 2016</a>
                    </li>
                  </ul>
     ");
            WriteLiteral(@"           </div>
              </div>
              <div class=""single-blog-page"">
                <div class=""left-tags blog-tags"">
                  <div class=""popular-tag left-side-tags left-blog"">
                    <h4>popular tags</h4>
                    <ul>
                      <li>
                        <a href=""#"">Portfolio</a>
                      </li>
                      <li>
                        <a href=""#"">Project</a>
                      </li>
                      <li>
                        <a href=""#"">Design</a>
                      </li>
                      <li>
                        <a href=""#"">Website</a>
                      </li>
                      <li>
                        <a href=""#"">Joomla</a>
                      </li>
                      <li>
                        <a href=""#"">Html</a>
                      </li>
                      <li>
                        <a href=""#"">wordpress</a>
                      </li>
      ");
            WriteLiteral(@"                <li>
                        <a href=""#"">Masonry</a>
                      </li>
                    </ul>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <!-- End left sidebar -->
          <!-- Start single blog -->
          <div class=""col-md-8 col-sm-8 col-xs-12"">
            <div class=""row"">
");
#nullable restore
#line 192 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
               foreach (Blog blog in Model)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <div class=\"col-md-12 col-sm-12 col-xs-12\">\r\n                <div class=\"single-blog\">\r\n                  <div class=\"single-blog-img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e64fc2d12df16cf4d48d135357fb8d6524c44e014418", async() => {
                WriteLiteral("\r\n                      <img");
                BeginWriteAttribute("src", " src=\"", 7441, "\"", 7474, 2);
                WriteAttributeValue("", 7447, "assets/img/blog/", 7447, 16, true);
#nullable restore
#line 198 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
WriteAttributeValue("", 7463, blog.Image, 7463, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 7475, "\"", 7481, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 197 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
                                                                         WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n                  <div class=\"blog-meta\">\r\n                    <span class=\"comments-type\">\r\n                      <i class=\"bi bi-chat\"></i>\r\n                      <a href=\"#\">");
#nullable restore
#line 204 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
                              Write(@blog.Comments.Count()==0 ? "No Comment" : @blog.Comments.Count()+"comments");

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </span>\r\n                    <span class=\"date-type\">\r\n                      <i class=\"bi bi-calendar\"></i>");
#nullable restore
#line 207 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
                                               Write(blog.Date.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                  </div>\r\n                  <div class=\"blog-text\">\r\n                    <h4>\r\n                      <a href=\"#\">");
#nullable restore
#line 212 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
                             Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h4>\r\n                    <p>\r\n                        ");
#nullable restore
#line 215 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
                   Write(blog.Desc.Substring(0, 300));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                    </p>\r\n                  </div>\r\n                  <span>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e64fc2d12df16cf4d48d135357fb8d6524c44e019220", async() => {
                WriteLiteral("Read more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 219 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
                                                                         WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </span>\r\n                </div>\r\n              </div>\n");
#nullable restore
#line 223 "C:\Users\isasa\Desktop\BackEnd\eBusiness2\eBusiness2\Views\Blog\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              <div class=""blog-pagination"">
                <ul class=""pagination"">
                  <li class=""page-item""><a href=""#"" class=""page-link"">&lt;</a></li>
                  <li class=""page-item active""><a href=""#"" class=""page-link"">1</a></li>
                  <li class=""page-item""><a href=""#"" class=""page-link"">2</a></li>
                  <li class=""page-item""><a href=""#"" class=""page-link"">3</a></li>
                  <li class=""page-item""><a href=""#"" class=""page-link"">&gt;</a></li>
                </ul>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div><!-- End Blog Page -->

  </main><!-- End #main -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591