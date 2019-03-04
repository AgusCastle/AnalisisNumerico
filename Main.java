import java.util.Scanner;
public class Main{
    public static void main(String[] args){
    Scanner Entradas=new Scanner(System.in);  
    Funcion f = new Funcion();
    Derivada df = new Derivada();
    double Punto, tol, fp, dfp, aux;
    int Contador, Iteracion;
    System.out.println("Dame el punto de inicio: ");
    Punto = Entradas.nextDouble();
    System.out.println("Dame la tolerancia:  ");
    tol = Entradas.nextDouble();
    System.out.println("Cuantas veces repetiremos el proceso:  ");
    Iteracion = Entradas.nextInt();
    Contador = 1;
    do{
            fp = f.funciondada(Punto);
            dfp = df.derivadita(Punto);
            aux = Punto;
            Punto = Punto-(fp/dfp);
            Contador++;
        }while((Math.abs(fp) > tol) && (Contador <= Iteracion));
    if(Math.abs(fp) < tol)
        {
            System.out.println("El punto esta en:  "+ aux);
            System.out.println("El valor de la funcion es:  " +fp);
            System.out.println("Se usaron "+ Contador +" iteraciones");
        }
    if (Contador > Iteracion)
        {
            System.out.println("Faltaron mas iteraciones para encontrar el punto");
        }
    System.out.println("Si salio ;)");
    }
}
