public class BusquedaBinaria {
    public static int busquedaBinaria(int[] arreglo, int dato) {
        int inicio = 0;
        int mitad;
        int fin = arreglo.length - 1;

        while (inicio <= fin) {
            mitad = (inicio + fin) / 2;
            if (arreglo[mitad] == dato) {
                return mitad; 
            } else if (dato < arreglo[mitad]) {
                fin = mitad - 1;
            } else {
                inicio = mitad + 1;
            }
        }
        return -1; 
    }
}
