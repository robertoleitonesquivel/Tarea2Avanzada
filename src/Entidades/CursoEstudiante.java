package Entidades;

import java.util.Objects;


public class CursoEstudiante {
    
    private String Nombre;
    private Curso Curso;

    public CursoEstudiante() {
    }

    public CursoEstudiante(String Nombre, Curso Curso) {
        this.Nombre = Nombre;
        this.Curso = Curso;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public Curso getCurso() {
        return Curso;
    }

    public void setCurso(Curso Curso) {
        this.Curso = Curso;
    }

    
    @Override
    public String toString() {
        return Nombre;
    }
    
    
}
