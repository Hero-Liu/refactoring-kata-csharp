using System.ComponentModel;

namespace RefactoringKata
{
    public enum ProductSize
    {
        SizeNotApplicable = -1,
        [Description("Invalid Size")]
        InvalidSize = -1,
        [Description("XS")]
        Xs = 1,
        [Description("S")]
        S = 2,
        [Description("M")]
        M = 3,
        [Description("L")]
        L = 4,
        [Description("XL")]
        Xl = 5,
        [Description("XXL")]
        Xxl = 6,

    }

}
