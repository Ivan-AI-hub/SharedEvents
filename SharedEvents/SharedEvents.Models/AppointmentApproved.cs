namespace SharedEvents.Models
{
    public class AppointmentApproved
    {
        public Guid PatientId { get; set; }
        public string PatientFullName { get; set; }
        public string DoctorFullName { get; set; }
        public DateTime Date { get; set; }
        public string ServiceName { get; set; }

        public AppointmentApproved(Guid patientId, string patientFullName, string doctorFullName, DateTime date, string serviceName)
        {
            PatientId = patientId;
            PatientFullName = patientFullName;
            DoctorFullName = doctorFullName;
            Date = date;
            ServiceName = serviceName;
        }
    }
}
