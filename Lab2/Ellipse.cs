using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Name: Vitaliy Shahanyants
    /// Date: 16/02/2017
    /// Project: Lab 2
    /// 
    /// Class Name: Ellipse
    /// Inherents: CircleShape
    /// 
    /// Purpose: Is to calcuate Circle shape area
    /// 
    /// Statement of Authorship : StAuth10065: I Vitaliy Shahanyants, 000311736 certify that this material is my original work. 
    /// No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    class Ellipse : CircleShape
    {
        private double major;
        private double minor;

        public Ellipse() : base() { }

        /// <summary>
        /// SetData: Is overrided method from CircleShape meant to uses base class CircleShape's EnterValue() method to get user input, passing the input message and reference to get back the value,
        /// and store it to base clas property, and class the base class SetDate to continue 
        /// </summary>
        public override void SetData()
        {
            base.EnterValue("Enter the semi-major axis length: ", out major);
            base.Major = major;
            base.EnterValue("Enter the semi-minor axis length: ", out minor);
            base.Minor = minor;
            base.ThirdDimentionalObject = false;
            base.SetData();
        }
        /// <summary>
        /// CalculateArea: Is a override method  from CircleShape, meant to calculate Area
        /// </summary>
        /// <returns>Double Calculated Area</returns>
        public override double CalculateArea()
        {
            return Shape.PI * base.Major * base.Minor;
        }
        /// <summary>
        /// ToString: is meant to display specifically formated 
        /// </summary>
        /// <returns>return formated string</returns>
        public override string ToString()
        {
            return string.Format("{0,-11}\t{1,10}\t{2,-10}\t{3,-45}",
                                    this.GetType().Name,base.AreaCalculation.ToString("0.00"),"",$"{base.Major.ToString("0.00")} s.major x {base.Minor.ToString("0.00")} s.minor");
        }
    }
}
