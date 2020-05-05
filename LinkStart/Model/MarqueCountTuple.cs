namespace LinqWinformProject.LinkStart.Model
{
    public class MarqueCountTuple
    {
        public string Name { get; private set; }
        public int Marqueid { get; private set; }
        public int Count { get; private set; }

        public MarqueCountTuple(string nameConst, int marqueConst, int countConst)
        {
            Name = nameConst;
            Count = countConst;
            Marqueid = marqueConst;
        }

        public override bool Equals(object obj)
        {
            bool ret = true;
            var objCast = obj as MarqueCountTuple;
            if (objCast == null)
            {
                ret = false;
            }
            else
            {
                ret = objCast.Count == Count && objCast.Marqueid == Marqueid && objCast.Name.Equals(Name);
            }
            return ret;
        }
    }
}