using FichaAtendimento.Shared.Model;

namespace FichaAtendimento.Client.Components.Fichas
{
    public partial class Fichas
    {

        protected Paciente[]? pacientesArr;
        protected Ficha[]? fichas;
        private IEnumerable<Paciente>? sortedPacientesArr;


        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await Http.GetFromJsonAsync<Paciente[]>("api/Pacientes");
            sortedPacientesArr = pacientesArr.OrderBy(x => x.NomePaciente);

            fichas = await Http.GetFromJsonAsync<Ficha[]>("api/records");

        }

        private string? sessaoPaga;
        private string? reciboEntregue;

        private int pacienteId;
        private IEnumerable<Ficha> FichaPorPaciente()
        {
            var returnedValue = fichas.Where(x => x.idPaciente == pacienteId);
            return returnedValue;
        }

        private void NovaFicha()
        {
            NavigationManager.NavigateTo("/addrecord");
        }

    }
}
