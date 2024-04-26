using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    class clsSelection
    {

        public static void SelectCampuses(DataGridView GV, DataGridViewColumn GVCAMPUSID, DataGridViewColumn GVCAMPUS, DataGridViewColumn GVADDRESS,
            DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2, DataGridViewColumn GVEMAIL, DataGridViewColumn GVSTATUS, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectCampuses", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchCampuses", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVCAMPUSID.DataPropertyName = dt.Columns["CampID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Name"].ToString();
                GVADDRESS.DataPropertyName = dt.Columns["Address"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["Phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["Phone2"].ToString();
                GVEMAIL.DataPropertyName = dt.Columns["Email"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectLevels(DataGridView GV, DataGridViewColumn GVCAMPUSID, DataGridViewColumn GVCAMPUS, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, int campusID, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectLevelsWRTCampus", MainClass.con);
                    com.Parameters.AddWithValue("@CampusID", campusID);
                }
                else
                {
                    com = new SqlCommand("stp_SearchLevels", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectClasses(DataGridView GV, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS, DataGridViewColumn GVCAMPUSID, DataGridViewColumn GVCAMPUS,
            DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVSTATUS, DataGridViewColumn GVCLASSNUMBER, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectClasses", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchClasses", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Name"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GVCLASSNUMBER.DataPropertyName = dt.Columns["ClassNumber"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectSections(DataGridView GV, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVCAMPUSID,
            DataGridViewColumn GVCAMPUS, DataGridViewColumn GVSECTION, DataGridViewColumn GVSTATUS, int campusID, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectSectionsWRTCampus", MainClass.con);
                    com.Parameters.AddWithValue("@CampusID", campusID);
                }
                else
                {
                    com = new SqlCommand("stp_SearchSections", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Name"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectPeriods(DataGridView GV, DataGridViewColumn GVPERIODID, DataGridViewColumn GVPERIOD, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectPeriods", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchPeriods", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVPERIODID.DataPropertyName = dt.Columns["PeriodID"].ToString();
                GVPERIOD.DataPropertyName = dt.Columns["Period"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectClasseTimings(DataGridView GV, DataGridViewColumn gvCTID, DataGridViewColumn GVPERIODID, DataGridViewColumn GVPERIOD, DataGridViewColumn GVSHIFTID,
           DataGridViewColumn GVSHIFT, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVSTARTTIME, DataGridViewColumn GVENDTIME, DataGridViewColumn GVDAY,int levelID, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectClassTimings", MainClass.con);
                    com.Parameters.AddWithValue("@levelID", levelID);
                }
                else
                {
                    com = new SqlCommand("stp_SearchClassTimings", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvCTID.DataPropertyName = dt.Columns["CTID"].ToString();
                GVPERIODID.DataPropertyName = dt.Columns["PeriodID"].ToString();
                GVPERIOD.DataPropertyName = dt.Columns["Period"].ToString();
                GVSHIFTID.DataPropertyName = dt.Columns["ShiftID"].ToString();
                GVSHIFT.DataPropertyName = dt.Columns["Shift"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVSTARTTIME.DataPropertyName = dt.Columns["StartTime"].ToString();
                GVENDTIME.DataPropertyName = dt.Columns["EndTime"].ToString();
                GVDAY.DataPropertyName = dt.Columns["Day"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectShifts(DataGridView GV, DataGridViewColumn GVSHIFTID, DataGridViewColumn GVCAMPUSID, DataGridViewColumn GVCAMPUS,
            DataGridViewColumn GVSHIFT, DataGridViewColumn GVSTARTTIME, DataGridViewColumn GVENDTIME, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectShifts", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchShifts", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSHIFTID.DataPropertyName = dt.Columns["ShiftID"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVSHIFT.DataPropertyName = dt.Columns["Name"].ToString();
                GVSTARTTIME.DataPropertyName = dt.Columns["StartTime"].ToString();
                GVENDTIME.DataPropertyName = dt.Columns["EndTime"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectSubjects(DataGridView GV, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS, DataGridViewColumn GVLEVELID,
            DataGridViewColumn GVLEVEL, DataGridViewColumn GVSUBJECTID, DataGridViewColumn GVSUBJECT,int classID, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectSubjects", MainClass.con);
                    com.Parameters.AddWithValue("@classID", classID);
                }
                else
                {
                    com = new SqlCommand("stp_SearchSubjects", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVSUBJECTID.DataPropertyName = dt.Columns["SubjectID"].ToString();
                GVSUBJECT.DataPropertyName = dt.Columns["Subject"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStaff(DataGridView GV, DataGridViewColumn GVPRIORITY, DataGridViewColumn GVSTAFFID, DataGridViewColumn GVNAME, DataGridViewColumn GVCNIC,
            DataGridViewColumn GVCAMPUSID, DataGridViewColumn GVCAMPUS, DataGridViewColumn GVUSERNAME, DataGridViewColumn GVPASSWORD,
            DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2, DataGridViewColumn GVROLE, DataGridViewColumn GVSCALE, DataGridViewColumn GVGENDER,
            DataGridViewColumn GVSTATUS, DataGridViewColumn GVJOINDATE, DataGridViewColumn GVLEFTDATE, DataGridViewColumn GVSALARY, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectStaffDetails", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchStaff", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVPRIORITY.DataPropertyName = dt.Columns["Priority"].ToString();
                GVSTAFFID.DataPropertyName = dt.Columns["STaffID"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["CampusName"].ToString();
                GVNAME.DataPropertyName = dt.Columns["Name"].ToString();
                GVCNIC.DataPropertyName = dt.Columns["CNIC"].ToString();
                GVUSERNAME.DataPropertyName = dt.Columns["Username"].ToString();
                GVPASSWORD.DataPropertyName = dt.Columns["Password"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["Phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["Phone2"].ToString();
                GVROLE.DataPropertyName = dt.Columns["Role"].ToString();
                GVSCALE.DataPropertyName = dt.Columns["Scale"].ToString();
                GVGENDER.DataPropertyName = dt.Columns["Gender"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GVJOINDATE.DataPropertyName = dt.Columns["JoinDate"].ToString();
                GVLEFTDATE.DataPropertyName = dt.Columns["LeftDate"].ToString();
                GVSALARY.DataPropertyName = dt.Columns["Salery"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectClassAssignments(DataGridView GV, DataGridViewColumn GVASSIGNID, DataGridViewColumn GVCTID, DataGridViewColumn GVCAMPUSID,
            DataGridViewColumn GVCAMPUS, DataGridViewColumn GVSHIFTID, DataGridViewColumn GVSHIFT, DataGridViewColumn GVSTAFFID,
            DataGridViewColumn GVSTAFFF, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
            DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVPERIODID, DataGridViewColumn GVPERIOD, DataGridViewColumn GVSUBJECTID, DataGridViewColumn GVSUBJECT, DataGridViewColumn GVDAY, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectAssignments", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchAssignments", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVASSIGNID.DataPropertyName = dt.Columns["AssignID"].ToString();
                GVCTID.DataPropertyName = dt.Columns["CTID"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVSHIFTID.DataPropertyName = dt.Columns["ShiftID"].ToString();
                GVSHIFT.DataPropertyName = dt.Columns["Shift"].ToString();
                GVSTAFFID.DataPropertyName = dt.Columns["StaffID"].ToString();
                GVSTAFFF.DataPropertyName = dt.Columns["Staff"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVPERIODID.DataPropertyName = dt.Columns["PeriodID"].ToString();
                GVPERIOD.DataPropertyName = dt.Columns["Period"].ToString();
                GVSUBJECTID.DataPropertyName = dt.Columns["SubjectID"].ToString();
                GVSUBJECT.DataPropertyName = dt.Columns["Subject"].ToString();
                GVDAY.DataPropertyName = dt.Columns["Day"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }


        public static int SelectExistStaffAttendance(DateTime date)
        {
            int ChkstaffAttendance = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectExistStaffAttendance", MainClass.con);
                com.Parameters.AddWithValue("@Date", date);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ChkstaffAttendance++;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return ChkstaffAttendance;
        }

        public static void SelectStaffAttendance(DataGridView GV, DataGridViewColumn GVATTENDID, DataGridViewColumn GVSTAFFID, DataGridViewColumn GVCNIC,
            DataGridViewColumn GVSTAFF, DataGridViewColumn GVROLE, DataGridViewColumn GVDATE, DataGridViewColumn GVSTATUS, DateTime date, int campusID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStaffAttendance", MainClass.con);
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVATTENDID.DataPropertyName = dt.Columns["StaffAttendanceID"].ToString();
                GVSTAFFID.DataPropertyName = dt.Columns["StaffID"].ToString();
                GVCNIC.DataPropertyName = dt.Columns["CNIC"].ToString();
                GVSTAFF.DataPropertyName = dt.Columns["Staff"].ToString();
                GVROLE.DataPropertyName = dt.Columns["Role"].ToString();
                GVDATE.DataPropertyName = dt.Columns["Date"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStaffDetailsForAttendance(DataGridView GV, DataGridViewColumn GVSTAFFID, DataGridViewColumn GVCNIC,
            DataGridViewColumn GVSTAFF, DataGridViewColumn GVROLE, int campusID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStaffDetailsForAttendance", MainClass.con);
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSTAFFID.DataPropertyName = dt.Columns["StaffID"].ToString();
                GVCNIC.DataPropertyName = dt.Columns["CNIC"].ToString();
                GVSTAFF.DataPropertyName = dt.Columns["Name"].ToString();
                GVROLE.DataPropertyName = dt.Columns["Role"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStaffForSalery(DataGridView GV, DataGridViewColumn GVSTAFFID, DataGridViewColumn GVCNIC,
           DataGridViewColumn GVSTAFF, DataGridViewColumn GVROLE, DataGridViewColumn GVSCALE, DataGridViewColumn GVSALARY, DataGridViewColumn GVTWD,
           DataGridViewColumn GVTP, DataGridViewColumn GVTA, DataGridViewColumn GVTL, DataGridViewColumn GVTHL, DataGridViewColumn GVGL, DataGridViewColumn GVPAIDSALARY, int month, int year)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStaffForSalery", MainClass.con);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSTAFFID.DataPropertyName = dt.Columns["StaffID"].ToString();
                GVCNIC.DataPropertyName = dt.Columns["CNIC"].ToString();
                GVSTAFF.DataPropertyName = dt.Columns["Staff"].ToString();
                GVROLE.DataPropertyName = dt.Columns["Role"].ToString();
                GVSCALE.DataPropertyName = dt.Columns["Scale"].ToString();
                GVSALARY.DataPropertyName = dt.Columns["Salery"].ToString();
                GVTWD.DataPropertyName = dt.Columns["WorkingDays"].ToString();
                GVTP.DataPropertyName = dt.Columns["TP"].ToString();
                GVTA.DataPropertyName = dt.Columns["TA"].ToString();
                GVTL.DataPropertyName = dt.Columns["TL"].ToString();
                GVTHL.DataPropertyName = dt.Columns["THL"].ToString();
                GVGL.DataPropertyName = dt.Columns["TGL"].ToString();
                GVPAIDSALARY.DataPropertyName = dt.Columns["PaidSalary"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStaffSalery(DataGridView GV, DataGridViewColumn GVSTAFFID, DataGridViewColumn GVCNIC,
           DataGridViewColumn GVSTAFF, DataGridViewColumn GVROLE, DataGridViewColumn GVSCALE, DataGridViewColumn GVSALARY, DataGridViewColumn GVTWD,
           DataGridViewColumn GVTP, DataGridViewColumn GVTA, DataGridViewColumn GVTL, DataGridViewColumn GVTHL, DataGridViewColumn GVGL, DataGridViewColumn GVPAIDSALARY,
           DataGridViewColumn GVSALARYID, DataGridViewColumn GVPAIDDATE, DataGridViewColumn GVPAIDSTATUS, DataGridViewColumn GVBONUS, int month, int year)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStaffSalery", MainClass.con);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVSALARYID.DataPropertyName = dt.Columns["SalaryID"].ToString();
                GVSTAFFID.DataPropertyName = dt.Columns["StaffID"].ToString();
                GVCNIC.DataPropertyName = dt.Columns["CNIC"].ToString();
                GVSTAFF.DataPropertyName = dt.Columns["Staff"].ToString();
                GVROLE.DataPropertyName = dt.Columns["Role"].ToString();
                GVSCALE.DataPropertyName = dt.Columns["Scale"].ToString();
                GVSALARY.DataPropertyName = dt.Columns["Salery"].ToString();
                GVTWD.DataPropertyName = dt.Columns["WorkingDays"].ToString();
                GVTP.DataPropertyName = dt.Columns["TP"].ToString();
                GVTA.DataPropertyName = dt.Columns["TA"].ToString();
                GVTL.DataPropertyName = dt.Columns["TL"].ToString();
                GVTHL.DataPropertyName = dt.Columns["THL"].ToString();
                GVGL.DataPropertyName = dt.Columns["TGL"].ToString();
                GVPAIDSTATUS.DataPropertyName = dt.Columns["PaidStatus"].ToString();
                GVPAIDDATE.DataPropertyName = dt.Columns["PaidDate"].ToString();
                GVPAIDSALARY.DataPropertyName = dt.Columns["PaidSalary"].ToString();
                GVBONUS.DataPropertyName = dt.Columns["Bonus"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int SelectExistStaffSalary(int month, int year)
        {
            int chkExistSalary = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectExistStaffSalary", MainClass.con);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@year", year);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        chkExistSalary++;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return chkExistSalary;
        }

        public static int CheckLeftStudent(Int64 regNo)
        {
            int chkLeftStudent = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectCheckLeftStudent", MainClass.con);
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        chkLeftStudent++;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return chkLeftStudent;
        }


        public static void SelectAdmissions(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVGENDER,
           DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVMOTHERNAME, DataGridViewColumn GVFATHERPROFESSION, DataGridViewColumn GVMOTHERPROFESSION, DataGridViewColumn GVRELEGION, DataGridViewColumn GVSTATUS,
           DataGridViewColumn GVDOB, DataGridViewColumn GVAGE, DataGridViewColumn GVNATIONALITY, DataGridViewColumn GVPOB, DataGridViewColumn GVCAMPUSID, DataGridViewColumn GVCAMPUS,
           DataGridViewColumn GVSESSION, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
           DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVADMISSIONDATE, DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2,
            DataGridViewColumn GVWHATSAPP, DataGridViewColumn GVADDRESS, DataGridViewColumn GVPRESCHOOLNAME, DataGridViewColumn GVREFERENCE,
            DataGridViewColumn GVCNICSTUDENT, DataGridViewColumn GVCNICFATHER, DataGridViewColumn GVCASTE, int Session, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectAdmissions", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                }
                else
                {
                    com = new SqlCommand("stp_SearchAdmissions", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVGENDER.DataPropertyName = dt.Columns["Gender"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVMOTHERNAME.DataPropertyName = dt.Columns["MotherName"].ToString();
                GVFATHERPROFESSION.DataPropertyName = dt.Columns["FatherProfession"].ToString();
                GVMOTHERPROFESSION.DataPropertyName = dt.Columns["MotherProfession"].ToString();
                GVRELEGION.DataPropertyName = dt.Columns["Relegion"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GVDOB.DataPropertyName = dt.Columns["DOB"].ToString();
                GVAGE.DataPropertyName = dt.Columns["Age"].ToString();
                GVNATIONALITY.DataPropertyName = dt.Columns["Nationality"].ToString();
                GVPOB.DataPropertyName = dt.Columns["POB"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVSESSION.DataPropertyName = dt.Columns["Session"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVADMISSIONDATE.DataPropertyName = dt.Columns["AdmissionDate"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["Phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["Phone2"].ToString();
                GVWHATSAPP.DataPropertyName = dt.Columns["Whatsapp"].ToString(); 
                GVADDRESS.DataPropertyName = dt.Columns["Address"].ToString();
                GVPRESCHOOLNAME.DataPropertyName = dt.Columns["PreSchoolName"].ToString();
                GVREFERENCE.DataPropertyName = dt.Columns["Reference"].ToString();
                GVCNICSTUDENT.DataPropertyName = dt.Columns["CNICStudent"].ToString();
                GVCNICFATHER.DataPropertyName = dt.Columns["CNICFather"].ToString();
                GVCASTE.DataPropertyName = dt.Columns["Caste"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int SelectAttendanceExistWRTDate(DateTime date, int classID=0, int sectionID=0)
        {
            int ChkStudentAttendance = 0;
            try
            {
                SqlCommand com;
                if (classID!=0 && sectionID!=0)
                {
                    com = new SqlCommand("stp_SelectAttendanceExistWRTDate", MainClass.con);
                    com.Parameters.AddWithValue("@Date", date);
                    com.Parameters.AddWithValue("@ClassID", classID);
                    com.Parameters.AddWithValue("@SectionID", sectionID);
                }
                else
                {
                    com = new SqlCommand("stp_SelectAttendanceExistWRTDateOnly", MainClass.con);
                    com.Parameters.AddWithValue("@Date", date);
                }
                
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ChkStudentAttendance++;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return ChkStudentAttendance;
        }

        public static void SelectAttendanceWRTDate(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVCLASSID,
           DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVATTENDANCEID,
           DataGridViewColumn GVDATE, DataGridViewColumn GVSTATUS, DateTime date, int classID, int sectionID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_selectAttendanceWRTDate", MainClass.con);
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVATTENDANCEID.DataPropertyName = dt.Columns["AttendanceID"].ToString();
                GVDATE.DataPropertyName = dt.Columns["Date"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStudentsForAttendance(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVCLASSID,
           DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, int levelID, int classID, int sectionID, int session)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStudentsWRT_Level_Session_Class_Section_And_Status", MainClass.con);
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Session", session);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SearchAttendanceWRTDate(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVCLASSID,
           DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVATTENDANCEID,
           DataGridViewColumn GVDATE, DataGridViewColumn GVSTATUS, DateTime date, int classID, int sectionID, string data)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SearchAttendanceWRTDate", MainClass.con);
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@data", data);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVATTENDANCEID.DataPropertyName = dt.Columns["AttendanceID"].ToString();
                GVDATE.DataPropertyName = dt.Columns["Date"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStudentsWRT_Level_Session_Class_Section_And_Status(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME,
            DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
            DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn gvSESSION, DataGridViewColumn GVSTATUS, int levelID, int classID, int sectionID, int session, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectStudentsWRT_Level_Session_Class_Section_And_Status", MainClass.con);
                    com.Parameters.AddWithValue("@LevelID", levelID);
                    com.Parameters.AddWithValue("@ClassID", classID);
                    com.Parameters.AddWithValue("@SectionID", sectionID);
                    com.Parameters.AddWithValue("@Session", session);
                }
                else
                {
                    com = new SqlCommand("stp_SearchActiveStudents", MainClass.con);
                    com.Parameters.AddWithValue("@LevelID", levelID);
                    com.Parameters.AddWithValue("@ClassID", classID);
                    com.Parameters.AddWithValue("@SectionID", sectionID);
                    com.Parameters.AddWithValue("@Session", session);
                    com.Parameters.AddWithValue("@Data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                gvSESSION.DataPropertyName = dt.Columns["Session"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectPassoutStudents(DataGridView GV, DataGridViewColumn GVLEFTID, DataGridViewColumn GVSESSION, DataGridViewColumn GVCAMPUSID,
            DataGridViewColumn GVCAMPUS, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVGENDER,
          DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2 , DataGridViewColumn GVADDRESS,
          DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
          DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVADMISSIONDATE,
           DataGridViewColumn GVPASSOUTDATE, int Session,int LEVEL, int CLASS, int SECTION, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data==null)
                {
                    com = new SqlCommand("stp_SelectPassoutStudents", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@Level", LEVEL);
                    com.Parameters.AddWithValue("@Class", CLASS);
                    com.Parameters.AddWithValue("@Section", SECTION);
                }
                else
                {
                    com = new SqlCommand("stp_SearchPassoutStudents", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@Level", LEVEL);
                    com.Parameters.AddWithValue("@Class", CLASS);
                    com.Parameters.AddWithValue("@Section", SECTION);
                    com.Parameters.AddWithValue("@Data", data);
                }
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVLEFTID.DataPropertyName = dt.Columns["LeftID"].ToString();
                GVSESSION.DataPropertyName = dt.Columns["Session"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["Student"].ToString();
                GVGENDER.DataPropertyName = dt.Columns["Gender"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["Phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["Phone2"].ToString();
                GVADDRESS.DataPropertyName = dt.Columns["Address"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVADMISSIONDATE.DataPropertyName = dt.Columns["AdmissionDate"].ToString();
                GVPASSOUTDATE.DataPropertyName = dt.Columns["PassoutDate"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectLeftStudents(DataGridView GV, DataGridViewColumn GVLEFTID, DataGridViewColumn GVSESSION, DataGridViewColumn GVCAMPUSID,
            DataGridViewColumn GVCAMPUS, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVGENDER,
          DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2, DataGridViewColumn GVADDRESS,
          DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
          DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVADMISSIONDATE,
           DataGridViewColumn GVLEFTdATE, int Session, int LEVEL, int CLASS, int SECTION, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectLeftStudents", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@Level", LEVEL);
                    com.Parameters.AddWithValue("@Class", CLASS);
                    com.Parameters.AddWithValue("@Section", SECTION);
                }
                else
                {
                    com = new SqlCommand("stp_searchLeftStudents", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@Level", LEVEL);
                    com.Parameters.AddWithValue("@Class", CLASS);
                    com.Parameters.AddWithValue("@Section", SECTION);
                    com.Parameters.AddWithValue("@Data", data);
                }
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVLEFTID.DataPropertyName = dt.Columns["LeftID"].ToString();
                GVSESSION.DataPropertyName = dt.Columns["Session"].ToString();
                GVCAMPUSID.DataPropertyName = dt.Columns["CampusID"].ToString();
                GVCAMPUS.DataPropertyName = dt.Columns["Campus"].ToString();
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["Student"].ToString();
                GVGENDER.DataPropertyName = dt.Columns["Gender"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["Phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["Phone2"].ToString();
                GVADDRESS.DataPropertyName = dt.Columns["Address"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVADMISSIONDATE.DataPropertyName = dt.Columns["AdmissionDate"].ToString();
                GVLEFTdATE.DataPropertyName = dt.Columns["LeftDate"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectPaymentMethods(DataGridView GV, DataGridViewColumn GVBANKID, DataGridViewColumn GVBANK, DataGridViewColumn GVBRANCH,
            DataGridViewColumn GVADDRESS, DataGridViewColumn GVACCOUNT, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectPaymentMethods", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchPaymentMethods", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVBANKID.DataPropertyName = dt.Columns["BankID"].ToString();
                GVBANK.DataPropertyName = dt.Columns["Bank"].ToString();
                GVBRANCH.DataPropertyName = dt.Columns["Branch"].ToString();
                GVADDRESS.DataPropertyName = dt.Columns["Address"].ToString();
                GVACCOUNT.DataPropertyName = dt.Columns["Account"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectFeeStructures(DataGridView GV, DataGridViewColumn GVFEESTRUCid, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
           DataGridViewColumn GVADMFEE, DataGridViewColumn GVMONTHLYFEE, DataGridViewColumn GVBOOKSFEE, DataGridViewColumn GVEXAMSFEE,
            DataGridViewColumn GVLATEFEE, DataGridViewColumn GVABSENTFEE, DataGridViewColumn GVMISCfEE, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectFeeStructure", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchFeeStructure", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVFEESTRUCid.DataPropertyName = dt.Columns["FeeStrucID"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVADMFEE.DataPropertyName = dt.Columns["AdmissionFee"].ToString();
                GVMONTHLYFEE.DataPropertyName = dt.Columns["MonthlyFee"].ToString();
                GVBOOKSFEE.DataPropertyName = dt.Columns["BooksFee"].ToString();
                GVEXAMSFEE.DataPropertyName = dt.Columns["ExamsFee"].ToString();
                GVLATEFEE.DataPropertyName = dt.Columns["LateFine"].ToString();
                GVABSENTFEE.DataPropertyName = dt.Columns["AbsentFine"].ToString();
                GVMISCfEE.DataPropertyName = dt.Columns["MiscFee"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectFeeConcession(DataGridView GV, DataGridViewColumn GVFEECONCID, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
           DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME,
            DataGridViewColumn GVDISCOUNT, DataGridViewColumn GVREASON, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectFeeConcessions", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchFeeConcessions", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVFEECONCID.DataPropertyName = dt.Columns["FeeConcID"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVDISCOUNT.DataPropertyName = dt.Columns["Discount"].ToString();
                GVREASON.DataPropertyName = dt.Columns["Reason"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }
        
        public static int SelectCheckFeeVouchersWRTClass(int session,int classID,int sectionID,int month,int year)
        {
            int chwck = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_GetCheckFeeVouchersWRTClass", MainClass.con);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        chwck++;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return chwck;
        }

        public static void SelectGetFeeVouchersWRTClass(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME,
            DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, 
            DataGridViewColumn GVSECTION,  DataGridViewColumn GVFEEVOUCHERID, DataGridViewColumn GVDUEDATE, DataGridViewColumn GVPRESENTFEE, 
            DataGridViewColumn GVDISCOUNT, DataGridViewColumn GVREASON,
            int session, int classID, int sectionID, int month, int year)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_GetFeeVouchersWRTClass", MainClass.con);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVFEEVOUCHERID.DataPropertyName = dt.Columns["FeeVoucherID"].ToString();
                GVDUEDATE.DataPropertyName = dt.Columns["DueDate"].ToString();
                GVPRESENTFEE.DataPropertyName = dt.Columns["PresentFee"].ToString();
                GVDISCOUNT.DataPropertyName = dt.Columns["Discount"].ToString();
                GVREASON.DataPropertyName = dt.Columns["Reason"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStudentsForFeeVouchers(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVFATHERNAME, 
            DataGridViewColumn GVCLASSID,DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, 
            int levelID, int classID, int sectionID, int session)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStudentsWRT_Level_Session_Class_Section_And_Status", MainClass.con);
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Session", session);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectGetFeeVouchersWRTRegNo(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME,
            DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID,
            DataGridViewColumn GVSECTION, DataGridViewColumn GVFEEVOUCHERID, DataGridViewColumn GVDUEDATE, DataGridViewColumn GVPRESENTFEE,
            DataGridViewColumn GVDISCOUNT, DataGridViewColumn GVREASON,
            int session, Int64 regNo , int month, int year)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_GetFeeVouchersWRT_RegNo", MainClass.con);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVFEEVOUCHERID.DataPropertyName = dt.Columns["FeeVoucherID"].ToString();
                GVDUEDATE.DataPropertyName = dt.Columns["DueDate"].ToString();
                GVPRESENTFEE.DataPropertyName = dt.Columns["PresentFee"].ToString();
                GVDISCOUNT.DataPropertyName = dt.Columns["Discount"].ToString();
                GVREASON.DataPropertyName = dt.Columns["Reason"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int SelectCheckFeeVouchersWRTRegNo(int session, Int64 regNo, int month, int year)
        {
            int check = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_GetCheckFeeVouchersWRT_RegNo", MainClass.con);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        check++;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return check;
        }

        public static void SelectStudentsWRT_RegNo_Session(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVFATHERNAME,
           DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION,
           Int64 regNo, int session)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStudentsWRT_RegNo_Session", MainClass.con);
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@Session", session);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static string[] SelectMonthlyFeeWRTClass(int classID)
        {
            string[] MONTHLYFEE = new string[2];
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectMonthlyFeeWRTClass", MainClass.con);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        MONTHLYFEE[0] = dr[0].ToString();
                        MONTHLYFEE[1] = dr[1].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return MONTHLYFEE;
        }

        public static string[] SelectPresentFeeForFeeVoucers(int session,Int64 ReNo,int month, int year,
            Int16 AdmissionFeeStat, Int16 AbsentFeeStat, Int16 BooksFeeStat, Int16 ExamsFeeStat, Int16 MiscFeeStat,Int16 LateFeeStat)
        {
            string[] PRESENTFEE = new string[8];
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectPresentFeeForFeeVoucers", MainClass.con);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@RegNo", ReNo);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.Parameters.AddWithValue("AdmissionFeeStat", AdmissionFeeStat);
                com.Parameters.AddWithValue("@AbsentFeeStat", AbsentFeeStat);
                com.Parameters.AddWithValue("@BooksFeeStat", BooksFeeStat);
                com.Parameters.AddWithValue("@ExamsFeeStat", ExamsFeeStat);
                com.Parameters.AddWithValue("@MiscFeeStat", MiscFeeStat);
                com.Parameters.AddWithValue("@LateFeeStat", LateFeeStat);

                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PRESENTFEE[0] = dr["MonthlyFee"].ToString();
                        PRESENTFEE[1] = dr["Discount"].ToString();
                        PRESENTFEE[2] = dr["AdmissionFee"].ToString();
                        PRESENTFEE[3] = dr["AbsentFee"].ToString();
                        PRESENTFEE[4] = dr["BooksFee"].ToString();
                        PRESENTFEE[5] = dr["ExamsFee"].ToString();
                        PRESENTFEE[6] = dr["MiscFee"].ToString();
                        PRESENTFEE[7] = dr["LateFee"].ToString();
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return PRESENTFEE;
        }   

        public static void SelectGetFeeVouchersWRTClassForFeePayment(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME,
            DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVFEEVOUCHERID, DataGridViewColumn GVSTATUS, DataGridViewColumn GVPAYMENTDATE,
            int session, int classID, int sectionID, Int16 month, Int16 year)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_GetFeeVouchersWRTClass", MainClass.con);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVFEEVOUCHERID.DataPropertyName = dt.Columns["FeeVoucherID"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["PaidStatus"].ToString();
                GVPAYMENTDATE.DataPropertyName = dt.Columns["PaymentDate"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectExamTypes(DataGridView GV, DataGridViewColumn GVEXAMTYPEID, DataGridViewColumn GVSESSION, DataGridViewColumn GVEXAMNAME,
           DataGridViewColumn GVRESULTDATE, DataGridViewColumn GVRESULTTIME, DataGridViewColumn GVRESULTVENUE, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectExamTypes", MainClass.con);
                }
                else
                {
                    com = new SqlCommand("stp_SearchExamTypes", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVEXAMTYPEID.DataPropertyName = dt.Columns["ExamTypeID"].ToString();
                GVSESSION.DataPropertyName = dt.Columns["Session"].ToString();
                GVEXAMNAME.DataPropertyName = dt.Columns["ExamName"].ToString();
                GVRESULTDATE.DataPropertyName = dt.Columns["ResultDate"].ToString();
                GVRESULTTIME.DataPropertyName = dt.Columns["ResultTime"].ToString();
                GVRESULTVENUE.DataPropertyName = dt.Columns["ResultVenue"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static Int64 SelectExamID()
        {
            Int64 ExamID = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectExamID", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ExamID = Convert.ToInt64( dr[0]); 
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return ExamID;
        }

        public static void SelectExamDetails(DataGridView GV, DataGridViewColumn GVEXAMTYPEID, DataGridViewColumn GVEXAMNAME, DataGridViewColumn GVEXAMID,
           DataGridViewColumn GVEXAMDETAILID, DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID,
            DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVSUBJECTID,
             DataGridViewColumn GVSUBJECT, DataGridViewColumn GVEXAMDATE, DataGridViewColumn GVTOTALMARKS, DataGridViewColumn GVPASSINGPERCENT,
             int Session,Int64 examTypeID, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectExamDetails", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@ExamTypeID", examTypeID);
                }
                else
                {
                    com = new SqlCommand("stp_SearchExamDetails", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@ExamTypeID", examTypeID);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVEXAMTYPEID.DataPropertyName = dt.Columns["ExamTypeID"].ToString();
                GVEXAMNAME.DataPropertyName = dt.Columns["ExamName"].ToString();
                GVEXAMID.DataPropertyName = dt.Columns["ExamID"].ToString();
                GVEXAMDETAILID.DataPropertyName = dt.Columns["ExamDetailID"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVSUBJECTID.DataPropertyName = dt.Columns["SubjectID"].ToString();
                GVSUBJECT.DataPropertyName = dt.Columns["Subject"].ToString();
                GVEXAMDATE.DataPropertyName = dt.Columns["ExamDate"].ToString();
                GVTOTALMARKS.DataPropertyName = dt.Columns["TotalMarks"].ToString();
                GVPASSINGPERCENT.DataPropertyName = dt.Columns["PassingPercent"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static Int64 SelectResultID()
        {
            Int64 resultID = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectResultID", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        resultID = Convert.ToInt64(dr[0]);
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return resultID;
        }

        public static float SelectTotalMarksFromsExamDetails(Int64 examTYpeID, int classID, int sectionID, int subjectID)
        {
            float totalMarks = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectTotalMarksFromsExamDetails", MainClass.con);
                com.Parameters.AddWithValue("@ExamTypeID", examTYpeID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@SubjectID", subjectID);
                com.CommandType = CommandType.StoredProcedure;

                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        totalMarks = Convert.ToSingle(dr[0]);
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return totalMarks;
        }

        public static void SelectResultDetails(DataGridView GV, DataGridViewColumn GVRESULTID, DataGridViewColumn GVRESULTDETAILID, DataGridViewColumn GVREGNO,
           DataGridViewColumn GVSTUDENT, DataGridViewColumn GVSUBJECTID, DataGridViewColumn GVSUBJECT, DataGridViewColumn GVTOTAL, DataGridViewColumn GVOBTAINEDMARKS,
           DataGridViewColumn GVPERCENTAGE,DataGridViewColumn GVGRADE, DataGridViewColumn GVREMARKS, DataGridViewColumn GVGRANDOBTAINED, DataGridViewColumn GVGRANDPERCENTAGE, 
           DataGridViewColumn GVGRANDGRADE, DataGridViewColumn GVGRANDREMARKS, DataGridViewColumn GVPOSITION,
             int Session, Int64 examTypeID,int classID,int sectionID, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectResultDetailsWRT_Session_ExamType_Class_Section", MainClass.con);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@ExamTypeID", examTypeID);
                    com.Parameters.AddWithValue("@ClassID", classID);
                    com.Parameters.AddWithValue("@SectionID", sectionID);
                }
                else
                {
                    com = new SqlCommand("stp_SearchResultDetails", MainClass.con);
                    com.Parameters.AddWithValue("@data", data);
                    com.Parameters.AddWithValue("@Session", Session);
                    com.Parameters.AddWithValue("@ExamTypeID", examTypeID);
                    com.Parameters.AddWithValue("@ClassID", classID);
                    com.Parameters.AddWithValue("@SectionID", sectionID);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVRESULTID.DataPropertyName = dt.Columns["ResultID"].ToString();
                GVRESULTDETAILID.DataPropertyName = dt.Columns["ResultDetailID"].ToString();
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUDENT.DataPropertyName = dt.Columns["Student"].ToString();
                GVSUBJECTID.DataPropertyName = dt.Columns["SubjectID"].ToString();
                GVSUBJECT.DataPropertyName = dt.Columns["Subject"].ToString();
                GVTOTAL.DataPropertyName = dt.Columns["Total"].ToString();
                GVOBTAINEDMARKS.DataPropertyName = dt.Columns["ObtainedMarks"].ToString();
                GVPERCENTAGE.DataPropertyName = dt.Columns["Percentage"].ToString();
                GVGRADE.DataPropertyName = dt.Columns["Grade"].ToString();
                GVREMARKS.DataPropertyName = dt.Columns["Remarks"].ToString();
                GVGRANDOBTAINED.DataPropertyName = dt.Columns["GrandObtained"].ToString();
                GVGRANDPERCENTAGE.DataPropertyName = dt.Columns["GrandPercentage"].ToString();
                GVGRANDGRADE.DataPropertyName = dt.Columns["GrandGrade"].ToString();
                GVGRANDREMARKS.DataPropertyName = dt.Columns["Grandremarks"].ToString();
                GVPOSITION.DataPropertyName = dt.Columns["Position"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectAbsentStudentsWRTDate(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVFATHERNAME, DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2, DataGridViewColumn GVWHATSAPP,
            DataGridViewColumn GVCLASSID,DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION,
           DataGridViewColumn GVDATE, DataGridViewColumn GVSTATUS, DateTime date, string search = null)
        {
            try
            {
                SqlCommand com;
                if (search==null)
                {
                    com = new SqlCommand("stp_SelectAbsentStudentsWRTDate", MainClass.con);
                    com.Parameters.AddWithValue("@Date", date);
                }
                else
                {
                    com = new SqlCommand("stp_SearchAbsentStudentsWRTDate", MainClass.con);
                    com.Parameters.AddWithValue("@Date", date);
                    com.Parameters.AddWithValue("@Data", search);
                }
              
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["Phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["Phone2"].ToString();
                GVWHATSAPP.DataPropertyName = dt.Columns["WhatsApp"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVDATE.DataPropertyName = dt.Columns["Date"].ToString();
                GVSTATUS.DataPropertyName = dt.Columns["Status"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static float SelectPassingPercentage(int subjID,Int64 ExamTypeID)
        {
            float PassingPercent = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectPassingPercentage", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SubjectID", subjID);
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PassingPercent = Convert.ToSingle(dr[0]);
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return PassingPercent;
        }

        public static void SelectExpenses(DataGridView GV, DataGridViewColumn GVEXPENSEID, DataGridViewColumn GVDATE,
            DataGridViewColumn GVEXPENSETYPE, DataGridViewColumn GVDESCRIPTION, DataGridViewColumn GVAMOUNT, DataGridViewColumn GVRECEIPTNAME, 
            DataGridViewColumn GVRECEIPTNO,int month, int year, int campusID, string data = null)
        {
            try
            {
                SqlCommand com;
                if (data == null)
                {
                    com = new SqlCommand("stp_SelectExpensesWRT_Month_Year_CampusID", MainClass.con);
                    com.Parameters.AddWithValue("@Month", month);
                    com.Parameters.AddWithValue("@Year", year);
                    com.Parameters.AddWithValue("@CampusID", campusID);
                }
                else
                {
                    com = new SqlCommand("stp_SearchExpensesWRT_Month_Year_CampusID", MainClass.con);
                    com.Parameters.AddWithValue("@Month", month);
                    com.Parameters.AddWithValue("@Year", year);
                    com.Parameters.AddWithValue("@CampusID", campusID);
                    com.Parameters.AddWithValue("@data", data);
                }

                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVEXPENSEID.DataPropertyName = dt.Columns["ExpenseID"].ToString();
                GVDATE.DataPropertyName = dt.Columns["Date"].ToString();
                GVEXPENSETYPE.DataPropertyName = dt.Columns["ExpenseType"].ToString();
                GVDESCRIPTION.DataPropertyName = dt.Columns["Description"].ToString();
                GVAMOUNT.DataPropertyName = dt.Columns["Amount"].ToString();
                GVRECEIPTNAME.DataPropertyName = dt.Columns["ReceiptName"].ToString();
                GVRECEIPTNO.DataPropertyName = dt.Columns["ReceiptNo"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static Int64 SelectExpenseID()
        {
            Int64 ExpenseID = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectExpenseID", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ExpenseID = Convert.ToInt64(dr[0]);
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return ExpenseID;
        }

        public static int SelectCheckStudentBirthday(int date, int month)
        {
            int check=0;
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectBirthDayOfSudent", MainClass.con);
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@Month", month);
                com.CommandType = CommandType.StoredProcedure;
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        check = 1;
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return check;
        }

        public static void SelectStudentBirthday(DataGridView GV,DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUDENT, DataGridViewColumn GVFATHERNAME,
            DataGridViewColumn GVDOB, DataGridViewColumn GVAGE, DataGridViewColumn GVCLASS, DataGridViewColumn GVSECTION, int date, int month)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectBirthDayOfSudent", MainClass.con);
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@Month", month);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUDENT.DataPropertyName = dt.Columns["Student"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVDOB.DataPropertyName = dt.Columns["DOB"].ToString();
                GVAGE.DataPropertyName = dt.Columns["Age"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void SelectStudentsForMessages(DataGridView GV, DataGridViewColumn GVREGNO, DataGridViewColumn GVSTUNAME, DataGridViewColumn GVFATHERNAME,
            DataGridViewColumn GVLEVELID, DataGridViewColumn GVLEVEL, DataGridViewColumn GVCLASSID, DataGridViewColumn GVCLASS,
           DataGridViewColumn GVSECTIONID, DataGridViewColumn GVSECTION, DataGridViewColumn GVPHONE1, DataGridViewColumn GVPHONE2,
            DataGridViewColumn GVWHATSAPP, int Session, int classID, int sectionID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStudentsForMessages", MainClass.con);
                com.Parameters.AddWithValue("@Session", Session);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GVREGNO.DataPropertyName = dt.Columns["RegNo"].ToString();
                GVSTUNAME.DataPropertyName = dt.Columns["StuName"].ToString();
                GVFATHERNAME.DataPropertyName = dt.Columns["FatherName"].ToString();
                GVLEVELID.DataPropertyName = dt.Columns["LevelID"].ToString();
                GVLEVEL.DataPropertyName = dt.Columns["Level"].ToString();
                GVCLASSID.DataPropertyName = dt.Columns["ClassID"].ToString();
                GVCLASS.DataPropertyName = dt.Columns["Class"].ToString();
                GVSECTIONID.DataPropertyName = dt.Columns["SectionID"].ToString();
                GVSECTION.DataPropertyName = dt.Columns["Section"].ToString();
                GVPHONE1.DataPropertyName = dt.Columns["Phone1"].ToString();
                GVPHONE2.DataPropertyName = dt.Columns["Phone2"].ToString();
                GVWHATSAPP.DataPropertyName = dt.Columns["Whatsapp"].ToString();
                GV.DataSource = dt;
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static string SelectStudentsWhatsAppNumber(Int64 RegNo)
        {
            String WhatsApp = "";
            try
            {
                SqlCommand com = new SqlCommand("stp_SelectStudentsWhatsAppNumberForMessages", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", RegNo);
                MainClass.con.Open();
                SqlDataReader dr = com.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        WhatsApp = Convert.ToString(dr[0]);
                    }
                }
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return WhatsApp;
        }
    }
}