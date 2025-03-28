// classe modello del file di input
namespace ProgettoAmbiente.Import.Models;

public class CSV : BaseFile  {

    List<string>? _lines { get; set; }

    // costruttore
    public CSV () {
        _lines = new();
    }
}