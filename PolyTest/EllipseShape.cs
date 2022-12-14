////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	EllipseShape.cs
//
// summary:	Implements the ellipse shape class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolymorphismDrawingApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An ellipse shape. </summary>
    ///
    /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class EllipseShape : Shape // EllipseShape "is a" type of Shape
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public EllipseShape()
        {
           
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Draws the given graphics. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="graphics"> The graphics object. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override void Draw(Graphics graphics)
        {
            formGraphics = graphics;

            Rectangle rectangle = new Rectangle(Math.Min((Convert.ToInt32(startPoint.X)), Convert.ToInt32(endPoint.X)),
                                         Math.Min(Convert.ToInt32(startPoint.Y), Convert.ToInt32(endPoint.Y)),
                                         Math.Abs(Convert.ToInt32(endPoint.X) - Convert.ToInt32(startPoint.X)),
                                         Math.Abs(Convert.ToInt32(endPoint.Y) - Convert.ToInt32(startPoint.Y)));

            formGraphics.FillEllipse(brush, rectangle);
        }
    }
}
