namespace C__BootCamp_Dio;

public class Pessoa
{
    private int _idade;
    private string _nome;

    public string Nome 
    {
        get =>  $"{_nome} {SobreNome}".ToUpper();
          
        set
        {
            if(value == "")
            {
                throw new ArgumentException("Campo nome é obrigatório...");        
            }  
            _nome = value;
        }
    }
    public int Idade
    {
        get => _idade; 
        set
        {
            if(value <= 0)
            {
                throw new ArgumentException("O valor não pode ser menor ou igual a Zero...");        
            }
            _idade = value;
        }
    }
    public string SobreNome {get;set;}
    public string NomeCompleto {get => $"{Nome}";} 

    //Construtor padrão
    public Pessoa(){}
    //Contrutor com Argumentos
    public Pessoa(string nome, int idade) 
    {
        this.Nome = nome;
        this.Idade = idade;
    }
   //Método
    public void Apresentar()
    {
        Console.WriteLine($"Olá meu nome é {NomeCompleto} e minha idade é {Idade}");
    }
        
}//Fim Class
//Fim NameSpace