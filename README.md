 Problem:E-ATM
 ```
This simple project will essentially create a simulation of an ATM within a Windows Console App. Just like an ATM, the program should have at least the following features:

Check whether an input – card number - is recorded correctly. Verifying user by asking for a PIN number. In case of negative verification, logging out user. In case of positive verification, showing three options : check account balance, cash withdrawal and exit. Give user ability to withdraw up to $1000 worth of cash in one transaction with total transactions limited to 3 per day. card numbers = [1, 2 ,3]

pin numbers = [123, 234, 456 ]

balance = [500, 200, 800]

Sample program behavior

what is your card number : 1

pin number : 123

what do you want to do: 1

enter amount: 200

Cash withdrawal successful. Your account balance is 300

Do you want to quit?

If the user doesnt quit, take to the step of balance check or cash withdrawal.






output:

Enter Card number 1

Enter Pin Number 123

Enter 1 for check Balance,2 for withdrawal Cash, 3 For help, 4  For  Another Acount, 0 for exit
 1
Your curret Balance is:500

Enter 1 for check Balance,2 for withdrawal Cas, 3 For help,4  For  Another Acount, 0 for exit
 2

Enter  Amount For WithDraw 2
Congratulation ! Cash  withdraw = 2 Taka. Your Current Balance is = : 498

Enter 1 for check Balance,2 for withdrawal Cas, 3 For help,4  For  Another Acount, 0 for exit
 2

Enter  Amount For WithDraw 2
 Congratulation ! Cash  withdraw = 2 Taka. Your Current Balance is = : 496

Enter 1 for check Balance,2 for withdrawal Cas, 3 For hel,4  For  Another Acount, 0 for exit
2

Enter  Amount For WithDraw 2
 Congratulation ! Cash  withdraw = 2 Taka. Your Current Balance is = : 494

Enter 1 for check Balance,2 for withdrawal Cas, 3 For help,4  For  Another Acount, 0 for exit
2

Enter  Amount For WithDraw 2
 Congratulation ! Cash  withdraw = 2 Taka. Your Current Balance is = : 492

Enter 1 for check Balance,2 for withdrawal Cash, 3 For help,4  For  Another Acount, 0 for exit
 2

-----------------------Warrnning----------------------------

you can not withdraw more than 3 times in a day
 You can not withdraw 2000 Taka  in One transactionn
 You can not withdraw more than  3,000 Taka  in One Day

-------------------------------------------------------------
-
Enter 1 for check Balance
,2 for withdrawal Cash, 3 For help,4  For  Another Acount, 0 for exit
1
Your curret Balance is:492
-
Enter 1 for check Balance,2 for withdrawal Cash, 3 For help,4  For  Another Acount, 0 for exit
 4

Enter Card number 234
-Invalid Card Number!!!

Enter Card number 2

Enter Pin Number 234

Enter 1 for check Balance,2 for withdrawal Cash, 3 For help,4  For  Another Acount
, 0 for exit
 1
 Your curret Balance is:400

Enter 1 for check Balance,2 for withdrawal Cash, 3 For help,4  For  Another Acount, 0 for exit
 2

Enter  Amount For WithDraw 56
Congratulation ! Cash  withdraw = 56 Taka. Your Current Balance is = : 344

Enter 1 for check Balance,2 for withdrawal Cash, 3 For help,4  For  Another Acount, 0 for exit
 4

Enter Card number 3

Enter Pin Number 345

Enter 1 for check Balance
 ,2 for withdrawal Cash
 , 3 For help
 ,4  For  Another Acount
 , 0 for exit
 1
Your curret Balance is:500

Enter 1 for check Balance
,2 for withdrawal Cash
, 3 For help,4  For  Another Acount, 0 for exit
 2

Enter  Amount For WithDraw 56
Congratulation ! Cash  withdraw = 56 Taka. Your Current Balance is = : 444

Enter 1 for check Balance,2 for withdrawal Cash, 3 For help,4  For  Another Acount, 0 for exit
 2

Enter  Amount For WithDraw 34
Congratulation ! Cash  withdraw = 34 Taka. Your Current Balance is = : 410

Enter 1 for check Balance,2 for withdrawal Cash, 3 For help,4  For  Another Acount, 0 for exit
