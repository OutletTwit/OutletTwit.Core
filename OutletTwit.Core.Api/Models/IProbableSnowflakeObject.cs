using System;

namespace OutletTwit.Core.Api.Models
{
    public interface IProbableSnowflakeObject : IObject
    {
        bool IsSnowflake { get; }
    }
}
