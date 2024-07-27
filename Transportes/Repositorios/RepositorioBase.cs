using Dapper;
using Microsoft.Data.SqlClient;
using Transportes.Models.Dominio;
using SqlKata;
using SqlKata.Execution;

namespace Transportes.Repositorios
{
    public class RepositorioBase<T> : IRepositorio where T : IDbModel
    {
        private readonly QueryFactory db;
        private readonly string tableName;

        public RepositorioBase(QueryFactory db)
        {
            this.db = db;
            this.tableName = typeof(T).Name;
        }

        public T Selecionar(int id)
            =>  db.Query(tableName).Where("Id", id).Where("Excluido", false).FirstOrDefault();

        public T Alterar(T item)
        {
            var properties = item.GetType().GetProperties();

            var updateQuery = new Query(item.GetType().Name);

            foreach (var property in properties)
            {
                var value = property.GetValue(typeof(T));
                updateQuery = updateQuery.AsUpdate(new Dictionary<string, object>
                {
                    { property.Name, value }
                });
            }

            var compiledQuery = db.Compiler.Compile(updateQuery);
            db.Connection.Execute(compiledQuery.Sql, compiledQuery.NamedBindings);
            return item;
        }

        public void Inserir(T item)
        {
            var properties = item.GetType().GetProperties();

            var updateQuery = new Query(tableName);

            foreach (var property in properties)
            {
                var value = property.GetValue(typeof(T));
                updateQuery = updateQuery.AsInsert(new Dictionary<string, object>
                {
                    { property.Name, value }
                });
            }

            var compiledQuery = db.Compiler.Compile(updateQuery);
            var id = db.Connection.Execute(compiledQuery.Sql, compiledQuery.NamedBindings);

            var itemClass = item.GetType() as IDbModel;
            itemClass.id = id;
        }

        public void Excluir(int id)
            =>  db.Query(tableName).Where("Id", id).AsUpdate(new string[] {"Excluido"}, new object[]
            {
                true
            });
    }
}