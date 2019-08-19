using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class ComplexNumber
    {
        public int real;
        public int imaginarity;

        public ComplexNumber(int real, int imaginarity)
        {
            this.real = real;
            this.imaginarity = imaginarity;
        }
        public override bool Equals(object obj)
        {
            var other = obj as ComplexNumber;
            if (other == null) return false;
            return (this.real == other.real) && (this.imaginarity == other.imaginarity);
        }
        public static ComplexNumber operator * (ComplexNumber a,ComplexNumber b)
            {
            return new ComplexNumber(((a.real * b.real) - (a.imaginarity * b.imaginarity)),(a.real*b.imaginarity+b.real*a.imaginarity ));           
            }
        public static ComplexNumber operator /(ComplexNumber a, ComplexNumber b)
        {
            int  x=b.imaginarity*b.imaginarity+b.real*b.real;
            return new ComplexNumber((a.real*b.real+a.imaginarity*b.imaginarity)/x,(a.imaginarity*b.real-a.real*b.imaginarity)/x );
        }
        
    }
}
