using System;

namespace CSharp.유형
{
    public enum SomeRootVegetable
    {
        HorseRadish,
        Radish,
        Turnip
    }

    [Flags]
    public enum Seasons
    {
        None = 0,
        Spring = 1,
        Summer = 2,
        Autumn = 4,
        Winter = 8,
        All = Spring | Summer | Autumn | Winter
    }
}