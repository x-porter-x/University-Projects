package proyectodeestrucuras.UI;

import java.awt.*;//carga controles basicos de win.
import java.awt.event.*;//tiene todas clases de los eventos clasicos.
import javax.swing.*;//carga los botones. 
import java.util.ArrayList;
import proyectodeestrucuras.clases.*;
import javax.swing.JFrame;

public class matarPersona extends JFrame{
    ProyectoDeEstrucuras parent;
    
    JLabel titulo = new JLabel("Matar Personas del Arbol");// titulo
    JLabel lblNombre = new JLabel("Nombre"); //nombre
    JComboBox<String> cmbPersonas = new JComboBox<>();//agrega el combo box
    JButton btnMatar = new JButton("Matar Persona");//boton para matar
    JLabel lblFechaDefuncion = new JLabel("Fecha de defunción");//agrega fecha de defuncion
    JTextField txtFechaDefuncion = new JTextField(20);//espacio en blanco para escribir fecha
    
    JLabel errores = new JLabel("");//para mostrar errores
    
    matarPersona(ProyectoDeEstrucuras parent){// ventana para matar persona
        super();
        this.parent = parent;
        Container panel = new Container();
        panel = getContentPane();//pone los componentes de la pc del usuario
        panel.setLayout(new FlowLayout());
        cargarVivos();
        panel.add(titulo);
        panel.add(lblNombre);
        panel.add(cmbPersonas);
        panel.add(lblFechaDefuncion);
        panel.add(txtFechaDefuncion);
        panel.add(btnMatar);
        panel.add(errores);
        panel.add(errores);
        btnMatar.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarMatarButtonClick(evt);
            }
        });
        setSize(300,200);//matriz de pixel
        setVisible(true);//para ver la ventana
    }
    
    public void cargarVivos(){//metodo para agregar personas vivas al arbol
        ArrayList<String> listaVivos = this.parent.arbolGenealogico.buscarVivos();
        for(int i=0; i<listaVivos.size(); i++){
            this.cmbPersonas.addItem(listaVivos.get(i));
        }
        if(listaVivos.isEmpty()){
            errores.setText("No hay personas vivas agregadas al arbol");
            this.btnMatar.setEnabled(false);
            this.cmbPersonas.setEnabled(false);
            this.txtFechaDefuncion.setEnabled(false);
        }
    }
    private void AgregarMatarButtonClick(ActionEvent evt){//agrega la accion del boton
        try{
            this.parent.arbolGenealogico.matarPersona(cmbPersonas.getSelectedItem().toString(), txtFechaDefuncion.getText());            
            this.parent.txtErrors.setText("Persona matada con éxito");
            this.setVisible(false);            
        }
        catch(Exception e){
            errores.setText(e.getMessage());
        }
    }
}
