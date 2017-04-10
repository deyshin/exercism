using System;

public class BankAccount
{
    private Object lockObj;
    private bool isOpen;
    
    public void Open()
    {
        lockObj = new Object();
        lock (lockObj)
        {
            isOpen = true;
            Balance = 0;
        }

    }

    public void Close()
    {
        lock (lockObj) { isOpen = false; }
    }

    private float balance;
    public float Balance
    {
        get
        {
            if (isOpen == false)
            { throw new InvalidOperationException(); }
            lock (lockObj)
            { return balance; }
        }

        private set
        {
            lock(lockObj)
            { balance = value;  }
        }
    }

    public void UpdateBalance(float change)
    {
        Balance += change;
    }
}
