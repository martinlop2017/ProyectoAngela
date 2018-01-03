namespace AdministracionAngela.Utils.Models.Albaran
{
    public class LineaAlbaranViewModel
    {
        public long ProductoId;
        public string SelectedProduct { get; set; }
        public decimal PorcentajeIVA { get; set; }
        public decimal ImporteIVA
        {
            get
            {
                return decimal.Round((Importe * (PorcentajeIVA / 100)), 2);
            }
            set { }
        }
        public decimal PorcentajeRE { get; set; }
        public decimal ImporteRE
        {
            get
            {
                return decimal.Round((Importe * (PorcentajeRE / 100)), 2);
            }
            set { }
        }
        public int Cajas { get; set; }
        public decimal Kgs { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public LineaAlbaranViewModel()
        {

        }
    }
}