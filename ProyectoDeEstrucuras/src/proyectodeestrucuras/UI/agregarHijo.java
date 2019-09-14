package proyectodeestrucuras.UI;

import java.awt.*;//carga controles basicos de win.
import java.awt.event.*;//tiene todas clases de los eventos clasicos.
import javax.swing.*;//carga los botones. 
import java.util.ArrayList;
import proyectodeestrucuras.clases.*;
import javax.swing.JFrame;

public class agregarHijo extends JFrame{
    ProyectoDeEstrucuras parent;
    
    JLabel titulo = new JLabel("Agregar Hijos al arbol");
    JLabel lblNombre = new JLabel("Nombre");
    JTextField txtNombre = new JTextField(20);
    JLabel lblPadre = new JLabel("Padre");
    JComboBox<String> cmbPadre = new JComboBox<>();
    JButton btnAgregar = new JButton("Agregar Hijo");
    JLabel Masculino = new JLabel("Masculino?");
    JCheckBox chkMasculino = new JCheckBox();
    JLabel lblHijoNatural = new JLabel("Hijo Natural?");
    JCheckBox chkNatural = new JCheckBox();
    JLabel lblFechaNacimiento = new JLabel("Fecha de naciemiento");
    JTextField txtFechaNacimiento = new JTextField(20);
    
    JLabel errores = new JLabel("");
    
    agregarHijo(ProyectoDeEstrucuras parent){
        super();
        this.parent = parent;
        Container panel = new Container();
        panel = getContentPane();//pone los componentes de la pc del usuario
        panel.setLayout(new FlowLayout());
        cargarPadres();
        panel.add(titulo);
        panel.add(lblNombre);
        panel.add(txtNombre);
        panel.add(lblPadre);
        panel.add(cmbPadre);
        panel.add(Masculino);
        panel.add(chkMasculino);
        panel.add(lblHijoNatural);
        panel.add(chkNatural);
        panel.add(lblFechaNacimiento);
        panel.add(txtFechaNacimiento);
        panel.add(btnAgregar);
        panel.add(errores);
        cambiarPadre();
        btnAgregar.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarButtonClick(evt);
            }
        });
        cmbPadre.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent evt){
                cambiarPadre();
            }
        });
        setSize(300,250);//matriz de pixel
        setVisible(true);//para ver la ventana
    }
    
    public void cargarPadres(){
        ArrayList<String> listaPadres = this.parent.arbolGenealogico.buscarPadres();
        for(int i=0; i<listaPadres.size(); i++){
            this.cmbPadre.addItem(listaPadres.get(i));
        }
        if(listaPadres.isEmpty()){
            errores.setText("No hay posibles padres agregados al arbol");
            this.btnAgregar.setEnabled(false);
            this.cmbPadre.setEnabled(false);
            this.txtNombre.setEnabled(false);
            this.chkMasculino.setEnabled(false);
            this.chkNatural.setEnabled(false);
        }
    }
    private void AgregarButtonClick(ActionEvent evt){
        try{
            Persona hijo = new Persona(txtNombre.getText(), chkMasculino.isSelected(), txtFechaNacimiento.getText(), chkNatural.isSelected());
            this.parent.arbolGenealogico.agregarHijo(cmbPadre.getSelectedItem().toString(), hijo);
            this.parent.txtErrors.setText("Hijo agregado con éxito");
            this.parent.imprimirArbol();
            this.setVisible(false);            
        }
        catch(Exception e){
            errores.setText(e.getMessage());
        }
    }
    private void cambiarPadre(){
        if(!this.parent.arbolGenealogico.buscarPersona(this.cmbPadre.getSelectedItem().toString()).puedeNatural()){
            this.chkNatural.setEnabled(false);
            this.chkNatural.setSelected(false);
            errores.setText("Matrimonio no permite hijos naturales");
        }
        else{
            this.chkNatural.setEnabled(true);
            errores.setText("");
        }
    }
}
