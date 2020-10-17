using ShopPCBusinessLogic.BindingModels;
using ShopPCBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPCBusinessLogic.Interfaces
{
    public interface IClientLogic
    {
        List<ClientViewModel> Read(ClientBindingModel model);
        void CreateOrUpdate(ClientBindingModel model);
        void Delete(ClientBindingModel model);
    }
}