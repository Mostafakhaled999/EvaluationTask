namespace EvaluationTask.Model
{
    public class Batch
    {
        public int id { get; set; }

        public string name { get; set; }

        public int noPapers { get; set; }


        //Foreign Key
        public int envelopeId { get; set; }

        public Envelope envelope { get; set; }

    }
}
