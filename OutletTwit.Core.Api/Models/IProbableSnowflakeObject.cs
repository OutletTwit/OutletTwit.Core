using System;

namespace OutletTwit.Core.Api.Models
{
    public interface IProbableSnowflakeObject : ICreatedObject
    {
        bool IsSnowflake { get; }
    }
}
