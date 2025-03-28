// classe di gestione di files
namespace ProgettoAmbiente.Import.Utilities;

public class FileUtility : IReader, IWriter, IBase {
    

    public List<string> ReadAsLines(FileInfo fileInfo) {
        
        CheckFileInfo(["FileUtility", "ReadAsLines"],fileInfo);

        var contet = File.ReadAllLines(fileInfo.FullName).ToList();
        return contet;
    }

    

    public string ReadAsString(FileInfo fileInfo) {

        CheckFileInfo(["FileUtility","ReadAsString"],fileInfo);

        var contet = File.ReadAllText(fileInfo.FullName);
        return contet;
    }

    public string SetDebug() {
        throw new NotImplementedException();
    }

    public void WriteAll() {
        throw new NotImplementedException();
    }

    void CheckFileInfo(string[] param, FileInfo fileInfo) {
        if (fileInfo == null)
            throw new PersonalizedException([$"{param[0]}", $"{param[1]}"], ExceptionCode.E0001, "File");
        if (!File.Exists(fileInfo.FullName))
            throw new PersonalizedException([$"{param[0]}", $"{param[1]}"], ExceptionCode.E0002, $"{fileInfo.Name}");
    }
}