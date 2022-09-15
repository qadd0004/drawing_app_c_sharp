﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	TextShape.cs
//
// summary:	Implements the text shape class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDrawingApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A text shape. </summary>
    ///
    /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class TextShape : Shape
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public TextShape()
        {
           
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary> the Draw method.  </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="graphics"> The graphics object. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override void Draw(Graphics graphics)
        {
            formGraphics = graphics;

            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            formGraphics.DrawString(text, font, brush, startPoint.X, startPoint.Y, drawFormat);
        }
    }
}
