#pragma checksum "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd4c11e12f5a79046e389f529d3906883511e41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Create), @"mvc.1.0.view", @"/Views/Client/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Create.cshtml", typeof(AspNetCore.Views_Client_Create))]
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
#line 1 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\_ViewImports.cshtml"
using CadastroDeClientes;

#line default
#line hidden
#line 2 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\_ViewImports.cshtml"
using CadastroDeClientes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd4c11e12f5a79046e389f529d3906883511e41", @"/Views/Client/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c6a21f97c118804bddab8ab8f058aecbacda7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CadastroDeClientes.Models.ClientModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("newClientForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("well form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
  
    ViewData["Title"] = "Create";


#line default
#line hidden
            BeginContext(90, 264, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>
<script src=""https://rawgit.com/RobinHerbots/Inputmask/3.x/dist/jquery.inputmask.bundle.js""></script>

<h2 class=""text-center"">XYZ</h2>

<div class=""container"">

    ");
            EndContext();
            BeginContext(354, 21205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9cb081d1f48470ea1a935985586f28e", async() => {
                BeginContext(462, 501, true);
                WriteLiteral(@"
        <fieldset>
            <legend><center><h2><b>Novo Cliente</b></h2></center></legend><br>

            <center><h4>Informações Básicas</h4></center>
            <div class=""form-group"">
                <label for=""Name"" class=""col-md-4 control-label"">Nome Completo</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
");
                EndContext();
                BeginContext(1083, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1108, 129, false);
#line 25 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.Name, Model.Name, new { @class = "form-control", @placeholder = "Nome Completo", required = "required", }));

#line default
#line hidden
                EndContext();
                BeginContext(1237, 428, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""Birthdate"" class=""col-md-4 control-label"">Data de Nascimento</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-calendar""></i></span>
");
                EndContext();
                BeginContext(1801, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(1826, 161, false);
#line 36 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.Birthdate, new { @type = "date", @class = "form-control", @id= "birthdate", @placeholder = "Data de Aniversário", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(1987, 401, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""RG"" class=""col-md-4 control-label"">RG</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
");
                EndContext();
                BeginContext(2500, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2525, 132, false);
#line 47 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.RG, Model.RG, new { @class = "form-control", @placeholder = "000000000", @id = "rg", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(2657, 405, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>


            <div class=""form-group"">
                <label for=""CPF"" class=""col-md-4 control-label"">CPF</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
");
                EndContext();
                BeginContext(3178, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3203, 140, false);
#line 59 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.CPF, Model.CPF, new { @class = "form-control", @placeholder = "000.000.000-00", @id = "cpf", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(3343, 487, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>

            <hr />
            <center><h4>Redes Sociais</h4></center>
            <div class=""form-group"">
                <label for=""Facebook"" class=""col-md-4 control-label"">Facebook</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-cloud""></i></span>
");
                EndContext();
                BeginContext(3971, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3996, 126, false);
#line 72 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.Facebook, Model.Facebook, new { @class = "form-control", @placeholder = "www.facebook.com/stevejobs" }));

#line default
#line hidden
                EndContext();
                BeginContext(4122, 414, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>


            <div class=""form-group"">
                <label for=""Twitter"" class=""col-md-4 control-label"">Twitter</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-cloud""></i></span>
");
                EndContext();
                BeginContext(4674, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(4699, 123, false);
#line 84 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.Twitter, Model.Twitter, new { @class = "form-control", @placeholder = "www.twitter.com/stevejobs" }));

#line default
#line hidden
                EndContext();
                BeginContext(4822, 416, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""Instagram"" class=""col-md-4 control-label"">Instagram</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-cloud""></i></span>
");
                EndContext();
                BeginContext(5382, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(5407, 129, false);
#line 95 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.Instagram, Model.Instagram, new { @class = "form-control", @placeholder = "www.instagram.com/stevejobs" }));

#line default
#line hidden
                EndContext();
                BeginContext(5536, 416, true);
                WriteLiteral(@"
                    </div>
                </div>
            </div>


            <div class=""form-group"">
                <label for=""Linkedin"" class=""col-md-4 control-label"">Linkedin</label>
                <div class=""col-md-4 inputGroupContainer"">
                    <div class=""input-group"">
                        <span class=""input-group-addon""><i class=""glyphicon glyphicon-cloud""></i></span>
");
                EndContext();
                BeginContext(6093, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(6118, 126, false);
#line 107 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                   Write(Html.TextBoxFor(x => x.Linkedin, Model.Linkedin, new { @class = "form-control", @placeholder = "www.linkedin.com/stevejobs" }));

#line default
#line hidden
                EndContext();
                BeginContext(6244, 233, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <hr />\r\n            <center><h4>Telefone Residencial</h4></center>\r\n\r\n            <div id=\"resPhones\">\r\n                <div id=\"allResPhones\">\r\n");
                EndContext();
                BeginContext(6581, 401, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""TelephoneM.ResidencialPhoneDDD"" class=""col-md-4 control-label"">DDD</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-phone-alt""></i></span>
");
                EndContext();
                BeginContext(7123, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(7156, 166, false);
#line 126 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.TelephoneM.ResidencialPhoneDDD, Model.TelephoneM.ResidencialPhoneDDD, new { @class = "form-control", @id = "resDDD", @placeholder = "Ex: 11" }));

#line default
#line hidden
                EndContext();
                BeginContext(7322, 512, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""TelephoneM.ResidencialPhone"" class=""col-md-4 control-label"">Numero Residencial </label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-phone-alt""></i></span>
");
                EndContext();
                BeginContext(8013, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(8046, 174, false);
#line 137 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.TelephoneM.ResidencialPhone, Model.TelephoneM.ResidencialPhone, new { @class = "form-control", @id="resPhone", @placeholder = "Telefone Residencial" }));

#line default
#line hidden
                EndContext();
                BeginContext(8220, 303, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                </div>
            </div>

            <hr />

            <center><h4>Telefone Comercial</h4></center>

            <div id=""comPhones"">
                <div id=""allComPhones"">
");
                EndContext();
                BeginContext(8627, 399, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""TelephoneM.ComercialPhoneDDD"" class=""col-md-4 control-label"">DDD</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-phone-alt""></i></span>
");
                EndContext();
                BeginContext(9167, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(9200, 162, false);
#line 160 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.TelephoneM.ComercialPhoneDDD, Model.TelephoneM.ComercialPhoneDDD, new { @class = "form-control", @id = "comDDD", @placeholder = "Ex: 11" }));

#line default
#line hidden
                EndContext();
                BeginContext(9362, 507, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""TelephoneM.ComercialPhone"" class=""col-md-4 control-label"">Numero Comercial</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-phone-alt""></i></span>
");
                EndContext();
                BeginContext(10048, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(10081, 170, false);
#line 171 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.TelephoneM.ComercialPhone, Model.TelephoneM.ComercialPhone, new { @class = "form-control", @id = "comPhone", @placeholder = "Telefone Comercial" }));

#line default
#line hidden
                EndContext();
                BeginContext(10251, 296, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>


                </div>
            </div>

            <hr />

            <center><h4>Celular</h4></center>

            <div id=""cellPhones"">
                <div id=""allCellPhones"">
");
                EndContext();
                BeginContext(10651, 394, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""TelephoneM.CellPhoneDDD"" class=""col-md-4 control-label"">DDD</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-phone-alt""></i></span>
");
                EndContext();
                BeginContext(11186, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(11219, 152, false);
#line 195 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.TelephoneM.CellPhoneDDD, Model.TelephoneM.CellPhoneDDD, new { @class = "form-control", @id = "celDDD", @placeholder = "Ex: 11" }));

#line default
#line hidden
                EndContext();
                BeginContext(11371, 503, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""TelephoneM.CellPhone"" class=""col-md-4 control-label"">Numero do Celular</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-phone-alt""></i></span>
");
                EndContext();
                BeginContext(12053, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(12086, 149, false);
#line 206 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.TelephoneM.CellPhone, Model.TelephoneM.CellPhone, new { @class = "form-control", @id = "celPhone", @placeholder = "Celular" }));

#line default
#line hidden
                EndContext();
                BeginContext(12235, 710, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>


                </div>
            </div>

            <hr />


            <center><h4>Endereço Residencial</h4></center>

            <div id=""resAdresses"">
                <div id=""allResAdresses"">
                    <div class=""form-group"">
                        <label for=""AdressesM.ResStreetAddress"" class=""col-md-4 control-label"">Logradouro</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(13116, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(13149, 171, false);
#line 228 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ResStreetAddress, Model.AdressesM.ResStreetAddress, new { @class = "form-control", @placeholder = "Av. Paulista", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(13320, 492, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM.ResNeighborhood"" class=""col-md-4 control-label"">Bairro</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(13971, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(14004, 167, false);
#line 239 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ResNeighborhood, Model.AdressesM.ResNeighborhood, new { @class = "form-control", @placeholder = "Bela Vista", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(14171, 484, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM.ResCity"" class=""col-md-4 control-label"">Cidade</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(14797, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(14830, 150, false);
#line 250 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ResCity, Model.AdressesM.ResCity, new { @class = "form-control", @placeholder = "São Paulo", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(14980, 485, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM.ResState"" class=""col-md-4 control-label"">Estado</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(15609, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(15642, 152, false);
#line 261 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ResState, Model.AdressesM.ResState, new { @class = "form-control", @placeholder = "São Paulo", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(15794, 487, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM[i].ResZipCode"" class=""col-md-4 control-label"">CEP</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(16429, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(16462, 172, false);
#line 272 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ResZipCode, Model.AdressesM.ResZipCode, new { @class = "form-control", @placeholder = "01310-923", @id = "resZip", required = "required" }));

#line default
#line hidden
                EndContext();
                BeginContext(16634, 702, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <hr />

            <center><h4>Endereço Comercial</h4></center>

            <div id=""comAdresses"">
                <div id=""allComAdresses"">
                    <div class=""form-group"">
                        <label for=""AdressesM.ComStreetAddress"" class=""col-md-4 control-label"">Logradouro</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(17507, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(17540, 148, false);
#line 291 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ComStreetAddress, Model.AdressesM.ComStreetAddress, new { @class = "form-control", @placeholder = "Av. Paulista" }));

#line default
#line hidden
                EndContext();
                BeginContext(17688, 492, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM.ComNeighborhood"" class=""col-md-4 control-label"">Bairro</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(18339, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(18372, 144, false);
#line 302 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ComNeighborhood, Model.AdressesM.ComNeighborhood, new { @class = "form-control", @placeholder = "Bela Vista" }));

#line default
#line hidden
                EndContext();
                BeginContext(18516, 484, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM.ComCity"" class=""col-md-4 control-label"">Cidade</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(19142, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(19175, 127, false);
#line 313 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ComCity, Model.AdressesM.ComCity, new { @class = "form-control", @placeholder = "São Paulo" }));

#line default
#line hidden
                EndContext();
                BeginContext(19302, 485, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM.ComState"" class=""col-md-4 control-label"">Estado</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(19931, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(19964, 129, false);
#line 324 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ComState, Model.AdressesM.ComState, new { @class = "form-control", @placeholder = "São Paulo" }));

#line default
#line hidden
                EndContext();
                BeginContext(20093, 487, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""AdressesM[i].ComZipCode"" class=""col-md-4 control-label"">CEP</label>
                        <div class=""col-md-4 inputGroupContainer"">
                            <div class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-home""></i></span>
");
                EndContext();
                BeginContext(20728, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(20761, 149, false);
#line 335 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
                           Write(Html.TextBoxFor(x => x.AdressesM.ComZipCode, Model.AdressesM.ComZipCode, new { @class = "form-control", @id = "comZip", @placeholder = "01310-923" }));

#line default
#line hidden
                EndContext();
                BeginContext(20910, 642, true);
                WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label class=""col-md-4 control-label""></label>
                <div class=""col-md-4"">
                    <br>
                    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<input type=""submit"" id=""save"" class=""btn btn-primary btn-lg gradient"" style=""width:30%;"" />
                </div>
            </div>

        </fieldset>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "C:\Users\Possari\source\repos\CadastroDeClientes_old\CadastroDeClientes\Views\Client\Create.cshtml"
AddHtmlAttributeValue("", 416, Url.Action("Create","Client"), 416, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(21559, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CadastroDeClientes.Models.ClientModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
