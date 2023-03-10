using DomainModel.Entity;
using DomainModel.POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            DataTable dataTable = new DataTable();
            DataColumn id = new DataColumn();
            id.ColumnName = "Identificador";
            dataTable.Columns.Add(id);
            DataColumn nombre = new DataColumn();
            nombre.ColumnName = "Nombre";
            dataTable.Columns.Add(nombre);

            foreach (var item in BLL.Service.DepositoService.Current.GetAll())
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = item.Identificador.ToString();
                dr[1] = item.Nombre;
                dataTable.Rows.Add(dr);
            }

            foreach (var item in BLL.Service.TiendaService.Current.GetAll())
            {
                DataRow dr = dataTable.NewRow();
                dr[0] = item.Identificador.ToString();
                dr[1] = item.Nombre;
                dataTable.Rows.Add(dr);
            }

            cboDestinos.DataSource = dataTable;
            cboDestinos.ValueMember = "Identificador";
            cboDestinos.DisplayMember = "Nombre";
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Movimiento de 100 teclados entre depositos
            OperacionHistoricaCab movDep = new OperacionHistoricaCab();
            movDep.Identificador = Guid.NewGuid();
            movDep.Origen = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857700"));
            movDep.Destino = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857701"));//Deposito D2
            movDep.Fecha = DateTime.Now;
            movDep.Usuario = "Jonathan";

            OperacionHistoricaDet teclados = new OperacionHistoricaDet();
            teclados.Cantidad = 100;
            teclados.Producto = BLL.Service.ProductoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857720"));
            movDep.Movimientos.Add(teclados);

            BLL.Service.TransferenciaService.Current.Add(movDep);

            //Movimiento de 50 parlantes entre depositos
            OperacionHistoricaCab movDep2 = new OperacionHistoricaCab();
            movDep2.Identificador = Guid.NewGuid();
            movDep2.Origen = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857700"));
            movDep2.Destino = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857701"));//Deposito D2
            movDep2.Fecha = DateTime.Now;
            movDep2.Usuario = "Jonathan";

            OperacionHistoricaDet parlante = new OperacionHistoricaDet();
            parlante.Cantidad = 50;
            parlante.Producto = BLL.Service.ProductoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857726"));
            movDep2.Movimientos.Add(parlante);

            BLL.Service.TransferenciaService.Current.Add(movDep2);

            //Movimiento de 10 Impresora entre depositos
            OperacionHistoricaCab movDep3 = new OperacionHistoricaCab();
            movDep3.Identificador = Guid.NewGuid();
            movDep3.Origen = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857700"));
            movDep3.Destino = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857701"));//Deposito D2
            movDep3.Fecha = DateTime.Now;
            movDep3.Usuario = "Jonathan";

            OperacionHistoricaDet impresora = new OperacionHistoricaDet();
            impresora.Cantidad = 10;
            impresora.Producto = BLL.Service.ProductoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857724"));
            movDep3.Movimientos.Add(impresora);

            BLL.Service.TransferenciaService.Current.Add(movDep3);

            //Movimiento de 1000 NotePad entre depositos
            OperacionHistoricaCab movDep4 = new OperacionHistoricaCab();
            movDep4.Identificador = Guid.NewGuid();
            movDep4.Origen = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857700"));
            movDep4.Destino = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857701"));//Deposito D2
            movDep4.Fecha = DateTime.Now;
            movDep4.Usuario = "Jonathan";

            OperacionHistoricaDet notepad = new OperacionHistoricaDet();
            notepad.Cantidad = 1000;
            notepad.Producto = BLL.Service.ProductoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857725"));
            movDep4.Movimientos.Add(notepad);

            BLL.Service.TransferenciaService.Current.Add(movDep4);


            //Movimiento de 200 parlantes y 150 discos de un deposito a tienda
            OperacionHistoricaCab movTienda = new OperacionHistoricaCab();
            movTienda.Identificador = Guid.NewGuid();
            movTienda.Origen = BLL.Service.DepositoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857700"));
            movTienda.Destino = BLL.Service.TiendaService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857711"));//Tienda T2
            movTienda.Fecha = DateTime.Now;
            movTienda.Usuario = "Bryan";

            OperacionHistoricaDet parlantes = new OperacionHistoricaDet();
            parlantes.Cantidad = 200;
            parlantes.Producto = BLL.Service.ProductoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857726"));
            movTienda.Movimientos.Add(parlantes);

            OperacionHistoricaDet discos = new OperacionHistoricaDet();
            discos.Cantidad = 150;
            discos.Producto = BLL.Service.ProductoService.Current.GetById(new Guid("9D2B0228-4D0D-4C23-8B49-01A698857723"));
            movTienda.Movimientos.Add(discos);

            BLL.Service.TransferenciaService.Current.Add(movTienda);



        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
        
                dgvMovimientos.DataSource = BLL.Service.TransferenciaService.Current.GetByDestino(new Guid(cboDestinos.SelectedValue.ToString()));
          
        }

        private void dgvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var mov = BLL.Service.TransferenciaService.Current.GetById(new Guid(senderGrid.Rows[e.RowIndex].Cells["Identificador"].Value.ToString()));
                var listaProductos = mov.Movimientos.Select(x => "Producto: " + x.Producto.Nombre + " | Cantidad: " + x.Cantidad.ToString("N2")).ToArray();
                MessageBox.Show("Productos del movimiento " + senderGrid.Rows[e.RowIndex].Cells["Identificador"].Value.ToString() + "\n\n" + String.Join("\n", listaProductos), "LISTADO",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {

            dgv2.DataSource = BLL.Service.TransferenciaService.Current.GetMayorTresOperaciones(new Guid(cboDestinos.SelectedValue.ToString()));

            
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var mov = BLL.Service.TransferenciaService.Current.GetById(new Guid(senderGrid.Rows[e.RowIndex].Cells["Identificador2"].Value.ToString()));
                var listaProductos = mov.Movimientos.Select(x => "Producto: " + x.Producto.Nombre + " | Cantidad: " + x.Cantidad.ToString("N2")).ToArray();
                MessageBox.Show("Productos del movimiento " + senderGrid.Rows[e.RowIndex].Cells["Identificador2"].Value.ToString() + "\n\n" + String.Join("\n", listaProductos), "LISTADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
