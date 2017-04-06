using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsrpp_6
{
    class ComplexNumber
    {
        private Double Re;
        private Double Im;

        public ComplexNumber()
        {
            this.Re = 0F;
            this.Im = 0F;
        }

        public ComplexNumber(Double _Re, Double _Im)
        {
            this.Re = _Re;
            this.Im = _Im;
        }

        public static ComplexNumber operator +(ComplexNumber _a, ComplexNumber _b)
        {
            return new ComplexNumber(_a.Re + _b.Re, _a.Im + _b.Im);
        }

        public static ComplexNumber operator *(ComplexNumber _a, ComplexNumber _b)
        {
            return new ComplexNumber(_a.Re * _b.Re, _a.Im * _b.Im);
        }

        public static ComplexNumber operator -(ComplexNumber _a, ComplexNumber _b)
        {
            return new ComplexNumber(_a.Re - _b.Re, _a.Im - _b.Im);
        }

        public static Boolean operator ==(ComplexNumber _a, ComplexNumber _b)
        {
            return _a.Equals(_b);
        }

        public static Boolean operator !=(ComplexNumber _a, ComplexNumber _b)
        {
            return _a.Equals(_b);
        }

        public String ToString()
        {
            return String.Concat(this.Re.ToString(), " + i", this.Im.ToString()); ;
        }
        
        public override bool Equals(object obj)
        {
            if (this.Re == ((ComplexNumber)obj).Re && this.Im == ((ComplexNumber)obj).Im)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
