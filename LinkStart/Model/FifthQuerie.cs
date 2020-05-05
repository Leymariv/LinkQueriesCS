using System.Collections;
using LinqWinformProject.LinkStart.Presenter;

namespace LinqWinformProject.LinkStart.Model
{
    internal class FifthQuerie : IAdapterQueries
    {
        public IEnumerable PerfromQuerie()
        {
            return Queries.FifthQuery();
        }
    }
}