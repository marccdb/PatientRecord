using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Components;


namespace FichaAtendimento.Client.Components.Pacientes
{
    public partial class RemovePaciente
    {

        [Parameter]
        public string? id { get; set; }
        Paciente newPaciente = new Paciente();

        protected override async Task OnInitializedAsync()
        {
            newPaciente = await Http.GetFromJsonAsync<Paciente>($"api/patients/{id}");
        }


        private async Task DeletePaciente()
        {
            await Http.DeleteAsync($"api/patients/{id}");
            NavigationManager.NavigateTo("Patients");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("Patients");
        }

    }
}
