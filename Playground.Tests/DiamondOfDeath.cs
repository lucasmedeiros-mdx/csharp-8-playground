using System;

namespace Playground.Tests
{
    interface IDeveloper
    {
        string LearnNewLanguage(string language)
        {
            Console.Write($"Learning {language} in a default way.");
            return language;
        }
    }

    interface IBackendDev : IDeveloper
    {
        new string LearnNewLanguage(string language)
        {
            Console.Write($"Learning {language} in a backend way.");
            return language;
        }
    }

    interface IFrontendDev : IDeveloper
    {
        new string LearnNewLanguage(string language)
        {
            Console.Write($"Learning {language} in a frontend way.");
            return language;
        }
    }

    interface IFullStackDev : IBackendDev, IFrontendDev { }
}
