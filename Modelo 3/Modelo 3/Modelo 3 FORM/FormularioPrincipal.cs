using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_3;

namespace Modelo_3_FORM
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //AVENGERS
            Marvel.Personaje = new Avenger(new List<EHabilidades>() {EHabilidades.InteligenciaSuperior }, "Anthony Stark",EEquipamiento.Armadura);
            Marvel.Personaje = new Avenger(new List<EHabilidades>() { EHabilidades.InteligenciaSuperior }, "Anthony Stark", EEquipamiento.Armadura);
            Marvel.Personaje = new Avenger(new List<EHabilidades>() { EHabilidades.InteligenciaSuperior }, "Dr Banner", EEquipamiento.Transformacion);
            Marvel.Personaje = new Avenger(new List<EHabilidades>() { EHabilidades.InteligenciaSuperior }, "Dr Banner", EEquipamiento.Transformacion);
            Marvel.Personaje = new Avenger(new List<EHabilidades>() { EHabilidades.Sigilo, EHabilidades.Astucia }, "Natasha Romanoff", EEquipamiento.ArtesMarciales);
            Marvel.Personaje = new Avenger(new List<EHabilidades>() { EHabilidades.Rayos, EHabilidades.Volar}, "Thor", EEquipamiento.Martillo);
            Marvel.Personaje = new Avenger(new List<EHabilidades>() { EHabilidades.Rayos, EHabilidades.Volar }, "Thor", EEquipamiento.Martillo);

            //VILLANOS

            Marvel.Personaje = new Enemigo("Thanos", new List<EHabilidades>() { EHabilidades.SuperFuerza,EHabilidades.Astucia, EHabilidades.Resistencia }, "Obtener las infinitystones y un te de vainilla");
            Marvel.Personaje = new Enemigo("Ultron", new List<EHabilidades>() { EHabilidades.SuperFuerza, EHabilidades.Astucia, EHabilidades.Volar }, "Exterminar a los humanos");
            Marvel.Personaje = new Enemigo("Loki", new List<EHabilidades>() { EHabilidades.Astucia }, "Dominar los 9 reinos");
        }

        private void btnMostrarPersonajes_Click(object sender, EventArgs e)
        {
            string datos;
            datos = Marvel.MostrarInformacion();
            this.rtbPersonajes.Text = datos;
        }
    }
}
