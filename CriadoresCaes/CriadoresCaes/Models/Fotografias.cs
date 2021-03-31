﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{


    /// <summary>
    /// Fotografias dos cães
    /// </summary>
    public class Fotografias
    {

        /// <summary>
        /// Identificador da fotografia
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do ficheiro com a fotografia do cão
        /// </summary>
        public string Fotografia { get; set; }

        /// <summary>
        /// Data da fotografia
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local onde a fotografia foi tirada
        /// </summary>
        public string Local { get; set; }

        //****************************************

        // criação da FK que referencia o Cão a quem a Foto pertence
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }
    }
}
