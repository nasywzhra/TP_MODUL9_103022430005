using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL9_103022430005
{
    internal class ConfigData
    {
        public string satuan_suhu { get; set; } = string.Empty;
        public int batas_hari_deman { get; set; } = 0;
        public string pesan_ditolak { get; set; } = string.Empty;
        public string pesan_diterima { get; set; } = string.Empty;
    }
}
