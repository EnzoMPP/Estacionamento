using _11;

internal class Program
{
    static void LeVeiculo(Veiculo[] carro,int ind)
    {
        Console.WriteLine("Informe a marca do veículo: ");
        carro[ind].Marca=Console.ReadLine();

        Console.WriteLine("Informe o Modelo do veículo: ");
        carro[ind].Modelo=Console.ReadLine();

        Console.WriteLine("Informe o Ano do veículo: ");
        carro[ind].Ano=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a placa do veículo: ");
        carro[ind].Placa=Console.ReadLine();
    }
    
    private static void Main(string[] args)
    {
        int opção;
        int i=0;
        Veiculo[] carros= new Veiculo[100];

        do
        {
 


        Console.WriteLine("        Menu        ");
        Console.WriteLine("1- Ler informações de um veículo");
        Console.WriteLine("2- Verificar se uma placa está no modelo correto(AAADDD)");
        Console.WriteLine("3- Imprimir por ano");
        Console.WriteLine("4- Pesquisar veículo por placa");
        Console.WriteLine("5- Imprimir todos os veículos cadastrados");

        Console.WriteLine("Escolha sua opção: ");
        opção =Convert.ToInt32(Console.ReadLine());

        if(opção==1)
        {
            carros[i]=new Veiculo();
            LeVeiculo(carros,i);
             i++;
    


        }
        else if(opção==2)
        {
            if(i>0)
            {
            int cont=1;
            int contplaca=0;
            Console.WriteLine("Informe qual veículo deseja conferir a placa: ");
            
            for(int J=0;J<i;J++)
            {
                
                
                Console.WriteLine( $"{cont++}: "+carros[J].Modelo,carros[J].Ano);

            }
            Console.WriteLine("Opçâo: ");
            int op = Convert.ToInt32(Console.ReadLine());
            for(int J=0;J<i;J++)
            {
                if(op-1==J)
                {
                    Console.WriteLine(carros[J].Placa);
                    

                }

            }
            for(int j=0;j<3;j++)
            {
                if(carros[op-1].Placa[j]>='a'&& carros[op-1].Placa[j]<='z' || carros[op-1].Placa[j]>='A' && carros[op-1].Placa[j]<='Z')
                {
                    contplaca++;
                }
                

            }
            for(int j=3;j<7;j++)
            {
                if(carros[op-1].Placa[j]>='0'&& carros[op-1].Placa[j]<='9' )
                {
                    contplaca++;
                }
            }


            if(contplaca!=7)
            {
                Console.WriteLine("Placa no formato incorreto");
                Console.WriteLine("Corrija a placa: ");
                carros[op-1].Placa=Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Placa informada corretamente");
            }
            }
            else{Console.WriteLine("Nenhum carro registrado");}
            Console.ReadKey();

        }
        else if(opção==3)
        {
            int[] crescente=new int[i];
            int aux=0;
            string stringaux;
            for(int j=0;j<i;j++)
            {
                for(int k=0;k<i;k++)
                {
                    if(carros[j].Ano<carros[k].Ano)
                    {
                        aux=carros[j].Ano;
                        carros[j].Ano=carros[k].Ano;
                        carros[k].Ano=aux;

                        stringaux=carros[j].Modelo;
                        carros[j].Modelo=carros[k].Modelo;
                        carros[k].Modelo=stringaux;
                        
                        stringaux=carros[j].Marca;
                        carros[j].Marca=carros[k].Marca;
                        carros[k].Marca=stringaux;

                        stringaux=carros[j].Placa;
                        carros[j].Placa=carros[k].Placa;
                        carros[k].Placa=stringaux;
                        

                    }
                    
                }
                

            }
            for(int j=0;j<i;j++)
            {
                Console.WriteLine($"{carros[j].Marca}      //{carros[j].Modelo}      //{carros[j].Ano}     //{carros[j].Placa}");
            }
            Console.ReadKey();
        }
        else if(opção==4)
        {
            if(i>0)
            {
            Console.WriteLine("Informe a placa do véiculo que deseja pesquisar: ");
            string pesquisa=Console.ReadLine()??"";

            for(int j=0;j<i;j++)
            {
                if(pesquisa== carros[j].Placa)
                {
                    Console.WriteLine($"A placa pertence ao carro {carros[j].Marca}  //{carros[j].Modelo}  //{carros[j].Ano}  //{carros[j].Placa}");
                }
                else{Console.WriteLine("Placa não pertence a nenhum carro registrado.");}
            }
            }
            else{Console.WriteLine("Nenhum Veículo registrado");}
            Console.ReadKey();
        }
        else if(opção==5)
        {
            for(int j=0;j<i;j++)
            {
            Console.WriteLine($"{carros[j].Marca}  //{carros[j].Modelo}  //{carros[j].Ano}  //{carros[j].Placa}");
            }
            Console.ReadKey();
        }

        }while(opção>0 && opção<=5);
        Console.WriteLine("Programa encerrado!!!");
        
    }
}