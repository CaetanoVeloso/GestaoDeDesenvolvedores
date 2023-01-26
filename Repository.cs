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
    public class Repository : DbContext
    {
        private static MySqlConnection _databaseConnection;

        public DbSet<Developer> Desenvolvedores { get; set; }
        public DbSet<Credential> Credenciais { get; set; }
        public DbSet<Project> Projetos { get; set; }
        public DbSet<Allocation> Allocations { get; set; }

        public Repository() : base(GetDbConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {
                Repository repository = this;
                Developer administradorPadrao = new Developer();
                administradorPadrao.Nome = "DevCaetano";
                administradorPadrao.Nascimento = new DateTime(2004, 7, 15);
                administradorPadrao.Nivel = 'S';
                Credential credencialPadrao = new Credential();
                credencialPadrao.Email = "caetano@bl.com";
                credencialPadrao.Senha = "banca";
                credencialPadrao.Administrador = true;

                credencialPadrao.Developer = administradorPadrao;
                administradorPadrao.Credential = credencialPadrao;

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
