#pragma checksum "C:\Users\Lenovo\source\repos\FrontToBack\FrontToBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed1b3e567ff85f18b56ae2412c8d111ada6a75e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed1b3e567ff85f18b56ae2412c8d111ada6a75e", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("interval"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/h3-slider-background.jpeg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section id=\"introduce\" class=\"col-lg-12 col-sm-12 col-12\">\r\n        <div class=\"images\">\r\n\r\n            <i class=\"fas fa-chevron-right clickright\"></i>\r\n            <i class=\"fas fa-chevron-left clickleft\"></i>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9ed1b3e567ff85f18b56ae2412c8d111ada6a75e4098", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""flowersInfo"">
            <div class=""title"">
                <div class=""st"">
                    <span>Send</span><span>flowers</span><span>like</span>
                </div>
                <div class=""nd"">
                    <span>you mean it.</span>
                </div>
            </div>
            <div class=""desc"">
                <p>
                    Lorem ipsum dolor sit, amet consectetur adipisicing elit. Mollitia rerum beatae totam sunt
                    excepturi voluptatum maiores non ex et officia?
                </p>
            </div>
            <div class=""sign"">
                <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h2-sign-img.png""");
            BeginWriteAttribute("alt", " alt=\"", 1107, "\"", 1113, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </div>
        </div>
    </section>
    <section id=""products"">
        <div class=""container"">
            <div class=""row"">
                <div class=""filters-filterbtn d-flex justify-content-between"">
                    <div class=""mdfilters"">
                        <span id=""mdcategory"" style=""cursor: pointer;
                            font-size: 12px;
                            letter-spacing: 2px;
                            transition: 0.2s;"">CATEGORY</span><i style=""font-size: 12px;""
                                                                 class=""fas fa-chevron-down""></i>
                        <div class=""mdcategories"" style=""max-width:min-content;"">
                            <span id=""firstfilter"" data-id=""all"">ALL</span>
                            <span data-id=""popular"">POPULAR</span>
                            <span data-id=""winter"">WINTER</span>
                            <span data-id=""various"">VARIOUS</span>
                            <spa");
            WriteLiteral(@"n data-id=""exotic"">EXOTIC</span>
                            <span data-id=""greens"">GREENS</span>
                            <span data-id=""cactuses"">CACTUSES</span>

                        </div>
                    </div>
                    <div class=""filters col-lg-10  "">
                        <span id=""firstfilter"" data-id=""all"">ALL</span>
                        <span data-id=""popular"" style=""margin-left: 20px;"">POPULAR</span>
                        <span data-id=""winter"" style=""margin-left: 20px;"">WINTER</span>
                        <span data-id=""various"" style=""margin-left: 20px;"">VARIOUS</span>
                        <span data-id=""exotic"" style=""margin-left: 20px;"">EXOTIC</span>
                        <span data-id=""greens"" style=""margin-left: 20px;"">GREENS</span>
                        <span data-id=""cactuses"" style=""margin-left: 20px;"">CACTUSES</span>

                    </div>
                    <div class=""filterbtn col-lg-2 d-flex justify-content-end"">
           ");
            WriteLiteral(@"             <span id=""mdfilterbtn"">FILTER</span><span><i class=""fas fa-chevron-down""></i></span>
                        <div class=""mdfilterLists"" style=""max-width:max-content;max-height: max-content;"">
                            <div class=""sortby"">
                                <h4>Sort By</h4>
                                <ul>
                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3549, "\"", 3556, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3618, "\"", 3625, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3690, "\"", 3697, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3759, "\"", 3766, 0);
            EndWriteAttribute();
            WriteLiteral(">Price : low to higher</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 3842, "\"", 3849, 0);
            EndWriteAttribute();
            WriteLiteral(@">Price : high to lower</a></li>
                                </ul>
                            </div>
                            <div class=""pricerange"">
                                <h4>Price range</h4>
                                <ul>
                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4146, "\"", 4153, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4211, "\"", 4218, 0);
            EndWriteAttribute();
            WriteLiteral(">$0 - $10</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4281, "\"", 4288, 0);
            EndWriteAttribute();
            WriteLiteral(">$10 - $20</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4352, "\"", 4359, 0);
            EndWriteAttribute();
            WriteLiteral(">$20 - $30</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4423, "\"", 4430, 0);
            EndWriteAttribute();
            WriteLiteral(">$30 - $40</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4494, "\"", 4501, 0);
            EndWriteAttribute();
            WriteLiteral(@">$40+</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""filterLists"">
                            <div class=""sortby"">
                                <h4>Sort By</h4>
                                <ul>
                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4856, "\"", 4863, 0);
            EndWriteAttribute();
            WriteLiteral(">Default</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4925, "\"", 4932, 0);
            EndWriteAttribute();
            WriteLiteral(">Popularity</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 4997, "\"", 5004, 0);
            EndWriteAttribute();
            WriteLiteral(">Newness</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5066, "\"", 5073, 0);
            EndWriteAttribute();
            WriteLiteral(">Price : low to higher</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5149, "\"", 5156, 0);
            EndWriteAttribute();
            WriteLiteral(@">Price : high to lower</a></li>
                                </ul>
                            </div>
                            <div class=""pricerange"">
                                <h4>Price range</h4>
                                <ul>
                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5453, "\"", 5460, 0);
            EndWriteAttribute();
            WriteLiteral(">All</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5518, "\"", 5525, 0);
            EndWriteAttribute();
            WriteLiteral(">$0 - $10</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5588, "\"", 5595, 0);
            EndWriteAttribute();
            WriteLiteral(">$10 - $20</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5659, "\"", 5666, 0);
            EndWriteAttribute();
            WriteLiteral(">$20 - $30</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5730, "\"", 5737, 0);
            EndWriteAttribute();
            WriteLiteral(">$30 - $40</a></li>\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 5801, "\"", 5808, 0);
            EndWriteAttribute();
            WriteLiteral(@">$40+</a></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div data-aos-offset=""100""
                     class=""product col-lg-3 col-md-6 popular winter all"">
                    <div class=""productImage"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-14-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 6266, "\"", 6302, 0);
            EndWriteAttribute();
            WriteLiteral(@">

                    </div>
                    <div class=""productTitle"">
                        <p>MAJESTY PALM</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""1"">Add to cart</span><span>$</span><span>259</span>
                    </div>
                    <div class=""addToCart"">

                    </div>

                </div>

                <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular winter various all"">
                    <div class=""productImage"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-13-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 7017, "\"", 7053, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""productTitle"">
                        <p>FOXGLOW FLOWER</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""2"">Add to cart</span> <span>$</span><span>259</span>
                    </div>
                    <div class=""addToCart"">

                    </div>
                </div>

                <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular winter all"">
                    <div class=""productImage"">
                        <img src="" https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/shop-10-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 7760, "\"", 7796, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""badge badge-dark bg-dark position-absolute""
                              style="" top:3%;left: 8%;transform: scale(1.3);"">SOLD</span>
                    </div>
                    <div class=""productTitle"">
                        <p>SWEET ALYYSUM</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""3"">Add to cart</span> <span>$</span><span>259</span>
                    </div>
                    <div class=""addToCart"">

                    </div>
                </div>

                <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular all"">
                    <div class=""productImage"">
                        <img src=""   https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-11-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 8670, "\"", 8706, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""productTitle"">
                        <p>SPRING SNOWFLAKE</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""4"">Add to cart</span> <span>$</span><span>170</span>
                    </div>
                    <div class=""addToCart"">

                    </div>
                </div>

                <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 popular various all"">
                    <div class=""productImage"">
                        <img src="" https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-12-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 9416, "\"", 9452, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""badge text-dark bg-light position-absolute""
                              style=""top:3%;left: 8%; transform: scale(1.3);"">SALE</span>
                    </div>
                    <div class=""productTitle"">
                        <p>SCARLET SAGE</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""5"">Add to cart</span> <span style=""text-decoration: line-through;"">$259</span>
                        <span>$</span><span>170</span>
                    </div>
                    <div class=""addToCart"">

                    </div>
                </div>

                <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 various cactuses all"">
                    <div class=""productImage"">
                        <img src="" https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-9-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 10413, "\"", 10449, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""productTitle"">
                        <p>ROCK SOAPWORT</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""6"">Add to cart</span> <span>$</span><span>259</span>
                    </div>
                    <div class=""addToCart"">

                    </div>
                </div>

                <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 greens all"">
                    <div class=""productImage"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-8-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 11145, "\"", 11181, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""productTitle"">
                        <p>SUMMER SAVORY</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""7"">Add to cart</span> <span>$</span><span>259</span>
                    </div>
                    <div class=""addToCart"">

                    </div>
                </div>

                <div data-aos-offset=""100"" class=""product col-lg-3 col-md-6 exotic all"">
                    <div class=""productImage"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/shop-7-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 11877, "\"", 11913, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""productTitle"">
                        <p>WILD ROSES</p>
                    </div>
                    <div class=""productPrice"">
                        <span class=""addToCardBtn"" data-id=""8"">Add to cart</span> <span>$</span><span>259</span>
                    </div>
                    <div class=""addToCart"">

                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""valentine"">
        <div class=""container"">
            <div class=""row"">
                <div data-aos=""zoom-in-up"" data-aos-duration=""1000"" class=""valentineVideo col-lg-6"">
                    <div class=""videoImage "">
                        <img style=""width: 100%;""
                             src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-video-img.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 12816, "\"", 12852, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fas fa-play""></i>
                    </div>
                </div>
                <div class=""valentineTexts col-lg-6"">
                    <div class=""title"">
                        <h1>Surprise Your <span style=""color: red;"">Valentine!</span></h1>
                        <h1>Let us arrange a smile.</h1>
                    </div>
                    <div class=""desc"">
                        <p>
                            Where flowers are our inspiration to create lasting memories. Whatever the occasion...

                        </p>
                    </div>
                    <div class=""icondescs"">
                        <div class=""first"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 13665, "\"", 13705, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span>
                                Hand picked just for you.
                            </span>
                        </div>
                        <div class=""sec"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 14007, "\"", 14047, 0);
            EndWriteAttribute();
            WriteLiteral("><span>Unique flower arrangements</span>\r\n                        </div>\r\n                        <div class=\"third\">\r\n\r\n                            <img src=\"https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h1-custom-icon.png\"");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 14290, "\"", 14330, 0);
            EndWriteAttribute();
            WriteLiteral(@"><span>Best way to say you care.</span>
                        </div>


                    </div>
                </div>
            </div>
        </div>

    </section>

    <section id=""flowerexperts"">
        <div class=""container"">
            <div class=""info col-lg-12"">
                <div class=""title"">
                    <h1>Flower Experts</h1>
                </div>
                <div class=""desc"">
                    <p>
                        Flower Experts
                        A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a
                        smile for you.
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""experts"">
                    <div class=""expert col-md-6 col-12 col-lg-3"">
                        <div class=""photo"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-1");
            WriteLiteral(".png\"");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 15360, "\"", 15400, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""name"">
                            <p>CRYSTAL BROOKS</p>
                        </div>
                        <div class=""job"">
                            <p>Florist</p>
                        </div>
                    </div>
                    <div class=""expert col-md-6 col-12 col-lg-3"">
                        <div class=""photo"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-team-img-2.png""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 15942, "\"", 15982, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""name"">
                            <p>SHIRLEY HARRIS</p>
                        </div>
                        <div class=""job"">
                            <p>Manager</p>
                        </div>
                    </div>
                    <div class=""expert col-md-6 col-12 col-lg-3"">
                        <div class=""photo"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-3.png""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 16524, "\"", 16564, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""name"">
                            <p>
                                BEVERLY CLARK
                            </p>
                        </div>
                        <div class=""job"">
                            <p>Florist</p>
                        </div>
                    </div>
                    <div class=""expert col-md-6 col-12 col-lg-3"">
                        <div class=""photo"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-4.png""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 17169, "\"", 17209, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""name"">
                            <p>AMANDA WATKINS</p>
                        </div>
                        <div class=""job"">
                            <p>Florist</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section id=""subscribe"">

        <div class=""parallax-window"" data-parallax=""scroll""
             data-image-src=""  https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/h3-background-img.jpg"">

            <div class=""container"">
                <div class=""title col-lg-12 col-12 col-md-12"">
                    <h1>Join The Colorful Bunch!</h1>
                </div>
                <div class=""subs col-lg-12 col-12 col-md-12"">
                    <input type=""email"">
                    <button>SUBSCRIBE</button>
                </div>

            </div>
        </div>



    </section>

   ");
            WriteLiteral(@" <section id=""blogs"">
        <div class=""container"">
            <div class=""info col-lg-12"">
                <div class=""title"">
                    <h1>Form our blog</h1>
                </div>
                <div class=""desc"">
                    <p>
                        Flower Experts
                        A perfect blend of creativity, energy, communication, happiness and love. Let us arrange a
                        smile for you.
                    </p>
                </div>
            </div>
            <div class=""row"">
                <div class=""blog col-lg-4"">
                    <div class=""image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/blog-feature-img-1.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 19002, "\"", 19038, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""badge bg-light text-dark"">03.08.2018</span>
                    </div>
                    <div class=""title"">
                        <h4>Flower Power</h4>
                    </div>
                    <div class=""desc"">
                        <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                    </div>
                </div>
                <div class=""blog col-lg-4"">
                    <div class=""image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-3.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 19671, "\"", 19707, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""badge bg-light text-dark"">03.08.2018</span>
                    </div>
                    <div class=""title"">
                        <h4>Local florists</h4>
                    </div>
                    <div class=""desc"">
                        <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                    </div>
                </div>
                <div class=""blog col-lg-4"">
                    <div class=""image"">
                        <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/05/blog-feature-img-4.jpg""");
            BeginWriteAttribute("alt", "\r\n                             alt=\"", 20342, "\"", 20378, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""badge bg-light text-dark"">03.08.2018</span>
                    </div>
                    <div class=""title"">
                        <h4>Flower beauty</h4>
                    </div>
                    <div class=""desc"">
                        <p>Class aptent taciti sociosqu ad litora torquent per conubia nostra, per</p>
                    </div>
                </div>
            </div>
        </div>


    </section>

    <section id=""slideimages"">
        <div class=""container"">
            <div class=""owl-carousel owl-theme"">
                <div class=""item"">
                    <div class=""expert col-md-6 col-12 col-lg-7"">
                        <div class=""photo"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-4.png""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 21246, "\"", 21286, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""title"">
                            <h3>
                                Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos magnam deleniti neque?
                            </h3>
                        </div>
                        <div class=""name"">
                            <p>AMANDA WATKINS</p>
                        </div>
                        <div class=""job"">
                            <p>Florist</p>
                        </div>
                    </div>
                </div>
                <div class=""item"">
                    <div class=""expert col-md-6 col-12 col-lg-7"">
                        <div class=""photo"">
                            <img src=""https://fiorello.qodeinteractive.com/wp-content/uploads/2018/04/h3-team-img-3.png""");
            BeginWriteAttribute("alt", "\r\n                                 alt=\"", 22152, "\"", 22192, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""title"">
                            <h3>
                                Lorem ipsum dolor sit amet consectetur adipisicing elit. Minima dolorum obcaecati
                                ratione.
                            </h3>
                        </div>
                        <div class=""name"">
                            <p>
                                BEVERLY CLARK
                            </p>
                        </div>
                        <div class=""job"">
                            <p>Florist</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

");
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