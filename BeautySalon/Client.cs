
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
    
public partial class Client
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Client()
    {

        this.Recording = new HashSet<Recording>();

    }


    public int ClientID { get; set; }

    public int IDPerson { get; set; }

    public int IDDiscount { get; set; }

    public string Phone { get; set; }



    public virtual Discount Discount { get; set; }

    public virtual Person Person { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Recording> Recording { get; set; }

}

}