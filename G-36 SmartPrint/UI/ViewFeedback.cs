using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G_36_SmartPrint.BL;
using G_36_SmartPrint.DL;

namespace G_36_SmartPrint.UI
{
    public partial class ViewFeedback : UserControl
    {
        public ViewFeedback()
        {
            InitializeComponent();
            LoadFeedbackData(); // Load data when control initializes
        }

        private void LoadFeedbackData()
        {
            try
            {
                // Get all feedback from the database
                List<FeedbackBL> feedbackList = FeedbackDL.LoadAllFeedback();

                // Clear existing data
                dgvFeedback.Rows.Clear();
                dgvFeedback.Columns.Clear();

                // Add columns (excluding FeedbackID)
                dgvFeedback.Columns.Add("customerNAme", "From User");
                dgvFeedback.Columns.Add("Rating", "Rating");
                dgvFeedback.Columns.Add("Comment", "Comment");
                dgvFeedback.Columns.Add("FeedbackDate", "Date");

                // Configure columns
                dgvFeedback.Columns["Rating"].Width = 80;
                dgvFeedback.Columns["FeedbackDate"].Width = 120;
                dgvFeedback.Columns["Comment"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                // Add star rating display for the Rating column
                dgvFeedback.Columns["Rating"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Populate rows
                foreach (var feedback in feedbackList)
                {
                    // Create star rating display (★ for filled, ☆ for empty)
                    string ratingStars = new string('★', feedback.getRating()) +
                                      new string('☆', 5 - feedback.getRating());

                    dgvFeedback.Rows.Add(
                        feedback.customer.UserName,
                        ratingStars,
                        feedback.getComment(),
                        feedback.getFeedabckdate().ToString("yyyy-MM-dd HH:mm")
                    );
                }

                // Optional: Add some styling
                dgvFeedback.RowHeadersVisible = false;
                dgvFeedback.AllowUserToAddRows = false;
                dgvFeedback.ReadOnly = true;
                dgvFeedback.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvFeedback.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading feedback data:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks if needed
        }

        // Optional: Add a refresh button or method
        public void RefreshData()
        {
            LoadFeedbackData();
        }
    }
}