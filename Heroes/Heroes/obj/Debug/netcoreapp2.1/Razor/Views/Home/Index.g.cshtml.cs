#pragma checksum "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2bd4be1dd0ee8589188c5c2ad07886c6acd5250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\_ViewImports.cshtml"
using Heroes;

#line default
#line hidden
#line 2 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\_ViewImports.cshtml"
using Heroes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2bd4be1dd0ee8589188c5c2ad07886c6acd5250", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94977f6c8204da2c8090b159a38ace68a4b9a81a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Heroes.Models.Hero>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 7121, true);
            WriteLiteral(@"


<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>


<style type=""text/css"">
    body {
        background: #392091;
    }

    #fundo-apresentacao-herois {
        background-color: #0e0b16;
    }

    .contorno {
        border-radius: 3px;
        background-color: #1a1724;
        padding: 15px 0 5px 0;
        margin: 10px 0 10px 0;
        font-size: 10px;
        color: #e7dfdd;
    }

    .p-descricao-herois {
        margin: 7px 0 0 0;
    }

    .img-apresentacao-herois {
        max-width: 175px;
        max-height: 230px;
        border-radius: 3px;
        width: 70%;
    }

    .botao-detalhe-heroi {
        width: 63%;
        height: 30px;
        padding: 0;
        margin-top: 10px;
        background: #1a1724;
        ");
            WriteLiteral(@"border: #4717f6 solid;
        color: #e7dfdd;
    }

        .botao-detalhe-heroi:hover {
            background: #4717f6;
            border: #4717f6 solid;
            color: #e7dfdd;
        }

    /*  selecao personagens */
    .background-herois-selecao {
        width: 100%;
        height: 117px;
        background-position: center;
        background-size: cover;
        background-repeat: no-repeat;
        margin: 30px 0 0 0;
        border-radius: 3px;
        transition: .2s ease;
        border: solid #e7dfdd 1px;
        opacity: 0.8;
    }

        .background-herois-selecao:hover {
            border: solid #e7dfdd 2px;
            opacity: 1;
        }

    .padding-col-heroi-selecao {
        padding-right: 15px;
        padding-left: 15px;
    }

    .marg-row-correcao {
        margin-bottom: 40px;
    }

    .texto-informativo {
        display: none;
    }

    .campeao {
    color: #a239ca;
    font-size: 21px;
    font-weight: 800;
    mar");
            WriteLiteral(@"gin: 0px;
    padding: 0;
    text-align: center;
    }

    .perdedor {
    color: #7e7876;
    font-size: 21px;
    font-weight: 800;
    margin: 0px;
    padding: 0;
    text-align: center;
    }

    .contorno-1{
        border: 3px solid;
        border-color: #353036;  /*#e7dfdd;*/ 
    }
    .contorno-2{
        border: 5px solid;
        border-color: #a239ca;
    }
    .contorno-0 {
        border: 3px solid;
        border-color: #e7dfdd; 
    }

    .img-vencedor {
    width: 50px;
    }
    .img-perdedor {
        margin-right: 11px;
        width: 32px;
        margin-top: 9px;
    }
    .div-btn-p {
        padding: 0;
    }
    #perdedor1 {
        display:none;
    }
    #campeao1 {
        display:none;
    }
    #perdedor2 {
        display:none;
    }
    #campeao2 {
        display:none;
    }
    #btn-fig {
    margin-top: 80px;
    }
    #img-vs {
    width: 60px;
    margin-top: 140px;
    }



</style>










