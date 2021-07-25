using SistemaAsistencias.BLO;
using SistemaAsistencias.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaAsistencias.UI
{
    public partial class PersonalControlFm : UserControl
    {
        private PersonalBLO _personalBLO = new PersonalBLO();
        private readonly PositionBLO _positionBLO = new PositionBLO();
        private Employee _employee = new Employee();
        ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();
        private DataGridViewCellEventArgs mouseLocation;

        public PersonalControlFm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.dataGridViewBasic.Visible = false;
            this.pnlAgregarPersonal.Visible = true;
            LoadPositions();
        }

        private void LoadPositions()
        {
            this.cbCargo.DataSource = null;
            this.cbCargo.DataSource = _positionBLO.GetPositions();
            this.cbCargo.DisplayMember = "Description";
            this.cbCargo.ValueMember = "PositionID";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Employee employe = new Employee();
            employe.Name = txtName.Text;
            employe.Identificator = txtIdentifier.Text;
            employe.Position.PositionID = (int)cbCargo.SelectedValue;
            employe.Country = (string)cbPais.SelectedItem;

            if (!Helpers.IsDecimal(txtSueldoxHora.Text))
            {
                MessageBox.Show(this, "Debe ingresar un valor válido para el campo Salario por Hora",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            employe.SalaryxHour = Convert.ToDecimal(txtSueldoxHora.Text);

            var (isSuccess, message) = _personalBLO.InsertarPersonal(employe);

            if (isSuccess)
            {
                MessageBox.Show(this, message, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridViewBasic.Visible = true;
                this.pnlAgregarPersonal.Visible = false;
                LoadEmployees();
                return;
            }

            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PersonalControl_Load(object sender, EventArgs e)
        {
            //Mandamos a llamar la funcion para obtener a los empleados
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            this.dataGridViewBasic.Rows.Clear();
            var employees = _personalBLO.MostrarPersonal();
            foreach (var item in employees)
            {
                this.dataGridViewBasic.Rows.Add(item.EmployeeID, item.Name, item.Identificator, item.Country, item.Position.Description,
                                                item.SalaryxHour, item.Status.Description);
            }
        }

        private void toolStripItem1_Click(object sender, EventArgs args)
        {
            dataGridViewBasic.Rows[mouseLocation.RowIndex]
                .Cells[mouseLocation.ColumnIndex].Style.BackColor
                = Color.Red;
        }

        private void AddContextMenu()
        {
            toolStripItem1.Text = "Redden";
            toolStripItem1.Click += new EventHandler(toolStripItem1_Click);
            ContextMenuStrip strip = new ContextMenuStrip();
            foreach (DataGridViewColumn column in dataGridViewBasic.Columns)
            {

                column.ContextMenuStrip = strip;
                column.ContextMenuStrip.Items.Add(toolStripItem1);
            }
        }

        private void dataGridViewBasic_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            mouseLocation = e;
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            AgregarCargoForm _agregarCargoForm = new AgregarCargoForm();
            _agregarCargoForm.ShowDialog();
            LoadPositions();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.dataGridViewBasic.Visible = true;
            this.pnlAgregarPersonal.Visible = false;
        }
    }
}
