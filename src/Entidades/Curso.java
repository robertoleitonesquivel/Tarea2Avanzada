package Entidades;


public class Curso {
    
    private int Id;
    private String Nombre;
    private String Modalidad;
    private int CantidadMaximaEstudiantes;

    public Curso() {
    }

    
    public Curso(int Id, String Nombre, String Modalidad, int CantidadMaximaEstudiantes) {
        this.Id = Id;
        this.Nombre = Nombre;
        this.Modalidad = Modalidad;
        this.CantidadMaximaEstudiantes = CantidadMaximaEstudiantes;
    }
    

    public int getId() {
        return Id;
    }

    public void setId(int Id) {
        this.Id = Id;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getModalidad() {
        return Modalidad;
    }

    public void setModalidad(String Modalidad) {
        this.Modalidad = Modalidad;
    }

    public int getCantidadMaximaEstudiantes() {
        return CantidadMaximaEstudiantes;
    }

    public void setCantidadMaximaEstudiantes(int CantidadMaximaEstudiantes) {
        this.CantidadMaximaEstudiantes = CantidadMaximaEstudiantes;
    }

    @Override
    public String toString() {
        return Id+" - "+Nombre;
    }
    
    
}
