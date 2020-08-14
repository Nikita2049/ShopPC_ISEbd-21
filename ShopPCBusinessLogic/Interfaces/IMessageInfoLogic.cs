using ShopPCBusinessLogic.BindingModels;
using ShopPCBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPCBusinessLogic.Interfaces
{
    public interface IMessageInfoLogic
    {
        List<MessageInfoViewModel> Read(MessageInfoBindingModel model);
        void Create(MessageInfoBindingModel model);
    }
}