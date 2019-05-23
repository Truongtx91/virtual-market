﻿using Newtonsoft.Json;
using System;
using VirtualMarket.Common.Messages;

namespace VirtualMarket.Services.Operations.Messages.Customers.Events
{
    [MessageNamespace("customers")]
    public class DeleteProductFromCartRejected : IRejectedEvent
    {
        public Guid CustomerId { get; }
        public Guid ProductId { get; }
        public string Reason { get; }
        public string Code { get; }
        [JsonConstructor]
        public DeleteProductFromCartRejected(Guid customerId, Guid productId,
            string reason, string code)
        {
            CustomerId = customerId;
            ProductId = productId;
            Reason = reason;
            Code = code;
        }
    }
}
