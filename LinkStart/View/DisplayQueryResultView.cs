using System.Collections;
using System.Windows.Forms;
using LinqWinformProject.LinkStart.Presenter;

namespace LinqWinformProject.LinkStart.View
{
    public partial class DisplayQueryResultView : UserControl
    {
        private readonly LinqQueriesPresenter presenter;

        public DisplayQueryResultView()
        {
            InitializeComponent();
            presenter = LinqQueriesPresenter.Instance;
            presenter.ResultView = this;
            presenter.OnModification += RefreshResult;
        }

        private void ReturnPreviousMenuClick(object sender, System.EventArgs e)
        {
            presenter.SwitchToSelectQueryView();
        }

        private void RefreshResult()
        {
            IEnumerable requestedQuerie = presenter.HandleQueries();
            FillData(requestedQuerie);
        }

        public void FillData(IEnumerable list)
        {
            dataGridView.DataSource = list;
        }
    }
}