using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Domain.Staff.Entities
{
    public class SalarySetting
    {
        public SalarySetting()
        {
            
        }

        public int Id { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> CreatedUserId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> ModifiedUserId { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> AssignedUserId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool IsTemplate { get; set; }
        public bool IsSend { get; set; }
        public string SalaryApprovalType { get; set; }
        public int OrderNo { get; set; }
        public bool HiddenForMonth { get; set; }
    }
}
