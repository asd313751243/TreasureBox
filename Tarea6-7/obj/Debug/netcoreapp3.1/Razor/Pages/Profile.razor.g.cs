#pragma checksum "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1ba096723d3fcdc752d39a46cb0bee5191b9d0d"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea6_7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Tarea6_7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Tarea6_7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Tarea6_7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "style");
            __builder.AddMarkupContent(1, "\r\n    .customcolor{\r\n            background-color: ");
            __builder.AddContent(2, 
#nullable restore
#line 7 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                               service._usuario.Color

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, ";\r\n        }\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
#nullable restore
#line 11 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
 if (service.estado)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-5 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "customcolor");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "p-3 mb-3 text-white text-center");
            __builder.OpenElement(17, "b");
            __builder.AddContent(18, "Hola, ");
            __builder.AddContent(19, 
#nullable restore
#line 16 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                       service._usuario.Correo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", " form-group");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.AddMarkupContent(25, "<b>Nombre</b>\r\n                ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "required", true);
            __builder.AddAttribute(30, "disabled", 
#nullable restore
#line 20 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                                                            disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                        service._usuario.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => service._usuario.Nombre = __value, service._usuario.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
#nullable restore
#line 23 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
             if (button_information == "Guardar")
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                 if (button_password == "Cambiar Contraseña")
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", " form-group");
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.AddMarkupContent(39, "<b>Contraseña</b>\r\n                        ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "password");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "required", true);
            __builder.AddAttribute(44, "disabled", true);
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                                    service._usuario.Clave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => service._usuario.Clave = __value, service._usuario.Clave));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 31 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                }
                else if (button_password == "Guardar Contraseña")
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", " form-group");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.AddMarkupContent(53, "<b>Contraseña Actual</b>\r\n                        ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "type", "password");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "required", true);
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                           password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", " form-group");
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.AddMarkupContent(65, "<b>Contraseña Nueva</b>\r\n                        ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "password");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "required", true);
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                           newpassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newpassword = __value, newpassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", " form-group");
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.AddMarkupContent(77, "<b>Confirmar Contraseña</b>\r\n                        ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "type", "password");
            __builder.AddAttribute(80, "class", "form-control");
            __builder.AddAttribute(81, "required", true);
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                           check

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => check = __value, check));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(86, "h6");
            __builder.AddAttribute(87, "class", "text-danger");
            __builder.AddContent(88, 
#nullable restore
#line 47 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 48 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "text-center p-3 mb-3");
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "button");
            __builder.AddAttribute(96, "class", "btn btn-success");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                           Edit_password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(98, "value", 
#nullable restore
#line 50 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                                                  button_password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 52 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"

            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", " form-group");
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.AddMarkupContent(105, "<b>Color</b>\r\n                ");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "type", "color");
            __builder.AddAttribute(108, "class", "form-control");
            __builder.AddAttribute(109, "required", true);
            __builder.AddAttribute(110, "disabled", 
#nullable restore
#line 56 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                                                            disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(111, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                         service._usuario.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => service._usuario.Color = __value, service._usuario.Color));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "text-center p-3 mb-3");
            __builder.AddMarkupContent(117, "\r\n                ");
            __builder.OpenElement(118, "input");
            __builder.AddAttribute(119, "type", "button");
            __builder.AddAttribute(120, "class", "btn btn-primary");
            __builder.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                       Edit_information

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "value", 
#nullable restore
#line 59 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
                                                                                                 button_information

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 63 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "    ");
            __builder.AddMarkupContent(128, "<h3>No estas autorizado</h3>\r\n");
#nullable restore
#line 67 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Profile.razor"
       
    private bool disabled = true;
    private string button_information = "Editar";
    private string button_password = "Cambiar Contraseña";
    private string password, newpassword, check, message;

    private async Task Edit_information()
    {
        if (button_information == "Guardar")
        {
            await service.UpdateUsuarioAsync(service._usuario);
            button_information = "Editar";
            disabled = true;
        }
        else
        {
            button_information = "Guardar";
            disabled = false;
        }
    }
    private void Edit_password()
    {
        if(button_password == "Guardar Contraseña")
        {
            if(password == service._usuario.Clave)
            {
                if(newpassword == check)
                {
                    service._usuario.Clave = newpassword;
                    button_password = "Cambiar Contraseña";
                    message = "";
                }
                else
                {
                    message = "Revisar la confirmacion de contraseña";
                }
            }
            else
            {
                message = "Contraseña actual incorrecta";
            }
        }
        else
        {
            button_password = "Guardar Contraseña";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioServices service { get; set; }
    }
}
#pragma warning restore 1591
