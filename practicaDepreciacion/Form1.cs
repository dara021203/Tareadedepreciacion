using AppCore.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaDepreciacion
{
    public partial class Form1 : Form
    {
        IActivoServices activoServices;
        private int idelegido;
        public Form1(IActivoServices ActivoServices)
        {
            this.activoServices = ActivoServices;
            InitializeComponent();
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El tipo de dato ingresado no es correcto");
            }
        }



        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El tipo de dato ingresado no es correcto");
            }
        }

        private void txtValorR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El tipo de dato ingresado no es correcto");
            }
        }

        private void txtVidaU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("El tipo de dato ingresado no es correcto");
            }
        }

        private void txtEnviar_Click(object sender, EventArgs e)
        {
            bool verificado = verificar();
            if (verificado == false)
            {
                MessageBox.Show("Asegurese de ingresar toda la informacion correspondiente");
            }
            else
            {

                Activo activo = new Activo()
                {
                    Nombre = txtNombre.Text,
                    Valor = double.Parse(txtValor.Text),
                    ValorResidual = double.Parse(txtValorR.Text),
                    VidaUtil = int.Parse(txtVidaU.Text)
                };
                activoServices.Add(activo);
                dataGridView1.DataSource = null;
                limpiar();
                dataGridView1.DataSource = activoServices.Read();

            }
        }
        private bool verificar()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtValor.Text) || String.IsNullOrEmpty(txtVidaU.Text) || String.IsNullOrEmpty(txtValorR.Text))
            {

                return false;
            }
            return true;
        }
        private void limpiar()
        {
            this.txtNombre.Text = String.Empty;
            this.txtValor.Text = String.Empty;
            this.txtValorR.Text = String.Empty;
            this.txtVidaU.Text = String.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = activoServices.Read();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idelegido = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FrmDepreciacion deprec = new FrmDepreciacion(activoServices.Read()[e.RowIndex]);
                deprec.ShowDialog();
            }
        }

    


        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (idelegido != 0)
            {
                Activo activo = activoServices.GetById(idelegido);
                if (activoServices.Delete(activo))
                {

                    dataGridView1.DataSource = null;

                    dataGridView1.DataSource = activoServices.Read();
                }
                else
                {
                    MessageBox.Show("Algo salio mal y no se borro");
                }
            }
          
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == false)
            {
                MessageBox.Show("Seleccione uno de los activos que ingreso");
                return;
            }

            // Implementando el update en el FrmActualizar
            FrmActualizar frmActualizar = new FrmActualizar();
            frmActualizar.activoServices = activoServices;
            frmActualizar.Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frmActualizar.txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frmActualizar.nudValor.Value = decimal.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            frmActualizar.nudValorResidual.Value = decimal.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            frmActualizar.nudVidaUtil.Value = decimal.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            frmActualizar.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = activoServices.Read();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
