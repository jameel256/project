using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//HERE THESE TWO CODE MISSING, SO COPY AND PUT THEM HERE
using MySql.Data.MySqlClient;
using System.Data;


namespace Mtn_Uganda_ver_1._0
{
    public partial class client : System.Web.UI.Page
    {
        
        //PLEASE CODE THIS SECTION OF CODE BTN THE START OF HERE AD CHANGE DATABASE(OR CALLED CATALOG=mtn (your database name)

        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader dr;
        String queryStr;

        MySqlConnection conn2 = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=mtn;User Id=root;Password=''");
      
        // END OF CODE COPIED ABOVE




        protected void cmdsave_Click(object sender, EventArgs e)
        {

            //PLEASE NOTE THAT THE NAME YOU USED IN CONNECTIONSTRING IN XML OR WEB.CONFIG,SHOULD BE THE SAME HERE = (MtnAppConnString)
            String ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["MtnAppConnString"].ToString();

           
            conn = new MySql.Data.MySqlClient.MySqlConnection(ConnString);

            conn.Open();



            //MySqlCommand commToCheckID = new MySqlCommand("select ID from client where RegNo='" + int.Parse(a.Text) + "' ", conn);
           
            
            
            //PUT THIS CODE , THIS TYPE OF SUBMIT FIRST FIRST CHECK IF THAT CLIENT IS READY IN THE SYSYEM THEN YOU CANNT PUT THE CLIENT AGAIN IN THE SYSEM IF READY EXIST, SO U ONLY SEARCH FOR THE ID OF THE CLIENT IF EXIST THEN THAT CLIENT WILL COME BACK TO THE SYSTEM TO AVOID ENTERING A PERSON TWICE OR A STUDENT TWICE IN THE SYETEM, SO U TRY IT AND SEE IF IT WORKS FOR OUR EXAMS ,
            MySqlCommand commToCheckID = new MySqlCommand("select RegNo from client where RegNo='" + a.Text + "' ", conn);
           
            
            MySqlDataAdapter sd = new MySqlDataAdapter(commToCheckID);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Already Exist ClientID');", true);

            }


            // END OF CODE WHICH CHECKS AND BEFORE IT SAVES IF A NEW DOWN CODE FOR INSERT IN NEW CLIENT, SO MODFIY YOUR CODE TO WORK. PLZ TRY IT ALSO. THKS


            else
            {

                queryStr = "";
                //HERE U MUST NAME ALL OUR TEXTBOXES GOING TO BE USED IN SAVING DATA E.G FOR REGNO(ID = a), NAME TEXTBOX (ID =b),Contact (ID=c) etc
                queryStr = "INSERT INTO mtn.client(RegNo,Name,Contact,Item,AmountPaid,DOR)" + "VALUES('" + a.Text + "','" + b.Text + "','" + c.Text + "','" + d.Text + "','" + f.Text + "','" + ii.Text + "')";


                cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);



                cmd.ExecuteReader();
                conn.Close();

                //Response.Write("Your Data has been saved successfully !");
                ms.Text = "Your Data has been saved successfully !";

