#pragma checksum "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\Song\Song.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a505451095727be836fdfee0d30e52cdf73d4322"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Song_Song), @"mvc.1.0.view", @"/Views/Song/Song.cshtml")]
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
#line 1 "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\_ViewImports.cshtml"
using Spotifive;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\_ViewImports.cshtml"
using Spotifive.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a505451095727be836fdfee0d30e52cdf73d4322", @"/Views/Song/Song.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15dd04377c4d99403807644ff523ddbac309b4ca", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Song_Song : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spotifive.Models.Song>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/moto.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/body.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sgnLogBttn.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/popUp.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("centered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/DetailsDots.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reviews"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Reviews.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ratings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Ratings.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("download"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Download.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Add.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/Edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\Song\Song.cshtml"
  
	ViewData["Title"] = "Song";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a505451095727be836fdfee0d30e52cdf73d432210317", async() => {
                WriteLiteral("\r\n\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a505451095727be836fdfee0d30e52cdf73d432210582", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a505451095727be836fdfee0d30e52cdf73d432211760", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a505451095727be836fdfee0d30e52cdf73d432212938", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a505451095727be836fdfee0d30e52cdf73d432214116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	<link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet'>

	<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
	<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>

	<style>
		.centered {
			position: absolute;
			top: 20px;
			left: 50%;
			height: 40px;
			width: 40px;
		}

		.profile {
			position: absolute;
			top: 60px;
			right: 80px;
			height: 60px;
			width: 60px;
		}

		.reviews {
			position: absolute;
			bottom: 40px;
			left: 50px;
			height: 40px;
			width: 40px;
		}

		.ratings {
			position: absolute;
			bottom: 90px;
			left: 50px;
			height: 40px;
			width: 40px;
		}

		.textReviews {
			position: absolute;
			bottom: 140px;
			left: 30px;
			font-size: 20px;
		}

		.download {
			position: absolute;
			bottom: 80px;
			left: 30%;
			height: 30px;
			width: 30px;
		}

		.textDownload {
			position: absolute;
			bottom: 15px;
			left:");
                WriteLiteral(@" 28%;
			font-size: 20px;
		}

		.previous {
			position: absolute;
			bottom: 80px;
			left: 42%;
			height: 40px;
			width: 40px;
		}

		.playsong {
			position: absolute;
			bottom: 140px;
			left: 20%;
		}

		.next {
			position: absolute;
			bottom: 80px;
			left: 58%;
			height: 40px;
			width: 40px;
		}

		.add {
			position: absolute;
			bottom: 80px;
			left: 70%;
			height: 40px;
			width: 40px;
		}

		.textAdd {
			position: absolute;
			bottom: 15px;
			left: 70%;
			font-size: 20px;
		}

	

		.edit {
			position: absolute;
			bottom: 80px;
			left: 80%;
			height: 30px;
			width: 30px;
		}

		.textEdit {
			position: absolute;
			bottom: 15px;
			left: 80%;
			font-size: 20px;
		}

		.addingToPlaylist {
			position: absolute;
			top: 80px;
			left: 300px;
			opacity: 0.8;
			width: 400px;
			height: 500px;
			background-color: whitesmoke;
			font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on th");
                WriteLiteral(@"e user's system*/
			color: #0b2847;
		}

		.successfulyDownloaded {
			opacity: 0.8;
			width: 230px;
			height: 130px;
			background-color: whitesmoke;
			font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
			color: #0b2847;
		}

		.criticComment {
			opacity: 0.8;
			width: 400px;
			height: 400px;
			background-color: whitesmoke;
			font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
			color: #0b2847;
		}

		.criticRating {
			opacity: 0.8;
			width: 400px;
			height: 400px;
			background-color: whitesmoke;
			font-family: 'Montserrat', sans-serif; /*sans-serif is in case there is no montserrat on the user's system*/
			color: #0b2847;
		}
	</style>

");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a505451095727be836fdfee0d30e52cdf73d432218936", async() => {
                WriteLiteral("\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432219197", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t<a href=\"#criticActions\"  data-toggle=\"modal\">\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432220435", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t</a>\r\n\t<a href=\"#userActions\" data-toggle=\"modal\">\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432221676", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t</a>\r\n\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432222866", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\t<a href=\"#criticActionsRating\" data-toggle=\"modal\">\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432224110", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t</a>\r\n\r\n\t<p class=\"textReviews\">Reviews</p>\r\n\r\n\t<a href=\"#successfulDownload\" data-toggle=\"modal\">\r\n\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432225410", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	</a>

	<p class=""textDownload"">Download</p>
	
		<audio controls style=""width: 70%"" class=""playsong"">
			<source src=""https://drive.google.com/uc?export=download&id=1Q7rgf3clizZtY6_6TKaibBAFrF6mY0sJ"" />
		</audio>


	<a href=""#addToPlaylist"" data-toggle=""modal"">
		");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432226872", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t</a>\r\n\r\n\t<p class=\"textAdd\">Add</p>\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a505451095727be836fdfee0d30e52cdf73d432228098", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_18);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
	<p class=""textEdit"">Edit</p>
	<!--Timestamp dodati dinamicki!!!-->


	<div class=""modal fade"" id=""addToPlaylist"" data-backdrop=""static"" data-keyboard=""false"">
		<div class=""modal-dialog"">
			<div class=""modal-content addingToPlaylist"">
				<style>
					h1 {
						font-size: 22px;
						position: absolute;
						top: 10px;
						left: 20px;
					}

					h2 {
						font-size: 22px;
						position: absolute;
						top: 330px;
						left: 20px;
					}

					.rectangle {
						position: absolute;
						top: 10px;
						left: 0px;
						width: 100%;
						height: 50px;
						background-color: whitesmoke;
					}

					.buttonOK {
						position: absolute;
						bottom: 0px;
						right: 0px;
						font-size: 18px;
						height: 40px;
						width: 110px;
						background-color: whitesmoke;
						color: #0b2847;
						border-color: #0b2847;
						font-weight: bold;
					}

					.buttonCancel {
						position: absolute;
						bottom: 0px;
						right: 110px;
						font");
                WriteLiteral(@"-size: 18px;
						height: 40px;
						width: 110px;
						background-color: whitesmoke;
						color: #0b2847;
						border-color: #0b2847;
					}

					.textbox {
						border-color: #0b2847;
						position: absolute;
						top: 390px;
						left: 60px;
						font-size: 18px;
						height: 40px;
						width: 280px;
					}
				</style>

				<div class=""rectangle""></div>

				<h1>Add to playlist:</h1>

				<h2>Or make a new playlist:</h2>

				<input type=""text"" id=""newPlaylist"" placeholder=""Enter name..."" class=""textbox"">

				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary buttonCancel"" data-dismiss=""modal"">Cancel</button>
				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary buttonOK"" data-dismiss=""modal"">OK</button>
				</div>
			</div>
		</div>
	</div>



	<div class=""modal fade"" id=""successfulDownload"" data-backdrop=""static"" data-keyboard=""false"">
		<div class=""modal-dialog"">
			<div class=""mod");
                WriteLiteral(@"al-content successfulyDownloaded"">
				<style>
					h12 {
						font-size: 22px;
						position: absolute;
						top: 10px;
						left: 43px;
					}

					.rectangle2 {
						position: absolute;
						top: 10px;
						left: 0px;
						width: 100%;
						height: 50px;
						background-color: whitesmoke
					}

					.buttonOK2 {
						position: absolute;
						bottom: 0px;
						right: 0px;
						font-size: 18px;
						height: 40px;
						width: 100%;
						background-color: whitesmoke;
						color: #0b2847;
						border-color: #0b2847;
						font-weight: bold;
					}
				</style>
				<div class=""rectangle2""></div>

				<h12>Downloaded successfully!</h12>

				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary buttonOK2"" data-dismiss=""modal"">OK</button>
				</div>
			</div>
		</div>
	</div>
");
#nullable restore
#line 332 "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\Song\Song.cshtml"
     if (User.IsInRole("Critic"))
	{


#line default
#line hidden
#nullable disable
                WriteLiteral(@"		<div class=""modal fade"" id=""criticActions"" data-backdrop=""static"" data-keyboard=""false"">
			<div class=""modal-dialog"">
				<div class=""modal-content criticComment"">
					<style>
						h13 {
						font-size: 22px;
						position: absolute;
						top: 20px;
						left: 55px;
						}

						.rectangle3 {
						position: absolute;
						top: 10px;
						left: 0px;
						width: 100%;
						height: 50px;
						background-color: #a8b6f0;
						}

						.buttonConfirm {
						position: absolute;
						bottom: 0px;
						right: 0px;
						font-size: 18px;
						height: 40px;
						width: 110px;
						background-color: whitesmoke;
						color: #0b2847;
						border-color: #0b2847;
						font-weight: bold;
						}

						.buttonCancel3 {
						position: absolute;
						bottom: 0px;
						right: 110px;
						font-size: 18px;
						height: 40px;
						width: 110px;
						background-color: whitesmoke;
						color: #0b2847;
						border-color: #0b2847;
						}

						.textbox3 ");
                WriteLiteral(@"{
						border-color: #0b2847;
						position: absolute;
						top: 70px;
						left: 50px;
						font-size: 18px;
						height: 280px;
						width: 290px;
						}
					</style>
					<div class=""rectangle3"">	</div>
					<h13>You are logged in as Critic</h13>


					<input type=""text"" id=""newComment"" placeholder=""Add comment..."" class=""textbox3"">

					<div class=""modal-footer"">
						<button type=""button"" class=""btn btn-secondary buttonCancel3"" data-dismiss=""modal"">Cancel</button>
					</div>
					<div class=""modal-footer"">
						<button type=""button"" class=""btn btn-secondary buttonConfirm"" data-dismiss=""modal"">Confirm</button>
					</div>
				</div>
			</div>
		</div>
");
#nullable restore
#line 405 "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\Song\Song.cshtml"
	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 406 "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\Song\Song.cshtml"
     if(User.IsInRole("Registered user"))
	{

#line default
#line hidden
#nullable disable
                WriteLiteral(@"		<div class=""modal fade"" id=""userActions"" data-backdrop=""static"" data-keyboard=""false"">
			<div class=""modal-dialog"">
				<div class=""modal-content criticComment"">
					<style>
						h13 {
							font-size: 22px;
							position: absolute;
							top: 20px;
							left: 55px;
						}

						.rectangle3 {
							position: absolute;
							top: 10px;
							left: 0px;
							width: 100%;
							height: 50px;
							background-color: #a8b6f0;
						}

						.buttonConfirm {
							position: absolute;
							bottom: 0px;
							right: 0px;
							font-size: 18px;
							height: 40px;
							width: 110px;
							background-color: whitesmoke;
							color: #0b2847;
							border-color: #0b2847;
							font-weight: bold;
						}

						.buttonCancel3 {
							position: absolute;
							bottom: 0px;
							right: 110px;
							font-size: 18px;
							height: 40px;
							width: 110px;
							background-color: whitesmoke;
							color: #0b2847;
							border-color: #0b2847;
");
                WriteLiteral(@"						}

						.textbox3 {
							border-color: #0b2847;
							position: absolute;
							top: 70px;
							left: 50px;
							font-size: 18px;
							height: 280px;
							width: 290px;
						}
					</style>
					<div class=""rectangle3"">	</div>
					<h13>You are logged in as Critic</h13>


					<input type=""text"" id=""newComment"" placeholder=""Add comment..."" class=""textbox3"">

					<div class=""modal-footer"">
						<button type=""button"" class=""btn btn-secondary buttonCancel3"" data-dismiss=""modal"">Cancel</button>
					</div>
					<div class=""modal-footer"">
						<button type=""button"" class=""btn btn-secondary buttonConfirm"" data-dismiss=""modal"">Confirm</button>
					</div>
				</div>
			</div>
		</div>
");
#nullable restore
#line 478 "C:\Users\x\source\repos\ProjekatOOADv9.0\Spotifive\Views\Song\Song.cshtml"
		
	}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"	<div class=""modal fade"" id=""criticActionsRating"" data-backdrop=""static"" data-keyboard=""false"">
		<div class=""modal-dialog"">
			<div class=""modal-content criticComment"">
				<style>
					h13 {
						font-size: 22px;
						position: absolute;
						top: 20px;
						left: 55px;
					}

					.rectangle3 {
						position: absolute;
						top: 10px;
						left: 0px;
						width: 100%;
						height: 50px;
						background-color: #a8b6f0;
					}

					.buttonConfirm {
						position: absolute;
						bottom: 0px;
						right: 0px;
						font-size: 18px;
						height: 40px;
						width: 110px;
						background-color: whitesmoke;
						color: #0b2847;
						border-color: #0b2847;
						font-weight: bold;
					}

					.buttonCancel3 {
						position: absolute;
						bottom: 0px;
						right: 110px;
						font-size: 18px;
						height: 40px;
						width: 110px;
						background-color: whitesmoke;
						color: #0b2847;
						border-color: #0b2847;
					}

					.starbar {
					");
                WriteLiteral(@"	border-color: #0b2847;
						position: absolute;
						top: 70px;
						left: 50px;
						font-size: 18px;
						height: 280px;
						width: 290px;
					}

				</style>
				<div class=""rectangle3"">	</div>
				<h13>You are logged in as Critic</h13>


				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary buttonCancel3"" data-dismiss=""modal"">Cancel</button>
				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary buttonConfirm"" data-dismiss=""modal"">Confirm</button>
				</div>
			</div>
		</div>
	</div>






");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spotifive.Models.Song> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
