package Presentacion;

import Entidades.Curso;
import Entidades.CursoEstudiante;
import Repository.CursoRepository;
import java.util.Queue;
import javax.swing.JOptionPane;

public class frmEstudiantes extends javax.swing.JFrame {

    private CursoRepository cursoRepository = null;
    int maximo = 0;

    public frmEstudiantes() {
        initComponents();
        this.cursoRepository = CursoRepository.getInstance();
        Queue<Curso> list = cursoRepository.getCursos();

        for (Curso c : list) {
            this.txtCurso.addItem(c);
        }

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        txtCurso = new javax.swing.JComboBox<>();
        txtNombre = new javax.swing.JTextField();
        btnGuardar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        txtCurso.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                txtCursoActionPerformed(evt);
            }
        });

        btnGuardar.setText("GUARDAR");
        btnGuardar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGuardarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(txtCurso, javax.swing.GroupLayout.Alignment.TRAILING, 0, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(txtNombre, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 192, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(btnGuardar, javax.swing.GroupLayout.DEFAULT_SIZE, 194, Short.MAX_VALUE))
                .addContainerGap(36, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addGap(0, 17, Short.MAX_VALUE)
                .addComponent(txtNombre, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtCurso, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnGuardar)
                .addGap(23, 23, 23))
        );

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 10, 240, 120));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnGuardarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGuardarActionPerformed
        try {
            if (!this.txtNombre.getText().equals("") && this.txtCurso.getSelectedItem() != null) {

                Curso cur = (Curso) this.txtCurso.getSelectedItem();

                if (maximo < cur.getCantidadMaximaEstudiantes()) {

                    CursoEstudiante estudiante = new CursoEstudiante();
                    estudiante.setNombre(this.txtNombre.getText());
                    estudiante.setCurso((Curso) this.txtCurso.getSelectedItem());

                    this.cursoRepository.insertEstudiante(estudiante);

                    JOptionPane.showMessageDialog(this, "Insertado con exito..!!!");

                    maximo++;

                } else {
                    JOptionPane.showMessageDialog(this, "No se permite agregar mas estudiantes a este curso..!!!");
                }

            } else {
                JOptionPane.showMessageDialog(this, "Todos los datos son requeridos..!!!");
            }
        } catch (Exception ex) {
            JOptionPane.showMessageDialog(this, ex.getMessage());
        }
    }//GEN-LAST:event_btnGuardarActionPerformed

    private void txtCursoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_txtCursoActionPerformed
        if (maximo > 0) {
            Curso cur = (Curso) this.txtCurso.getSelectedItem();

            if (this.cursoRepository.completoCupos(cur.getId(), maximo)) {
                maximo = 1;
            } else {
                JOptionPane.showMessageDialog(this, "Los cupos  para el curso " + cur.getNombre() + " estan llenos ..!!!");
            }
        }
    }//GEN-LAST:event_txtCursoActionPerformed

    public static void main(String args[]) {

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new frmEstudiantes().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnGuardar;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JComboBox<Curso> txtCurso;
    private javax.swing.JTextField txtNombre;
    // End of variables declaration//GEN-END:variables
}
