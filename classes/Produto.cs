namespace POO_inerfaces.classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto(int codigo, string nome, float preco){

            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}