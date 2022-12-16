using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeDesenvolvedores
{
    internal class Repository : DbContext
    {
        private static MySqlConnection _databaseConnection;

        public DbSet<Desenvolvedor> Desenvolvedores { get; set; }
        public DbSet<Credencial> Credenciais { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {
            // If database not exists, create it ...
            if (Database.CreateIfNotExists())
            {
                // ... and...
                Repository repository = this;

                // ... insert a default administrator
                Desenvolvedor administradorPadrao = new Desenvolvedor();
                administradorPadrao.Nome = "Admin";

                Credencial credencialPadrao = new Credencial();
                credencialPadrao.Email = "admin@mail.com";
                credencialPadrao.Senha = "xyz098";
                credencialPadrao.Administrador = true;

                credencialPadrao.Desenvolvedor = administradorPadrao;
                administradorPadrao.Credencial = credencialPadrao;

                repository.Desenvolvedores.Add(administradorPadrao);
                repository.SaveChanges();
            }
        }
        public static Credencial Autenticar(Credencial usuario)
        {
            using (var contextoBd = new Repository())
            {
                // EF 6
                return contextoBd.Credenciais
                    .Where(u =>
                        u.Email == usuario.Email
                        && u.Senha == usuario.Senha)
                    .SingleOrDefault();

                // LINQ
                //return (Usuario)
                //    from u
                //    in contextoBd.Usuarios
                //    where u.Nome == usuario.Nome
                //        && u.Senha == usuario.Senha
                //    select u;
            }
        }

        public static MySqlConnection GetDbConnection()
        {
            if (_databaseConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["GestDevBD"].ConnectionString;
                _databaseConnection = new MySqlConnection(connectionString);
            }
            return _databaseConnection;
        }
    }
}
