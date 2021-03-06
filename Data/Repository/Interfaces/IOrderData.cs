﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AaronPuffer.DependencyInjection.DTO;

namespace AaronPuffer.DependencyInjection.Data.Repository.Interfaces
{
    public interface IOrderData
    {
        void CreateOrder(Order CustomerOrder);

        Order GetCustomerOrder(int OrderId);

        void DeleteCustomerOrder(int OrderId);
    }
}
