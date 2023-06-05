namespace SharedEvents.Models
{
    public class AppointmentResultCreated
    {
        public Guid PatientId { get; set; }
        public string Complaints { get; set; }
        public string Conclusion { get; set; }
        public string Recomendations { get; set; }

        public AppointmentResultCreated(Guid patientId, string complaints, string conclusion, string recomendations)
        {
            PatientId = patientId;
            Complaints = complaints;
            Conclusion = conclusion;
            Recomendations = recomendations;
        }
    }
}
