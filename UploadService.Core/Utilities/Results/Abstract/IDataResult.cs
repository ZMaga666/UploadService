using System;

namespace UploadService.Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; set; }
    }
}

