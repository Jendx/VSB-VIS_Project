using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Structs
{
    public class Zaznam_SCP_ObjektuDTO
    {
        public int cisloZaznamu { get; set; }
        public string textZaznamu { get; set; }

        public int trida { get; set; }
        public int proverka { get; set; }
        public int dodatek_id { get; set; }
    }
}
