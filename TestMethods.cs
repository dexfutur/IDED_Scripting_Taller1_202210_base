using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = new Stack<int>();
            int[] element = new int[sourceStack.Length];

            for (int i = sourceStack.Length - 1; i >= 0; i--)
            {

                if (result.Count > 0)
                {
                    while (result.Count > 0
                           && result.Peek() <= sourceStack[i])
                    {
                        result.Pop();
                    }
                }
                element[i] = result.Count == 0 ? -1 : result.Peek();
                result.Push(sourceStack[i]);

            }

            for (int i = 0; i < [sourceStack.Length; i++)
            {
                result.Push([sourceStack[i] + " --> " + element[i]);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}