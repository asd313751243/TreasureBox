#pragma checksum "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7719c17db539d564cc59dde227eb056c43549100"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<center><h2>Register</h2></center>\r\n    ");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 7 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
                     CreateUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", " form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<label>Nombre</label>\r\n            ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "required", true);
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
                                                                    _user.Nombre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Nombre = __value, _user.Nombre));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", " form-group");
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.AddMarkupContent(22, "<label>Color</label>\r\n            ");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "color");
            __builder.AddAttribute(25, "class", "form-control");
            __builder.AddAttribute(26, "required", true);
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
                                                                     _user.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Color = __value, _user.Color));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", " form-group");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.AddMarkupContent(34, "<label>Correo</label>\r\n            ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "email");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "required", true);
            __builder.AddAttribute(39, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
                                                                     _user.Correo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Correo = __value, _user.Correo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", " form-group");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.AddMarkupContent(46, "<label>Contraseña</label>\r\n            ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "type", "password");
            __builder.AddAttribute(49, "class", "form-control");
            __builder.AddAttribute(50, "required", true);
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
                                                                        _user.Clave

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Clave = __value, _user.Clave));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", " form-group");
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.AddMarkupContent(58, "<label>Confirmar Contraseña</label>\r\n            ");
            __builder.OpenElement(59, "input");
            __builder.AddAttribute(60, "type", "password");
            __builder.AddAttribute(61, "class", "form-control");
            __builder.AddAttribute(62, "required", true);
            __builder.AddAttribute(63, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
                                                                        check

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => check = __value, check));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "text-center p-3 mb-3");
            __builder.AddMarkupContent(69, "\r\n            <input type=\"submit\" class=\"btn btn-primary\" value=\"Sign Up\">\r\n            <br>\r\n            ");
            __builder.OpenElement(70, "h6");
            __builder.AddAttribute(71, "class", "text-danger");
            __builder.AddContent(72, 
#nullable restore
#line 31 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
                                     message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Pages\Register.razor"
       
    private Usuario _user = new Usuario();
    private string check, message;

    public async Task CreateUser()
    {
        if(_user.Clave == check)
        {
            message = await service.AddUsuarioAsync(_user);
            if(message == "Usuario creado exitosamente")
            {
                nav.NavigateTo("/login");
            }
        }
        else
        {
            message = "Revisar contraseña";
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioServices service { get; set; }
    }
}
#pragma warning restore 1591
