using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    public class Allocation
    {
        public int Id { get; set; }
        public DateTime inicio { get; set; }
        public DateTime termino { get; set; }
        public Byte horasAtuacaoSemanal { get; set; }
        public Decimal remuneracao { get; set; }
        public Developer Developer { get; set; }
        public Project Project {get; set; }
        public List<Task> Tasks { get; set; }



    }
}
