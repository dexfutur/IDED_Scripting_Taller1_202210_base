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
            List<int> element = new List<int>();

            int ele = sourceStack.Count;

            for (int i = 0; i <= ele; i++)
            {
                element.Add(sourceStack.Pop());
            }

            element.Reverse();

            int high;

            for (int i = 0; i <= element.Count - 1; i++)
            {

                high = 0;
                for (int j = i; j <= element.Count - 1; j++)
                {
                    if (high < element[j])
                    {
                        high = element[j];
                    }
                }

                if (element[i] < high)
                {
                    result.Push(high);
                }

                else
                {

                    result.Push(-1);
                }

                for (int i= 0; i <= element.Count - 1; i++)
            {
                sourceStack.Push(element[i]);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            for (int i = 0; i < sourceArr.Length; i++)
            {
                if (sourceArr[i] % 2 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Two);
                }

                else if (sourceArr[i] % 3 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Three);
                }

                else if (sourceArr[i] % 5 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Five);
                }
                
                else if (sourceArr[i] % 7 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Seven);
                }

                else if (sourceArr[i] % sourceArr[i]  == 0 )
                {
                    result.Add(sourceArr[i], EValueType.Prime);
                }

            }


            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int cantidad = 0;
            foreach(var value in sourceDict.Values)
            {
                if (value == type)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            int[] keys = new int[sourceDict.Count];
            sourceDict.Keys.CopyTo(keys, 0);

            EValueType[] value = new EValueType[sourceDict.Count];
            sourceDict.Values.CopyTo(value, 0);

            int tempkey;
            EValueType tempval;
            for (int j = 0; j <= keys.Length; j++)
            {
                for (int i = 0; i <= keys.Length; i++)
                {

                    if (keys[i] < keys[i + 1])
                    {
                        tempkey= keys[i + 1];
                        keys[i + 1] = keys[i];
                        keys[i] = tempkey;

                        tempval= value[i + 1];
                        value[i + 1] = value[i];
                        value[i] = tempval;
                    }
                }
            }

            for (int j = 0; j < keys.Length; j++)
            {
                result.Add(keys[j], value[j]);
            }
            
            
         


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