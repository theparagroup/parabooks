using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.theparagroup.parabooks.models.Ef;
using Ef=System.Data.Entity;

namespace com.theparagroup.parabooks.Transactors
{
    public abstract class Transactor
    {
        protected DbContext _db;
        protected Ef.DbContextTransaction _dbTransaction;
        protected EfTransaction _transaction;
        protected decimal _balance;

        public Transactor(DateTime date, string description, int? reference=null)
        {
            _transaction = new EfTransaction();
            _transaction.Date = date;
            _transaction.Description = description;
            _transaction.Reference = reference;
        }

        protected virtual void Execute(Action<EfTransaction> lambda)
        {
            using (_db = new DbContext())
            {
                using (var _dbTransaction = _db.Database.BeginTransaction())
                {
                    _db.Transactions.Add(_transaction);
                    _db.SaveChanges();

                    try
                    {
                        _balance = 0;

                        lambda(_transaction);

                        Validate();

                        _db.SaveChanges();

                        _dbTransaction.Commit();
                    }
                    catch (Exception e)
                    {
                        _dbTransaction.Rollback();
                        throw;
                    }
                }
            }

        }

        protected virtual void Entry(EfAccount account, decimal amount)
        {
            var entry = new EfEntry();
            entry.TransactionId = _transaction.Id;
            entry.AccountId = account.Id;
            entry.Amount = amount;
            _db.Entries.Add(entry);

            if (account.AccountType.NormalId==0)
            {
                //debit
                _balance += amount;
            }
            else if (account.AccountType.NormalId == 1)
            {
                //credit
                _balance -= amount;
            }
            else
            {
                throw new InvalidAccountException($"account [{account.Number} - {account.Name}] has a null normal id");
            }

        }

        protected virtual void Validate()
        {
            //debits & credits balance
            if (_balance != 0) throw new Exception("credit and debits do not balance!");

        }

    }
}
