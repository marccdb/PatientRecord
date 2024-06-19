using FichaAtendimento.Shared.Model;


namespace FichaAtendimento.Client.Components.Pacientes
{
    public partial class AddPaciente
    {
        Paciente newPaciente = new();



        private async Task CreatePaciente()
        {
            await Http.PostAsJsonAsync<Paciente>("api/patients", newPaciente);
            NavigationManager.NavigateTo("Patients");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("Patients");
        }

    }
}
