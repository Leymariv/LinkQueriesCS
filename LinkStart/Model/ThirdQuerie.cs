using System.Collections;
using LinqWinformProject.LinkStart.Presenter;

namespace LinqWinformProject.LinkStart.Model
{
    internal class ThirdQuerie : IAdapterQueries
    {
        public IEnumerable PerfromQuerie()
        {
            return Queries.ThirdQuery();
        }
    }
}