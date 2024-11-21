/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the abstract class TwoDimensionalShape, which serves as the base
             class for all 2D shapes. It inherits from the base class Shape and provides a
             foundation for specific 2D shapes like Circle, Square, Triangle, etc., allowing them 
             to implement their own methods for calculating area. Since 2D shapes do not have volume, 
             it provides a default implementation of the CalculateVolume method that returns 0.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Abstract class representing a 2D shape.
    /// Inherits from the base class Shape.
    /// This class serves as a base for specific two-dimensional shapes,
    /// like Circle, Square, and Triangle, which will define their own properties and behaviors.
    /// </summary>
    public abstract class TwoDimensionalShape : Shape
    {
        /// <summary>
        /// Constructor for the TwoDimensionalShape class.
        /// Sets the shape type to "Two-Dimensional Shape".
        /// Each derived class can override this to set its own type.
        /// </summary>
        public TwoDimensionalShape()
        {
            // Set a default shape type. Derived classes (e.g., Circle, Square) will override this as needed.
            Type = "Two-Dimensional Shape";
        }

        /// <summary>
        /// 2D shapes do not have volume. This method provides a default implementation that returns 0.
        /// </summary>
        /// <returns>0, as 2D shapes do not have volume.</returns>
        public override double CalculateVolume()
        {
            return 0; // 2D shapes do not have a volume, so this method returns 0
        }
    }
}
