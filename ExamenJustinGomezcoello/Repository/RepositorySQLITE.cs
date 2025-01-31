﻿using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExamenJustinGomezcoello.Models;

namespace ExamenJustinGomezcoello.Repository
{
    public class RepositorySQLITE
    {
        private readonly SQLiteAsyncConnection _database;

        public RepositorySQLITE(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Pelicula>().Wait();
        }

        public Task<int> InsertarPeliculaAsync(Pelicula pelicula)
        {
            return _database.InsertAsync(pelicula);
        }

        public Task<List<Pelicula>> ObtenerPeliculasAsync()
        {
            return _database.Table<Pelicula>().ToListAsync();
        }


    }
}
