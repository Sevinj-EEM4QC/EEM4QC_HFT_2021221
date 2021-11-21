using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEM4QC_HFT_2021221.Models
{
    public class ExitedEmployeeModel
    {
        [Key]
        public int Exit_Id { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets exit detail.
        /// </summary>
        public string ExitDetail { get; set; }

        /// <summary>
        /// Gets or sets exit date.
        /// </summary>
        public DateTime ExitDate { get; set; }
    }
}
