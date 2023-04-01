namespace EvaluationTask.Model
{
    public class Envelope
    {
        public int id { get; set; }

        public string name { get; set; }

        public int code { get; set; }

        public int nobatches { get; set; }

        public string date { get; set; }


        //Foreign Key
        public int boxId  { get; set; }
        public  Box box { get; set; }
    }
}
