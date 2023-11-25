using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA_app.Templates
{
    public class BuscadorCBA : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            // Lógica para mostrar sugerencias o resultados de búsqueda
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            // Lógica para navegar a una página con el elemento seleccionado
        }
        
    }
}
