#pragma checksum "C:\Users\Hussain Imtiaz\source\repos\DBProject\DBProject\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "974bee8f2ed7add23c68679314a9e1996d1c9ff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"974bee8f2ed7add23c68679314a9e1996d1c9ff9", @"/Views/Home/Login.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3847, true);
            WriteLiteral(@"<header a href=""../Home/Index"">
    <a href=""../Home/Index"" />
    TVTrack
</header>

<div class=""login-page"">
    <div class=""form"">
        <form class=""register-form"">
            <input type=""text"" placeholder=""name"" />
            <input type=""password"" placeholder=""password"" />
            <input type=""text"" placeholder=""email address"" />
            <input type=""submit"">
            <p class=""message"">Already registered? <a href=""#"">Sign In</a></p>
        </form>
        <form class=""login-form"" method=""post"">
            <input type=""text"" name=""email"" placeholder=""username"" required />
            <input type=""password"" name=""password"" placeholder=""password"" required />
            <input type=""submit"" id=""submit"">
            <p class=""message"">Not registered? <a href=""..\Home\Signup"">Create an account</a></p>
        </form>
    </div>
</div>

<style>
    header {
        background: #F1584E;
        color: #EF3B3A;
        text-decoration: solid;
        font-size: x-l");
            WriteLiteral(@"arge;
        align-content: center;
    }
    .login-page {
        width: 360px;
        padding: 8% 0 0;
        margin: auto;
    }

    .form {
        position: relative;
        z-index: 1;
        background: #FFFFFF;
        max-width: 360px;
        margin: 0 auto 100px;
        padding: 45px;
        text-align: center;
        box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
    }

        .form input {
            font-family: ""Roboto"", sans-serif;
            outline: 0;
            background: #f2f2f2;
            width: 100%;
            border: 0;
            margin: 0 0 15px;
            padding: 15px;
            box-sizing: border-box;
            font-size: 14px;
        }

    #submit {
        font-family: ""Roboto"", sans-serif;
        text-transform: uppercase;
        outline: 0;
        background: #F1584E;
        width: 100%;
        border: 0;
        padding: 15px;
        color: #FFFFFF;
        font-size: 14px;");
            WriteLiteral(@"
        -webkit-transition: all 0.3 ease;
        transition: all 0.3 ease;
        cursor: pointer;
    }

        #submit:hover, #submit:active, #submit:focus {
            background: #EF3B3A;
        }

    .form .message {
        margin: 15px 0 0;
        color: #F1584E;
        font-size: 12px;
    }

        .form .message a {
            color: #4CAF50;
            text-decoration: none;
        }

    .form .register-form {
        display: none;
    }

    .container {
        position: relative;
        z-index: 1;
        max-width: 300px;
        margin: 0 auto;
    }

        .container:before, .container:after {
            content: """";
            display: block;
            clear: both;
        }

        .container .info {
            margin: 50px auto;
            text-align: center;
        }

            .container .info h1 {
                margin: 0 0 15px;
                padding: 0;
                font-size: 36px;
                font-");
            WriteLiteral(@"weight: 300;
                color: #1a1a1a;
            }

            .container .info span {
                color: #4d4d4d;
                font-size: 12px;
            }

                .container .info span a {
                    color: #000000;
                    text-decoration: none;
                }

                .container .info span .fa {
                    color: #EF3B3A;
                }

    body {
        background: #F1584E;
        font-family: ""Roboto"", sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
    }
</style>
<script>
    $('.message a').click(function () {
        $('form').animate({ height: ""toggle"", opacity: ""toggle"" }, ""slow"");
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591