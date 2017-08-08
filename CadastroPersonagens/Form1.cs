using System;
using Newtonsoft.Json;
using ManipuladorArquivo;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPersonagens
{

    public partial class formCadastro : Form
    {
        private const string CAMINHO = @"C:\Users\netorobe\Documents\Projeto Curso C#\";
        private const string EXTENSAO = ".json";

        public formCadastro()
        {
            InitializeComponent();
        }
        

        private Personagem getPersonagem(){

            Personagem pers = new Personagem();
            pers.Nome = txtNome.Text;
            pers.Arma = txtArma.Text;
            pers.Tipo = txtTipo.Text;
            pers.Ataque = Int32.Parse(txtAtaque.Text);
            pers.Defesa = Int32.Parse(txtDefesa.Text);
            pers.caminhoImagem = picImagem.ImageLocation;

            return pers;
        }

        private void LimpaTela() {
            txtNome.Text = "";
            txtArma.Text = "";
            txtTipo.Text = "";
            txtAtaque.Text = "";
            txtDefesa.Text = "";
            lbID.Text = "";
            picImagem.Image = null;
        }

        //Botoes
        private void btNovo_Click(object sender, EventArgs e)
        {
            //Resgata Personagem
            Personagem pers = getPersonagem();

            //Cria novo ID
            pers.ID = Guid.NewGuid();

            //Serializa JSON
            var jsonPersonagem = JsonConvert.SerializeObject(pers);

            //Grava em diretorio
            Arquivo.CriaArquivo(CAMINHO, pers.ID.ToString(), EXTENSAO ,jsonPersonagem);

            //Limpa Tela
            LimpaTela();

            //Limpa Lista
            listCadastrados.Items.Clear();

            //Atualiza Lista
            CarregarPersonagens(CAMINHO);

           
            
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (listCadastrados.SelectedItem == null)
            {
                MessageBox.Show("Nenhum personagem selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var pers = (Personagem)listCadastrados.SelectedItem;
                if (Arquivo.DeletaArquivo(CAMINHO + pers.ID + EXTENSAO))
                {
                    if (MessageBox.Show("Deseja excluir o personagem selecionado?",
                        "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("Personagem excluído com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o personagem selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            listCadastrados.Items.Clear();
            CarregarPersonagens(CAMINHO);
            LimpaTela();

        }

        private void formCadastro_Load(object sender, EventArgs e)
        {
            CarregarPersonagens(CAMINHO);
        }

        private Personagem JSONtoPersonagem(string arquivo) {
            var arquivoLido = Arquivo.LerArquivo(arquivo);
            return JsonConvert.DeserializeObject<Personagem>(arquivoLido);
        }

        private void CarregarPersonagens(string caminho)
        {
            //Carrega arquivos
            var arquivos = Arquivo.CarregarArquivos(caminho);

            var personagens = new List<Personagem>();

            foreach (var arquivo in arquivos) {
                Personagem pers = JSONtoPersonagem(arquivo);
                listCadastrados.Items.Add(pers);
            }
        }

        private void DesativarItens() {
            txtNome.Enabled = false;
            txtTipo.Enabled = false;
            txtArma.Enabled = false;
            txtAtaque.Enabled = false;
            txtDefesa.Enabled = false;
        }

        private void AtivarItens()
        {
            txtNome.Enabled = true;
            txtTipo.Enabled = true;
            txtArma.Enabled = true;
            txtAtaque.Enabled = true;
            txtDefesa.Enabled = true;
            btNovo.Enabled = true;
        }

        private void PopulaTela(Personagem pers) {
            txtNome.Text = pers.Nome;
            txtTipo.Text = pers.Tipo;
            txtArma.Text = pers.Arma;
            txtAtaque.Text = pers.Ataque.ToString();
            txtDefesa.Text = pers.Defesa.ToString();
            lbID.Text =  pers.ID.ToString();
            picImagem.ImageLocation = pers.caminhoImagem;
        }

       


        private void listCadastrados_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Pegar Personagem a partir de Arquivo Selecionado
            var persSelecionado = (Personagem)listCadastrados.SelectedItem;            

            //Popular tela
            PopulaTela(persSelecionado);

            //Dar disabled
            DesativarItens();

            //Nao permitir clicar em novo
            btNovo.Enabled = false;

        }

        private void btResetar_Click_1(object sender, EventArgs e)
        {
            AtivarItens();
            LimpaTela();
        }

        private void btCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if(file.ShowDialog() == DialogResult.OK){
                picImagem.ImageLocation = file.FileName;
            }
        }
    }    
}
