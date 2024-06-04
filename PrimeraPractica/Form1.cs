using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraPractica
{
    public partial class POKEDEX : Form
    {
        public POKEDEX()
        {
            InitializeComponent();
        }

        private void POKEDEX_Load(object sender, EventArgs e)
        {
            PokemonDataBase dataBase = new PokemonDataBase();
            dgvPokemons.DataSource = dataBase.listar();
        }
    }
}
