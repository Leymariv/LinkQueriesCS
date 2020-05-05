using System.Collections;
using LinqWinformProject.LinkStart.Presenter;

namespace LinqWinformProject.LinkStart.Model
{
    internal class SecondQuerie : IAdapterQueries
    {
        public IEnumerable PerfromQuerie()
        {
            return Queries.SecondQuery();
        }
    }
}