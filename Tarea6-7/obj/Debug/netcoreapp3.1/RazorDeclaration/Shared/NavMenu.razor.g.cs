#pragma checksum "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70528a98819a0016f143f330dbf5ba9ef5707c38"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea6_7.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Tarea6_7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Tarea6_7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Tarea6_7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\_Imports.razor"
using Syncfusion.Blazor.Maps;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "e:\ITLA\ITLA\6to cuatri\Programacion III\Tarea6-7\Tarea6-7\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591