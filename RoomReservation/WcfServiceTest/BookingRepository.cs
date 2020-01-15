using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfServiceTest.Model;

namespace WcfServiceTest
{
    public class BookingRepository
    {
        string conString;

        public BookingRepository()
        {
            conString = ConfigurationManager.ConnectionStrings["BookingDB"].ToString();
        }

        public int UpdateItem(BookingDetails bookingItem)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Stp_UpdateBookDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookingID", bookingItem.BookingID);
                    cmd.Parameters.AddWithValue("@RoomID", bookingItem.RoomID);
                    cmd.Parameters.AddWithValue("@BookingStatus", bookingItem.BookingStatus);
                    cmd.Parameters.AddWithValue("@BookedDateFrom", bookingItem.BookedDateFrom);
                    cmd.Parameters.AddWithValue("@BookedDateTO", bookingItem.BookedDateTO);                  
                    cmd.Parameters.AddWithValue("@AdvancePayed", bookingItem.AdvancePayed);
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                }
            }
            return count;
        }
        public int InsertItem(BookingDetails bookingItem)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Stp_InsertBookDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RoomID", bookingItem.RoomID);
                    cmd.Parameters.AddWithValue("@BookingStatus", bookingItem.BookingStatus);
                    cmd.Parameters.AddWithValue("@BookedDateFrom", bookingItem.BookedDateFrom);
                    cmd.Parameters.AddWithValue("@BookedDateTO", bookingItem.BookedDateTO);                  
                    cmd.Parameters.AddWithValue("@AdvancePayed", bookingItem.AdvancePayed);
                    con.Open();
                    count = cmd.ExecuteNonQuery();                   
                }
            }
            return count;
        }
        public List<BookingDetails> GetItems()
        {           
            List<BookingDetails> items = new List<BookingDetails>();

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Stp_GetBookDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    con.Open();
                    SqlDataReader rdr=  cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        items.Add(new BookingDetails() {
                            BookingID = Convert.ToInt32(rdr["BookingID"]),
                            RoomID = Convert.ToInt32(rdr["RoomID"]),
                            BookingStatus = Convert.ToInt32(rdr["BookingStatus"]),
                            BookedDateFrom= rdr["BookedDateFrom"].ToString(),
                            BookedDateTO=rdr["BookedDateTO"].ToString(),
                            AdvancePayed = (rdr["AdvancePayed"] !=null ? rdr["AdvancePayed"].ToString(): string.Empty)
                           
                        });                        
                    }
                }
            }
            return items;
        }

        public BookingDetails GetItemByID(int bookingID)
        {         
            BookingDetails item = new BookingDetails();

            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Stp_GetBookDetailsByID", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        item=new BookingDetails()
                        {
                            BookingID = Convert.ToInt32(rdr["BookingID"]),
                            RoomID = Convert.ToInt32(rdr["RoomID"]),
                            BookingStatus = Convert.ToInt32(rdr["BookingStatus"]),
                            BookedDateFrom = rdr["BookedDateFrom"].ToString(),
                            BookedDateTO = rdr["BookedDateTO"].ToString(),
                            AdvancePayed = (rdr["AdvancePayed"] != null ? rdr["AdvancePayed"].ToString() : string.Empty)                           
                        };
                    }
                }
            }
            return item;
        }

        public int DeleteItem(int bookingID)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Stp_DeleteBookDetails", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);
                    con.Open();
                    count = cmd.ExecuteNonQuery();
                    
                }
            }
            return count;
        }

    }
}