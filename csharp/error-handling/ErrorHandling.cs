using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        int? res;
        try
        { res = int.Parse(input); }
        catch
        { res = null; }

        return res;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        bool res;

        try
        {
            result = int.Parse(input);
            res = true;
        }
        catch
        {
            result = 0;
            res = false;
        }

        return res;
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        { throw new Exception(); }
        catch
        {
            disposableObject.Dispose();
            throw;
        }
    }
}
