# RleLwzCompression
Simple project for compression pictures.
In this project implements two algorithms of compression:
- RLE - https://en.wikipedia.org/wiki/Run-length_encoding, http://rosettacode.org/wiki/Run-length_encoding
- LWZ - https://en.wikipedia.org/wiki/Lempel%E2%80%93Ziv%E2%80%93Welch, http://rosettacode.org/wiki/LZW_compression#C.32

In the project implemented the ability to adding new compression algorithms.

To add a new algorithm, you need to create a class and implement the interface IAlgorithmsCompression

Tools
- VS 2013
- C# .NET 4.5

About the project:
- Is used the design pattern - MVP (https://msdn.microsoft.com/en-us/library/ff649571.aspx)
- To implement the algorithms used to add new behavioral pattern - Strategy (https://en.wikipedia.org/wiki/Strategy_pattern)
