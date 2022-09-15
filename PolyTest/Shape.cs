////////////////////////////////////////////////////////////////////////////////////////////////////
//  Mohsen Qaddoura - April 7th, 2021
// file:	Shape.cs
//
// summary:	Implements the shape class
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismDrawingApp
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A shape. </summary>
    ///
    /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    /*
     
        public virtual void Draw(Graphics graphics) // the concept of drawing an undefined shape is abstract 
        {

        }

     
     */



    abstract class Shape //  base class. An abstract class is a class that can be inherited from but can not be used
     // to directly create an an object. A class must be declared "abstract" if it has one, or more, abstract methods
    {
        /// <summary>   The brush. </summary>
        protected System.Drawing.SolidBrush brush;
        /// <summary>   The pen. </summary>
        protected System.Drawing.Pen pen;
        /// <summary>   The font. </summary>
        protected Font font;
   
        /// <summary>   The graphics object. </summary>
        protected Graphics formGraphics;

        /// <summary>   The start point. </summary>
        protected Point startPoint;
        /// <summary>   The end point. </summary>
        protected Point endPoint;

        /// <summary>   The text. </summary>
        protected string text;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Shape()
        {
            brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            pen = new System.Drawing.Pen(System.Drawing.Color.Black);
            font = new System.Drawing.Font("Arial", 16); // using a known default font
            text = string.Empty;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Finaliser. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        ~Shape() // we are responsible for cleaning up these graphic items
        {
            brush.Dispose();
            pen.Dispose();
            formGraphics.Dispose();
            font.Dispose();
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Draws to the given graphics device.
        /// </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="graphics"> The graphics object. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public abstract void Draw(Graphics graphics); // the concept of drawing an undefined shape is abstract 
        // an abstract method has its signature but no implentation (body) in its abstract class. It has to be implemented
        // in the deriverd class where the abstract method is overidden and implemented


        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets start point. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="point">    The point. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SetStartPoint(Point point)
        {
            startPoint = point;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets end point. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="point">    The point. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SetEndPoint(Point point)
        {
            endPoint = point;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets pen colour. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="colour">   The colour. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SetPenColour(Color colour)
        {
            pen.Color = colour;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets brush colour. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="colour">   The colour. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SetBrushColour(Color colour)
        {
            brush.Color = colour;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets a font. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="font"> The font. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SetFont(Font font)
        {
            this.font = font;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Sets a text. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <param name="text"> The text. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public void SetText(string text)
        {
            this.text = text;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets pen colour. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <returns>   The pen colour. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Color GetPenColour() { return pen.Color; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets brush colour. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <returns>   The brush colour. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Color GetBrushColour() { return brush.Color; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets start point. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <returns>   The start point. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Point GetStartPoint() { return startPoint; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets end point. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <returns>   The end point. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public Point GetEndPoint() { return endPoint; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the text. </summary>
        ///
        /// <remarks>   Tony Davidson, 2021-03-22. </remarks>
        ///
        /// <returns>   The text. </returns>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string GetText() { return text; }
    }
}

/*
How does the polymorphic code compare to the original code in this project?
It is much more concise and is less error prone

Was it difficult to convert the project to use polymorphism?
No, it was not.

What are your thoughts on polymorphism?
Polymorphis makes the program code more solid and resistant to programming errors

Any other thoughts or comments?
Great programming concept to learn and apply

------------------------------------------------------------------------------------------------------------------------

I will write the remaining required comments here, in one place, as there are many class files that make finding
the appropiate comments difficult

-A virtual method is a method in the base class that can be inherited and overrdiden in the derived class. It is bond to its
entry point at runtime.

- Overide, keyword is used in the derived class to verride the base class method with modified code in the dervided class method
that has the same signature but different body.

-  a reference to the base class is a reference that instances of
the derived classes, in the inheritance heirarchy of the base class, can use (upcasting).
 */
