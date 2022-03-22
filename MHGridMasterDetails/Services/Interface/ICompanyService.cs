using MHGridMasterDetails.Model.Company;
using MHGridMasterDetails.Model.ResponseMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Services.Interface
{
    public interface ICompanyService
    {
        ResponseMessage GetCompany();
        ResponseMessage GetCompanyStock( int company_id);
        //ResponseMessage CreateCompany(NewCompanyModel model);
    }
}
