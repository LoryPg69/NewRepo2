using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Complex;
using System.Diagnostics;

namespace SuperMath
{
    public class Utility
    {
        public static string DoTheMath()
        {
            Debug.WriteLine("ddhudh");

            var a = Matrix<double>.Build.Random(400, 344);
            var v = Vector<double>.Build.Random(400, 344);
            var y = a.Solve(v);

            return y.ToString();    

        }
        
        }  
    }
