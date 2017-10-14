using System;

namespace OutletTwit.Core.Api.Models
{
    public interface ICreatedObject : IObject
    {
        DateTimeOffset CreatedAt { get; }
    }
}
