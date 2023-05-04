using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS
{
    class clsInsertion
    {
        public static void AddCampuses(string campus, string address, string phone1, string phone2, string Email, Int16 Status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddCampuses", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", campus);
                com.Parameters.AddWithValue("@Address", address);
                com.Parameters.AddWithValue("@Phone1", phone1);
                com.Parameters.AddWithValue("@Phone2", phone2);
                com.Parameters.AddWithValue("@Email", Email);
                com.Parameters.AddWithValue("@Status", Status);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(campus + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddShifts(int campusID, string shift, TimeSpan start, TimeSpan end)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddShifts", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@Name", shift);
                com.Parameters.AddWithValue("@StartTime", start);
                com.Parameters.AddWithValue("@EndTime", end);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(shift + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddLevels(string level, int campusID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddLevels", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Level", level);
                com.Parameters.AddWithValue("@CampusID", campusID);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(level + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddClasses(string name, int campusID, int levelID, Int16 status,float ClassNumber)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddClasses", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Name", name);
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@ClassNumber", ClassNumber);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(name + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddSections(int campusID, string name, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddSections", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@Name", name);
                com.Parameters.AddWithValue("@Status", status);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(name + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddSubjects(int levelID, int classID, string subject)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddSubjects", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@Subject", subject);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(subject + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddPeriods(string period)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddPeriods", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Period", period);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(period + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddClassTimings(int periodID, int shiftID, int levelID, TimeSpan starttime, TimeSpan endtime, string day)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddClassTimings", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@PeriodID", periodID);
                com.Parameters.AddWithValue("@ShiftID", shiftID);
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@StartTime", starttime);
                com.Parameters.AddWithValue("@EndTime", endtime);
                com.Parameters.AddWithValue("@Day", day);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Successfully Added!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddStaffWithoutImage(int campusID,int priority, string CNIC, string name, string username, string password, string phone1, string phone2,
            string role, string scale, Int16 gender, Int16 status, DateTime joindate, DateTime leftdate, float salery)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddStaffWithoutImage", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@Priority", priority);
                com.Parameters.AddWithValue("@CNIC", CNIC);
                com.Parameters.AddWithValue("@Name", name);
                com.Parameters.AddWithValue("@Username", username);
                com.Parameters.AddWithValue("@Password", password);
                com.Parameters.AddWithValue("@Phone1", phone1);
                com.Parameters.AddWithValue("@Phone2", phone2);
                com.Parameters.AddWithValue("@Role", role);
                com.Parameters.AddWithValue("@Scale", scale);
                com.Parameters.AddWithValue("@Gender", gender);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@JoinDate", joindate);
                com.Parameters.AddWithValue("@LeftDate", leftdate);
                com.Parameters.AddWithValue("@Salery", salery);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(name + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddStaff(int campusID,int priority, string CNIC, string name, string username, string password, string phone1, string phone2,
            string role, string scale, Int16 gender, Int16 status, DateTime joindate, DateTime leftdate, float salery,object arr)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddStaff", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@Priority", priority);
                com.Parameters.AddWithValue("@CNIC", CNIC);
                com.Parameters.AddWithValue("@Name", name);
                com.Parameters.AddWithValue("@Username", username);
                com.Parameters.AddWithValue("@Password", password);
                com.Parameters.AddWithValue("@Phone1", phone1);
                com.Parameters.AddWithValue("@Phone2", phone2);
                com.Parameters.AddWithValue("@Role", role);
                com.Parameters.AddWithValue("@Scale", scale);
                com.Parameters.AddWithValue("@Gender", gender);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@JoinDate", joindate);
                com.Parameters.AddWithValue("@LeftDate", leftdate);
                com.Parameters.AddWithValue("@Salery", salery);
                com.Parameters.AddWithValue("@Image", arr);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(name + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddClassAssignments(int campusID, int shiftID,int classID,int sectionID,int CTID,int subjectID,int StaffID )
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddAssignments", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@ShiftID", shiftID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@CTID", CTID);
                com.Parameters.AddWithValue("@SubjectID", subjectID);
                com.Parameters.AddWithValue("@SatffID", StaffID);
                
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Successfully Added!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg("Possible Errors.\n\nAre you trying to assign period to this teacher again?\n\nYou can not assign a same period to same teacher again!\n\n"+x.Message, "Error", "Error");
            }
        }
       
        public static void  AddStaffAttendance(int staffID, DateTime date, string status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddStaffAttendance", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@StaffID", staffID);
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@Status", status);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");

            }
        }
        
        public static void AddSalery(Int16 month,Int16 year,int staffID,float paidSalery,DateTime paidDate,Int16 status, float bonus)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddSalary", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.Parameters.AddWithValue("@StaffID", staffID);
                com.Parameters.AddWithValue("@PaidSalary", paidSalery);
                com.Parameters.AddWithValue("@Date", paidDate);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@Bonus", bonus);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");

            }
        }

        public static void AddAdmissions(Int64 regNo, string name,Int16 gender,string fatherName,string motherName,string fatherProfession,string motherProfession,
            string relegion,DateTime DOB,string nationality,string placeOfBirth,int campusID,int classID, int sectionID,DateTime session,DateTime admissionDate, string phone1, string phone2,
            string Whatsapp, string address, string preSchool, object arr,Int16 status ,string reference,string CNICFather, string CNICStudent, string Caste,object QR)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddAdmissions", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@StuName", name);
                com.Parameters.AddWithValue("@Gender", gender);
                com.Parameters.AddWithValue("@FatherName", fatherName);
                com.Parameters.AddWithValue("@MotherName", motherName);
                com.Parameters.AddWithValue("@FatherProf", fatherProfession);
                com.Parameters.AddWithValue("@MotherProf", motherProfession);
                com.Parameters.AddWithValue("@Relegion", relegion);
                com.Parameters.AddWithValue("@DOB", DOB);
                com.Parameters.AddWithValue("@Nationality", nationality);
                com.Parameters.AddWithValue("@POB", placeOfBirth);
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@AdmissionDate", admissionDate);
                com.Parameters.AddWithValue("@Phone1", phone1);
                com.Parameters.AddWithValue("@Phone2", phone2);
                com.Parameters.AddWithValue("@Whatsapp", Whatsapp); 
                com.Parameters.AddWithValue("@Address", address);
                com.Parameters.AddWithValue("@PreSchoolName", preSchool);
                com.Parameters.AddWithValue("@Image", arr);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@Reference", reference);
                com.Parameters.AddWithValue("@CNICFather", CNICFather);
                com.Parameters.AddWithValue("@CNICStudent", CNICStudent);
                com.Parameters.AddWithValue("@Caste", Caste);
                com.Parameters.AddWithValue("@QRCode", QR);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(name + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddStudentsAttendance(DateTime  date,Int64 regNo,int classID,int sectionID, string status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddAttendance", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Date", date );
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Status", status);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddLeftStudent(Int64 regNo,DateTime leftDate,Int16 reason,Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddLeftStudents", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@LeftDate", leftDate);
                com.Parameters.AddWithValue("@Reason", reason);
                com.Parameters.AddWithValue("@Status", status);
                MainClass.con.Open();
                com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddPaymentMethods(string bank, string branch ,string address, string account)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddPaymentMethods", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Bank", bank);
                com.Parameters.AddWithValue("@branch", branch );
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@account", account);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(bank + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddFeeStructure(int classID,float admissionFee,float monthlyFee,float BooksFee,float examsFee,float lateFee,float absentFee,float miscFee)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddFeeStructure", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@AdmissionFee", admissionFee);
                com.Parameters.AddWithValue("@MonthlyFee", monthlyFee);
                com.Parameters.AddWithValue("@BooksFee", BooksFee);
                com.Parameters.AddWithValue("@ExamsFee", examsFee);
                com.Parameters.AddWithValue("@LateFine", lateFee);
                com.Parameters.AddWithValue("@AbsentFine", absentFee);
                com.Parameters.AddWithValue("@MiscFee", miscFee);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Added Successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void AddFeeConcession( Int64 regNo,float discount,string reason)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddFeeConcessions", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@Disount", discount);
                com.Parameters.AddWithValue("@Reason", reason);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Concession Granted Successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }
        
        public static int AddFeeVouchers(int session,int month, int year, Int64 regNo, int classID, int sectionID,DateTime dueDate,int bankID, float PresentFee,
            int status, int admFeeStat, int absentFeeStat, int booksFeeStat, int examsFeeStat, int miscFeeStat,int LateSurcharge)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_AddFeeVouchers", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@DueDate", dueDate);
                com.Parameters.AddWithValue("@BankID", bankID);
                com.Parameters.AddWithValue("@PresentFee", PresentFee);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@AdmissionFeeStat", admFeeStat);
                com.Parameters.AddWithValue("@AbsentFeeStat", absentFeeStat);
                com.Parameters.AddWithValue("@BooksFeeStat", booksFeeStat);
                com.Parameters.AddWithValue("@ExamsFeeStat", examsFeeStat);
                com.Parameters.AddWithValue("@MiscFeeStat", miscFeeStat);
                com.Parameters.AddWithValue("@LateSurcharge", LateSurcharge);
                MainClass.con.Open();
                st= com.ExecuteNonQuery();
                MainClass.con.Close();
                
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }

        public static void AddExamTypes(DateTime session, string examName, DateTime resultdate, TimeSpan resultTime, string resultVenue)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_AddExamTypes", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@ExamName", examName);
                com.Parameters.AddWithValue("@ResultDate", resultdate);
                com.Parameters.AddWithValue("@ResultTime", resultTime);
                com.Parameters.AddWithValue("@ResultVenue", resultVenue);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(examName + " added successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int AddExams(Int64 ExamTypeID,int levelID,int ClassID,int sectionID,float GrandTotal)
        {
            int st=0;
            try
            {
                SqlCommand com = new SqlCommand("stp_AddExams", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@GrandTotal", GrandTotal);
                MainClass.con.Open();
                st = com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }

        public static int AddExamDetails(Int64 ExamID, int subjectID, DateTime examDate, float totalMarks, float passingPercent)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_AddExamDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamID", ExamID);
                com.Parameters.AddWithValue("@SubjectID", subjectID);
                com.Parameters.AddWithValue("@ExamDate", examDate);
                com.Parameters.AddWithValue("@TotalMarks", totalMarks);
                com.Parameters.AddWithValue("@PassingPercent", passingPercent);
                MainClass.con.Open();
                st = com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }

        public static int AddResults( int ClassID, int sectionID, Int64 ExamTypeID,Int64 RegNo, float grandObtained,float granfPercent,string grandGrade,string grandRemarks,int  position)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_AddResults", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ClassID", ClassID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@ExamTypeID", ExamTypeID);
                com.Parameters.AddWithValue("@RegNo", RegNo);
                com.Parameters.AddWithValue("@GrandObtained", grandObtained);
                com.Parameters.AddWithValue("@GrandPercentage", granfPercent);
                com.Parameters.AddWithValue("@GrandGrade", grandGrade);
                com.Parameters.AddWithValue("@GrandRemarks", grandRemarks);
                com.Parameters.AddWithValue("@Position", position);
                MainClass.con.Open();
                st = com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }

        public static int AddResultDetails(Int64 resultID, int subjectID,float obtainedMarks,double percent,string grade,string remarks)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_AddResultDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ResultID", resultID);
                com.Parameters.AddWithValue("@SubjectID", subjectID);
                com.Parameters.AddWithValue("@ObtainedMarks", obtainedMarks);
                com.Parameters.AddWithValue("@Percentage", percent);
                com.Parameters.AddWithValue("@Grade", grade);
                com.Parameters.AddWithValue("@Remarks", remarks);
                MainClass.con.Open();
                st = com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }

        public static int AddExpenses(int campusID, int Month, int Year, DateTime date, string ExpenseType, string Description, float Amount, string receiptName, string receiptNo)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_AddExpenses", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@fkCampusID", campusID);
                com.Parameters.AddWithValue("@Month", Month);
                com.Parameters.AddWithValue("@Year", Year);
                com.Parameters.AddWithValue("@Date", date);
                com.Parameters.AddWithValue("@ExpenseType", ExpenseType);
                com.Parameters.AddWithValue("@Description", Description);
                com.Parameters.AddWithValue("@Amount", Amount);
                com.Parameters.AddWithValue("@ReceiptName", receiptName);
                com.Parameters.AddWithValue("@ReceiptNo", receiptNo);
                MainClass.con.Open();
                st = com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
            return st;
        }
    }
}
