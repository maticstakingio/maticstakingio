﻿using Core.Application.ViewModels.BlockChain;
using Core.Utilities.Dtos;
using System.Threading.Tasks;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3.Accounts;
using System.Numerics;

namespace Core.Application.Interfaces
{
    public interface IBlockChainService
    {
        Account CreateAccount();

        CoinMarKetCapInfoViewModel GetListingLatest(int startIndex, int limitItem, string unitConvertTo);

        Task<Transaction> GetTransactionByTransactionID(string transactionID, string urlRPC);

        Task<TransactionReceipt> GetTransactionReceiptByTransactionID(string transactionID, string urlRPC);

        Task<decimal> GetERC20Balance(string owner, string smartContractAddress, int decimalPlaces, string urlRPC);

        Task<decimal> GetEtherBalance(string publishKey, string urlRPC);

        Task<TransactionReceipt> SendEthAsync(string privateKey, string receiverAddress, decimal tokenAmount, string urlRPC);

        decimal GetCurrentPrice(string unit, string unitConverto);

        Task<string> SendTokenAsync(string privateKeyERC20, string receiverAddress,
            string contractAddress, decimal tokenAmount, int decimalPlaces, string urlRPC);

        Task<TransactionReceipt> SendERC20Async(string privateKeyERC20, string receiverAddress, 
            string contractAddress, decimal tokenAmount, int decimalPlaces, string urlRPC);

        Task<string> SendERC20WithoutReceiptAsync(string privateKeyERC20, string receiverAddress,
            string contractAddress, decimal tokenAmount, int decimalPlaces, string urlRPC);

        Task<string> SendEthWithoutReceiptAsync(string privateKey,
            string receiverAddress, decimal tokenAmount, string urlRPC);

        Task<TransactionReceipt> GetTransactionReceiptByTransactionIDWithRetry(
           string transactionID, string urlRPC, int retry = 3, int timeout = 3000);

        Task<string> SendERC20WithEstimateGasAsync(string privateKeyERC20, string receiverAddress,
            string contractAddress, decimal tokenAmount, int decimalPlaces, string urlRPC);

        Task<BigInteger> GetGasPrice();

        Task<TransactionReceipt> SendERC20Async(string privateKeyERC20, string receiverAddress,
            string contractAddress, decimal tokenAmount, int decimalPlaces, string urlRPC, BigInteger gasPrice);

        Task<TransactionReceipt> SendEthAsync(string privateKey,
            string receiverAddress, decimal tokenAmount, string urlRPC, BigInteger gasPrice);
    }
}
