package proyectodeestrucuras.UI;
import java.awt.*;//carga controles basicos de win.
import java.awt.event.*;//tiene todas clases de los eventos clasicos.
import javax.swing.*;//carga los botones. 
import proyectodeestrucuras.clases.Persona;

public class agregarPersonaPanel extends JDialog {
    ProyectoDeEstrucuras parent;
    
    JLabel Titulo = new JLabel("Agregar una nueva");//es para dar intruciones o aclarar cosas
    JLabel Titulo2 = new JLabel("persona al árbol                 ");
    JLabel Nombre = new JLabel("Nombre");//ingresar el Nombre
    JLabel FechaDeNacimiento = new JLabel("Fecha de nacimiento");//ingrese fecha de nacimiento
    JLabel lblSexo = new JLabel("Masculino?"); //ingresa el sexo
    JCheckBox chkSexo = new JCheckBox();//ingresar el sexo    
    JTextField txtNombre = new JTextField(15);//espacio para escribir o ingresar datos
    JTextField txtFechaNacimiento = new JTextField(15);//espacio para escribir o ingresar datos
    JButton btnAgregarPersona = new JButton("Agregar Persona");//Boton para ingresar los datos del Patriarca/Matriarca
    
    agregarPersonaPanel(ProyectoDeEstrucuras parent, Persona nuevaPersona){//agrega persona nueva al panel
        super();
        this.parent = parent;
        Container panel = new Container();
        panel = getContentPane();//pone los componentes de la pc del usuario
        panel.setLayout(new FlowLayout(FlowLayout.CENTER));
        panel.add(Titulo);//agrega el titulo al panel 
        panel.add(Titulo2);//agrega el titulo 2 al panel
        panel.add(Nombre);//agrega el nombre
        panel.add(txtNombre);// agrega una barra para escribir
        panel.add(lblSexo);//agregar el sexo
        panel.add(chkSexo); //agrega el sexo
        panel.add(FechaDeNacimiento);//agrega fecha de nacimiento
        panel.add(txtFechaNacimiento);//agrega una barra para escribir
        panel.add(btnAgregarPersona);//agrega el boon al panel
        setSize(200,500);//matriz de pixel
        setVisible(true);//para ver la ventana 
        
        
        btnAgregarPersona.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarPersonaClickEvent(evt);
            }
        });
    }
    
    private void AgregarPersonaClickEvent(ActionEvent evt){
        boolean sexo = chkSexo.isSelected();
        String nombre = txtNombre.getText();
        String fechaNacimiento = txtFechaNacimiento.getText();
        Persona nuevaPersona;
        nuevaPersona = new Persona(nombre, sexo, fechaNacimiento, 0);
        this.parent.agregarPatriarca(nuevaPersona);
        this.parent.imprimirArbol();
        this.setVisible(false);
    }
  
}
