using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;

namespace G_36_SmartPrint.BL
{
    internal class DesignBL
    {
        public int designid;
        public OrderBL order;
        public string designFile;
        public DesignerBL designer;
        public DateTime createddate;
        public LookupBL approvalstatus;

        public DesignBL(string designFile, DesignerBL designer, DateTime createddate, LookupBL approvalstatus)
        {
            this.designFile = designFile;
            this.designer = designer;
            this.createddate = createddate;
            this.approvalstatus = approvalstatus;
        }
        public DesignBL(string designFile, DesignerBL designer, DateTime createddate)
        {
            this.designFile = designFile;
            this.designer = designer;
            this.createddate = createddate;
        }
        public DesignBL(string designFile, DesignerBL designer)
        {
            this.designFile = designFile;
            this.designer = designer;
        }
        public DesignBL(string designFile, DesignerBL designer, DateTime createddate, LookupBL approvalstatus,int orderid)
        {
            this.designFile = designFile;
            this.designer = designer;
            this.createddate = createddate;
            this.approvalstatus = approvalstatus;
            this.order= new OrderBL(orderid);
        }
    }
}
