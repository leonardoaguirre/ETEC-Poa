using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Agenda
    {
        public int Id { get; set; }
        public string Lembrete { get; set; }
        public string Nome { get; set; }
        public string Importancia { get; set; }
        public DateTime Data { get; set; }
        public string Hora { get; set; }
        public string Observacoes { get; set; }
    }
}
