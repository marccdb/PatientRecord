﻿using FichaAtendimento.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FichaAtendimento.Client.Pages.Pacientes
{
    public partial class AddPaciente
    {
        Paciente newPaciente = new Paciente();



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
