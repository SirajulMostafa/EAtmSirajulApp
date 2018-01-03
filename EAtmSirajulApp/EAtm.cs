using System;
using System.Collections.Generic;

namespace EAtmSirajulApp
{
    class EAtm
    {
        List<int> _TransactionCount = new List<int>();
        List<Account> Accounts = new List<Account>();
        bool IsConfirmationForTransaction = false;
        string _CurrentCardNum;
        int _WithDrawAmount;
        Account _Account;

        public void StartApp()
        {
            this.InIt();
            this.TakeInputForCardNumber();
        }


        public void TakeInputForCardNumber()
        {
            this.MessageDisplay("Enter Card number ");
            //this.IsValidCardAndPin(TakeInputSrtring());
            this.CardNumberCheck(TakeInputSrtring());

        }
        public void CardNumberCheck(string card)
        {

            if (Accounts.Exists(account => account.CardNumber.Equals(card)))
            {
                var account = Accounts.Find(a => a.CardNumber.Equals(card));
                //go for pin number check
                _CurrentCardNum = account.CardNumber;
                var pin = account.PinNumber;
                this.PinNumberCheck(pin);

            }
            else
            {
                this.ErrorMassage("Invalid Card Number!!!\n");
                this.TakeInputForCardNumber();
            }

        }
        public void PinNumberCheck(string pin)
        {
            this.MessageDisplay("Enter Pin Number ");
            if (pin.Equals(this.TakeInputSrtring()))
            {
                this.DoWorkOption();
            }
            else
            {
                this.ErrorMassage("Pin Number Is not Valid ! Try Again\n");
                this.TakeInputForCardNumber();

            }
        }
        public Account GetAccountByCardNumber()
        {
            Account account = Accounts.Find(a => a.CardNumber.Equals(value: _CurrentCardNum));
            return account;
        }
        private int TransactionCount()
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (_CurrentCardNum.Equals(Accounts[i].CardNumber))
                {
                    return _TransactionCount[i];

                }

            }
            return -1;
        }
        private bool ConfirmationForTransaction()
        {
            var balance = this.GetCurrentBalance();
            // if (this.TransactionCount() < 3 && input <= balance && input < 1000)
            if (TransactionCount() <= 2)
            {
                this.MessageDisplay("Enter  Amount For WithDraw ");
                int input = this.TakeInput();
                if (input <= balance && input < 1000 && input > 0)
                {
                    _WithDrawAmount = input;
                    IsConfirmationForTransaction = true;
                    // return IsConfirmationForTransaction;
                }
                else
                {
                    IsConfirmationForTransaction = false;

                }
            }
            else
            {
                IsConfirmationForTransaction = false;

            }
            return IsConfirmationForTransaction;
        }
        public void Transaction()
        {
            this.ConfirmationForTransaction();
            if (IsConfirmationForTransaction)
                this.Update();
            else
                this.RulesAndRegulation();
        }
        public void Update()
        {
            int balance = 0;
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (_CurrentCardNum.Equals(Accounts[i].CardNumber))
                {
                    balance = GetCurrentBalance() - _WithDrawAmount;
                    _Account.Balance = balance;
                    _TransactionCount[i]++;
                    var msg = "Congratulation ! Cash  withdraw = ";
                    msg += _WithDrawAmount + " Taka." + " Your Current Balance is = : " + balance + "\n";
                    this.MessageDisplay(msg);
                    break;
                }

            }
        }
        public void BalanceCheck()
        {
            var balance = this.GetCurrentBalance();
            var msg = "Your curret Balance is:" + balance + "\n";
            this.MessageDisplay(msg);
        }
        public int GetCurrentBalance()
        {
            _Account = this.GetAccountByCardNumber();
            return _Account.Balance;
        }
        private void MessageDisplay(string msg) => System.Console.Write(msg);
        private void ErrorMassage(string msg = "") => this.MessageDisplay(msg);
        private int TakeInput() => Convert.ToInt32(Console.ReadLine());
        private string TakeInputSrtring() => Console.ReadLine();
        private void Instraction()
        {
            var msg = "Enter 1 for check Balance \nEnter 2 for withdrawal Cash  \nEnter 3 For help\nEnter 4  For  Another Acount\nEnter 0 for exit \n ";
            this.MessageDisplay(msg);

        }
        private void RulesAndRegulation()
        {
            var msg = "\n-----------------------Warrnning-----------------------------";
            msg += "\nyou can not withdraw more than 3 times in a day\n You can not withdraw 2000 Taka  in One transactionn\n You can not withdraw more than  3,000 Taka  in One Day\n";
            msg += "\n-------------------------------------------------------------\n";
            this.MessageDisplay(msg);
        }
        public void DoWorkOption()
        {
            var option = "";
            do
            {
                this.Instraction();
                option = this.TakeInputSrtring();
                switch (option)
                {
                    case "1":
                        this.BalanceCheck();
                        // ErrorMassage("hello balance Check");
                        //this.DoWorkOption();

                        break;

                    case "2":

                        this.Transaction();
                        break;
                    case "3":

                        this.RulesAndRegulation();
                        break;

                    case "4":

                        this.StartApp();

                        break;

                    case "0":

                        break;

                    default:

                        this.ErrorMassage("-----!!! Error Foud !!!-------\n");
                        this.DoWorkOption();
                        break;
                }

            } while (!option.Equals("0"));
        }
        public void InIt()
        {
            Accounts.Add(item: new Account() { CardNumber = "1", PinNumber = "123", Balance = 500 });
            Accounts.Add(item: new Account() { CardNumber = "2", PinNumber = "234", Balance = 400 });
            Accounts.Add(item: new Account() { CardNumber = "3", PinNumber = "345", Balance = 500 });
            _TransactionCount.Add(item: 0);
            _TransactionCount.Add(item: 0);
            _TransactionCount.Add(item: 0);

        }

    }
}