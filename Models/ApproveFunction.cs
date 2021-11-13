using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace BscTokenSniper.Models
{
    public class ApproveFunction : ApproveFunctionBase
    {
    }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender")] public virtual string Spender { get; set; }

        [Parameter("uint256", "value", 2)] public virtual BigInteger Value { get; set; }
    }
}