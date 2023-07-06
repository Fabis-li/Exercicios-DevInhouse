namespace exercicio
{
    public class Empregado
    {      

        public int id { get; set; }
        public string nome { get; set; }

        public Empregado()
        {            
        }

        public Empregado(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public void Trabalhar()
        {
            Console.WriteLine("Trabalhando");
        }

        public void IrEmbora()
        {
            Console.WriteLine("Ir para casa!");
        }

        public void TirarFolga()
        {
            Console.WriteLine("Tomar uma no bar!");
        }

        
    }
}