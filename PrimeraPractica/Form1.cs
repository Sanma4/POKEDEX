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
                pbxPokemon.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
            }
        }
    }
}
