using System.Collections;
using LinqWinformProject.LinkStart.Presenter;

namespace LinqWinformProject.LinkStart.Model
{
    internal class FourthQuerie : IAdapterQueries
    {
        public IEnumerable PerfromQuerie()
        {
            return Queries.FourthQuery();
        }
    }
}