                clr();
                displaydata();
            }
        }




        // THIS CODE DOW HERE , IS A FUNCTION WHICH CLEARS FOR NEXT APPLICANT AND WHY A FUNCTION, TO BE USED FOR MANY TIMES 
        private void clr()
        {

            a.Enabled = true;
            b.Enabled = true;
            c.Enabled = true;
            d.Enabled = true;
            f.Enabled = true;
            ii.Enabled = true;
            
            a.Text = "";
            b.Text = "";
            c.Text = "";
           // d.Text = "";
           
            f.Text = "";
           ii.Text = "";
           a.Focus();
        }




        // THIS IS WHEN U DOUBLE CLICK ON THAT BUTTON CALLED CLEAR THEN JUST PUT OE ENTER BTN {     AND } - clr();  THE WILL COME FOR THE FUNCTION
        protected void cmdclear_Click(object sender, EventArgs e)
        {
            clr();
        }



        //THIS IS THE CODE FOR DELETE AN APPLICANT
        protected void cmddel_Click(object sender, EventArgs e)
        {
            conn2.Open();
            MySqlCommand cmd2 = conn2.CreateCommand();
            cmd2.CommandType = CommandType.Text;

            cmd2.CommandText = "delete from client where RegNo='" + a.Text + "'";   //THIS IS THE CODE WHICH DELETES USING OUR PRIMARY KEY FIELD REGNO=" THE REGNO U WILL ENTER IN TEXT a

            cmd2.ExecuteNonQuery();
            conn2.Close();

            //  Response.Write("Your Data has been Delete Permanently !");  // TRY TO REMOVE THIS COMMENT AND SEE WHAT IT DOES


            ms.Text = "Your Data has been deleted successfully !";

            clr();
            displaydata();
         }

        protected void cmdupdate0_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
           // String ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["MtnAppConnStringcompanyConnectionString2"].ToString();

            String ConnString = System.Configuration.ConfigurationManager.ConnectionStrings["MtnAppConnString"].ToString();

           
            conn = new MySqlConnection(ConnString);

            conn.Open();


            //conn.Open();
            //SqlCommand cmd = conn.CreateCommand();
            // cmd.CommandType = CommandType.Text;

            //SqlCommand cmd;




            queryStr = "";

            queryStr = "select * from client";

            // cmd2.CommandText = "select * from webapptech.userregistration2";   even this one works

            cmd = new  MySqlCommand(queryStr, conn);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();

        }

        protected void Griddata_SelectedIndexChanged(object sender, EventArgs e)
        {
          //REMOVE
            // a.Text = GridView1.SelectedRow.Cells[1].Text;

            //b.Text = GridView1.SelectedRow.Cells[2].Text;

            //c.Text = GridView1.SelectedRow.Cells[3].Text;

           // d.Text = GridView1.SelectedRow.Cells[4].Text;
        //    // DropDownList1.Text = GridView1.SelectedRow.Cells[5].Text;


            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            a.Text = GridView1.Rows[rowind].Cells[1].Text;
            b.Text = GridView1.Rows[rowind].Cells[1].Text;
            c.Text = GridView1.Rows[rowind].Cells[1].Text;
            //  a.Text = gvList.Rows[rowind].Cells[1].Text;
        }

        protected void cmdupdate_Click(object sender, EventArgs e)
        {

        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {

            searchbtn444();
        }
       
        private void searchbtn444()
        {
            
            MySqlConnection conn2 = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=mtn;User Id=root;Password=''");
      
            string find = "select * from client where(RegNo like '" + txt2.Text + "' or Name like '" + txt2.Text + "')";

            MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(find, conn2);
            cmd2.Parameters.Add("@RegNo", SqlDbType.VarChar).Value = txt2.Text;
            cmd2.Parameters.Add("@Name", SqlDbType.VarChar).Value = txt2.Text;
            cmd2.Parameters.Add("@Contact", SqlDbType.VarChar).Value = txt2.Text;

            //conn.Open();
           // cmd2.ExecuteNonQuery();
           
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd2;
            DataSet ds = new DataSet();
            da.Fill(ds, "RegNo");
            da.Fill(ds, "LastName");
            da.Fill(ds, "Contact");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            //conn.Close();

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Dim con3 as new MySqlConnection;
            //conn.ConnectionString=
           // conn.Open();

           // MySqlConnection conn2 = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=mtn;User Id=root;Password=''");
           
            //cmd=new MySqlCommand("Select * from mtn where ClientID = '" + txt2.Text +"'", conn);
            //MySql.Data.MySqlClient.MySqlDataReader dr;
            //dr = cmd.ExecuteReader();

            //a.Text =dr.GetString(0);
            //b.Text =dr.GetString(1);
            //c.Text =dr.GetString(2);
            //d.Text =dr.GetString(3);
            //conn.Close();


            // A CODE FOR DATA TO BE VIEWED IN TEXTBOXES
            MySqlConnection conn2 = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=mtn;User Id=root;Password=''");
           
            conn2.Open();
            if (txt2.Text != "")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT RegNo, Name, contact, Item,AmountPaid, DOR from client WHERE RegNo =@id", conn2);
               
                //cmd.Parameters.AddWithValue("@id", int.Parse(txt2.Text));

                cmd.Parameters.AddWithValue("@id", txt2.Text);


                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    a.Text = dr.GetValue(0).ToString();
                    b.Text = dr.GetValue(1).ToString();
                    c.Text = dr.GetValue(2).ToString();
                    d.Text = dr.GetValue(3).ToString();
                    f.Text = dr.GetValue(4).ToString();
                    ii.Text = dr.GetValue(5).ToString();

                    a.Enabled = false;
                    b.Enabled = false;
                    c.Enabled = false;
                    d.Enabled = false;
                    f.Enabled = false;
                    ii.Enabled = false;
                }
                conn2.Close();
            }   


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            AddVal();
        }

        protected void p_TextChanged(object sender, EventArgs e)
        {
            AddVal();
        }

        protected void q_TextChanged(object sender, EventArgs e)
        {
            AddVal();
        }

        protected void r_TextChanged(object sender, EventArgs e)
        {
            AddVal();
        }
        protected void AddVal()
        {
        int num1, num2 , num3;
        if(p.Text !="")
        num1=Convert.ToInt32(p.Text);
        else
        num1=0;

        if(q.Text !="")
        num2=Convert.ToInt32(q.Text);
        else
        num2=0;

        if (r.Text != "")
            num3 = Convert.ToInt32(r.Text);
        else
            num3 = 0;

        int tot = num1 + num2 + num3;
        z.Text=tot.ToString();
        }
      


    }
}