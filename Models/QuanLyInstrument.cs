using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplicationcheckwebconfig.Models
{
    public class QuanLyInstrument
    {
        [Required(ErrorMessage = "Can nhap vao ID Instrument")]
        [Display(Name = "ID Instrument")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Nhap ma cua Instrument")]
        [Display(Name = "Ma Instrument")]
        public string MaIns { set; get; }
        [Required(ErrorMessage = "Nhap ten cua Instrument")]
        [Display(Name = "Name Instrument")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Nhap xuat xu cua Instrument")]
        [Display(Name = "Origin Instrument")]
        public string Origin { get; set; }
        [Required(ErrorMessage = "Nhap hinh dang cua Instrument")]
        [Display(Name = "Shape Instrument")]
        public string Shape { get; set; }
        [Required(ErrorMessage = "Nhap so luong cua Instrument")]
        [Display(Name = "Quantity Instrument")]
        public int Quantity { get; set; }

    }
}