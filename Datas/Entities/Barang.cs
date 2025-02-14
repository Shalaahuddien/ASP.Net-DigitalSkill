﻿using System;
using System.Collections.Generic;

namespace Template.Net.Datas.Entities
{
    public partial class Barang
    {
        public int Id { get; set; }
        public string? Kode { get; set; }
        public string? Nama { get; set; }
        public string? Description { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }
        public int IdPenjual { get; set; }
        public string? FileName { get; set; }
        public string? Url { get; set; }

        public virtual Penjual IdPenjualNavigation { get; set; } = null!;
    }
}
