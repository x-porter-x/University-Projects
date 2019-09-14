package proyectodeestrucuras.UI;

import java.awt.*;//carga controles basicos de win.
import java.awt.event.*;//tiene todas clases de los eventos clasicos.
import javax.swing.*;//carga los botones. 
import java.util.ArrayList;
import proyectodeestrucuras.clases.*;

import javax.swing.JFrame;

public class agregarMatrimonio extends JFrame {
    ProyectoDeEstrucuras parent;
    
    JLabel titulo = new JLabel("Agregar un matrimonio");
    JLabel lblNombreCasado = new JLabel("Nombre de la Persona");
    JCheckBox playo = new JCheckBox();
    JLabel lblPlayo = new JLabel("Son del mismo sexo?");
    JLabel lblConyugue = new JLabel("Nombre del Conyugue");
    JTextField txtConyugue = new JTextField(20);
    JButton btnAgregarMatrimonio = new JButton("Agregar Matrimonio");
    JComboBox<String> cmbCasado = new JComboBox<>();
    JLabel errores = new JLabel("");
    
    agregarMatrimonio(ProyectoDeEstrucuras parent){
        super();
        this.parent = parent;
        Container panel = new Container();
        panel = getContentPane();//pone los componentes de la pc del usuario
        panel.setLayout(new FlowLayout());
        cargarCasados();
        panel.add(titulo);
        panel.add(lblNombreCasado);
        panel.add(cmbCasado);
        panel.add(lblPlayo);
        panel.add(playo);
        panel.add(lblConyugue);
        panel.add(txtConyugue);
        panel.add(btnAgregarMatrimonio);
        panel.add(errores);
        btnAgregarMatrimonio.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarMatrimonioButtonClick(evt);
            }
        });
        setSize(300,200);//matriz de pixel
        setVisible(true);//para ver la ventana
    }
    
    public void cargarCasados(){
        ArrayList<String> listaCasdos = this.parent.arbolGenealogico.buscarSolteros();
        for(int i=0; i<listaCasdos.size(); i++){
            this.cmbCasado.addItem(listaCasdos.get(i));
        }
        if(listaCasdos.isEmpty()){
            errores.setText("No hay solteros agregados al arbol");
            this.btnAgregarMatrimonio.setEnabled(false);
            this.txtConyugue.setEnabled(false);
            this.playo.setEnabled(false);
        }
    }
    
    private void AgregarMatrimonioButtonClick(ActionEvent evt){
        try{
            this.parent.arbolGenealogico.agregarMatrimonio(cmbCasado.getSelectedItem().toString(), txtConyugue.getText(), playo.isSelected());
            this.parent.btnAgregarMatrimonioPatriarca.setVisible(false);
            this.parent.btnAgregarHijo.setVisible(true);
            this.parent.btnAgregarMatrimonio.setVisible(true);
            this.parent.btnMatarPersona.setVisible(true);
            this.parent.btnBuscarPersonas.setVisible(true);
            this.parent.txtErrors.setText("Matrimonio Agregado con éxito");
            this.setVisible(false);            
        }
        catch(Exception e){
            errores.setText(e.getMessage());
        }
    }
    
}
