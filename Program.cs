int menu;
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador(); 
menu = cargarMenu("Eligue una opcion");
while(menu>0 && menu<5){
switch(menu)
{
    case 1:
    boxeador1 = cargarBoxeador();
    break;

    case 2:
    boxeador2 = cargarBoxeador();
    break;

    case 3:
    pelear();
    break;
}

menu = cargarMenu("Eligue una opcion");
}

void pelear()
{
    if(boxeador1.Nombre=="" || boxeador2.Nombre=="")
    {
    Console.WriteLine("No has ingresado a los dos boxeadores, ingresalos para poder continuar");
    }else{
        ganador();
    }
}
void ganador()
{
double diferencia;
string ganadornom ="";
if(boxeador1.ObtenerSkill()>=boxeador2.ObtenerSkill())
{
    ganadornom = boxeador1.Nombre;
Console.WriteLine("El ganador es el boxeador " + boxeador1.Nombre);
diferencia=(boxeador1.ObtenerSkill()-boxeador2.ObtenerSkill());
}else{
    ganadornom=boxeador2.Nombre;
diferencia=(boxeador2.ObtenerSkill()-boxeador1.ObtenerSkill());
}
if(diferencia >=30)
{
Console.WriteLine("El ganador es el boxeador " + ganadornom + " por KO");
}else if(diferencia>= 10)
{
Console.WriteLine("El ganador es el boxeador " + ganadornom + " por puntos en unanime");
}else
{
Console.WriteLine("El ganador es el boxeador " + ganadornom + " por puntos en fallo dividido");
}
}

int cargarMenu(string mensaje)
{
    int opcion;
    Console.WriteLine(mensaje);
    Console.WriteLine("1- Cargar Datos Boxeador 1");
    Console.WriteLine("2- Cargar Datos Boxeador 2");
    Console.WriteLine("3- Pelear");
    Console.WriteLine("4- Salir");
    opcion=int.Parse(Console.ReadLine());
    return opcion; 
}
double ingresarPeso(String mensaje)
{
    double num;
    Console.WriteLine(mensaje);
    num=double.Parse(Console.ReadLine());
    return num;

}
int ingresarInt(string mensaje)
{
    int num;
    Console.WriteLine(mensaje);
    num=int.Parse(Console.ReadLine());
    while(num<0 || num>100)
    {
        Console.WriteLine("El numero debe estar entre 0 y 100, ingresalo de nuevo");
        num=int.Parse(Console.ReadLine());
    }
    return num;
}
string ingresarTexto(string mensaje)
{
    string palabra;
    Console.WriteLine(mensaje);
    palabra=Console.ReadLine();
    return palabra;
}

Boxeador cargarBoxeador()
{
    string nom, pais;
    int pg,vp;
    double peso;
    nom = ingresarTexto("Ingrese el nombre del Boxeador");
    pais = ingresarTexto("Ingrese el pais donde nacio");
    peso = ingresarPeso("Ingrese el peso del boxeador");
    pg= ingresarInt("Ingrese la potencia en golpes del boxeador");
    vp= ingresarInt("Ingrese la velocidad en piernas del boxeador");
    Boxeador unBoxeador = new Boxeador(nom, pais, peso, pg, vp);
    Console.WriteLine("Se ha creado el boxeador "+ nom);
    return unBoxeador;
}
