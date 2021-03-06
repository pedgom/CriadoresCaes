using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{

    /// <summary>
    /// Descreve os Criadores de cães
    /// </summary>
    public class Criadores
    {

        public Criadores()
        {
            // inicializar a lista de Cães do Criador
            ListaDeCaes = new HashSet<CriadoresDeCaes>();
        }

        /// <summary>
        /// identificador do Criador
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do criador
        /// </summary>
         
        [Required(ErrorMessage ="O Nome é de preenchimento obrigatório")]
        [StringLength (60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [RegularExpression("[A-ZÓÂÍ][a-zçáéíóúàèìòùãõäëïöüâêîôûñ]+(( | d[ao](s)? | e |-|'| d')[A-ZÓÂÍ][a-zçáéíóúàèìòùãõäëïöüâêîôûñ]+){1,3}")]
        public string Nome { get; set; }

        /// <summary>
        /// nome do Sufixo associado aos nomes dos cães do criador
        /// </summary>
        [StringLength(20, ErrorMessage = "0 {0} não pode ter mais de {1} carcteres.")]
        [Display(Name = "Afixo")]
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada
        /// </summary>
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(30, MinimumLength =8, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3}( [a-zA-Z-áÁéÉçÇ]+)+")]
        [Display(Name ="Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// Telemóvel
        /// </summary>
        [StringLength(14, MinimumLength = 9, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva, por favor, um nº de telemóvel com 9 algarismos. Se quiser, pode acrescentar o indicativo nacional e o internacional.")]
        [Display(Name = "Telemóvel")]
        public string Telemovel { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "O {0} introduzido não é válido")]
        [RegularExpression("((((aluno)|(es((tt)|(ta)|(gt))))[0-9]{4,5})|([a-z]+(.[a-z]+)*))@ipt.pt", ErrorMessage = "Só são aceites emails do IPT.")]
        public string Email { get; set; }

        // ############################################

        /// <summary>
        /// lista dos Cães associados ao Criador
        /// </summary>
        public ICollection<CriadoresDeCaes> ListaDeCaes { get; set; }
    }
}

