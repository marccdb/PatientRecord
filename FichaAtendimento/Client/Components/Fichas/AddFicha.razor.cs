using FichaAtendimento.Shared.Model;


namespace FichaAtendimento.Client.Components.Fichas
{
    public partial class AddFicha
    {
        Ficha newFicha = new();
        private IEnumerable<Paciente>? sortedPacientesArr;


        private async Task CreateFicha()
        {
            newFicha.NomePaciente = pacientesArr?.Where(x => x.idPaciente == newFicha.idPaciente).SingleOrDefault()?.NomePaciente;
            await Http.PostAsJsonAsync<Ficha>("api/Fichas", newFicha);
            NavigationManager.NavigateTo("fichasatendimento");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("fichasatendimento");
        }



        protected Paciente[]? pacientesArr;
        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await Http.GetFromJsonAsync<Paciente[]>("api/Pacientes");
            sortedPacientesArr = pacientesArr?.OrderBy(x => x.NomePaciente);
            newFicha.DataAtendimento = DateTime.Today;
        }
    }
}