<di");
            WriteLiteral(@"v id=""fundo-apresentacao-herois"" class=""text-center container-fluid"">
    <div class=""row"">
        <div class=""col-md-1 col-xs-0"">
        </div>
        <div class=""col-md-4 col-xs-5"">
            <div id=""campeao1"" class=""campeao"">
                <img id=""img-vencedor"" class=""img-vencedor"" src=""https://cdn.pixabay.com/photo/2013/07/12/12/22/explosion-145687_960_720.png"">
                Vencedor
            </div>
            <div id=""perdedor1"" class=""perdedor""><img id=""img-perdedor"" class=""img-perdedor"" src=""https://cdn.pixabay.com/photo/2014/04/03/11/54/headstone-312540_960_720.png""> R.I.P </div>
            <div id=""heroi-contorno-1"" class=""contorno contorno-0"">
                <img id=""img-heori1"" class=""img-apresentacao-herois"" src=""https://image.freepik.com/vetores-gratis/ilustracao-de-silhueta-de-um-garoto-fingindo-como-um-super-heroi_24381-159.jpg"">
                <p id=""supernome1"" class=""p-descricao-herois""><b>Super nome:</b></p>
                <p id=""nome1"" class=""p-descricao-he");
            WriteLiteral(@"rois""><b>Nome:</b> </p>
                <p id=""universo-planeta1"" class=""p-descricao-herois""><b>Universo: </b>   <b>Planeta: </b> </p>
                <p id=""categoria1"" class=""p-descricao-herois""><b>Categoria:</b></p>
                <p class=""p-descricao-herois""><b>Super poderes:</b></p>
                <p id=""sp1-1"" class=""p-descricao-herois""> ...</p>
                <p id=""sp2-1"" class=""p-descricao-herois""> ... </p>
                <p id=""sp3-1"" class=""p-descricao-herois""> ... </p>
                <button id=""dercri-1"" type=""button"" class=""btn botao-detalhe-heroi"">Origem</button>
                <p id=""descricao1"" class=""texto-informativo""></p>
                <p id=""forca1"" class=""texto-informativo"">-1</p>
            </div>
        </div>
        <div class=""div-btn-p col-md-2 col-xs-2 "">
            <button id=""btn-fig"" type=""button"" onclick=""batalha()"" class=""btn btn-danger"">Fight</button>
            <br />
            <img id=""img-vs"" class=""img-vs"" src=""https://i2.wp.com/vspodcast.co");
            WriteLiteral(@"m.br/wp-content/uploads/2017/12/cropped-vs.png"">
        </div>
        <div class=""col-md-4 col-xs-5"">
            <div id=""campeao2"" class=""campeao"">
                <img id=""img-vencedor"" class=""img-vencedor"" src=""https://cdn.pixabay.com/photo/2013/07/12/12/22/explosion-145687_960_720.png"">
                Vencedor
            </div>
            <div id=""perdedor2"" class=""perdedor""><img id=""img-perdedor"" class=""img-perdedor"" src=""https://cdn.pixabay.com/photo/2014/04/03/11/54/headstone-312540_960_720.png""> R.I.P </div>
            <div id=""heroi-contorno-2"" class=""contorno contorno-0"">
                <img id=""img-heori2"" class=""img-apresentacao-herois"" src=""https://image.freepik.com/vetores-gratis/ilustracao-de-silhueta-de-um-garoto-fingindo-como-um-super-heroi_24381-159.jpg"">
                <p id=""supernome2"" class=""p-descricao-herois""><b>Super nome:</b></p>
                <p id=""nome2"" class=""p-descricao-herois""><b>Nome:</b> </p>
                <p id=""universo-planeta2"" class=""p-descricao");
            WriteLiteral(@"-herois""><b>Universo: </b> <b>Planeta: </b> </p>
                <p id=""categoria2"" class=""p-descricao-herois""><b>Categoria:</b> </p>
                <p class=""p-descricao-herois""><b>Super poderes:</b></p>
                <p id=""sp1-2"" class=""p-descricao-herois""> ... </p>
                <p id=""sp2-2"" class=""p-descricao-herois""> ... </p>
                <p id=""sp3-2"" class=""p-descricao-herois""> ... </p>
                <button id=""dercri-2"" type=""button"" class=""btn botao-detalhe-heroi"" onclick="""">Origem</button>
                <p id=""descricao2"" class=""texto-informativo"">  </p>
                <p id=""forca2"" class=""texto-informativo"">-1</p>
            </div>
        </div>
        <div class=""col-md-1 col-xs-0"">
        </div>
    </div>

</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-1 col-xs-0"">
        </div>
        <div class=""col-sm-10 col-xs-12"">
            <div class=""marg-row-correcao row"">


");
            EndContext();
#line 227 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {



#line default
#line hidden
            BeginContext(7230, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 7254, "\"", 7315, 3);
            WriteAttributeValue("", 7264, "trocaHerois(", 7264, 12, true);
#line 231 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 7276, Html.DisplayFor(modelItem => item.Id), 7276, 38, false);

#line default
#line hidden
            WriteAttributeValue("", 7314, ")", 7314, 1, true);
            EndWriteAttribute();
            BeginContext(7316, 105, true);
            WriteLiteral(" class=\"padding-col-heroi-selecao col-md-2 col-xs-3\">\r\n                        <div data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 7421, "\"", 7474, 1);
#line 232 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 7429, Html.DisplayFor(modelItem => item.SuperName), 7429, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 7475, "\"", 7518, 1);
#line 232 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 7480, Html.DisplayFor(modelItem => item.Id), 7480, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7519, 34, true);
            WriteLiteral(" class=\"background-herois-selecao\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 7553, "\"", 7625, 4);
            WriteAttributeValue("", 7561, "background-image:", 7561, 17, true);
            WriteAttributeValue(" ", 7578, "url(\'", 7579, 6, true);
#line 232 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 7584, Html.DisplayFor(modelItem => item.Img), 7584, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 7623, "\')", 7623, 2, true);
            EndWriteAttribute();
            BeginContext(7626, 33, true);
            WriteLiteral(">\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7659, "\"", 7707, 2);
            WriteAttributeValue("", 7664, "imge-", 7664, 5, true);
#line 233 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 7669, Html.DisplayFor(modelItem => item.Id), 7669, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7708, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(7770, 38, false);
#line 234 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Img));

#line default
#line hidden
            EndContext();
            BeginContext(7808, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 7876, "\"", 7924, 2);
            WriteAttributeValue("", 7881, "nome-", 7881, 5, true);
#line 237 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 7886, Html.DisplayFor(modelItem => item.Id), 7886, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7925, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(7987, 39, false);
#line 238 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(8026, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 8094, "\"", 8147, 2);
            WriteAttributeValue("", 8099, "superNome-", 8099, 10, true);
#line 241 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 8109, Html.DisplayFor(modelItem => item.Id), 8109, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8148, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(8210, 44, false);
#line 242 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SuperName));

#line default
#line hidden
            EndContext();
            BeginContext(8254, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 8322, "\"", 8374, 2);
            WriteAttributeValue("", 8327, "universo-", 8327, 9, true);
#line 245 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 8336, Html.DisplayFor(modelItem => item.Id), 8336, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8375, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(8437, 43, false);
#line 246 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Universe));

#line default
#line hidden
            EndContext();
            BeginContext(8480, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 8548, "\"", 8599, 2);
            WriteAttributeValue("", 8553, "planeta-", 8553, 8, true);
#line 249 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 8561, Html.DisplayFor(modelItem => item.Id), 8561, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8600, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(8662, 46, false);
#line 250 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Planet.Name));

#line default
#line hidden
            EndContext();
            BeginContext(8708, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 8776, "\"", 8829, 2);
            WriteAttributeValue("", 8781, "categoria-", 8781, 10, true);
#line 253 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 8791, Html.DisplayFor(modelItem => item.Id), 8791, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8830, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(8892, 49, false);
#line 254 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Categoria.Name));

#line default
#line hidden
            EndContext();
            BeginContext(8941, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9009, "\"", 9055, 2);
            WriteAttributeValue("", 9014, "p1-", 9014, 3, true);
#line 257 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 9017, Html.DisplayFor(modelItem => item.Id), 9017, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9056, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(9118, 41, false);
#line 258 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Power1));

#line default
#line hidden
            EndContext();
            BeginContext(9159, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9227, "\"", 9273, 2);
            WriteAttributeValue("", 9232, "p2-", 9232, 3, true);
#line 261 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 9235, Html.DisplayFor(modelItem => item.Id), 9235, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9274, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(9336, 41, false);
#line 262 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Power2));

#line default
#line hidden
            EndContext();
            BeginContext(9377, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9445, "\"", 9491, 2);
            WriteAttributeValue("", 9450, "p3-", 9450, 3, true);
#line 265 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 9453, Html.DisplayFor(modelItem => item.Id), 9453, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9492, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(9554, 41, false);
#line 266 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Power3));

#line default
#line hidden
            EndContext();
            BeginContext(9595, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9663, "\"", 9712, 2);
            WriteAttributeValue("", 9668, "descr-", 9668, 6, true);
#line 269 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 9674, Html.DisplayFor(modelItem => item.Id), 9674, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9713, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(9775, 46, false);
#line 270 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(9821, 68, true);
            WriteLiteral("\r\n                            </p>\r\n\r\n                            <p");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 9889, "\"", 9938, 2);
            WriteAttributeValue("", 9894, "force-", 9894, 6, true);
#line 273 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
WriteAttributeValue("", 9900, Html.DisplayFor(modelItem => item.Id), 9900, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9939, 61, true);
            WriteLiteral(" class=\"texto-informativo\">\r\n                                ");
            EndContext();
            BeginContext(10001, 40, false);
#line 274 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Force));

#line default
#line hidden
            EndContext();
            BeginContext(10041, 96, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 278 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(10156, 846, true);
            WriteLiteral(@"



            </div>
        </div>
        <div class=""col-sm-1 col-xs-0"">
        </div>
    </div>
</div>


<!-- Modal -->
<div class=""modal fade"" id=""myModal"" role=""dialog"">
    <div class=""modal-dialog"">
        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                <h4 id=""titulo-modal"" class=""modal-title"">Modal Header</h4>
            </div>
            <div id=""descricao-modal"" class=""modal-body"">
                <p>Some text in the modal.</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(11028, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 311 "C:\Users\RenanFontouraBoldrin\source\repos\Heroes\Heroes\Views\Home\Index.cshtml"
              await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(11106, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            BeginContext(11117, 3900, true);
            WriteLiteral(@"
        <script>
            var altHeroi = 1;

    function batalha() {
        if(!(parseInt($('#forca2').text()) == -1) && !(parseInt($('#forca1').text()) == -1)){
            if (parseInt($('#forca1').text()) > parseInt($('#forca2').text())) {
                document.getElementById('campeao1').style.display = 'block';
                document.getElementById('perdedor2').style.display = 'block';
                $('#heroi-contorno-1').removeClass('contorno-0')
                $('#heroi-contorno-1').removeClass('contorno-1')
                $('#heroi-contorno-1').addClass('contorno-2')

                $('#heroi-contorno-2').removeClass('contorno-0')
                $('#heroi-contorno-2').removeClass('contorno-2')
                $('#heroi-contorno-2').addClass('contorno-1')

            }
            if (parseInt($('#forca2').text()) > parseInt($('#forca1').text())) {
                document.getElementById('campeao2').style.display = 'block';
                document.getElementById('per");
            WriteLiteral(@"dedor1').style.display = 'block';

                $('#heroi-contorno-2').removeClass('contorno-0')
                $('#heroi-contorno-2').removeClass('contorno-1')
                $('#heroi-contorno-2').addClass('contorno-2')

                $('#heroi-contorno-1').removeClass('contorno-0')
                $('#heroi-contorno-1').removeClass('contorno-2')
                $('#heroi-contorno-1').addClass('contorno-1')
            }
            if (parseInt($('#forca2').text()) == parseInt($('#forca1').text())) {
                //empate
            }
        console.log(""atacar"")
        }
        
    }

            function openModal(id) {
                $('#titulo-modal').html($('#superNome-' + id).text());
                $('#descricao-modal').html($('#descr-' + id).text());
                $('#myModal').modal('show');
            }

            function trocaHerois(id) {
                document.getElementById('campeao2').style.display = 'none';
                document.getElementB");
            WriteLiteral(@"yId('perdedor1').style.display = 'none';
                document.getElementById('campeao1').style.display = 'none';
                document.getElementById('perdedor2').style.display = 'none';

                $('#heroi-contorno-2').removeClass('contorno-2')
                $('#heroi-contorno-2').removeClass('contorno-1')
                $('#heroi-contorno-2').addClass('contorno-0')

                $('#heroi-contorno-1').removeClass('contorno-1')
                $('#heroi-contorno-1').removeClass('contorno-2')
                $('#heroi-contorno-1').addClass('contorno-0')

                $('#img-heori' + altHeroi).attr(""src"", $('#imge-' + id).text());

                $('#supernome' + altHeroi).html(""<b>Super nome:</b>"" + $('#superNome-' + id).text())

                $('#nome' + altHeroi).html(""<b>Nome:</b>"" + $('#nome-' + id).text())

                $('#universo-planeta' + altHeroi).html(""<b>Universo: </b> "" + $('#universo-' + id).text() + ""   <b>Planeta: </b> "" + $('#planeta-' + id).text");
            WriteLiteral(@"())

                $('#categoria' + altHeroi).html(""<b>Categoria:</b>"" + $('#categoria-' + id).text())

                $('#sp1-' + altHeroi).html($('#p1-' + id).text())

                $('#sp2-' + altHeroi).html($('#p2-' + id).text())

                $('#sp3-' + altHeroi).html($('#p3-' + id).text())

                $('#descricao' + altHeroi).html($('#descr-' + id).text())

                $('#forca' + altHeroi).html($('#force-' + id).text())

                $(""#dercri-"" + altHeroi).attr('onClick', 'openModal(' + id + ')');

                altHeroiFun()
            }


            function altHeroiFun() {
                if (altHeroi == 1) {
                    altHeroi = 2;
                } else {
                    altHeroi = 1;
                }
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Heroes.Models.Hero>> Html { get; private set; }
    }
}
#pragma warning restore 1591
