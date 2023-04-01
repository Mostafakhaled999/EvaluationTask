namespace EvaluationTask.Model
{
    public class Box
    {
        public int id { get; set; }

        public string name { get; set; }

        public string? fromDate { get; set; }

        public string? toDate { get; set; }

        public int? noEnvelope { get; set; }

        //Foreign Key
        public int shipmentId { get; set; }
        public Shipment shipment { get; set; }
    }
}
