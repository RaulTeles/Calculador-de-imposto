namespace AtividadeSenai
{
    using System;

    class Program{
        static void Main(string[] args){
            Pessoa_Fisica pf = new Pessoa_Fisica();

            float val_pag;
            Console.WriteLine("Informe o Nome: ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informe o Endereco: ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine ("Informe qual o tipo de Pessoa (F) Pessoa Fisica | (J) Pessoa Juridica: ");
            string var_tipo = Console.ReadLine();
        
        //    Pessoa Fisica
            if (var_tipo == "f"){
                pf.nome = var_nome;
                pf.endenreco = var_endereco;
                Console.WriteLine("Informe o CPF: ");
                string var_cpf = Console.ReadLine();
                Console.WriteLine("Informe o RG: ");
                string var_rg = Console.ReadLine();
                Console.WriteLine("Informe o Valor da Compra: ");
                // Converte os dados entrado na string para o float
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);

                Console.WriteLine("------------Pessoa Física------------");
                Console.WriteLine("\nNome..............: " + pf.nome);
                Console.WriteLine("Endereco..........: " + pf.endenreco);
                Console.WriteLine("CPF...............: " + pf.cpf);
                Console.WriteLine("RG................: " + pf.rg);
                Console.WriteLine("Valor de Compra...: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto...........: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar.....: " + pf.total.ToString("C"));
            }if(var_tipo == "j"){
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endenreco = var_endereco;
                Console.WriteLine("Informe o CNPJ: ");
                string var_cnpj = Console.ReadLine();
                Console.WriteLine("Informe o Imposto Estadual: ");
                string var_ie = Console.ReadLine();
                Console.WriteLine("Informe o Valor da Compra: ");
                // Converte os dados entrado na string para o float
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                
                
                Console.WriteLine("------------Pessoa Física------------");
                Console.WriteLine("\nNome..............: " + pj.nome);
                Console.WriteLine("Endereco..........: " + pj.endenreco);
                Console.WriteLine("CNPJ...............: " + var_cnpj);
                Console.WriteLine("IE................: " + var_ie);
                Console.WriteLine("Valor de Compra...: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto...........: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar.....: " + pj.total.ToString("C"));
            } 
        }
    }

}