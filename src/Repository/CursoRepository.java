package Repository;

import Entidades.Curso;
import Entidades.CursoEstudiante;
import java.util.LinkedList;
import java.util.Queue;
import java.util.Stack;

public class CursoRepository {

    private static CursoRepository cursoRepository = null;

    private CursoRepository() {
    }

    public static CursoRepository getInstance() {
        if (cursoRepository == null) {
            cursoRepository = new CursoRepository();
        }
        return cursoRepository;
    }

    public Queue<Curso> getCursos() {
        return cursos;
    }

    public Stack<CursoEstudiante> getEstudiantes() {
        return estudiantes;
    }

    public void setEstudiantes(Stack<CursoEstudiante> estudiantes) {
        this.estudiantes = estudiantes;
    }

    public void insert(Curso curso) {
        try {
            cursos.offer(curso);
        } catch (Exception ex) {
            throw ex;
        }
    }

    public void insertEstudiante(CursoEstudiante cursoEstudiante) {
        try {
            estudiantes.push(cursoEstudiante);
        } catch (Exception ex) {
            throw ex;
        }
    }

    public Stack<CursoEstudiante> getStudentByCurso(Curso c) throws Exception {
        try {
            Stack<CursoEstudiante> stack = new Stack();

            for (CursoEstudiante ce : estudiantes) {
                if (ce.getCurso().getId() == c.getId()) {
                    stack.add(ce);
                }
            }

            if (stack.isEmpty()) {
                throw new Exception("No existen estudiantes con el curso seleccionado...!!!");
            } else {
                return stack;
            }

        } catch (Exception ex) {
            throw ex;
        }
    }

    public void deleteStudent() throws Exception {
        try {
            if (!estudiantes.isEmpty()) {
                estudiantes.pop();
            } else {
                throw new Exception("No hay estudiantes para eliminar...!!!");
            }
        } catch (Exception ex) {
            throw ex;
        }
    }

    public void deleteCurso() throws Exception {
        try {
            if (!cursos.isEmpty()) {

                boolean si = false;

                Curso c = cursos.peek();

                for (int i = 0; i < estudiantes.size(); i++) {
                    if (estudiantes.get(i).getCurso() == c) {
                        si = true;
                        break;
                    }
                }

                if (!si) {
                    estudiantes.pop();
                } else {
                    throw new Exception("Este curso tiene alumnos asoaciados...!!!");
                }
            } else {
                throw new Exception("No hay cursos para eliminar...!!!");
            }
        } catch (Exception ex) {
            throw ex;
        }
    }

    public boolean Unique(int Id) {
        try {
            if (!cursos.isEmpty()) {

                for (Curso cu : cursos) {
                    if (cu.getId() == Id) {
                        return false;
                    }
                }

            }
            return true;
        } catch (Exception ex) {
            throw ex;
        }
    }
    
    public boolean completoCupos(int Id, int maximo){
        try{
            int cantidad = 0;
            for(int i = 0; i < estudiantes.size(); i++){
                if(estudiantes.get(i).getCurso().getId() == Id){
                    cantidad++;
                }
            }
            if(cantidad == maximo){
               return false; 
            }else{
                return true;
            }
        }catch(Exception ex){
            throw ex;
        }
    }

    private Queue<Curso> cursos = new LinkedList();
    private Stack<CursoEstudiante> estudiantes = new Stack<CursoEstudiante>();

}
