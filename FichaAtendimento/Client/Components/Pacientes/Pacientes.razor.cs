using FichaAtendimento.Shared.Model;

namespace FichaAtendimento.Client.Components.Pacientes
{
    public partial class Pacientes
    {

        private Paciente[]? pacientesArr;
        private IEnumerable<Paciente>? sortedPacientesArr;

        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await Http.GetFromJsonAsync<Paciente[]>("api/patients");
            sortedPacientesArr = pacientesArr.OrderBy(x => x.NomePaciente);
        }

        private void NewPaciente()
        {
            NavigationManager.NavigateTo("/addpatient");
        }

    }
}
