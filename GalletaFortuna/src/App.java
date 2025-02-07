import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;
import java.util.Random;

public class App {
    private static ArrayList<String> list = new ArrayList<>();

    public static void main(String[] args) {
        // Lista de frases
        list.add("Cree en ti mismo y todo será posible.");
        list.add("El éxito empieza con el primer paso.");
        list.add("No sueñes con el éxito, trabaja por él.");
        list.add("Tu único límite eres tú mismo.");
        list.add("El fracaso es parte del camino al éxito.");

        // Configuración del JFrame
        JFrame frame = new JFrame("Galleta de la fortuna");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(500, 500);

        // Usar GridBagLayout para centrar el botón
        frame.setLayout(new GridBagLayout());
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.gridx = 0;
        gbc.gridy = 0;
        gbc.anchor = GridBagConstraints.CENTER;
        gbc.insets = new Insets(10, 10, 10, 10);

        // Crear botón
        JButton button = new JButton("Galleta de la fortuna");
        button.setPreferredSize(new Dimension(200, 50));
        frame.add(button, gbc);

        // Crear área de texto
        JTextArea text = new JTextArea(2, 20);
        text.setEditable(false);
        text.setLineWrap(true);
        text.setWrapStyleWord(true);
        text.setFont(new Font("Arial", Font.PLAIN, 16));
        text.setMargin(new Insets(10, 10, 10, 10));

        // Envolver el área de texto en un JScrollPane
        JScrollPane scrollPane = new JScrollPane(text);
        gbc.gridy = 1;
        frame.add(scrollPane, gbc);

        // Acción del botón
        button.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Random random = new Random();
                int index = random.nextInt(list.size());
                String message = list.get(index);
                text.setText(message);
            }
        });

        // Mostrar ventana
        frame.setVisible(true);
    }
}
