using System;

namespace OutletTwit.Core.Api.Models
{
    public interface IObject : IEquatable<long>
    {
         long Id { get; }
    }
}
