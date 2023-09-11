using System;
using UploadService.Core.Utilities.Results.Abstract;
using UploadService.Core.Utilities.Results.Concrete.ErrorResults;
using UploadService.Core.Utilities.Results.Concrete.SuccessResults;

namespace UploadService.Core.Utilities.Business
{
    public class BusinessRule
    {
        public static IResult CheckRules(params IResult[] logic)
        {
            foreach (var method in logic)
            {
                if (!method.Success)
                {
                    return new ErrorResult();
                }
            }
            return new SuccessResult();
        }
    }
}

