namespace EvaluationTask.Model
{
    public class Paper
    {
        public int id { get; set; }

        public string path { get; set; }

        public string name { get; set; }

        //Foreign Key
        public int batchId { get; set; }
        public Batch batch { get; set; }
    }
}
