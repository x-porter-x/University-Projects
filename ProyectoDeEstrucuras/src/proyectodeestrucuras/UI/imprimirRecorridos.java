package proyectodeestrucuras.UI;

import java.awt.*;//carga controles basicos de win.
import java.awt.event.*;//tiene todas clases de los eventos clasicos.
import javax.swing.*;//carga los botones. 
import java.util.ArrayList;
import proyectodeestrucuras.clases.*;
import javax.swing.JFrame;

public class imprimirRecorridos extends JFrame{
    ProyectoDeEstrucuras parent;
    
    JLabel Titulo = new JLabel("Imprmir recorridos");//es para dar intruciones o aclarar cosas
    JTextArea lblArbolImpreso = new JTextArea(20, 20);
    JButton btnImprimirEnOrden = new JButton("En Orden");//Boton para ingresar los datos del Patriarca/Matriarca
    JButton btnImprimirPostOrden = new JButton("Post Orden");//Boton para agragar matrimonio al patriarca
    JButton btnImprimirPreOrden = new JButton("Pre Orden");//Boton para agregar hijo
    public JLabel txtErrors = new JLabel("");//Label para errores 
    
    imprimirRecorridos(ProyectoDeEstrucuras parent){
        super();
        this.parent = parent;
        Container panel = new Container();
        panel = getContentPane();//pone los componentes de la pc del usuario
        panel.setLayout(new FlowLayout(FlowLayout.CENTER));
        panel.add(Titulo);//agrega el titulo al panel 
        panel.add(lblArbolImpreso);//agrega el titulo 2 al panel
        lblArbolImpreso.setEnabled(false);
        panel.add(btnImprimirEnOrden);//agrega el nombre
        panel.add(btnImprimirPostOrden);// agrega una barra para escribir
        panel.add(btnImprimirPreOrden);//agregar el sexo
        panel.add(txtErrors); //agrega el sexo
        setSize(300,500);//matriz de pixel
        setVisible(true);//para ver la ventana         
        
        btnImprimirEnOrden.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                imprimirEnOrdenButtonClick(evt);
            }
        });
        btnImprimirPreOrden.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                imprimirPreOrdenButtonClick(evt);
            }
        });
        btnImprimirPostOrden.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                imprimirPostOrdenButtonClick(evt);
            }
        });
    }
    
    private void imprimirEnOrdenButtonClick(ActionEvent evt){
        lblArbolImpreso.setText(this.parent.arbolGenealogico.getArbol().get(0).imprimirEnOrden());
    }
    private void imprimirPreOrdenButtonClick(ActionEvent evt){
        lblArbolImpreso.setText(this.parent.arbolGenealogico.getArbol().get(0).imprimirPreOrden());
    }
    private void imprimirPostOrdenButtonClick(ActionEvent evt){
        lblArbolImpreso.setText(this.parent.arbolGenealogico.getArbol().get(0).imprimirPostOrden());
    }
}
