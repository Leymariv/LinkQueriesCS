using System;
using System.Collections;
using System.Collections.Generic;
using LinqWinformProject.LinkStart.Model;
using LinqWinformProject.LinkStart.View;

namespace LinqWinformProject.LinkStart.Presenter
{
    public class LinqQueriesPresenter
    {
        private IAdapterQueries adaptor;
        private readonly Dictionary<int, IAdapterQueries> dicoAdapterQueries;

        public SelectAQueryView InputView { get; set; }
        public DisplayQueryResultView ResultView { get; set; }
        public event Action OnModification = delegate { };

        private LinqQueriesPresenter()
        {
            IndexComboBox = 0;
            int indexDico = 0;
            dicoAdapterQueries = new Dictionary<int, IAdapterQueries>
                                 {
                                     {
                                         indexDico++, new FirstQuerie()
                                     },
                                     {
                                         indexDico++, new SecondQuerie()
                                     },
                                     {
                                         indexDico++, new ThirdQuerie()
                                     },
                                     {
                                         indexDico++, new FourthQuerie()
                                     },
                                     {
                                         indexDico, new FifthQuerie()
                                     }
                                 };
        }

        private static readonly LinqQueriesPresenter instance = new LinqQueriesPresenter();

        public static LinqQueriesPresenter Instance
        {
            get { return instance; }
        }

        public int IndexComboBox { get; set; }

        public void SwitchToSelectQueryView()
        {
            InvertViews();
            OnModification();
        }

        private void InvertViews()
        {
            bool currentView = InputView.Visible;
            InputView.Visible = !currentView;
            ResultView.Visible = currentView;
        }

        public void DisplayQuery(int indexComboBox)
        {
            InvertViews();
            IndexComboBox = indexComboBox;
            OnModification();
        }

        public IEnumerable HandleQueries()
        {
            if (dicoAdapterQueries.TryGetValue(IndexComboBox, out adaptor))
            {
                return adaptor.PerfromQuerie();
            }
            return null;
        }
    }
}