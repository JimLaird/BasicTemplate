using System.Drawing;

namespace BasicTemplate.Helpers
{
    public interface IEnvironment
    {
        void SetStatusBarColor(Color color, bool darkStatusBarTint);
    }
}
