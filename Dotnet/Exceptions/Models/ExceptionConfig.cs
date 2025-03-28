// Enum dei codici delle eccezioni
using System.ComponentModel;

namespace ProgettoAmbiente.Exceptions.Models;

public enum ExceptionCode {

    [Description("FileInfo is Null")]
    E0001, 
    [Description("File Not Exists")]
    E0002


}