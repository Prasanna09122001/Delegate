using System;
namespace Delegate
{
    internal class ArrayDelegate
    {
        delegate void DelOp(int x, int y);
        public static void Implementation()
        {
            DelOp[] obj =
            {
                new DelOp(Operation.Add),
                new DelOp(Operation.Sub )
            };
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);
                Console.WriteLine();
            }
        }
    }
}

