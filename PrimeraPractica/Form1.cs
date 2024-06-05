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
        private List<Pokemon> pokemonLista;
        public POKEDEX()
        {
            InitializeComponent();
        }

        private void POKEDEX_Load(object sender, EventArgs e)
        {
            PokemonDataBase dataBase = new PokemonDataBase();
            pokemonLista = dataBase.listar();
            dgvPokemons.DataSource = pokemonLista;
            dgvPokemons.Columns["UrlImagen"].Visible = false;
            cargarImagen(pokemonLista[0].UrlImagen);
        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selecionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(selecionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPokemon.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPokemon.Load("https://t4.ftcdn.net/jpg/05/17/53/57/360_F_517535712_q7f9QC9X6TQxWi6xYZZbMmw5cnLMr279.jpg");
            }
        }


    }
}
