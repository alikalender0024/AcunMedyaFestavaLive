using AcunMedyaFestavaLive.DataAccess.Context;
using AcunMedyaFestavaLive.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.DataAccess
{
    public class UserDal
    {
        FestavaContext _festavaContext = new FestavaContext();

        public List<OperationClaim> GetClaims(User user)
        {

            var result = from userOperationClaim in _festavaContext.UserOperationClaims
                         join operationClaim in _festavaContext.OperationClaims
                         on userOperationClaim.OperationClaimId equals operationClaim.OperationClaimID
                         where userOperationClaim.UserId==user.UserID
                         select new OperationClaim
                         {
                             OperationClaimID = operationClaim.OperationClaimID,
                             ClaimName=operationClaim.ClaimName
                         };
            return result.ToList();

        }
    }
}