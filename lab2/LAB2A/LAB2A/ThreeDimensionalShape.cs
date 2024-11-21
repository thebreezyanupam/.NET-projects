/*
    Author: Anupam Pandey
    Student Number: 000921043
    Date: 2024-10-06

    Purpose: This file defines the abstract class ThreeDimensionalShape, which represents
             a base for all 3D shapes. It inherits from the base class Shape and serves as
             a foundation for other classes like Sphere, Cube, Cylinder, etc., to provide
             specific implementations for calculating surface area and volume.

    Statement of Authorship:
    I, Anupam Pandey, 000921043, certify that this material is my original work. No other person's work has been used without due acknowledgement.
*/

using System;

namespace Lab2A
{
    /// <summary>
    /// Abstract class representing a 3D shape.
    /// Inherits from the base class Shape.
    /// This class serves as a base for specific three-dimensional shapes,
    /// like Sphere, Cube, and Cylinder, which will define their own properties and behaviors.
    /// </summary>
    public abstract class ThreeDimensionalShape : Shape
    {
        /// <summary>
        /// Constructor for the ThreeDimensionalShape class.
        /// Sets the shape type to "Three-Dimensional Shape".
        /// Each derived class can override this to set its own type.
        /// </summary>
        public ThreeDimensionalShape()
        {
            // Set a default shape type. Derived classes (e.g., Sphere, Cube) will override this as needed.
            Type = "Three-Dimensional Shape";
        }

        // Note: No additional methods or properties are defined here because
        // specific 3D shapes (like Sphere, Cube) will implement their own
        // versions of the CalculateArea and CalculateVolume methods.
    }
}
