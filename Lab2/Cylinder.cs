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
    /// Class Name: Cylinder
    /// Inherents: CircleShape
    /// 
    /// Purpose: Is to calcuate Circle shape area
    /// 
    /// Statement of Authorship : StAuth10065: I Vitaliy Shahanyants, 000311736 certify that this material is my original work. 
    /// No other person's work has been used without due acknowledgement. I have not made my work available to anyone else.
    /// </summary>
    class Cylinder : CircleShape
    {
        private double radius;
        private double height;

        public Cylinder() : base() { }

        /// <summary>
        /// SetData: Is overrided method from CircleShape meant to uses base class CircleShape's EnterValue() method to get user input, passing the input message and reference to get back the value,
        /// and store it to base clas property, and class the base class SetDate to continue 
        /// </summary>
        public override void SetData()
        {
            base.EnterValue("Enter the radius: ", out radius);
            base.Radius = radius;
            base.EnterValue("Enter the height: ", out height);
            base.Height = height;
            base.ThirdDimentionalObject = true;
            base.SetData();
        }

        /// <summary>
        /// CalculateArea: Is a override method  from CircleShape, meant to calculate Area
        /// </summary>
        /// <returns>Double Calculated Area</returns>
        public override double CalculateArea()
        {
            return base.CalculateArea();
        }

        /// <summary>
        /// CalculateVolume: Is a override method  from CircleShape, meant to calculate Volume
        /// </summary>
        /// <returns>Double Calculated Area</returns>
        public override double CalculateVolume()
        {
            return base.CalculateVolume();
        }
        /// <summary>
        /// ToString: is meant to display specifically formated 
        /// </summary>
        /// <returns>return formated string</returns>
        public override string ToString()
        {
            return string.Format("{0,-11}\t{1,10}\t{2,10}\t{3,-45}",
                                    this.GetType().Name, AreaCalculation.ToString("0.00"), VolumeCalculation.ToString("0.00"), $"{base.Radius.ToString("0.00")} r x {base.Height.ToString("0.00")} h");
        }
    }
}
