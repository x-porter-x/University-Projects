package proyectodeestrucuras.clases;

public class EC {
    public enum tipo{
        casado, soltero, viudo
    }
    
    private boolean playo;
    private tipo tipo;
    private String conyuge;
    
    public EC(tipo tipo){
        this.tipo = tipo;
        this.playo = false;
        this.conyuge = null;
    }
    public EC(boolean playo, tipo tipo, String conyuge){
        this.playo = playo;
        this.tipo = tipo;
        this.conyuge = conyuge;
    }
    
    public tipo getTipo(){
        return this.tipo;
    }
    
    public void setTipo(tipo tipo){
        this.tipo = tipo;
    }
    
    public boolean isPlayo() {
        return playo;
    }

    public void setPlayo(boolean playo) {
        this.playo = playo;
    }

    public String getConyuge() {
        return conyuge;
    }

    public void setConyuge(String conyuge) {
        this.conyuge = conyuge;
    }
    
    public boolean isCasado(){
        return this.tipo == tipo.casado;
    } 
    
    
    
}
