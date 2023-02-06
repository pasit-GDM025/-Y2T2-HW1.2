using System;
class Program{
    static void Main(string[]args){
        double CX, CY, PX, PY, NLoop;
        
        Console.WriteLine("Rup Kar:");
        CX = double.Parse(Console.ReadLine());
        CY = double.Parse(Console.ReadLine());
        PX = double.Parse(Console.ReadLine());
        PY = double.Parse(Console.ReadLine());
        NLoop = double.Parse(Console.ReadLine());

        double TheTa = Math.Atan((PY-CY)/(PX-CX));
        double Radius = Math.Sqrt(Math.Pow((PY-CY),2)+Math.Pow((PX-CX),2));

        double CheckCX = 0, CheckCY = 0;
        for(int i = 1; i<=NLoop; i++){
            CheckCX = CX;
            CheckCY = CY;
            CX = CX + (Radius/(2*NLoop))*Math.Cos(Radius+((Math.PI/2)*NLoop));
            CY = CY + (Radius/(2*NLoop))*Math.Sin(Radius+((Math.PI/2)*NLoop));
            PX = CheckCX + (Radius/(Math.Pow(2,NLoop-1)))*Math.Cos(Radius+((Math.PI/2)*NLoop));
            PY = CheckCY + (Radius/(Math.Pow(2,NLoop-1)))*Math.Sin(Radius+((Math.PI/2)*NLoop));
        }
        Console.WriteLine("C0X:{0} \n C0Y:{1}\n P0X:{2}\n P0Y:{3}\n", CX, CY, PX, PY);
    }
    
}
