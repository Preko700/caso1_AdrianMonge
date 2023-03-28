namespace caso1_AdrianMonge.Models
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string CarreraProfesional { get; set; }
        public string CodigoAsignatura { get; set; }
        public string NombreAsignatura { get; set; }
        public decimal Creditos { get; set; }
        public string CuatrimestreAcademico { get; set; }
        public int HorasSemanales { get; set; }
        public int DuracionSemanas { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public string Docente { get; set; }
        public string Correo { get; set; }
    }

}
