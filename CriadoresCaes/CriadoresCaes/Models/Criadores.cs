﻿using System;
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
         
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// nome do Sufixo associado aos nomes dos cães do criador
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada
        /// </summary>
        [Required]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal
        /// </summary>
        [Required]
        public string CodPostal { get; set; }

        /// <summary>
        /// Telemóvel
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        // ############################################

        /// <summary>
        /// lista dos Cães associados ao Criador
        /// </summary>
        public ICollection<CriadoresDeCaes> ListaDeCaes { get; set; }
    }
}

