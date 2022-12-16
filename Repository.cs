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

        public DbSet<Developer> Desenvolvedores { get; set; }
        public DbSet<Credential> Credenciais { get; set; }
        public DbSet<Project> Projetos { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {
            // If database not exists, create it ...
            if (Database.CreateIfNotExists())
            {
                // ... and...
                Repository repository = this;

                // ... insert a default administrator
                Developer administradorPadrao = new Developer();
                administradorPadrao.Nome = "DevCaetano";

                Credential credencialPadrao = new Credential();
                credencialPadrao.Email = "caetano@bl.com";
                credencialPadrao.Senha = "banca";
                credencialPadrao.Administrador = true;

                credencialPadrao.Desenvolvedor = administradorPadrao;
                administradorPadrao.Credencial = credencialPadrao;

                repository.Desenvolvedores.Add(administradorPadrao);
                repository.SaveChanges();
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
