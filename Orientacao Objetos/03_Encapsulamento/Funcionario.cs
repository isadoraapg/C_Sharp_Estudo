namespace RH
{
    public class Funcionario
    {
        public string Nome;
        //private string CPF;

        private string cpf;

        //encapsula o atributo cpf e controla o acesso a ele, gerenciando a forma como a informação é retornada/lida
        public string CPF
        {
            get
            {
                return cpf.Replace(".", "").Replace("-", "");
            }
            set
            {
                if (value.Length == 0)
                    return;
                cpf = value;
            }

        }

        public Funcionario(string nome, string _cpf)
        {
            Nome = nome;
            cpf = _cpf;
        }
        // public string GetCPF()
        // {
        //     return CPF;
        // }

        // public void SetCPF(string cpf)
        // {
        //     if (cpf.Length == 0)
        //         return;

        //     CPF = cpf;
        // }

    }
}