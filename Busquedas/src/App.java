import javax.swing.JOptionPane;

public class App {
    public static void main(String[] args) throws Exception {
        int[] arreglo = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

        String menu = ("Seleccione el tipo de búsqueda:\n1. Búsqueda Secuencial\n2. Búsqueda Binaria");
        int opcion = Integer.parseInt(JOptionPane.showInputDialog(menu));

        int dato = -1;  
        
        if (opcion == 1 || opcion == 2) {
            dato = Integer.parseInt(JOptionPane.showInputDialog("Ingrese el dato a buscar:"));
        }

        switch (opcion) {
            case 1:
                if (dato != -1) {  
                    int posicionSecuencial = BusquedaSecuencial.busquedaLineal(arreglo, dato);
                    if (posicionSecuencial != -1) {
                        JOptionPane.showMessageDialog(null, "El dato " + dato + " se encontró en la posición " + posicionSecuencial + " (Búsqueda Secuencial).");
                    } else {
                        JOptionPane.showMessageDialog(null, "El dato " + dato + " no se encontró (Búsqueda Secuencial).");
                    }
                }
                break;

            case 2:
                if (dato != -1) {  
                    int posicionBinaria = BusquedaBinaria.busquedaBinaria(arreglo, dato);
                    if (posicionBinaria != -1) {
                        JOptionPane.showMessageDialog(null, "El dato " + dato + " se encontró en la posición " + posicionBinaria + " (Búsqueda Binaria).");
                    } else {
                        JOptionPane.showMessageDialog(null, "El dato " + dato + " no se encontró (Búsqueda Binaria).");
                    }
                }
                break;

            default:
                JOptionPane.showMessageDialog(null, "Opción no válida.");
                break;
        }
    }
}
