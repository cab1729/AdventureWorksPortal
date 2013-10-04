using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Domain.ModelObjects.DataTransfer
{
    using AdventureWorks.Domain.ModelObjects.Entities;

    [DataContract(IsReference = true, Name = "ProductInventory")]
    public class ProductInventoryDTO
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public short LocationID { get; set; }
        [DataMember]
        public string Shelf { get; set; }
        [DataMember]
        public byte Bin { get; set; }
        [DataMember]
        public short Quantity { get; set; }
    }
}
