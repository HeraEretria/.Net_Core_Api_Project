﻿using HotelProject.BussinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinessLayer.Concrete
{
    public class ServiceMenager : IServiceService
    {
        private readonly IServicesDal _servicesDal;
        public ServiceMenager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void TDelete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service TGetById(int id)
        {
            return _servicesDal.GetById(id);
        }

        public List<Service> TGetList()
        {
            return _servicesDal.GetList();
        }

        public void TInsert(Service t)
        {
            _servicesDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _servicesDal.Update(t);
        }
    }
}
