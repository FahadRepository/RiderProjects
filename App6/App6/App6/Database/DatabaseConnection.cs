using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using App6.Model;
using SQLite;
namespace App6.Database
{
    public class DatabaseConnection
    {
        readonly SQLiteAsyncConnection database;

        public DatabaseConnection(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Loan>().Wait();
        }

        public Task<List<Loan>> GetNotesAsync()
        {
            //Get all notes.
            return database.Table<Loan>().ToListAsync();
        }

        public Task<Loan> GetNoteAsync(int id)
        {
            // Get a specific note.
            return database.Table<Loan>()
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Loan note)
        {
            if (note.Id != 0)
            {
                // Update an existing note.
                return database.UpdateAsync(note);
            }
            else
            {
                // Save a new note.
                return database.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Loan note)
        {
            // Delete a note.
            return database.DeleteAsync(note);
        }
    }
}