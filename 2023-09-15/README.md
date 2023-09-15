# 2023-09-15
I have created a datatable i vb.net with the following design:

TableIn:
```
Col1 Integer
Col2 Integer
Col3 Integer
``` 
Example:
```
Col1  Col2  Col3
----------------
10     2     1
4      7     2
10     2     1
6      4     3
5      5     3
4      7     2
```

I want to create a table with this design:

TableOut
```
Out1 VarChar(10)
Out2 Integer
```

Your code should do the following:

1. Group TableIn after Col1, Col2, Col3.

2. The output should be sorted after group in ascending order.

3. Sum frequence for each group.

4. Concatenate Col1, Col2 and Col3 with a hyphen between.

The example above should give this result:
```
Col1    Col2
------------
4-7-2    2
5-5-3    1
6-4-3    1
10-2-1   2
```

Write your code in C# or Java. I will integrate it with my own code.
