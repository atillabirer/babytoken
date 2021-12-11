using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Project.Contracts.IterableMapping.ContractDefinition;

namespace Project.Contracts.IterableMapping
{
    public partial class IterableMappingService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, IterableMappingDeployment iterableMappingDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<IterableMappingDeployment>().SendRequestAndWaitForReceiptAsync(iterableMappingDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, IterableMappingDeployment iterableMappingDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<IterableMappingDeployment>().SendRequestAsync(iterableMappingDeployment);
        }

        public static async Task<IterableMappingService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, IterableMappingDeployment iterableMappingDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, iterableMappingDeployment, cancellationTokenSource);
            return new IterableMappingService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public IterableMappingService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}
