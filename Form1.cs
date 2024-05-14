using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEtapa2Ahumada
{
    public partial class frmEtapa2 : Form
    {
        private List<clsVehiculo> vehiculos;
        private int indiceActual = 0;

        public frmEtapa2()
        {
            InitializeComponent();

            vehiculos = new List<clsVehiculo>
            {
                new clsVehiculo("Auto", "Auto", Properties.Resources.auto),
                new clsVehiculo("Barco", "Barco", Properties.Resources.barco),
                new clsVehiculo("Avion", "Avion", Properties.Resources.avion)
            };
        }

        private void MostrarSiguienteVehiculo()
        {

            indiceActual = (indiceActual + 1) % vehiculos.Count;
            clsVehiculo vehiculo = vehiculos[indiceActual];


            pctImagen.Image = vehiculo.Imagen;
            pctImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            MostrarSiguienteVehiculo();
        }
    }
}
