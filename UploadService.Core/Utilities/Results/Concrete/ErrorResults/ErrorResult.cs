using System;

namespace UploadService.Core.Utilities.Results.Concrete.ErrorResults
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult(string message) : base(false, message)
        {
        }
    }
}

