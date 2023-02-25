using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplicationcheckwebconfig.Models
{
    public class QuanLyCoffee
    {
        [Required(ErrorMessage ="Can nhap vao ID Coffee")]
        [Display(Name ="ID Coffee")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Can nhap vao Ma Coffee")]
        [Display(Name = "Ma Coffee")]
        public string MaCoffee { get; set; }

        [Required(ErrorMessage = "Can nhap vao Name Coffee")]
        [Display(Name = "Ma Coffee")]
        public string NameCoffee { get; set; }

        [Required(ErrorMessage = "Can nhap vao Description Coffee")]
        [Display(Name = "Description Coffee")]
        public string Description { get; set;}


    }

    class ListCoffee
    {
        DBConnection db;
        public ListCoffee() { 
        db = new DBConnection();
        }
        // lay data coffee tu CSDL

        public List<QuanLyCoffee> getCoffee(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
            {
                sql = "Select * From Coffee";
            }
            else
            {
                sql = "Select * From Coffee Where Id = " + ID;
            }
            List<QuanLyCoffee> strList = new List<QuanLyCoffee> ();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();

            // mo ket noi 
            con.Open();
            cmd.Fill (dt); // do data vua truy van dc tu sql data adapter vao data table

            // dong ket noi
            cmd.Dispose (); // ngat cau lenh do data
            con.Close();

            QuanLyCoffee QLC;
            for(int i = 0;i< dt.Rows.Count;i++)
            {
                QLC = new QuanLyCoffee();
                QLC.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                QLC.MaCoffee = dt.Rows[i]["MaCoffee"].ToString();
                QLC.NameCoffee = dt.Rows[i]["NameCoffee"].ToString();
                QLC.Description = dt.Rows[i]["Description"].ToString();
                strList.Add( QLC );
            }
            return strList;
        }
    }
}