using System.ComponentModel;

namespace RefactoringKata
{
    public enum ProductColor
    {
        [Description("no color")]
        NoColor = 0,
        [Description("blue")]
        Blue = 1,
        [Description("red")]
        Red = 2,
        [Description("yellow")]
        Yellow = 3,
    }
}
