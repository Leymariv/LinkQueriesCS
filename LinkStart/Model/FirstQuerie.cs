using System.Collections;
using LinqWinformProject.LinkStart.Presenter;

namespace LinqWinformProject.LinkStart.Model
{
    internal class FirstQuerie : IAdapterQueries
    {
        public IEnumerable PerfromQuerie()
        {
            return Queries.FirstQuery();
        }
    }
}