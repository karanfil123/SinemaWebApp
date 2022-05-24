using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinemam.Core.Dtos
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Succes(int statuscode, T data)
        {
            return new CustomResponseDto<T> { StatusCode = statuscode, Data = data };
        }
        public static CustomResponseDto<T> Succes(int statuscode)
        {
            return new CustomResponseDto<T> { StatusCode = statuscode };
        }
        public static CustomResponseDto<T> Failed(int statuscode, List<string> errors)
        {
            return new CustomResponseDto<T> { StatusCode = statuscode, Errors = errors };
        }
        public static CustomResponseDto<T> Failed(int statuscode, string errors)
        {
            return new CustomResponseDto<T> { StatusCode = statuscode, Errors = new List<string> { errors } };
        }
    }
}
