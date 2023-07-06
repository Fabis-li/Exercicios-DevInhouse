
namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnSalvarDados_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string curso = txtCurso.Text;
            string escolaridade = txtEscolaridade.Text;
            DateTime dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
            decimal valorCurso = Convert.ToDecimal(txtValorCurso.Text);
            decimal valorDesconto = Convert.ToDecimal(txtValorDesconto.Text);
            decimal valorMulta = Convert.ToDecimal(txtValorMulta.Text);         
            


           FichaInscricao ficha = new FichaInscricao(nome, curso, escolaridade, dataNascimento, valorCurso, valorDesconto, valorMulta);

            int idade = ficha.CalcularIdade();
            string idadeString = idade.ToString();
            txtIdade.Text = idadeString;

            if (valorDesconto == 0)
            {
                FormatacaoTexto.Formatacao(nome, curso, valorCurso);
            }
            else if (valorDesconto > 0 && idade < 18)
            {
                FormatacaoTexto.Formatacao(nome, curso, valorCurso, valorDesconto, idade);
            }
            else if (valorDesconto > 0)
            {
                FormatacaoTexto.Formatacao(nome, curso, valorCurso, valorDesconto);
            }
          
            List<CursoSelecionado> lista = new List<CursoSelecionado>();

            string cursos = lista.
            


            
            

        }

        
    }
} 