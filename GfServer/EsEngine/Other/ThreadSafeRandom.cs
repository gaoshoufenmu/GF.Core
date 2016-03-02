using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Thread-safe random number generator.
// Has same API as System.Random but is thread safe, 
// similar to the implementation by Steven Toub: http://blogs.msdn.com/b/pfxteam/archive/2014/10/20/9434171.aspx
public class ThreadSafeRandom
{
    //------------------------------------------------------------------------=
    private static readonly RandomNumberGenerator mGlobalCryptoProvider = RandomNumberGenerator.Create();
    [ThreadStatic]
    private static Random mRandom;

    //------------------------------------------------------------------------=
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static Random GetRandom()
    {
        if (mRandom == null)
        {
            byte[] buffer = new byte[4];
            mGlobalCryptoProvider.GetBytes(buffer);
            mRandom = new Random(BitConverter.ToInt32(buffer, 0));
        }

        return mRandom;
    }

    //------------------------------------------------------------------------=
    public int next()
    {
        return GetRandom().Next();
    }

    //------------------------------------------------------------------------=
    public int next(int maxValue)
    {
        return GetRandom().Next(maxValue);
    }

    //------------------------------------------------------------------------=
    public int next(int minValue, int maxValue)
    {
        return GetRandom().Next(minValue, maxValue);
    }

    //------------------------------------------------------------------------=
    public void nextBytes(byte[] buffer)
    {
        GetRandom().NextBytes(buffer);
    }

    //------------------------------------------------------------------------=
    public double nextDouble()
    {
        return GetRandom().NextDouble();
    }
}
