using System.Net.Http.Json;
using System.Threading.Tasks;
using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace FichaAtendimento.Client.Pages.Fichas
{
    public partial class EditFicha
    {
        [Parameter]
        public string id { get; set; }
        Ficha newFicha = new Ficha();

        protected override async Task OnInitializedAsync()
        {
            newFicha = await Http.GetFromJsonAsync<Ficha>($"api/records/{id}");
        }


        private async Task UpdateFicha()
        {
            await Http.PutAsJsonAsync<Ficha>($"api/records/{id}", newFicha);
            NavigationManager.NavigateTo("records");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("records");
        }

    }
}
