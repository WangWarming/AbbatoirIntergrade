
namespace AbbatoirIntergrade.DataTypes
{
    public partial class Messages
    {
        public string MessageTitle;
        public string MessageText;
        public const string Intro = "Intro";
        public const string WelcomeBack = "WelcomeBack";
        public static System.Collections.Generic.List<System.String> OrderedList = new System.Collections.Generic.List<System.String>
        {
        Intro
        ,WelcomeBack
        };
        
        
    }
}
