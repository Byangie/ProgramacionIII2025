public class BusquedaSecuencial {
    public static int busquedaLineal(int[] arreglo, int dato) {
        for (int i = 0; i < arreglo.length; i++) {
            if (arreglo[i] == dato) {
                return i; 
            }
        }
        return -1; 
    }
}
