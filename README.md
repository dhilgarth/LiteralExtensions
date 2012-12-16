LiteralExtensions
=================

Provides literal extensions methods that allow to write stuff like `5.Days() + 42.Minutes()`.

The extension methods are in the same namespace as the type for which they have been created to make them available immediately.

Currently the following literal extensions exist:

- For [`System.TimeSpan`](http://msdn.microsoft.com/en-us/library/system.timespan.aspx):
    - `Ticks(long)`, `Ticks(int)`
    - `Milliseconds(double)`, `Milliseconds(int)`
    - `Seconds(double)`, `Seconds(int)`
    - `Minutes(double)`, `Minutes(int)`
    - `Hours(double)`, `Hours(int)`
    - `Days(double)`, `Days(int)`