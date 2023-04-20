class Boxeador
{
public string Nombre{get;set;}
public string Pais{get;set;}
public double Peso{get;set;}
public int PotenciaGolpes{get;set;}
public int VelocidadPiernas{get;set;}


public Boxeador(string nom="", string pais="", double peso=0, int pg=0, int vp=0)
{
Nombre=nom;
Pais=pais;
Peso=peso;
PotenciaGolpes=pg;
VelocidadPiernas=vp;
}


public double ObtenerSkill()
{
    double resultado;
    Random num= new Random();
    double numero= num.Next(1,10);
    resultado=VelocidadPiernas*0.6 + PotenciaGolpes*0.8 + numero;
    return resultado;
}
}

