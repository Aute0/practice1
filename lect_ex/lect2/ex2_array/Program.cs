// intro to array world

// studing functions&massive. 
// Program should find max value from 9 number. Two types of solution.

// First method
// 
// int max = a1;
//
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;
// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;
// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
//
// Console.WriteLine(max);
// --------------------------
// Second metod:
//
int Max(int arg1, int arg2, int arg3)
 {
        int result = arg1;

    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
 }

/* int max = Max
(Max(a1, b1, c1),
Max(a2, b2, c2),
Max(a3, b3, c3));

Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine(max);

 */

int[] array = { 15, 21, 39, 12, 23, 33, 13, 23, 33 };

int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);