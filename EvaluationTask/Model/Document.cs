namespace EvaluationTask.Model
{
    public class Document
    {
        public int id { get; set; }

        public string name { get; set; }


        //Foreign Key
        public int paperId { get; set; }
        public Paper paper { get; set; }
    }
}
