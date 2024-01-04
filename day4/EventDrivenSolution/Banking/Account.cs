namespace Banking;
using Taxation;
using Notification;

public class Account
{   
    public float Balance{get;set;}

    public event TaxOperation overBalance;
    public event NotificationOperation underBalance;

    public void Deposit(float amount){
        this.Balance = this.Balance + amount;

        if(this.Balance > 250000){
            overBalance(4500);
            this.Balance = this.Balance - 4500;
        }
    }

    public void Withdraw(float amount){
        this.Balance = this.Balance - amount;

        if(this.Balance < 10000){
            underBalance("Ameya","You are account balance is less than 10000");
        }

    }

}
