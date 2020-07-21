namespace Exercicio_1
{
    class Aluno
    {
        private string matricula;
        private string nome;
        private double[] vetornota;

        public Aluno()
        {
            vetornota = new double[4];
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public double[] Vetornota { get => vetornota; set => vetornota = value; }

        public double media
        {
            get
            {
                double soma = 0;
                foreach(double item in vetornota)
                {
                    soma += item;
                }
                return (double)soma / 4;
            }
        }
    }
}
