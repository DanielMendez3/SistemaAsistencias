using SistemaAsistencias.BLO;
using SistemaAsistencias.Entities;
using System;
using System.Windows.Forms;

namespace SistemaAsistencias.UI
{
    public partial class AgregarCargoForm : Form
    {
        private readonly PositionBLO _positionBLO = new PositionBLO();
        public AgregarCargoForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Position position = new Position();
            position.Description = txtCargo.Text;

            if (!Helpers.IsDecimal(txtSueldoxHora.Text))
            {
                MessageBox.Show(this, "Debe ingresar un valor válido para el campo Salario por Hora", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            position.SalaryBasexHour = Convert.ToDecimal(txtSueldoxHora.Text);
            var (result, message) = _positionBLO.InsertarCargo(position);
            if (!result)
            {
                MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(this, message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
