
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
    
public partial class Recording
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Recording()
    {

        this.ProcedureInRecording = new HashSet<ProcedureInRecording>();

    }


    public int RecordingID { get; set; }

    public int IDClient { get; set; }

    public System.DateTime Date { get; set; }



    public virtual Client Client { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ProcedureInRecording> ProcedureInRecording { get; set; }

}

}
