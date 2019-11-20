using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exeption
{
    public partial class FrmExeption : Form
    {
        public FrmExeption()
        {
            InitializeComponent();
        }

        private void CmdMio_Click(object sender, EventArgs e)
        {
            
            
                if (txtMatricula.Text == "")
                {
                errorProvider1.SetError(txtMatricula, "No ha ingresado Matricula");
                }
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ha ingresado Nombre");
            }
            if (txtSemestre.Text == "")
            {
                errorProvider1.SetError(txtSemestre, "No ha ingresado semestre");
            }
            if (txtCarrera.Text == "")
            {
                errorProvider1.SetError(txtCarrera, "No ha ingresado Carrera");
            }
            if (txtTelefono.Text == "")
            {
                errorProvider1.SetError(txtTelefono, "No ha ingresado Telefono");
            }


            try
            {
                Alumno alumno = new Alumno();
                alumno.Matricula = Convert.ToInt32(txtMatricula.Text);
                alumno.Nombre = txtNombre.Text;
                alumno.Semestre = Convert.ToInt32(txtSemestre.Text);
                alumno.Carrera = txtCarrera.Text;
                alumno.Telefono = Convert.ToInt32(txtTelefono.Text);

            }

            finally
            {

            }
            try
            {
                throw new EspecialExeption
                    ("Se crea exitosamente");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error al registrar esto");
            }

            catch (EspecialExeption expex)
            {
                MessageBox.Show(expex.Message);
            }

            finally
            {
                errorProvider1.Clear();
            }


        }

       

        private void CmdAceptar_Click(object sender, EventArgs e)
        {

        }

        private void TxtCali_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int cal = Convert.ToInt32(txtCali.Text);
                if (cal < 1 || cal > 10) ;
                MessageBox.Show("Ingrese las calificaciones del 1 AL 10", "ERROR");

            }

            catch (Exception EX)
            {
                MessageBox.Show("Introdusca los numeros correctos", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error);


            }
        }
    }
}
