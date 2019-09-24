package colas1;
import java.awt.*; 
import java.awt.event.*;
import javax.swing.*;

public class Colas1 extends JFrame {
        long monedas_de_5 = 0;
        long monedas_de_10 = 0;
        long monedas_de_25 = 0;
        long monedas_de_50 = 0;
        long monedas_de_100 = 0;
        long monedas_de_500 = 0;
        long total = 0;
    String m5 = "";
    String m10 = "";
    String m25 = "";
    String m50 = "";
    String m100 = "";
    String m500 = "";
    JTextArea Totales = new JTextArea(6,30);
    JButton Botton1 = new JButton("+5");
    JButton Botton2 = new JButton("+10");
    JButton Botton3 = new JButton("+25");
    JButton Botton4 = new JButton("+50");
    JButton Botton5 = new JButton("+100");
    JButton Botton6 = new JButton("+500");
    JButton Botton7 = new JButton("Mostrar cantidad total");
    JButton Botton8 = new JButton("-5");
    JButton Botton9 = new JButton("-10");
    JButton Botton10 = new JButton("-25");
    JButton Botton11 = new JButton("-50");
    JButton Botton12 = new JButton("-100");
    JButton Botton13 = new JButton("-500");
    JLabel Label1 = new JLabel("");
    
    Colas1 (){
    super ("Contador de Monedas");
    Container contenedor = new Container();
    contenedor = getContentPane();
    contenedor.setLayout(new FlowLayout());
    contenedor.add(Label1);
    contenedor.add(Totales);
    Totales.setEnabled(false);
    Botton1.addActionListener(new Manejador());  
    contenedor.add(Botton1);
    Botton2.addActionListener(new Manejador());
    contenedor.add(Botton2);
    Botton3.addActionListener(new Manejador());
    contenedor.add(Botton3);
    Botton4.addActionListener(new Manejador());
    contenedor.add(Botton4);
    Botton5.addActionListener(new Manejador());
    contenedor.add(Botton5);
    Botton6.addActionListener(new Manejador());
    contenedor.add(Botton6);
    Botton8.addActionListener(new Manejador());
    contenedor.add(Botton8);
    Botton9.addActionListener(new Manejador());
    contenedor.add(Botton9);
    Botton10.addActionListener(new Manejador());
    contenedor.add(Botton10);
    Botton11.addActionListener(new Manejador());
    contenedor.add(Botton11);
    Botton12.addActionListener(new Manejador());
    contenedor.add(Botton12);
    Botton13.addActionListener(new Manejador());
    contenedor.add(Botton13);
    Botton7.addActionListener(new Manejador());
    contenedor.add(Botton7);
    setSize (350,280);
    setVisible(true);
    }
    
    public static void main(String[] args) {
       Colas1 aplicacion = new Colas1();
        aplicacion.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    
    class Manejador implements ActionListener {
        boolean estado = false;
        public void actionPerformed(ActionEvent e) {  
            if (e.getSource() == Botton1)    
           {
               
           monedas_de_5 = monedas_de_5 + 5;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
            
           }else  if (e.getSource() == Botton2) 
           {
               
           monedas_de_10 = monedas_de_10 + 10;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
           
           }else if (e.getSource() == Botton3) 
           {
               
           monedas_de_25 = monedas_de_25 + 25;     
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
           
           }else if (e.getSource() == Botton4)
           {
               
           monedas_de_50 = monedas_de_50 + 50;     
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
           
           }else if (e.getSource() == Botton5)
           {
               
           monedas_de_100 = monedas_de_100 + 100;   
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
           
           } else if (e.getSource() == Botton6) 
           {
               
           monedas_de_500 = monedas_de_500 + 500;     
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
           
           }else if (e.getSource() == Botton7) 
           {
             total = total + monedas_de_5 + monedas_de_10 + monedas_de_25 + monedas_de_50 + monedas_de_100 + monedas_de_500; 
           JOptionPane.showMessageDialog(null,"Total de dinero en monedas: "+ "\n" + total + "₡");
         monedas_de_5 = 0;
         monedas_de_10 = 0;
         monedas_de_25 = 0;
         monedas_de_50 = 0;
         monedas_de_100 = 0;
         monedas_de_500 = 0;
         total = 0;
         Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
           }else if (e.getSource() == Botton8)
           {
           monedas_de_5 = monedas_de_5 - 5;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
               
           }else if (e.getSource() == Botton9)
           {
           monedas_de_10 = monedas_de_10 - 10;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
               
           }else if (e.getSource() == Botton10)
           {
           monedas_de_25 = monedas_de_25 - 25;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
               
           }else if (e.getSource() == Botton11)
           {
           monedas_de_50 = monedas_de_50 - 50;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
               
           }else if (e.getSource() == Botton12)
           {
           monedas_de_100 = monedas_de_100 - 100;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
               
           }else if (e.getSource() == Botton13)
           {
           monedas_de_500 = monedas_de_500 - 500;
           Totales.setText("Total de 5: "+ monedas_de_5 + "₡" + "\n" + "Total de 10: " + monedas_de_10 + "₡" + "\n" + "Total de 25: " + monedas_de_25 + "₡" + "\n" + "Total de 50: " + monedas_de_50 + "₡" + "\n" + "Total de 100: " + monedas_de_100 + "₡" + "\n" + "Total de 500: " + monedas_de_500 + "₡" );
               
           }
        }
    }
}