﻿using Admin.Core.IRepository;
using Admin.Core.IServices;
using Admin.Core.Model.Models;
using Admin.Core.Services.BASE;

namespace Admin.Core.Services
{
    public class AdvertisementServices : BaseServices<Advertisement>, IAdvertisementServices
    {
        IAdvertisementRepository _dal;
        public AdvertisementServices(IAdvertisementRepository dal)
        {
            this._dal = dal;
            base.BaseDal = dal;
        }

        public void ReturnExp()
        {

            int a = 1;
            int b = 0;

            int c = a / b;
        }

        //public IAdvertisementRepository dal = new AdvertisementRepository();
        //public int Sum(int i, int j)
        //{
        //    return base.Sum(i, j);

        //}


        //public int Add(Advertisement model)
        //{
        //    return base.Add(model);
        //}

        //public bool Delete(Advertisement model)
        //{
        //    return base.Delete(model);
        //}

        //public List<Advertisement> Query(Expression<Func<Advertisement, bool>> whereExpression)
        //{
        //    return base.Query(whereExpression);

        //}

        //public bool Update(Advertisement model)
        //{
        //    return base.Update(model);
        //}

    }
}
