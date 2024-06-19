using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Components;


namespace FichaAtendimento.Client.Components.Pacientes
{
    public partial class EditPaciente
    {

        [Parameter]
        public string? id { get; set; }
        Paciente newPaciente = new();

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
