namespace LinqWinformProject.LinkStart.Model
{
    public class QueryFiveTuple
    {
        public int Marqueid { get; private set; }
        public string Name { get; private set; }
        public double TotventesMarques { get; private set; }

        public QueryFiveTuple(int identifier, string name, double totSales)
        {
            TotventesMarques = totSales;
            Name = name;
            Marqueid = identifier;
        }

        public override bool Equals(object obj)
        {
            bool ret = true;
            var objCast = obj as QueryFiveTuple;
            if (objCast == null)
            {
                ret = false;
            }
            else
            {
                ret = Equals(objCast.Name, Name) && Equals(objCast.Marqueid, Marqueid) &&
                      Equals(objCast.TotventesMarques, TotventesMarques);
            }
            return ret;
        }
    }
}