using ShopPCBusinessLogic.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShopPCBusinessLogic.ViewModels
{
    public class ComponentViewModel : BaseViewModel
    {
        [Column(title: "Коипонент", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ComponentName"
        };
    }
}