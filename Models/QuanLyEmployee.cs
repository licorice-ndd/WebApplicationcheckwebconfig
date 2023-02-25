using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplicationcheckwebconfig.Models
{
    public class QuanLyEmployee
    {
        [Required(ErrorMessage = "Can nhap vao ID Employee")]
        [Display(Name = "ID Employee")]
        public int ID { get; set; }
        [Required(ErrorMessage ="Nhap ma cua nhan vien")]
        [Display(Name = "Ma Employee")]
        public string MaEmp { set; get; }
        [Required(ErrorMessage ="Nhap ten cua nhan vien")]
        [Display(Name ="Name Employee")]
        public string Name { set; get; }
        [Required(ErrorMessage = "Nhap tuoi cua nhan vien")]
        [Display(Name = "Age Employee")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Nhap dia chi cua nhan vien")]
        [Display(Name = "Address Employee")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Nhap luong cua nhan vien")]
        [Display(Name = "Salary Employee")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "Nhap email cua nhan vien")]
        [Display(Name = "Email Employee")]
        public string Email { get; set; }   

        class ListEmployee
        {
            DBConnection db;
            public ListEmployee() { db = new DBConnection(); }

            public List<QuanLyEmployee> GetEmployees(string ID)
            {
                string sql;
                if (string.IsNullOrEmpty(ID))
                {
                    sql = "select top 5 From Employee Order By NEWID()";
                }
                else
                {
                    sql = "Select * from Employee where Id = " + ID;
                }
                List<QuanLyEmployee> strList = new List<QuanLyEmployee>();
                SqlConnection con = db.GetConnection();
                SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                // mo ket noi 
                con.Open();
                cmd.Fill(dt); // do data vua truy van dc tu sql data adapter vao data table

                // dong ket noi
                cmd.Dispose(); // ngat cau lenh do data
                con.Close();

                QuanLyEmployee QLE;
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    QLE = new QuanLyEmployee();
                    QLE.ID = Convert.ToInt32
                }
            }
        }
    }
}