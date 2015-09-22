using System;

namespace PokeD.ServerProxy.Desktop
{
    [Flags]
    public enum ExitCodes
    {
        Success = 0,
        UnknownError = 1,
    }
}
