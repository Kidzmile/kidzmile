﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Web;

namespace Kidzmile.Models
{
    [DataContract]
    public class ApiResponse
    {
        [DataMember]
        public string Version { get { return "0.0.0.5"; } }

        [DataMember]
        public int StatusCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public object Result { get; set; }

        public ApiResponse(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            StatusCode = (int)statusCode;
            Result = result;
            ErrorMessage = errorMessage;
        }
    }
}