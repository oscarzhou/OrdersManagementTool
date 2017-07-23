﻿
using DLL;
using Models;
using System.Collections.Generic;

namespace BLL
{
    public class TransactionManage
    {
        public int InsertTransactionRecord(Transaction objTransaction)
        {
            return new TransactionService().InsertTransactionRecord(objTransaction);
        }

        public List<Transaction> GetTransactionList()
        {
            return new TransactionService().GetTransactionList();
        }

        public List<Transaction> GetUndoneTransactionList()
        {
            return new TransactionService().GetUndoneTransactionList();
        }

        public Transaction GetTransactionRecordByOrderNo(int orderNo)
        {
            return new TransactionService().GetTransactionRecordByOrderNo(orderNo);
        }

        public int UpdateTransactionRecord(Transaction objTransaction)
        {
            return new TransactionService().UpdateTransactionRecord(objTransaction);
        }
    }
}
