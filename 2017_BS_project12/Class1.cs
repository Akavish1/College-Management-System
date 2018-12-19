using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projB2
{
    public class Login
    {
        private string name;
        private int curr_id;
        private int id;
        private string pwd;
        private int type;
        private int year;
        private string semester;

        public Login() { }

        public string getName() { return name; }
        public string getPwd() { return pwd; }
        public int getType() { return type; }
        public int getId() { return id; }
        public int getCurrId() { return curr_id; }
        public int getYear() { return year; }
        public string getSem() { return semester; }


        public void setName(string name) { this.name = name; }
        public void setPwd(string pwd) { this.pwd = pwd; }
        public void setType(int type) { this.type = type; }
        public void setId(int id) { this.id = id; }
        public void setCurrId(int curr_id) { this.curr_id = curr_id; }
        public void setYear(int year) { this.year = year; }
        public void setSem(string semester) { this.semester = semester; }

        internal void saveData(int curr_id)
        {
            SqlDataAdapter da;
            SqlCommandBuilder cmdBuilder;
            DataSet UserData = new DataSet();

            //Initialize the SqlDataAdapter object by specifying a Select command 
            //that retrieves data from the sample table.
            da = new SqlDataAdapter("select * from Login where id=" + curr_id, Globals.conn);


            //Initialize the SqlCommandBuilder object to automatically generate and initialize
            //the UpdateCommand, InsertCommand, and DeleteCommand properties of the SqlDataAdapter.
            cmdBuilder = new SqlCommandBuilder(da);

            //Populate the DataSet by running the Fill method of the SqlDataAdapter.
            da.Fill(UserData, "Login");

            //Modify the value of the CustName field.
            UserData.Tables["Login"].Rows[0]["id"] = id;
            UserData.Tables["Login"].Rows[0]["name"] = name;
            UserData.Tables["Login"].Rows[0]["pwd"] = pwd;
            UserData.Tables["Login"].Rows[0]["type"] = type;
            UserData.Tables["Login"].Rows[0]["year"] = year;
            UserData.Tables["Login"].Rows[0]["semester"] = semester;

            //Post the data modification to the database.
            da.Update(UserData, "Login");

            Globals.conn.Close();
        }
    }
}
