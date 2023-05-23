using System.Collections.Generic;

namespace PlasticosCerriDeposito.Clases
{
    public class DatosAjusteStock
    {
        public string TipoAjuste { get; set; }
        public string NumeroAjuste { get; set; }
        public string FechaAjuste { get; set; }

        public string Deposito { get; set; }

        public List<DatosAjusteStock> Detail = new List<DatosAjusteStock>();
    }
}
