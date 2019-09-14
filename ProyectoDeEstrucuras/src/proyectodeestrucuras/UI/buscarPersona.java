package proyectodeestrucuras.UI;
import java.awt.*;//carga controles basicos de win.
import java.awt.event.*;//tiene todas clases de los eventos clasicos.
import javax.swing.*;//carga los botones. 
import java.util.ArrayList;
import proyectodeestrucuras.clases.*;
import javax.swing.JFrame;

public class buscarPersona extends JFrame {//herencia de JFrame
    ProyectoDeEstrucuras parent;
    
    JLabel titulo = new JLabel("Buscar personas");//titulo para buscar personas
    JLabel lblNombre = new JLabel("Nombre");//Nombre
    JComboBox<String> cmbPersonas = new JComboBox<>();//combo box 
    
    JLabel sexo = new JLabel("Sexo: ");//muestra el sexo
    JLabel hijos = new JLabel("Cantidad de hijos: ");// muentra la cantidad de hijos
    JLabel vivo = new JLabel("Vivo: ");//muestra si esta vivo
    JLabel estadoCivil = new JLabel("Estado Civil: ");//muestra el estado civil
    JLabel conyugue = new JLabel("Nombre del Conyugue: ");//muestra el matrimonio
    JLabel natural = new JLabel("Hijo Natural: ");// muentras los hijos naturales o adoptados
    JLabel fechaNacimiento = new JLabel("Fecha de Nacimiento: ");//muestra la decha de nacimiento
    JLabel fechaDefuncion = new JLabel("Fecha de Defuncion: ");  //muestra la fecha de funcion
    
    JLabel hijo1 = new JLabel("Nombre de Hijo: ");//nombre del primer hijo
    JLabel hijo2 = new JLabel("Nombre de Hijo: ");//nombre del segundo hijo
    
    buscarPersona(ProyectoDeEstrucuras parent){// agrega la ventana para buscar persona 
        super();
        this.parent = parent;
        Container panel = new Container();
        panel = getContentPane();//pone los componentes de la pc del usuario
        panel.setLayout(new FlowLayout());
        cargarPersonas();
        buscarPersona();
        panel.add(titulo);
        panel.add(lblNombre);
        panel.add(cmbPersonas);
        panel.add(sexo);
        panel.add(hijos);
        panel.add(vivo);
        panel.add(estadoCivil);
        panel.add(conyugue);
        panel.add(natural);
        panel.add(fechaNacimiento);
        panel.add(fechaDefuncion);
        panel.add(hijo1);
        panel.add(hijo2);        
        cmbPersonas.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent evt){
                buscarPersona();
            }
        });
        setSize(300,250);//matriz de pixel
        setVisible(true);//para ver la ventana
    }
    
    public void cargarPersonas(){//metodo para agregar personas al combobox
        for(int i=0; i<this.parent.arbolGenealogico.getArbol().size(); i++){
            this.cmbPersonas.addItem(this.parent.arbolGenealogico.getArbol().get(i).getNombre());
        }
    }
    public void buscarPersona(){//Metodo para buscar la informacion de persona en el arbol
        Persona persona = this.parent.arbolGenealogico.buscarPersona(cmbPersonas.getSelectedItem().toString());
        if(persona.isMasculino())        
            sexo.setText("Sexo: Masculino");
        else
            sexo.setText("Sexo: Femenino");
        hijos.setText("Hijos: " + persona.getHijos());
        if(persona.isVivo()){
            vivo.setText("Vivo: si");
            fechaDefuncion.setVisible(false);
        }
        else{
            vivo.setText("Vivo: no");
            fechaDefuncion.setText("Fecha de defuncion: " + persona.getFechaDefuncion());
            fechaDefuncion.setVisible(true);
        }
        estadoCivil.setText("Estado Civil: " + persona.getEstadoCivil().getTipo());
        if(persona.isCasado()){
            conyugue.setText("Nombre del conyugue: " + persona.getEstadoCivil().getConyuge());
            conyugue.setVisible(true);
        }
        else
            conyugue.setVisible(false);
        if(persona.isNatural())
            natural.setText("Natural: si");
        else
            natural.setText("Natual: no, hijo adoptado");
        fechaNacimiento.setText("Fecha de Nacimiento: " + persona.getFechaNacimiento());
        if(persona.getHijo1() != null){
            hijo1.setText("Nombre de Hijo: " + persona.getHijo1().getNombre());
            hijo1.setVisible(true);
        }
        else
            hijo1.setVisible(false);
        if(persona.getHijo2() != null){
            hijo2.setText("Nombre de Hijo: " + persona.getHijo2().getNombre());
            hijo2.setVisible(true);
        }
        else{
            hijo2.setVisible(false);
        }
    }
    
}
