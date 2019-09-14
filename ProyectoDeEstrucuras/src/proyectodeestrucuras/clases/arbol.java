package proyectodeestrucuras.clases;

import java.util.ArrayList;
import java.util.List;

public class arbol { // se crea una lista para el arbol
    List<Persona> arbol;
    
    public arbol(){
        this.arbol = new ArrayList<>();
    }
    public void agregarPatriarca(Persona nuevaPersona) throws Exception{ //Metodo para agregar al patriarca
        arbol.add(nuevaPersona);
    }    
    public void matarPersona(String nombre, String fechaDefuncion) throws Exception{ //Metodo para matar persona en el arbol
        Persona matar = buscarPersona(nombre);
        if (matar != null){
            matar.matar(fechaDefuncion);
        }else{
            throw new Exception("persona no se encuentra agregada al árbol");
        }
    }    
    public void agregarMatrimonio(String nombre, String conyugue, boolean playo) throws Exception{ //Metodo para casara a una persona
        Persona matrimonio = buscarPersona(nombre);
        if (matrimonio != null){
            matrimonio.casar(conyugue, playo);
        }
        else
            throw new Exception("Persona no se encuentra en el árbol");
    }    
    public void agregarViudo(String nombre) throws Exception{ //Metodo para dejar viudo a una persona
        Persona viudo = buscarPersona(nombre);
        if(viudo != null){
            viudo.enviudar();
        }
        else
            throw new Exception("Persona no se encuentra agregada al árbol");
    }
    public Persona buscarPersona(String nombre){ //Metodo para buscar una persona
        for(int i =0; i<arbol.size(); i++){
            if (arbol.get(i).getNombre().equals(nombre))
                return arbol.get(i);
        }
        return null;
    }
    public void agregarHijo(String nombrePadre, Persona hijo) throws Exception{ //Metodo para agregar Hijo
        Persona padre = buscarPersona(nombrePadre);
        if (padre != null){
            padre.agregarHijo(hijo);
            arbol.add(hijo);
        }
        else{
            throw new Exception("No existe el padre");
        }
    }
    
    public ArrayList<String> buscarSolteros(){//Busca los solteros en el arbol
        ArrayList<String> listaCasados = new ArrayList<>();
        for (int i = 0; i<arbol.size(); i++){
            if(!arbol.get(i).isCasado())
                listaCasados.add(arbol.get(i).getNombre());
        }        
        return listaCasados;
    }
    public ArrayList<String> buscarVivos(){//Busca los vivos en el arbol
        ArrayList<String> listaCasados = new ArrayList<>();
        for (int i = 0; i<arbol.size(); i++){
            if(arbol.get(i).isVivo())
                listaCasados.add(arbol.get(i).getNombre());
        }        
        return listaCasados;
    }
    public ArrayList<String> buscarPadres(){//Busca los padres en el arbol
        ArrayList<String> listaPadres = new ArrayList<>();
        for (int i = 0; i<arbol.size(); i++){
            if(arbol.get(i).puedeTenerHijos())
                listaPadres.add(arbol.get(i).getNombre());
        }        
        return listaPadres;
    }
    public List<Persona> getArbol(){
        return this.arbol;
    }
    
    public String imprimir() {//realiza la imprecion
        return imprimir("", true);
    }
    
    private String imprimir(String prefix, boolean isTail) { //realiza la impresion
        String imprimir = "";
        for (int i = 0; i < arbol.size(); i++) {
            imprimir += arbol.get(i).imprimir(prefix + (isTail ? "    " : "│   "), false);
        }
        if (arbol.size() > 0) {
            arbol.get(arbol.size() - 1)
                    .imprimir(prefix + (isTail ? "    " : "│   "), true);
        }
        return imprimir;
    }
    
    public String imprimirs(){
        String impreso = "";
        
        
        return impreso;
    }
}
