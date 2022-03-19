using DXApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApp.Engine
{
    public class Engine
    {
        string queryData = "SELECT [Id],[RegisterNo],[Name],[Surname],[Name2],[Surname2],[FatherName2],[Birthday],[EnterDate],[CountryOfBirth],[Gender],[EmployeesPhotoId],[Email],[PassportNo],[Phone1],[IsLeft],[NotBack],[LeftDate],[CreatedBy],[CreatedDate],[UpdatedBy],[UpdatedDate] FROM[dbo].[HR_Employees]";
        string queryInsert = "insert into HR_Employees(RegisterNo,Name,Surname,Name2,Surname2,FatherName2,Birthday,EnterDate,CountryOfBirth,Gender,EmployeesPhotoId,Email,PassportNo,Phone1,IsLeft,NotBack,LeftDate,CreatedBy,CreatedDate,UpdatedBy,UpdatedDate) values (@RegisterNo,@Name,@Surname,@Name2,@Surname2,@FatherName2,@Birthday,@EnterDate,@CountryOfBirth,@Gender,@EmployeesPhotoId,@Email,@PassportNo,@Phone1,@IsLeft,@NotBack,@LeftDate,@CreatedBy,@CreatedDate,@UpdatedBy,@UpdatedDate)";
        string queryUpdate = "UPDATE HR_Employees SET Name = @Name,Surname = @Surname,Name2=@Name2,Surname2=@Surname2,FatherName2=@FatherName2,Birthday=@Birthday,EnterDate=@EnterDate,CountryOfBirth=@CountryOfBirth,Gender=@Gender,EmployeesPhotoId=@EmployeesPhotoId,Email=@Email,PassportNo=@PassportNo,Phone1=@Phone1,IsLeft=@IsLeft,NotBack=@NotBack,LeftDate=@LeftDate,CreatedBy=@CreatedBy,CreatedDate=@CreatedDate,UpdatedBy=@UpdatedBy,UpdatedDate=@UpdatedDate Where RegisterNo = @RegisterNo";
        string queryDelete = "DELETE FROM HR_Employees WHERE RegisterNo = @RegisterNo";
        public void RowEkle(HR_Employees items)
        {
            try
            {
                Data.Dal SQLConnect = new Data.Dal();
                SqlConnection baglanti = SQLConnect.OpenConnection();
                string kayits = queryInsert;
                SqlCommand cmd = SQLConnect.SorguOlustur(kayits);
                SqlCommand komuts = new SqlCommand(kayits, baglanti);
                items.Birthday = Convert.ToDateTime("2021.03.20");
                items.EnterDate = Convert.ToDateTime("2021.03.20");
                items.LeftDate = Convert.ToDateTime("2021.03.20");
                items.CreatedDate = Convert.ToDateTime("2021.03.20");
                items.UpdatedDate = Convert.ToDateTime("2021.03.20");
                komuts.Parameters.AddWithValue("@RegisterNo", items.RegisterNo);
                komuts.Parameters.AddWithValue("@Name", items.Name);
                komuts.Parameters.AddWithValue("@Surname", items.Surname);
                komuts.Parameters.AddWithValue("@Name2", items.Name2);
                komuts.Parameters.AddWithValue("@Surname2", items.Surname2);
                komuts.Parameters.AddWithValue("@FatherName2", items.FatherName2);
                komuts.Parameters.AddWithValue("@Birthday", items.Birthday);
                komuts.Parameters.AddWithValue("@EnterDate", items.EnterDate);
                komuts.Parameters.AddWithValue("@CountryOfBirth", items.CountryOfBirth);
                komuts.Parameters.AddWithValue("@Gender", items.Gender);
                komuts.Parameters.AddWithValue("@EmployeesPhotoId", items.EmployeesPhotoId);
                komuts.Parameters.AddWithValue("@Email", items.Email);
                komuts.Parameters.AddWithValue("@PassportNo", items.PassportNo);
                komuts.Parameters.AddWithValue("@Phone1", items.Phone1);
                komuts.Parameters.AddWithValue("@IsLeft", items.IsLeft);
                komuts.Parameters.AddWithValue("@NotBack", items.NotBack);
                komuts.Parameters.AddWithValue("@LeftDate", items.LeftDate);
                komuts.Parameters.AddWithValue("@CreatedBy", items.CreatedBy);
                komuts.Parameters.AddWithValue("@CreatedDate", items.CreatedDate);
                komuts.Parameters.AddWithValue("@UpdatedBy", items.UpdatedBy);
                komuts.Parameters.AddWithValue("@UpdatedDate", items.UpdatedDate);
                komuts.ExecuteNonQuery();
                baglanti.Close();
            }
            catch(IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void RowGuncelle(HR_Employees items)
        {
            try
            {
                Data.Dal SQLConnect = new Data.Dal();
                SqlConnection baglanti = SQLConnect.OpenConnection();
                SqlCommand komuts = new SqlCommand(queryUpdate, baglanti);
                items.Birthday = Convert.ToDateTime("2021.03.20");
                items.EnterDate = Convert.ToDateTime("2021.03.20");
                items.LeftDate = Convert.ToDateTime("2021.03.20");
                items.CreatedDate = Convert.ToDateTime("2021.03.20");
                items.UpdatedDate = Convert.ToDateTime("2021.03.20");
                komuts.Parameters.AddWithValue("@RegisterNo", items.RegisterNo);
                komuts.Parameters.AddWithValue("@Name", items.Name);
                komuts.Parameters.AddWithValue("@Surname", items.Surname);
                komuts.Parameters.AddWithValue("@Name2", items.Name2);
                komuts.Parameters.AddWithValue("@Surname2", items.Surname2);
                komuts.Parameters.AddWithValue("@FatherName2", items.FatherName2);
                komuts.Parameters.AddWithValue("@Birthday", items.Birthday);
                komuts.Parameters.AddWithValue("@EnterDate", items.EnterDate);
                komuts.Parameters.AddWithValue("@CountryOfBirth", items.CountryOfBirth);
                komuts.Parameters.AddWithValue("@Gender", items.Gender);
                komuts.Parameters.AddWithValue("@EmployeesPhotoId", items.EmployeesPhotoId);
                komuts.Parameters.AddWithValue("@Email", items.Email);
                komuts.Parameters.AddWithValue("@PassportNo", items.PassportNo);
                komuts.Parameters.AddWithValue("@Phone1", items.Phone1);
                komuts.Parameters.AddWithValue("@IsLeft", items.IsLeft);
                komuts.Parameters.AddWithValue("@NotBack", items.NotBack);
                komuts.Parameters.AddWithValue("@LeftDate", items.LeftDate);
                komuts.Parameters.AddWithValue("@CreatedBy", items.CreatedBy);
                komuts.Parameters.AddWithValue("@CreatedDate", items.CreatedDate);
                komuts.Parameters.AddWithValue("@UpdatedBy", items.UpdatedBy);
                komuts.Parameters.AddWithValue("@UpdatedDate", items.UpdatedDate);
                komuts.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public List<CounterClass> getCounter()
        {
            List<CounterClass> Counter = new List<CounterClass>();
            Data.Dal BaglantiYapVeCalistir = new Data.Dal();
            SqlConnection baglanti = BaglantiYapVeCalistir.OpenConnection();
            SqlCommand cmd = BaglantiYapVeCalistir.SorguOlustur("SELECT * FROM SYS_Sid");
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                Counter.Add(new CounterClass { Prefix = dr["Prefix"].ToString(), Counter = dr["Counter"].ToString(), Length = dr["Length"].ToString() });
            }
            baglanti.Dispose();
            baglanti.Close();
            return Counter;
        }
        public List<HR_Employees> getList()
        {
            List<HR_Employees> list = new List<HR_Employees>();
            using (var ctx = new HR_EmployeesDbContext())
            {
                list = ctx.DxDBContent.SqlQuery(queryData).ToList();
            }
            return list;
        }
        public void RowSil(string registerNo)
        {
            try
            {
                Data.Dal SQLConnect = new Data.Dal();
                SqlConnection baglanti = SQLConnect.OpenConnection();
                SqlCommand komuts = new SqlCommand(queryDelete, baglanti);
                komuts.Parameters.AddWithValue("@RegisterNo", registerNo);
                komuts.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public string generate(int length, int count, int gridRowCount)
        {
            string strGenerate = "";
            count = count + gridRowCount;
            if (count.ToString().Length < length)
            {
                for (int i = 1; i <= length - count.ToString().Length; i++)
                {
                    strGenerate += "0";
                }
            }
            strGenerate = strGenerate + count.ToString();
            return strGenerate;
        }
    }
}
