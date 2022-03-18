// произведение массивов
  
using System;

class Polynomial {
    private readonly double[] _coefficients;
    
    public Polynomial(params double[] coefficients) {
        _coefficients = coefficients;
    }
 
    public double this[int n] {
        get { return _coefficients[n]; }
        set { _coefficients[n] = value; }
    }
 
    public override string ToString() {
        return "coefficients:" + string.Join(",", _coefficients);
    }
 
    public static Polynomial operator *(Polynomial first, Polynomial second) {
        int itemsCount = first._coefficients.Length + second._coefficients.Length - 1;
        var result = new double[itemsCount];
        for (int i = 0; i < first._coefficients.Length; i++) {
            for (int j = 0; j < second._coefficients.Length; j++) {
                result[i + j] += first[i] * second[j];
            }
        }
        return new Polynomial(result);
    }
       
    static void Main(string[] args)
    {
        Polynomial p1 = new Polynomial(-1, 1);
        Polynomial p2 = new Polynomial(2, 1);
        Console.WriteLine(p1 * p2);
    }
}