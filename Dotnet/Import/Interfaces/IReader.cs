// interfaccia per la lettura dei file
namespace ProgettoAmbiente.Import.Interfaces;

public interface IReader {
    List<string> ReadAsLines(FileInfo fileInfo);
    string ReadAsString(FileInfo fileInfo);
}