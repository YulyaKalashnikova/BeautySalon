
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BeautySalon
{

using System;
    using System.Collections.Generic;
    
public partial class Master
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Master()
    {

        this.ProcedureOfMaster = new HashSet<ProcedureOfMaster>();

    }


    public int MasterID { get; set; }

    public int IDEmployee { get; set; }

    public int IDPosition { get; set; }



    public virtual Employee Employee { get; set; }

    public virtual Position Position { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ProcedureOfMaster> ProcedureOfMaster { get; set; }

}

}