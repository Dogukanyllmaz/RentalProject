﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<Customer>> GetAllCustomers();
        IDataResult<Customer> GetCustomerById(int id);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
        IResult AddTransactionalTest(Customer customer);
    }
}
