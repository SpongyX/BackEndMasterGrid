using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHGridMasterDetails.Enums
{
    public enum ErrorCodes
    {
        Exception = -1,
        MissingEmail = 2,
        MissingPassword = 3,
        AccountNotFound = 4,
        IncorrectPassword = 5,
        UserNotActive = 6,
        ClientAlreadyDeleted = 7,
        ClientStatusSameAsNew = 8,
        ProductAlreadyDeleted = 9,
    }
}
