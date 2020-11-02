using ShopPCBusinessLogic.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace ShopPCBusinessLogic.ViewModels
{
    [DataContract]
    public class ProductViewModel : BaseViewModel
    {
        [Column(title: "Название системного блока", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string ProductName { get; set; }
        [Column(title: "Цена", width: 50)]
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> ProductComponents { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ProductName",
            "Price"
        };
    }
}