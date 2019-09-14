package proyectodeestrucuras.UI;
import java.awt.*;//carga controles basicos de win.
import java.awt.event.*;//tiene todas clases de los eventos clasicos.
import javax.swing.*;//carga los botones. 
import proyectodeestrucuras.clases.*;

public class ProyectoDeEstrucuras extends JFrame {//la herencia de JFrame de swing
    
    public arbol arbolGenealogico = new arbol();
    Persona nuevaPersona;
   
    JLabel Titulo = new JLabel("Bienvenido al árbol genealógico");//es para dar intruciones o aclarar cosas
    JTextArea lblArbolImpreso = new JTextArea(20, 20);
    JButton btnAgregarPatriarca = new JButton("Agregar Patriarca");//Boton para ingresar los datos del Patriarca/Matriarca
    JButton btnAgregarMatrimonioPatriarca = new JButton("Agregar Matrimonio al Patriarca");//Boton para agragar matrimonio al patriarca
    JButton btnAgregarHijo = new JButton("Agregar Hijo");//Boton para agregar hijo
    JButton btnAgregarMatrimonio = new JButton("Agregar Matrimonio");//Boton para agregar matrimonio
    JButton btnMatarPersona = new JButton("Matar Persona");//Boton para matar persona
    JButton btnBuscarPersonas = new JButton("Buscar Personas");//Boton para buscar personas en el arbol
    JButton btnImprimirRecorridos = new JButton("Imprimir Recorridos");
    public JLabel txtErrors = new JLabel("");//Label para errores 

    ProyectoDeEstrucuras(){
        super("Arbol genealogico");//Titulo de la ventana
        Container panel = new Container();
        panel = getContentPane();//pone los componentes de la pc del usuario
        panel.setLayout(new FlowLayout());
        panel.add(Titulo);//agrega el titulo al panel 
        panel.add(lblArbolImpreso);//titulo para el formulario
        lblArbolImpreso.setEnabled(false);
        panel.add(btnAgregarPatriarca);//agrega el boton al panel
        panel.add(btnAgregarMatrimonioPatriarca);//agrega Boton al panel
        btnAgregarMatrimonioPatriarca.setVisible(false);//
        panel.add(btnAgregarHijo);//agrega Boton al panel
        btnAgregarHijo.setVisible(false);//        
        panel.add(btnAgregarMatrimonio);//agregar boton al panel
        btnAgregarMatrimonio.setVisible(false);//
        panel.add(btnMatarPersona);//agregar boton al panel
        btnMatarPersona.setVisible(false);//
        panel.add(btnBuscarPersonas);//agregar boton al panel
        btnBuscarPersonas.setVisible(false);//
        panel.add(btnImprimirRecorridos);
        btnImprimirRecorridos.setVisible(false);
        panel.add(txtErrors);//agregar texto de error
        btnAgregarPatriarca.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarPatriarcaButtonClick(evt);
            }
        });
        btnAgregarHijo.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarHijoButtonClick(evt);
            }
        });
        btnAgregarMatrimonioPatriarca.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarMatrimonioPatriarca(evt);
            }
        });
        btnAgregarMatrimonio.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                AgregarMatrimonio(evt);
            }
        });
        btnMatarPersona.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                MatarPersona(evt);
            }
        });
        btnBuscarPersonas.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                buscarPersonas(evt);
            }
        });
        btnImprimirRecorridos.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent evt){
                imprimirRecorridos(evt);
            }
        });
        setSize(300,500);//matriz de pixel
        setVisible(true);//para ver la ventana
    }
    public void agregarPatriarca(Persona nuevaPersona){//agrega patriarca al arbol como raiz 
         try{
             this.arbolGenealogico.agregarPatriarca(nuevaPersona);
             this.btnAgregarPatriarca.setVisible(false);
             this.btnAgregarMatrimonioPatriarca.setVisible(true);
             this.btnImprimirRecorridos.setVisible(true);
             txtErrors.setText("Patriarca agregado con éxito");
         }
         catch(Exception e){
             this.txtErrors.setText(e.getMessage());
         }
    }
    public void imprimirArbol(){
        this.lblArbolImpreso.setText(this.arbolGenealogico.getArbol().get(0).imprimir());
        lblArbolImpreso.setVisible(true);
    }
   
    public static void main(String[] args) {      
        ProyectoDeEstrucuras interfaz = new ProyectoDeEstrucuras();
        interfaz.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);// hacer llamada por medio de metodos y constructor
        
    }
    private void AgregarPatriarcaButtonClick(ActionEvent evt){
        nuevaPersona = new Persona();
        agregarPersonaPanel ventanaPatriarca = new agregarPersonaPanel(this, nuevaPersona);
        ventanaPatriarca.setModal(true);
        ventanaPatriarca.setVisible(true);
    }
    private void AgregarHijoButtonClick(ActionEvent evt){
        agregarHijo ventana = new agregarHijo(this);
        ventana.setVisible(true);
    }
    private void AgregarMatrimonioPatriarca(ActionEvent evt){
        agregarMatrimonio ventana = new agregarMatrimonio(this);
        ventana.setVisible(true);
    }
    private void AgregarMatrimonio(ActionEvent evt){
        agregarMatrimonio ventana = new agregarMatrimonio(this);
        ventana.setVisible(true);
    }
    private void MatarPersona(ActionEvent evt){
        matarPersona ventana = new matarPersona(this);
        ventana.setVisible(true);
    }
    private void buscarPersonas(ActionEvent evt){
        buscarPersona ventana = new buscarPersona(this);
        ventana.setVisible(true);
    }
   private void imprimirRecorridos(ActionEvent evt){
       imprimirRecorridos ventana = new imprimirRecorridos(this);
       ventana.setVisible(true);
    }
}






