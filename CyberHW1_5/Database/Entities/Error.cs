using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using static ShopMVP.Database.Entities.Error;

namespace ShopMVP.Database.Entities
{
    internal class Error
    {
        [Key]
        public int ErrorId { get; set; }
        public string? Message { get; set; }
        public DateTime Time { get; set; }
        public string? Request { get; set; }
        public StatusCode Status { get; set; }

        [Obsolete("Use other constructors to create instances of Error\n" +
            "This is constructor for Entity")]
        public Error() {
            this.Time = DateTime.Now;
            this.Status = 0;
        }
        public Error(StatusCode statusCode) 
        {
            this.Time = DateTime.Now;
            this.Status = statusCode;
        }
        public Error(string? message, string? request, StatusCode statusCode)
        {
            this.Time = DateTime.Now;
            this.Status = statusCode;
            this.Message = message;
            this.Request = request;
        }
        
        public enum StatusCode : short
        {
            Undefined = 0,
            Ok = 200,
            NotFound = 404,
            Server = 500
        }
    }
}
