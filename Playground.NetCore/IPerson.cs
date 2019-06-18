using System;

namespace Playground.NetCore
{
    public interface IPerson
    {
        int GetNameLength();

        int GetMiddleNameLength() => throw new NotImplementedException();
    }
}
