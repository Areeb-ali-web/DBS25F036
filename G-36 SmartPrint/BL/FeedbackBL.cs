using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace G_36_SmartPrint.BL
{
    internal class FeedbackBL
    {
        private int feedbackId;
        private int rating;
        private string comment;
        private DateTime feedabckdate;

        public FeedbackBL(int feedbackId, int rating, string comment, DateTime feedabckdate)
        {
            this.feedbackId = feedbackId;
            this.rating = rating;
            this.comment = comment;
            this.feedabckdate = feedabckdate;
        }
        public FeedbackBL() { }
        public FeedbackBL( int rating, string comment, DateTime feedabckdate)
        {
          
            this.rating = rating;
            this.comment = comment;
            this.feedabckdate = feedabckdate;
        }
        public int getFeedbackId() { return feedbackId; }
        public int getRating() { return rating; }
        public string getComment() { return comment; }
        public DateTime getFeedabckdate() {
            return feedabckdate; }

        public void setFeedbackId(int feedbackId)
        {
            this.feedbackId = feedbackId;
        }

        public void setrating(int rating) 
        {
            this.rating = (int) rating;

        }

        
    }
}
