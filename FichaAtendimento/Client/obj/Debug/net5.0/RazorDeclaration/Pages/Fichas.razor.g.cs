// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FichaAtendimento.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using FichaAtendimento.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\_Imports.razor"
using FichaAtendimento.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
using FichaAtendimento.Shared.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Fichasatendimento")]
    public partial class Fichas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "E:\Projetos\Projetos Web\FichaAtendimento\FichaAtendimento\Client\Pages\Fichas.razor"
       
    private Ficha[] fichas;

    protected override async Task OnInitializedAsync()
    {
        fichas = await Http.GetFromJsonAsync<Ficha[]>("api/Fichas");
    }

    private string sessaoPaga;
    private string reciboEntregue;

    private void NovaFicha()
    {
        NavigationManager.NavigateTo("/addficha");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591