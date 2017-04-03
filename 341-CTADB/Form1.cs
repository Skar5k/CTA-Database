/*
 *  CTA Ridership analysis using C# and SQL Serer. 
 * 
 *  <<Jaskaran Singh>> 
 *  U. of Illinois, Chicago
 *  CS341, Fall 2016
 *  Homework 6
 *  
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _341_CTADB
{
    public partial class Form1 : Form
    {
        //method which opens a database connection
        SqlConnection db_connect()
        {
            SqlConnection db;
            string filename, version, connectionInfo;
            version = "MSSQLLocalDB";
            filename = "CTA.mdf";
            connectionInfo = String.Format(@"
                    Data Source=(LocalDB)\{0};AttachDbFilename=|DataDirectory|\{1};Integrated Security=True;",
                    version, filename);
            db = new SqlConnection(connectionInfo);
            db.Open();
            return db;
        }

        //excecutes a scalar query based on the given string and returns the result
        Object scaler_Q(string sql, SqlConnection db)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            cmd.CommandText = sql;
            return cmd.ExecuteScalar();
        }

        //excecutes a query which requires a dataset and returns the dataset
        DataSet adapter_Q(string sql, SqlConnection db)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = db;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            cmd.CommandText = sql;
            adapter.Fill(ds);
            return ds;
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Load button click. Fills in the Station_List listbox.
        private void Load_button_Click(object sender, EventArgs e)
        {
            Station_list.Items.Clear();
            SqlConnection db = db_connect();
            string sql;
            sql = String.Format(@"              
                select Name 
                from Stations
                Order by Name");                //Select all the names from stations

            DataSet ds = new DataSet();
            ds = adapter_Q(sql, db);            //fill dataset with adapter method
            db.Close();

            foreach(DataRow row in ds.Tables["TABLE"].Rows)     //add each item to the list
            {
                string msg = Convert.ToString(row["Name"]);
                Station_list.Items.Add(msg);
            }
            
        }

        //when a user selects a station from the station list, display info about that station
        private void Station_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Stops_at_station.Items.Clear();
            string selected = Station_list.SelectedItem.ToString();
            string[] split = selected.Split(')');               //handle the case when top 10 is being displayed
            selected = split[0] + ')';
            selected = selected.Replace("'", "''");
            string sql_total = String.Format(@"                 
                select sum(DailyTotal) as Daily_Total, (sum(DailyTotal) / count(*)) as avg_ridership
                from Riderships
                inner join Stations on Stations.StationID = Riderships.StationID
                where Stations.Name = '{0}';
            ", selected);               //select the total rides in a day as well as the average

            string sql_stationID = String.Format(@"
                select StationID
                from Stations
                where Name = '{0}';
            ",selected);                //get station id for easier queries

            string sql_stops = String.Format(@"
                Select Stops.Name
                From Stops
                inner join Stations on Stations.StationID = Stops.StationID
                Where Stations.Name = '{0}'
                order by Stops.Name
            ",selected);                //get stop names

            DataSet ds_total = new DataSet();       //datasets for the 3 queries which we will make
            DataSet ds_days = new DataSet();
            DataSet ds_stops = new DataSet();

            SqlConnection db = db_connect();        //connect the db

            ds_stops = adapter_Q(sql_stops, db);    //excecute queries and fill dataset
            ds_total = adapter_Q(sql_total, db);
            DataRow row = ds_total.Tables["Table"].Rows[0];
            
            double total_Riders = Convert.ToInt64(row["Daily_Total"]);
            int StationID = Convert.ToInt32(scaler_Q(sql_stationID, db));
            string sql_percent = String.Format(@"
                Select convert(float,{0}) / Sum(convert(bigint, DailyTotal)) * 100
                From Riderships
            ", total_Riders.ToString());            //find the percent of total, passing in 
                                                    //ridership at selected stop

            string sql_Days = String.Format(@"
                Select sum(DailyTotal) as Sunday
                From Riderships
                where TypeOfDay = 'U' and StationID = {0};

                Select sum(DailyTotal) as Weekday
                From Riderships
                where TypeOfDay = 'W' and StationID = {0};

                Select sum(DailyTotal) as Saturday
                From Riderships
                where TypeOfDay = 'A' and StationID = {0};
            ", StationID);                          //find how many of the riders rode on
                                                    //weekdays,saturday,sunday or a holiday

            double percent = Convert.ToDouble(scaler_Q(sql_percent, db));   //get percent of riders out of total
            

            ds_days = adapter_Q(sql_Days, db);      //execute days query
            
            db.Close();

            //fill in with results
            Total_ridership_box.Text = string.Format("{0:,000,000}", Convert.ToInt64(row["Daily_Total"]));
            Average_ridership_box.Text = string.Format("{0:,000}/day", Convert.ToDouble(row["avg_ridership"]));
            Percent_ridership_box.Text = String.Format("{0:0.00}%", percent);
            DataRow Sunday = ds_days.Tables[0].Rows[0];
            DataRow Weekday = ds_days.Tables[1].Rows[0];
            DataRow Saturday = ds_days.Tables[2].Rows[0];
            sunday_box.Text = string.Format("{0:,000,000}",Convert.ToDouble(Sunday["Sunday"]));
            Weekday_box.Text = string.Format("{0:,000,000}",Convert.ToDouble(Weekday["Weekday"]));
            Saturday_box.Text = string.Format("{0:,000,000}",Convert.ToDouble(Saturday["Saturday"]));
            foreach(DataRow r in ds_stops.Tables[0].Rows)
            {
                Stops_at_station.Items.Add(Convert.ToString(r[0]));
            }

        }

        //When user selects a stop at a station, display info about that stop
        private void Stops_at_station_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lines.Items.Clear();
            string selected = Stops_at_station.SelectedItem.ToString();
            selected = selected.Replace("'", "''");
            string sql_stopinfo = string.Format(@"
                Select ADA, Latitude, Longitude, Direction
                From Stops
                Where Name = '{0}'
            ", selected);               //finds all the info except lines

            string sql_lines = string.Format(@"
                Select Color 
                From Lines
                inner join StopDetails on StopDetails.LineID = Lines.LineID
                inner join Stops on Stops.StopID = StopDetails.StopID
                where Stops.Name = '{0}';
            ",selected);                //find all the lines at selected station

            DataSet Stop_info = new DataSet();
            DataSet Line_info = new DataSet();
            SqlConnection db = db_connect();
            
            Stop_info = adapter_Q(sql_stopinfo, db);        //excecute the queries
            Line_info = adapter_Q(sql_lines, db);   

            db.Close();

            //fill in results
            DataRow result = Stop_info.Tables[0].Rows[0];
            bool handicapped = Convert.ToBoolean(result[0]);
            double Latitude = Convert.ToDouble(result[1]);
            double Longitude = Convert.ToDouble(result[2]);
            char Direction = Convert.ToChar(result[3]);
            Location.Text = String.Format("({0:0.0000},{1:0.0000})",Latitude,Longitude);
            Direction_travel.Text = Direction.ToString();

            if (handicapped)
                Handicap.Text = "Yes";
            else
                Handicap.Text = "No";

            foreach(DataRow r in Line_info.Tables[0].Rows)
            {
                string line_color = Convert.ToString(r["Color"]);
                Lines.Items.Add(line_color);
            }
        }

        //when top 10 is clicked, find the busiest stations and show them in the station list,
        //as well as how many riders in each.
        private void Top10_button_Click(object sender, EventArgs e)
        {
            Station_list.Items.Clear();
            string sql = string.Format(@"
                Select Top(10) sum(Riderships.DailyTotal) as Riders, Stations.Name
                from Stations
                inner join Riderships on Stations.StationID = Riderships.StationID
                group by Stations.Name
                order by Riders desc;
            ");                         //finds top 10 stations and how many riders total

            DataSet result = new DataSet();
            SqlConnection db = db_connect();        //excecute
            result = adapter_Q(sql, db);
            db.Close();

            foreach(DataRow row in result.Tables[0].Rows)   //fill in results
            {
                string entry = string.Format(@"{1}: {0:,000,000}",
                                Convert.ToInt64(row["Riders"]),
                                Convert.ToString(row["Name"])
                                );
                Station_list.Items.Add(entry);
            }

        }
    }
}
