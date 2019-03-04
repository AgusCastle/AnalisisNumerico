public class Funcion{
    public double funciondada(double pto)
    {
        double salida;
        salida = Math.exp(pto) - (Math.pow(2,-pto)) + ((2) * Math.cos(pto)) - 6;
        //salida=Math.sin(pto)-Math.exp(-pto);
        return salida;
    }

}