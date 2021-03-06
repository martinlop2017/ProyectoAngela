﻿using System.Collections.Generic;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.RutasSalida;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioSistema
    {
        void UpdateFormaDePago(FormaPago formaDePago);
        void SaveFormaDePago(FormaPago formaDePago);
        List<FormaPago> GetAllFormasDePago();
        void SaveRutasSalida(RutasSalidaViewModel viewModel);
        FormaPago GetAllFormasDePagoByDescription(string formaDePago);
        bool BackUp();
    }
}
