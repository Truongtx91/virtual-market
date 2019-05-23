﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using VirtualMarket.Common.Messages;

namespace VirtualMarket.Services.Operations.Messages.Products.Events
{
    [MessageNamespace("products")]
    public class ProductsReleased : IEvent
    {
        public Guid OrderId { get; set; }
        public IDictionary<Guid, int> Products { get; }
        [JsonConstructor]
        public ProductsReleased(Guid orderId, IDictionary<Guid, int> products)
        {
            OrderId = orderId;
            Products = products;
        }
    }
}
