namespace LinqWinformProject.LinkStart.Model
{
    public class QueryFourTuple
    {
        public int YearDate { get; private set; }
        public double TotalSales { get; private set; }
        public int CouleurId { get; private set; }
        public string CouleurName { get; private set; }

        public QueryFourTuple(int yearDate, double totalSales, int colId, string colName)
        {
            YearDate = yearDate;
            TotalSales = totalSales;
            CouleurId = colId;
            CouleurName = colName;
        }

        public override bool Equals(object obj)
        {
            bool ret = true;
            var objCast = obj as QueryFourTuple;
            if (objCast == null)
            {
                ret = false;
            }
            else
            {
                ret = Equals(objCast.YearDate, YearDate) && Equals(objCast.CouleurId, CouleurId) &&
                      Equals(objCast.CouleurName, CouleurName);
                ret = ret && Equals(objCast.TotalSales, TotalSales);
            }
            return ret;
        }
    }
}