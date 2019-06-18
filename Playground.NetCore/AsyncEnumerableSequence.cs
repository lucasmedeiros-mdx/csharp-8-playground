using System.Collections.Generic;
using System.Threading.Tasks;

namespace Playground.NetCore
{
    public class AsyncEnumerableSequence
    {
        public static async Task<IEnumerable<int>> GenerateCurrentSequenceAsync()
        {
            var impl = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                impl.Add(i);
            }

            return impl;
        }

        public static async Task<int> SumCurrentSequenceAsync()
        {
            int sum = 0;

            foreach (var number in await GenerateCurrentSequenceAsync())
            {
                sum += number;
            }

            return sum;
        }

        public static async IAsyncEnumerable<int> GenerateSequenceAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }
        
        public async Task<int> SumSequenceAsync()
        {
            int sum = 0;

            await foreach (var number in GenerateSequenceAsync())
            {
                sum += number;
            }

            return sum;
        }
    }
}
