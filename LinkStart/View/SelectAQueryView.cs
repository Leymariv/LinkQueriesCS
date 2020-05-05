using System;
using System.Windows.Forms;
using LinqWinformProject.LinkStart.Presenter;

namespace LinqWinformProject.LinkStart.View
{
    public partial class SelectAQueryView : UserControl
    {
        private readonly LinqQueriesPresenter presenter;

        public SelectAQueryView()
        {
            InitializeComponent();
            presenter = LinqQueriesPresenter.Instance;
            presenter.InputView = this;
        }

        private void QueriesComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            presenter.DisplayQuery(queriesComboBox.SelectedIndex);
        }
    }
}