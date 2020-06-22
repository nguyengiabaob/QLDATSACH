using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BTH4.modules
{
    class XLBANG :DataTable
    {
        #region fields
        public static string cnnstring = "Data Source=DESKTOP-T11FG2C\\SQLEXPRESS;Initial Catalog=QLNHASACH;Integrated Security=True";
        public static SqlConnection cnn;
        private SqlDataAdapter da = new SqlDataAdapter();
        private string _query;
        private string _name;
        #endregion
        #region properties
        public string query
        {
            get { return _query; }
            set { _query = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int getcount
        {
            get { return this.DefaultView.Count; }
        }
        #endregion
        #region constructor
        public XLBANG() : base() { }
        public XLBANG (string pname)
        {
            _name = pname;
            docbang();
        }
        public XLBANG (string pname, string query)
        {
            _name = pname;
            _query = query;
            docbang();
        }
        #endregion
        #region methods
        public void docbang()
        {
            if (_query == null)
                _query = "select * from " + _name;
            if (cnn==null)
            {
                cnn = new SqlConnection(cnnstring);
            }
            try
            {
                da = new SqlDataAdapter(_query, cnnstring);
                da.FillSchema(this, SchemaType.Mapped);
                da.Fill(this);
                da.RowUpdated += new SqlRowUpdatedEventHandler(da_RowUpdated);
                SqlCommandBuilder cmdb = new SqlCommandBuilder(da);

            }
            catch( Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        public Boolean ghi ()
        {
            Boolean result = true;
            try
            {
                da.Update(this);
                this.AcceptChanges();

            }
            catch(SqlException ex)
            {
                this.RejectChanges();
                result = false;
                throw ex;

            }
            return result;

        }
        public void locdulieu (string pdieukien)
        {
            try
            {
                this.DefaultView.RowFilter = pdieukien;

            }
            catch (SqlException ex)
            {
                throw ex;

            }

        }
        public static int thuc_hien_lenh(string pquery)
        {
            if(cnn==null)
            {
                cnn = new SqlConnection(cnnstring);
            }
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(pquery, cnn);
                int result = cmd.ExecuteNonQuery();
                cnn.Close();
                return result;
            }
            catch 
            {
                return -1;
            }
        }
        public static object thuc_hien_lenh_tinh_toan(string pquery)
        {
            if (cnn == null)
            {
                cnn = new SqlConnection(cnnstring);
            }
            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(pquery, cnn);
                Object result = cmd.ExecuteScalar();
                cnn.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }
        #region events
        private void da_RowUpdated (object sender,SqlRowUpdatedEventArgs e)
        {
            if(this.PrimaryKey[0].AutoIncrement)
            {
                if((e.Status==UpdateStatus.Continue)&& (e.StatementType==StatementType.Insert))
                {
                    SqlCommand cmd = new SqlCommand("select @@INDENTITY", cnn);
                    e.Row.ItemArray[0] = cmd.ExecuteScalar();
                    e.Row.AcceptChanges();
                }
            }
        }
        #endregion

    }
}
