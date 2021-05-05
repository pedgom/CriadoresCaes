using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    /// <summary>
    /// dados dos veterinnarios que tratam dos cães
    /// um cão pode ser tratado por muitos veterinários
    /// um Veteri´nário pode, naturalmente, tratar de muitos cães
    /// </summary>
    public class Veterinarios
    {
        public Veterinarios()
        {
            ListaCaesTratadosPeloVeterinario = new HashSet<Caes>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        public string Nome { get; set; }

        //***************************************************************************
        //identificar os cães que são tratados pelo Veterinário
        //vamos ignorar a tabela do relacionamento. è como se elea não existisse......
        public ICollection<Caes> ListaCaesTratadosPeloVeterinario { get; set; }




    }
}
