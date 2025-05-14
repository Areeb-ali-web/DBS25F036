using System;

namespace G_36_SmartPrint.BL
{
    internal class DesignBL
    {
        // Private fields
        private int designID;
        private string designFile;
        private DesignerBL designer;
        private DateTime createdDate;
        private LookupBL approvalStatus;
        private OrderBL order;

        // Public Properties
        public int DesignID
        {
            get => designID;
            set => designID = value;
        }

        public string DesignFile
        {
            get => designFile;
            set => designFile = value;
        }

        public DesignerBL Designer
        {
            get => designer;
            set => designer = value;
        }

        public DateTime CreatedDate
        {
            get => createdDate;
            set => createdDate = value;
        }

        public LookupBL ApprovalStatus
        {
            get => approvalStatus;
            set => approvalStatus = value;
        }

        public OrderBL Order
        {
            get => order;
            set => order = value;
        }

        // Constructors
        public DesignBL() { }

        public DesignBL(string designFile, DesignerBL designer)
            : this(designFile, designer, DateTime.Now) { }

        public DesignBL(string designFile, DesignerBL designer, DateTime createdDate)
            : this(designFile, designer, createdDate, null) { }

        public DesignBL(string designFile, DesignerBL designer, DateTime createdDate, LookupBL approvalStatus)
        {
            this.designFile = designFile;
            this.designer = designer;
            this.createdDate = createdDate;
            this.approvalStatus = approvalStatus;
        }

        public DesignBL(string designFile, DesignerBL designer, DateTime createdDate, LookupBL approvalStatus, int orderID)
            : this(designFile, designer, createdDate, approvalStatus)
        {
            this.order = new OrderBL(orderID);
        }

        // Behavior Methods

        public bool IsApproved()
        {
            return approvalStatus != null && approvalStatus.LookupValue.Equals("Approved", StringComparison.OrdinalIgnoreCase);
        }

        public void AssignOrder(OrderBL order)
        {
            this.order = order;
        }

        public void AssignDesigner(DesignerBL designer)
        {
            this.designer = designer;
        }

        public string GetDesignSummary()
        {
            return $"DesignID: {designID}, File: {designFile}, Designer: {designer?.Name}, Status: {approvalStatus?.LookupValue}";
        }
    }
}
