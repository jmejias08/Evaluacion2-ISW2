using System;
using System.Text;

namespace SQLQueryBuilder
{
    // Interfaz del Builder
    public interface ISQLQueryBuilder
    {
        void Select(string columns);
        void From(string table);
        void Where(string condition);
        void GroupBy(string columns);
        void OrderBy(string columns);
        string GetQuery();
    }

    // Implementación concreta del Builder para construir comandos SELECT
    public class SelectQueryBuilder : ISQLQueryBuilder
    {
        private StringBuilder query = new StringBuilder();

        public void Select(string columns)
        {
            query.Append($"SELECT {columns} ");
        }

        public void From(string table)
        {
            query.Append($"FROM {table} ");
        }

        public void Where(string condition)
        {
            query.Append($"WHERE {condition} ");
        }

        public void GroupBy(string columns)
        {
            query.Append($"GROUP BY {columns} ");
        }

        public void OrderBy(string columns)
        {
            query.Append($"ORDER BY {columns} ");
        }

        public string GetQuery()
        {
            return query.ToString();
        }
    }

    // Director del Builder
    public class SQLQueryDirector
    {
        private ISQLQueryBuilder sqlQueryBuilder;

        public SQLQueryDirector(ISQLQueryBuilder builder)
        {
            sqlQueryBuilder = builder;
        }

        public string ConstructQuery(string columns, string table, string condition, string groupBy, string orderBy)
        {
            sqlQueryBuilder.Select(columns);
            sqlQueryBuilder.From(table);
            if (!string.IsNullOrEmpty(condition))
                sqlQueryBuilder.Where(condition);
            if (!string.IsNullOrEmpty(groupBy))
                sqlQueryBuilder.GroupBy(groupBy);
            if (!string.IsNullOrEmpty(orderBy))
                sqlQueryBuilder.OrderBy(orderBy);

            return sqlQueryBuilder.GetQuery();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Construir un comando SELECT
            var selectBuilder = new SelectQueryBuilder();
            var director = new SQLQueryDirector(selectBuilder);
            string selectQuery = director.ConstructQuery("*", "mi_tabla", "columna1 = 'valor'", "columna2", "columna3 DESC");

            Console.WriteLine("Comando SELECT construido:");
            Console.WriteLine(selectQuery);
        }
    }
}
