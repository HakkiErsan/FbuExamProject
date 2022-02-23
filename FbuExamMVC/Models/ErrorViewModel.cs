using System;
using System.ComponentModel.DataAnnotations;

namespace FbuExamMVC.Models
{
    public class ErrorViewModel
    {
       
        public string RequestId { get; set; }

        
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
