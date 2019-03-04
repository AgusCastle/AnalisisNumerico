public class Derivada{
    public double derivadita(double pto){
    double salida;
    salida = (Math.exp(pto)) + ((Math.log(2))*(Math.pow(2,-pto)))-((2)*(Math.sin(pto)));
    //salida=Math.cos(pto)+Math.exp(-pto);
    return salida;
    }
}