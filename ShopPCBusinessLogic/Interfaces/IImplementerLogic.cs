using ShopPCBusinessLogic.BindingModels;
using ShopPCBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPCBusinessLogic.Interfaces
{
    public interface IImplementerLogic
    {
        List<ImplementerViewModel> Read(ImplementerBindingModel model);
        void CreateOrUpdate(ImplementerBindingModel model);
        void Delete(ImplementerBindingModel model);
    }
}