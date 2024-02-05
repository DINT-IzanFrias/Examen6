using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

class Deseo : ObservableObject
{
    // ------------------------------------------------------------
	// Termina de definir las propiedades con el fin de implementar
	// ObservableObject.
	// ------------------------------------------------------------
	
	private string tipo;

    public string Tipo { 
        get { return tipo; }
        set { SetProperty(ref tipo, value); }
    }

    private string titulo;

    public string Titulo
    {
        get { return titulo; }
        set { SetProperty(ref titulo, value); }
    }

    private string imagen;

    public string Imagen
    {
        get { return imagen; }
        set { SetProperty(ref imagen, value); }
    }

    private int prioridad;

    public int Prioridad
    {
        get { return prioridad; }
        set { SetProperty(ref prioridad, value); }
    }

    public Deseo(string tipo, string titulo, string imagen, int prioridad)
    {
        this.Tipo = tipo;
        this.Titulo = titulo;
        this.Imagen = imagen;
        this.Prioridad = prioridad;
    }
}

