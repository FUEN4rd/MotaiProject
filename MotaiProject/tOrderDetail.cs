//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MotaiProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class tOrderDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tOrderDetail()
        {
            this.tShipDetails = new HashSet<tShipDetail>();
        }
    
        public int oOrderDetailId { get; set; }
        public int oOrderId { get; set; }
        public int oProductId { get; set; }
        public int oProductQty { get; set; }
        public string oNote { get; set; }
    
        public virtual tOrder tOrder { get; set; }
        public virtual tProduct tProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tShipDetail> tShipDetails { get; set; }
    }
}
