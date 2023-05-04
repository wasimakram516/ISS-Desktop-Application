using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS
{
    class clsUpdation
    {
        public static void UpdateCampuses(int campusID, string campus, string address, string phone1, string phone2, string Email, Int16 Status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateCampuses", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CampID", campusID);
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
                    MainClass.ShowMsg(campus + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateShifts(int shiftID, string shift, TimeSpan start, TimeSpan end)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateShifts", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ShiftID", shiftID);
                com.Parameters.AddWithValue("@Name", shift);
                com.Parameters.AddWithValue("@StartTime", start);
                com.Parameters.AddWithValue("@EndTime", end);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(shift + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateLevels(int levelID, string level, int campusID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateLevels", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@Level", level);
                com.Parameters.AddWithValue("@CampusID", campusID);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(level + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateClasses(int classID, string name, int campusID, int levelID, Int16 status,float ClassNumber)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateClasses", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ClassID", classID);
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
                    MainClass.ShowMsg(name + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateSections(int sectionID, int campusID, string name, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateSections", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@Name", name);
                com.Parameters.AddWithValue("@Status", status);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(name + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateSubjects(int subjectID, int levelID, int classID, string subject)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateSubjects", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SubjectID", subjectID);
                com.Parameters.AddWithValue("@LevelID", levelID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@Subject", subject);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(subject + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdatePeriods(int periodID, string period)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdatePeriods", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@PeriodID", periodID);
                com.Parameters.AddWithValue("@Period", period);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(period + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateClassTimings(int CTID, int periodID, int shiftID, int levelID, TimeSpan starttime, TimeSpan endtime, string day)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateClassTimings", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@CTID", CTID);
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
                    MainClass.ShowMsg("Successfully Updated!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateStaffWithoutImage(int staffID, int campusID,int priority ,string CNIC, string name, string username, string password, string phone1, string phone2,
            string role, string scale, Int16 gender, Int16 status, DateTime joindate, DateTime leftdate, float salery)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateStaffWithoutImage", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@StaffID", staffID);
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
                    MainClass.ShowMsg(name + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateStaff(int staffID, int campusID,int priority, string CNIC, string name, string username, string password, string phone1, string phone2,
            string role, string scale, Int16 gender, Int16 status, DateTime joindate, DateTime leftdate, float salery, object arr)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateStaff", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@StaffID", staffID);
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
                    MainClass.ShowMsg(name + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateClassAssignments(int AssignID, int campusID, int shiftID, int classID, int sectionID, int CTID, int subjectID, int StaffID)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateAssignments", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@AssignID", AssignID);
                com.Parameters.AddWithValue("@CampusID", campusID);
                com.Parameters.AddWithValue("@ShiftID", shiftID);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@CTID", CTID);
                com.Parameters.AddWithValue("@SubjectID", subjectID);
                com.Parameters.AddWithValue("@StaffID", StaffID);

                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Successfully Updated!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg("Possible Errors.\n\nAre you trying to assign period to this teacher again?\n\nYou can not assign a same period to same teacher again!\n\n" + x.Message, "Error", "Error");
            }
        }

        public static void UpdateStaffAttendance(Int64 AttendID, DateTime date, string status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateStaffAttendance", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@StaffAttID", AttendID);
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
        static int checkupdatesal;
        public static int UpdateSalery(Int64 paidSaleryID, float paidSalery, DateTime paidDate, Int16 status,float bonus)
        {
            
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateSalary", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@SalaryID", paidSaleryID);
                com.Parameters.AddWithValue("@PaidSalary", paidSalery);
                com.Parameters.AddWithValue("@Date", paidDate);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@Bonus", bonus);
                MainClass.con.Open();
                checkupdatesal = com.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");

            }
            return checkupdatesal;
        }

        public static void UpdateAdmissions(Int64 oldRegNo, Int64 newRegNo, string name, Int16 gender, string fatherName, string motherName, string fatherProfession, string motherProfession,
            string relegion, DateTime DOB, string nationality, string placeOfBirth, int campusID, int classID, int sectionID, DateTime session, string phone1, string phone2,
            string Whatsapp, string address, string preSchool, object arr, DateTime admissionDate, Int16 status, string reference, string CNICFather, string CNICStudent, string Caste,object QR)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateAdmissions", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@OldRegNo", oldRegNo);
                com.Parameters.AddWithValue("@NewRegNo", newRegNo);
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
                com.Parameters.AddWithValue("@Phone1", phone1);
                com.Parameters.AddWithValue("@Phone2", phone2);
                com.Parameters.AddWithValue("@Whatsapp", Whatsapp);
                com.Parameters.AddWithValue("@Address", address);
                com.Parameters.AddWithValue("@PreSchoolName", preSchool);
                com.Parameters.AddWithValue("@Image", arr);
                com.Parameters.AddWithValue("@AdmissionDate", admissionDate);
                com.Parameters.AddWithValue("@Status", status);
                com.Parameters.AddWithValue("@Reference", reference);
                com.Parameters.AddWithValue("@CNICFather", CNICFather);
                com.Parameters.AddWithValue("@CNICStudent", CNICStudent);
                com.Parameters.AddWithValue("@Caste", Caste);
                com.Parameters.AddWithValue("@QRCode", QR);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateLeftStudentStatus(Int64 regNo)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateLeftStudentsStatus", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", regNo);
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

        public static void UpdateStudentsAttendance(Int64 AttendID, DateTime date, string status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateAttendance", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@AttendanceID", AttendID);
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

        public static void UpdateStudentStatus(Int64 regNo, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateStudentStatus", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", regNo);
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

        public static void UpdateLeftStudent(Int64 regNo, DateTime leftDate, Int16 reason, Int16 status)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateLeftStudents", MainClass.con);
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

        public static void UpdateAdmissionsWRT_Session_Level_Class_Section(Int64 regNo, int classID, int sectionID, DateTime session, Int16 reason)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateAdmissionsWRT_Session_Level_Class_Section", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@Promotion", reason);
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

        public static void UpdatePaymentMethods(int bankID, string bank, string branch, string address, string account)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdatePaymentMethods", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@BankID", bankID);
                com.Parameters.AddWithValue("@Bank", bank);
                com.Parameters.AddWithValue("@branch", branch);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@account", account);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg(bank + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateFeeStructure(int feeStructureID, int classID, float admissionFee, float monthlyFee, float BooksFee, float examsFee, float lateFee, float absentFee, float miscFee)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateFeeStructure", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FeeStrucID", feeStructureID);
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
                    MainClass.ShowMsg("Updated Successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static void UpdateFeeConcession(int FeeConcID, float discount, string reason)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateFeeConcessions", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FeeConcID", FeeConcID);
                com.Parameters.AddWithValue("@Disount", discount);
                com.Parameters.AddWithValue("@Reason", reason);
                MainClass.con.Open();
                int st = com.ExecuteNonQuery();
                MainClass.con.Close();
                if (st > 0)
                {
                    MainClass.ShowMsg("Concession Updated Successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }


        public static int UpdateFeeVouchers(Int64 feeVoucherID,int session, int month, int year, Int64 regNo, int classID, int sectionID, DateTime dueDate, int bankID,
            int admFeeStat, int absentFeeStat, int booksFeeStat, int examsFeeStat, int miscFeeStat,int LateSurcharge, float PresentFee)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateFeeVouchers", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FeeVoucherID", feeVoucherID);
                com.Parameters.AddWithValue("@Session", session);
                com.Parameters.AddWithValue("@Month", month);
                com.Parameters.AddWithValue("@Year", year);
                com.Parameters.AddWithValue("@RegNo", regNo);
                com.Parameters.AddWithValue("@ClassID", classID);
                com.Parameters.AddWithValue("@SectionID", sectionID);
                com.Parameters.AddWithValue("@DueDate", dueDate);
                com.Parameters.AddWithValue("@BankID", bankID);
                com.Parameters.AddWithValue("@AdmFeeStat", admFeeStat);
                com.Parameters.AddWithValue("@AbsentFeeStat", absentFeeStat);
                com.Parameters.AddWithValue("@BooksFeeStat", booksFeeStat);
                com.Parameters.AddWithValue("@ExamsFeeStat", examsFeeStat);
                com.Parameters.AddWithValue("@MiscFeeStat", miscFeeStat);
                com.Parameters.AddWithValue("@LateSurcharge", LateSurcharge);
                com.Parameters.AddWithValue("@PresentFee", PresentFee);
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

        public static int UpdateFeeVouchersWRTStudent(Int64 feeVoucherID, Int16 paidstatus, DateTime PaymentDate)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateFeeVouchersWRTStudent", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FeeVoucherID", feeVoucherID);
                com.Parameters.AddWithValue("@PaidStatus", paidstatus);
                com.Parameters.AddWithValue("@PaymentDate", PaymentDate);
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

        public static void UpdateExamTypes(Int64 examTypeID, DateTime session, string examName, DateTime resultdate, TimeSpan resultTime, string resultVenue)
        {
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateExamTypes", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamTypeID", examTypeID);
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
                    MainClass.ShowMsg(examName + " updated successfully!", "Success!", "Success");
                }
            }
            catch (Exception x)
            {
                MainClass.con.Close();
                MainClass.ShowMsg(x.Message, "Error", "Error");
            }
        }

        public static int UpdateExams(Int64 examID, Int64 ExamTypeID, int levelID, int ClassID, int sectionID, float GrandTotal)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateExams", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamID", examID);
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

        public static int UpdateExamDetails(Int64 examDetailID, int subjectID, DateTime examDate, float totalMarks, float passingPercent)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateExamDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExamDetailID", examDetailID);
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


        public static int UpdateResults(Int64 ResultID, float grandObtained, float grandPercent, string grandGrade, string grandRemarks,int position)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateResults", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ResultID", ResultID);
                com.Parameters.AddWithValue("@GrandObtained", grandObtained);
                com.Parameters.AddWithValue("@GrandPercentage", grandPercent);
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

        public static int UpdateResultDetails(Int64 ResultDetailID, float obtainedMarks, double percent, string grade, string remarks)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateResultDetails", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ResultDetailID", ResultDetailID);
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

        public static int UpdateExpenses(Int64 ExpenseID, int Month, int Year, DateTime Date, string ExpenseType, string Description, float amount, string receiptName, string receiptNo)
        {
            int st = 0;
            try
            {
                SqlCommand com = new SqlCommand("stp_UpdateExpenses", MainClass.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ExpenseID", ExpenseID);
                com.Parameters.AddWithValue("@Month", Month);
                com.Parameters.AddWithValue("@Year", Year);
                com.Parameters.AddWithValue("@Date", Date);
                com.Parameters.AddWithValue("@ExpenseType", ExpenseType);
                com.Parameters.AddWithValue("@Description", Description);
                com.Parameters.AddWithValue("@Amount", amount);
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
