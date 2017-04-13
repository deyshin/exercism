using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{

    private string badPhoneNumber = "0000000000";
    private string phoneNumber;
    public PhoneNumber(string pn)
    {
        var phoneNum = Regex.Replace(pn, "[^0-9]", "");
        phoneNumber =
            CheckPhoneNumberValidity(phoneNum) ?
            TrimPhoneNumber(phoneNum) : badPhoneNumber;
    }

    private bool CheckPhoneNumberValidity(string phoneNum)
    {
        var l = phoneNum.Length;
        var isValid =
            (l == 10)
            || (l == 11 && phoneNum[0] == '1');

        return isValid;
    }

    private string TrimPhoneNumber(string phoneNum)
    {
        var trimmedPhoneNumber = phoneNum.Length == 11 ?
         phoneNum.Substring(1,10) : phoneNum;

        return trimmedPhoneNumber;
    }

    public string Number
    {
        get
        { return phoneNumber; }
    }

    public string AreaCode
    {
        get
        { return phoneNumber.Substring(0, 3); }
    }

    public override string ToString()
    { return $"({AreaCode}) {phoneNumber.Substring(3,3)}-{phoneNumber.Substring(6,4)}";}
}