
using System;
using System.Collections;
using System.Collections.Generic;

using XComponent.SwaggerPetstore.UserObject.Models;

namespace XComponent.SwaggerPetstore.UserObject
{
	[System.Serializable()]
    public class PlaceOrderOperation
    {
        public XComponent.SwaggerPetstore.UserObject.PlaceOrder Event { get; set; }
		public Order OperationResult { get; set; }
		public bool HasErrors { get; set; }
        public string Message { get; set; }
    }
}

