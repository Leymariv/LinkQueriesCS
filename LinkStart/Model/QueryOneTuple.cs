namespace LinqWinformProject.LinkStart.Model
{
    public class QueryOneTuple
    {
        public QueryOneTuple(string name, int countTuples)
        {
            Name = name;
            CountTuples = countTuples;
        }

        public string Name { get; set; }
        public int CountTuples { get; set; }

        public override bool Equals(object obj)
        {
            bool ret = true;
            var objCast = obj as QueryOneTuple;
            if (objCast == null)
            {
                ret = false;
            }
            else
            {
                ret = Equals(objCast.Name, Name) && Equals(objCast.CountTuples, CountTuples);
            }
            return ret;
        }
    }
}