using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);

    }
}
