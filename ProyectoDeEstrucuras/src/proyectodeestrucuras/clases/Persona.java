package proyectodeestrucuras.clases;

public class Persona { //Atributos

    private String nombre;
    private boolean masculino; 
    private int hijos = 0;
    private boolean vivo = true;
    private EC estadoCivil;
    private boolean natural; 
    private String fechaNacimiento;
    private String fechaDefuncion;
    private Persona hijo1 = null;
    private Persona hijo2 = null;
    private int peso;
    
    public Persona(String nombre, boolean masculino, int hijos, boolean vivo, EC.tipo tipoEC, String conyuge, boolean playo , boolean natural, String fechaNacimiento, String fechaDefuncion){
        this.nombre = nombre; //Metodo para validar persona
        this.masculino = masculino;
        this.hijos = hijos;
        this.vivo = vivo;
        this.estadoCivil = new EC(playo, tipoEC, conyuge);
        this.natural = natural;
        this.fechaNacimiento = fechaNacimiento;
        this.fechaDefuncion = fechaDefuncion;
    }
    public Persona(String nombre, boolean sexo, String fechaNacimiento, int peso){ //Metodo para validar informacion de la persona
        this.nombre = nombre;
        this.masculino = sexo;
        this.fechaNacimiento = fechaNacimiento;
        this.estadoCivil = new EC(EC.tipo.soltero);
        this.peso = peso;
    }
    public Persona(String nombre, boolean sexo, String fechaNacimiento, boolean natural){ //Metodo para validar informacion de la persona
        this.nombre = nombre;
        this.masculino = sexo;
        this.fechaNacimiento = fechaNacimiento;
        this.natural = natural;
        this.estadoCivil = new EC(EC.tipo.soltero);
    }
    public Persona(){ //Metodo para agregar una persona 
        this.nombre = null;
        this.masculino = true;
        this.hijos = 0;
        this.vivo = true;
        this.estadoCivil = new EC(EC.tipo.soltero);
        this.natural = true;
        this.fechaDefuncion = null;
        this.fechaNacimiento = null;
    }   
    
    public String getNombre(){ //Metodo para obtener el nombre
        return this.nombre;
    }
    public boolean puedeTenerHijos(){ //Metodo para conteo de hijos
        return this.hijos < 2 && this.estadoCivil.isCasado();
    }
    public void casar (String conyuge, boolean playo) throws Exception{
        if (!estadoCivil.isCasado()){
            this.estadoCivil.setConyuge(conyuge);
            this.estadoCivil.setTipo(EC.tipo.casado);
            this.estadoCivil.setPlayo(playo);
        }else{
            throw new Exception("Persona ya se ecuentra casada");
        }
    }    
    public void matar(String fechaDefuncion) throws Exception{ //Metodo para matar
        if (fechaDefuncion != null){
            this.fechaDefuncion = fechaDefuncion;
            this.vivo = false;
        }else{
            throw new Exception("Persona ya se encuentra muerta");
        }
    } 
    public void enviudar() throws Exception{ //Metodo para Enviudar
        if(this.estadoCivil.getTipo() == EC.tipo.casado)
            this.estadoCivil.setTipo(EC.tipo.viudo);
        else
            throw new Exception("No se encuentra casado");
    }
    public void agregarHijo (Persona hijo) throws Exception{ //Metodo para Agregar Hijo
        if(puedeTenerHijos()){
            if((this.estadoCivil.isPlayo() && !hijo.natural) || (!this.estadoCivil.isPlayo()) ) {
                if(hijos == 0){
                    hijo.setPeso(this.peso + 1);
                    this.hijo1 = hijo;
                }
                else{
                    hijo.setPeso(this.peso + 1);
                    this.hijo2 = hijo;
                }
                this.hijos++;
            }else{
                throw new Exception("Padre no cumple con las reglas");
            }
        }else{
            throw new Exception("Persona tiene dos hijos, no puede tener mas hijos");
        }
    }
    public boolean isCasado(){
        return this.estadoCivil.isCasado();
    }
    public boolean isVivo(){
        return this.vivo;
    }
    public boolean puedeNatural(){
        return !this.estadoCivil.isPlayo();
    }
    
    public boolean isMasculino(){
        return this.masculino;
    }
    public int getHijos(){
        return this.hijos;
    }
    public EC getEstadoCivil(){
        return this.estadoCivil;
    }
    public boolean isNatural(){
        return this.natural;
    }
    public String getFechaNacimiento(){
        return this.fechaNacimiento;
    }
    public String getFechaDefuncion(){
        return this.fechaDefuncion;
    }
    public Persona getHijo1(){
        return this.hijo1;
    }
    public Persona getHijo2(){
        return this.hijo2;
    }
    public void setPeso(int peso){
        this.peso = peso;
    }
    
    public String imprimir(String prefix, boolean isFirst){
        return (prefix + (isFirst ?"├── " : "└── ") + nombre);
    }
    
    public String imprimir(){
        String imprimir = "";
        for(int i= 0; i < this.peso * 5; i++){
            imprimir += " ";
        }
        imprimir += "└──" + this.nombre + "\n";
        if(hijo1 != null){
            imprimir += hijo1.imprimir();
        }
        if(hijo2 != null){
            imprimir += hijo2.imprimir();
        }        
        return imprimir;
    }
    
    public String imprimirPreOrden(){
        String imprimir = this.nombre + "\n";
        if(hijo1 != null)
            imprimir += hijo1.imprimirPreOrden();
        if(hijo2 != null)
            imprimir += hijo2.imprimirPreOrden();
        return imprimir;
    }
    
    public String imprimirEnOrden(){
        String imprimir = "";
        if(hijo1 != null)
            imprimir += hijo1.imprimirEnOrden();
        imprimir += this.nombre + "\n";
        if(hijo2 != null)
            imprimir += hijo2.imprimirEnOrden();        
        return imprimir;
    }
    
    public String imprimirPostOrden(){
        String imprimir = "";
        if(hijo1 != null)
            imprimir += hijo1.imprimirPostOrden();        
        if(hijo2 != null)
            imprimir += hijo2.imprimirPostOrden();
        imprimir += this.nombre + "\n";
        return imprimir;
    }
    

}

