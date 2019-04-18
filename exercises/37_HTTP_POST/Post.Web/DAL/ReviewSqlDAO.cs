using Post.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Post.Web.DAL
{
    public class ReviewSqlDAO : IReviewDAO
    {
        private readonly string connectionString;

        public ReviewSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Review PopulatePost(SqlDataReader reader)
        {
            Review p = new Review();

            p.ReviewID = (int)reader["review_id"];
            p.UserName = (string)reader["username"];
            p.Rating = (int)reader["rating"];
            p.ReviewTitle = (string)reader["review_title"];
            p.ReviewText = (string)reader["review_text"];
            p.ReviewDate = Convert.ToDateTime(reader["review_date"]);

            return p;

        }
        /// <summary>
        /// Returns a list of all reviews
        /// </summary>
        /// <returns></returns>


        public IList<Review> GetAllReviews()
        {
            IList<Review> reviews = new List<Review>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from reviews", conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        reviews.Add(PopulatePost(reader));
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }

            return reviews;
        }
        /*Username
          Rating
          Review Title
          Review Text */
        /// 
        /// <summary>
        /// Saves a new review to the system.
        /// </summary>
        /// <param name="newReview"></param>
        /// <returns></returns>
        public int SaveReview(Review newReview)
        {
            int reviewID;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into reviews values (@username, @rating, @review_title, @review_text, @review_date); SELECT @@IDENTITY;", conn);
                    cmd.Parameters.AddWithValue("@username", newReview.UserName);
                    cmd.Parameters.AddWithValue("@rating", newReview.Rating);
                    cmd.Parameters.AddWithValue("@review_title", newReview.ReviewTitle);
                    cmd.Parameters.AddWithValue("@review_text", newReview.ReviewText);
                    cmd.Parameters.AddWithValue("@review_date", DateTime.Now);

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("Select MAX(review_id) from reviews;", conn);
                    reviewID = Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
            catch (Exception)
            {

                throw;
            }
            return reviewID;
        }
    }
}
