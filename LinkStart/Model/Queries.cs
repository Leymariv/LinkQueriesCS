using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWinformProject.LinkStart.Model
{
    public static class Queries
    {
        public static IEnumerable<QueryOneTuple> FirstQuery()
        {
            List<QueryOneTuple> resultList = new List<QueryOneTuple>();
            using (var db = DatabaseFactory.Database())
            {
                var resultColors = (from e in db.Couleurs
                                    select e).Count();
                var resultMarques = db.Marques.Count();
                var resultVentes = db.Ventes.Count();
                resultList.Add(new QueryOneTuple("Color", resultColors));
                resultList.Add(new QueryOneTuple("Brand", resultMarques));
                resultList.Add(new QueryOneTuple("Sales", resultVentes));
            }
            return resultList;
        }

        public static IEnumerable<Ventes> SecondQuery()
        {
            List<Ventes> resultList;
            using (var db = DatabaseFactory.Database())
            {
                DateTime minus50Days = DateTime.Today.AddDays(-50);
                var resultSecondQuery = (from v in db.Ventes
                                         where (v.date > minus50Days)
                                         select v).ToList();
                resultList = resultSecondQuery;
            }
            return resultList;
        }

        public static IEnumerable<Ventes> SecondQueryFluent()
        {
            List<Ventes> resultListFluent;
            using (var db = DatabaseFactory.Database())
            {
                DateTime minus25Days = DateTime.Today.AddDays(-25);
                var resFluentSecondQuery = db.Ventes.Where(v => (v.date >= minus25Days.Date)).ToList();
                resultListFluent = resFluentSecondQuery;
            }
            return resultListFluent;
        }

        public static IEnumerable<MarqueCountTuple> ThirdQuery()
        {
            List<MarqueCountTuple> resultList = new List<MarqueCountTuple>();
            using (var db = DatabaseFactory.Database())
            {
                var resultThirdQuery = (from v in db.Ventes
                                        join m in db.Marques on v.marqueid equals m.Id
                                        group v by new { v.marqueid, m.Name }
                                        into grp
                                        let score = (from g in grp select g.marqueid).Count()
                                        orderby score descending
                                        select new
                                               {
                                                   MarqueId = grp.Key.marqueid,
                                                   Count = score,
                                                   grp.Key.Name
                                               }).Take(10).ToList();

                resultList.AddRange(
                                    resultThirdQuery.Select(tuple =>
                                                            new MarqueCountTuple(
                                                                tuple.Name, tuple.MarqueId,
                                                                tuple.Count)));
            }
            return resultList;
        }

        public static IEnumerable<MarqueCountTuple> ThirdQueryFluent()
        {
            List<MarqueCountTuple> resultListFluent = new List<MarqueCountTuple>();
            using (var db = DatabaseFactory.Database())
            {
                var resultThirdQueryFluent = db
                    .Ventes.Join(db.Marques, v => v.marqueid, m => m.Id, (v, m) => new { v, m })
                    .GroupBy(temp => new { temp.v.marqueid, temp.m.Name }, temp => temp.v)
                    .Select(grp => new
                                   {
                                       grp,
                                       score =
                                       (from g in grp select g.marqueid).Count()
                                   })
                    .OrderByDescending(temp => temp.score)
                    .Select(temp => new
                                    {
                                        MarqueId = temp.grp.Key.marqueid,
                                        Count = temp.score,
                                        temp.grp.Key.Name
                                    }).Take(10).ToList();

                resultListFluent.AddRange(
                                    resultThirdQueryFluent.Select(tuple =>
                                                                  new MarqueCountTuple(
                                                                      tuple.Name, tuple.MarqueId,
                                                                      tuple.Count)));
            }
            return resultListFluent;
        }

        public static IEnumerable<QueryFourTuple> FourthQuery()
        {
            List<QueryFourTuple> resultList = new List<QueryFourTuple>();
            using (var db = DatabaseFactory.Database())
            {
                var resultFourthQueryTemp = (from v in db.Ventes
                                             join c in db.Couleurs on v.couleurid equals c.Id
                                             group v by new { v.date.Year, v.couleurid, c.name }
                                             into grptemp
                                             let sales = (from g in grptemp select g.valeur).Sum()
                                             select new
                                                    {
                                                        YearDate = grptemp.Key.Year,
                                                        TotalSales = sales,
                                                        CouleurID = grptemp.Key.couleurid,
                                                        CouleurName = grptemp.Key.name
                                                    }).ToList();
                var resultFourthQuery = (from g in resultFourthQueryTemp
                                         group g by g.YearDate
                                         into grp
                                         orderby grp.Key
                                         select grp.OrderByDescending(t => t.TotalSales).First()).ToList();

                resultList.AddRange(resultFourthQuery.Select(tuple =>
                                                             new QueryFourTuple(
                                                                 tuple.YearDate, tuple.TotalSales,
                                                                 tuple.CouleurID, tuple.CouleurName)));
            }
            return resultList;
        }

        public static IEnumerable<QueryFourTuple> FourthQueryFluent()
        {
            List<QueryFourTuple> resultListFluent = new List<QueryFourTuple>();
            using (var db = DatabaseFactory.Database())
            {
                var resultFourthQueryFluentTemp =
                    db.Ventes.Join(db.Couleurs, v => v.couleurid, c => c.Id, (v, c) => new { v, c })
                      .GroupBy(t => new { t.v.date.Year, t.v.couleurid, t.c.name }, t => t.v)
                      .Select(grptemp => new { grptemp, sales = (from g in grptemp select g.valeur).Sum() })
                      .Select(t => new
                                   {
                                       YearDate = t.grptemp.Key.Year,
                                       TotalSales = t.sales,
                                       CouleurID = t.grptemp.Key.couleurid,
                                       CouleurName = t.grptemp.Key.name
                                   }).ToList();

                var resultFourthQueryFluent = resultFourthQueryFluentTemp
                    .GroupBy(g => g.YearDate)
                    .OrderBy(grp => grp.Key)
                    .Select(
                            grp =>
                            grp.OrderByDescending(t => t.TotalSales).First()).ToList();

                resultListFluent.AddRange(resultFourthQueryFluent.Select(tuple =>
                                                                   new QueryFourTuple(
                                                                       tuple.YearDate, tuple.TotalSales,
                                                                       tuple.CouleurID, tuple.CouleurName)));
            }
            return resultListFluent;
        }

        private static DateTime minus90 = new DateTime(2015, 8, 16, 6, 30, 0);

        public static IEnumerable<QueryFiveTuple> FifthQuery()
        {
            List<QueryFiveTuple> resultList = new List<QueryFiveTuple>();
            using (var db = DatabaseFactory.Database())
            {
                var resultFifthQuery = (from v in db.Ventes
                                        join m in db.Marques on v.marqueid equals m.Id
                                        where v.date >= minus90
                                        group v by new { v.marqueid, m.Name }
                                        into grp
                                        let totVentes = (from g in grp select g.valeur).Sum()
                                        orderby totVentes descending
                                        where totVentes > 500000
                                        select new
                                               {
                                                   MarqueID = grp.Key.marqueid,
                                                   NAME = grp.Key.Name,
                                                   TotVentesMarques = totVentes
                                               }).ToList();

                resultList.AddRange(resultFifthQuery.Select(tuple =>
                                                            new QueryFiveTuple(tuple.MarqueID, tuple.NAME,
                                                                               tuple.TotVentesMarques)));
            }
            return resultList;
        }

        public static IEnumerable<QueryFiveTuple> FifthQueryFluent()
        {
            List<QueryFiveTuple> resultListFluent = new List<QueryFiveTuple>();
            using (var db = DatabaseFactory.Database())
            {
                var resultFiveFluent =
                    db.Ventes.Join(db.Marques, v => v.marqueid, m => m.Id, (v, m) => new { v, m })
                      .Where(t => t.v.date >= minus90)
                      .GroupBy(t => new { t.v.marqueid, t.m.Name }, t => t.v)
                      .Select(grp => new { grp, TotVentes = (from g in grp select g.valeur).Sum() })
                      .OrderByDescending(t => t.TotVentes)
                      .Where(t => t.TotVentes > 500000)
                      .Select(t => new
                                   {
                                       MarqueID = t.grp.Key.marqueid,
                                       NAME = t.grp.Key.Name,
                                       TotVentesMarques = t.TotVentes
                                   }).ToList();

                resultListFluent.AddRange(resultFiveFluent.Select(tuple =>
                                                            new QueryFiveTuple(tuple.MarqueID, tuple.NAME,
                                                                               tuple.TotVentesMarques)));
            }
            return resultListFluent;
        }

        public static DateTime Minus90
        {
            get { return minus90; }
            set { minus90 = value; }
        }
    }
}