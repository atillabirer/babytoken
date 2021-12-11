using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Project.Contracts.IterableMapping.ContractDefinition
{


    public partial class IterableMappingDeployment : IterableMappingDeploymentBase
    {
        public IterableMappingDeployment() : base(BYTECODE) { }
        public IterableMappingDeployment(string byteCode) : base(byteCode) { }
    }

    public class IterableMappingDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6104e761003a600b82828239805160001a60731461002d57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe730000000000000000000000000000000000000000301460806040526004361061006c5760003560e01c806317e142d1146100715780634c60db9c14610097578063732a2ccf146100b9578063bc2b405c146100e6578063d1aa9e7e14610106578063deb3d89614610131575b600080fd5b61008461007f3660046103c4565b610143565b6040519081526020015b60405180910390f35b8180156100a357600080fd5b506100b76100b23660046103c4565b610191565b005b6100846100c73660046103c4565b6001600160a01b03166000908152600191909101602052604090205490565b8180156100f257600080fd5b506100b76101013660046103f0565b6102cc565b610119610114366004610425565b610375565b6040516001600160a01b03909116815260200161008e565b61008461013f366004610447565b5490565b6001600160a01b038116600090815260038301602052604081205460ff1661016e575060001961018b565b506001600160a01b03811660009081526002830160205260409020545b92915050565b6001600160a01b038116600090815260038301602052604090205460ff166101b7575050565b6001600160a01b03811660009081526003830160209081526040808320805460ff191690556001808601835281842084905560028601909252822054845490929161020191610460565b9050600084600001828154811061021a5761021a610485565b60009182526020808320909101546001600160a01b0390811680845260028901909252604080842087905590871683528220919091558554909150819086908590811061026957610269610485565b600091825260209091200180546001600160a01b0319166001600160a01b039290921691909117905584548590806102a3576102a361049b565b600082815260209020810160001990810180546001600160a01b03191690550190555050505050565b6001600160a01b038216600090815260038401602052604090205460ff1615610311576001600160a01b03821660009081526001840160205260409020819055505050565b6001600160a01b03821660008181526003850160209081526040808320805460ff19166001908117909155878101835281842086905587546002890184529184208290558101875586835291200180546001600160a01b0319169091179055505050565b600082600001828154811061038c5761038c610485565b6000918252602090912001546001600160a01b03169392505050565b80356001600160a01b03811681146103bf57600080fd5b919050565b600080604083850312156103d757600080fd5b823591506103e7602084016103a8565b90509250929050565b60008060006060848603121561040557600080fd5b83359250610415602085016103a8565b9150604084013590509250925092565b6000806040838503121561043857600080fd5b50508035926020909101359150565b60006020828403121561045957600080fd5b5035919050565b60008282101561048057634e487b7160e01b600052601160045260246000fd5b500390565b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052603160045260246000fdfea2646970667358221220a96f4db0490768bb151cd15425349e3b8539142eb795e56aa41a8326a6c75ff664736f6c634300080a0033";
        public IterableMappingDeploymentBase() : base(BYTECODE) { }
        public IterableMappingDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
