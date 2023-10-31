namespace C__BootCamp_Dio;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    //Criando o metodo para adiconar os alunos na Lista
    public void AdcionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }
}
