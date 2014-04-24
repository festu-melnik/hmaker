using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace HMaker.UI.SyntaxHighlightBox 
{
	public class DrawingControl : FrameworkElement 
    {
		private VisualCollection visuals;
		private DrawingVisual visual;

        protected override int VisualChildrenCount
        {
            get { return visuals.Count; }
        }

		public DrawingControl() 
        {
			visual = new DrawingVisual();
			visuals = new VisualCollection(this);
			visuals.Add(visual);
		}

		public DrawingContext GetContext() 
        {
			return visual.RenderOpen();
		}

		protected override Visual GetVisualChild(int index) 
        {
			return visuals[index];
		}
	}
}
