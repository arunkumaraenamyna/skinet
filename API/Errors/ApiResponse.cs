using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message=null)
        {
            StatusCode = statusCode;
            Message = message?? GetDefaultMessageStatusCode(statusCode);
        }

       

        public int StatusCode { get; set; }
        public string Message { get; set; }

         private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400=>"A bad requst,you have made",
                401=>"Authorized, you are not",
                404=>"Resource Found,it was not",
                500=>"Errors are the path to take dark side.errors lead to anger.",
                _=>null
            };
        }
        
    }
}