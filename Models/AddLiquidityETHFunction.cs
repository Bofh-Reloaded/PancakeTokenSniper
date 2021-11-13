using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace BscTokenSniper.Models
{
    public class AddLiquidityETHFunction : AddLiquidityETHFunctionBase
    {
    }

    [Function("addLiquidityETH", typeof(AddLiquidityETHOutputDTO))]
    public class AddLiquidityETHFunctionBase : FunctionMessage
    {
        [Parameter("address", "token")] public virtual string Token { get; set; }

        [Parameter("uint256", "amountTokenDesired", 2)]
        public virtual BigInteger AmountTokenDesired { get; set; }

        [Parameter("uint256", "amountTokenMin", 3)]
        public virtual BigInteger AmountTokenMin { get; set; }

        [Parameter("uint256", "amountETHMin", 4)]
        public virtual BigInteger AmountETHMin { get; set; }

        [Parameter("address", "to", 5)] public virtual string To { get; set; }

        [Parameter("uint256", "deadline", 6)] public virtual BigInteger Deadline { get; set; }
    }

    public class AddLiquidityETHOutputDTO : AddLiquidityETHOutputDTOBase
    {
    }

    [FunctionOutput]
    public class AddLiquidityETHOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "amountToken")] public virtual BigInteger AmountToken { get; set; }

        [Parameter("uint256", "amountETH", 2)] public virtual BigInteger AmountETH { get; set; }

        [Parameter("uint256", "liquidity", 3)] public virtual BigInteger Liquidity { get; set; }
    }
}