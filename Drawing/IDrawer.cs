using HTMLCreator.Parsing;
using System.Drawing;

namespace HTMLCreator.Drawing
{
    interface IDrawer
    {
        Image Draw(GraphComponent root);
    }
}
