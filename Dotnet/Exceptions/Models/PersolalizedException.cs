// classe per gestire l'eccezione se il file type non è corretto
using System.ComponentModel;
using System.Reflection;
using ProgettoAmbiente.Exceptions.Exstensions;

namespace ProgettoAmbiente.Exceptions.Models;

public class PersonalizedException : System.Exception {

    // costruttore
    public PersonalizedException (string[] classDefine, ExceptionCode code, string? param = null) : base(
        $"[{String.Join("::", classDefine)}]: ({code}); ({(param == null ? "N/A" : param)}): {code.GetDescription()}"
    ) { }
}