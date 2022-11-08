using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FichaAtendimento.Client.Pages.Pacientes
{
    public partial class EditPaciente
    {

        [Parameter]
        public string id { get; set; }
        Paciente newPaciente = new Paciente();

        protected override async Task OnInitializedAsync()
        {
            newPaciente = await Http.GetFromJsonAsync<Paciente>($"api/patients/{id}");
        }


        private async Task UpdatePaciente()
        {
            await Http.PutAsJsonAsync<Paciente>($"api/patients/{id}", newPaciente);
            NavigationManager.NavigateTo("Patients");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("Patients");
        }


    }
}
