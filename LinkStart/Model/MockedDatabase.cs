using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NSubstitute;

namespace LinqWinformProject.LinkStart.Model
{
    public static class MockedDatabase
    {
        public static EntitiesDb CreateMock(
            IEnumerable<Couleurs> colors, IEnumerable<Marques> brand, IEnumerable<Ventes> orders)
        {
            var result = Substitute.For<EntitiesDb>();

            result.Couleurs = MockDbSet(colors.ToList());
            result.Ventes = MockDbSet(orders.ToList());
            result.Marques = MockDbSet(brand.ToList());
            return result;
        }

        public static DbSet<T> MockDbSet<T>(IEnumerable<T> items) where T : class
        {
            DbSet<T> result = Substitute.For<DbSet<T>, IQueryable<T>>();
            var queryable = result as IQueryable<T>;
            queryable.Provider.Returns(items.AsQueryable().Provider);
            queryable.Expression.Returns(items.AsQueryable().Expression);
            queryable.ElementType.Returns(items.AsQueryable().ElementType);
            queryable.GetEnumerator().ReturnsForAnyArgs(delegate { return items.GetEnumerator(); });
            return result;
        }
    }
}