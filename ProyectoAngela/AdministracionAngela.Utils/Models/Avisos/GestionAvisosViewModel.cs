using System.ComponentModel;

namespace AdministracionAngela.Utils.Models.Avisos
{
    public class GestionAvisosViewModel
    {
        public BindingList<AvisoViewModel> Avisos { get; set; }

        public GestionAvisosViewModel()
        {
            this.Avisos = new BindingList<AvisoViewModel>();
        }
    }
}
