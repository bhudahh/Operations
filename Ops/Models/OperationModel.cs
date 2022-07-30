using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ops.Models
{
    public class OperationModel
    {
        public int OperationID { get; set; }
        [Required]
        public string Name { get; set; }
        public int OrderInWhichToPerform { get; set; }
        public byte[] ImageData { get; set; }
        public DeviceModel Device { get; set; }
    }
}
