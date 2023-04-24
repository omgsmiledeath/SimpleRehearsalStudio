using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RehearsalLib.Entities;
using RehearsalLib.Interfaces;

namespace RehearsalLib.Base;

public class SqliteRehearsalBase : DbContext, IRehearsalBase
{
    public DbSet<Entry> Entries { get; set; }
    public DbSet<Client> Clients { get; set; }
    public SqliteRehearsalBase()
    {
    }
    private string _path = string.Empty;
    public SqliteRehearsalBase(string path)
    {
        _path = path;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(_path == string.Empty)
        optionsBuilder.UseSqlite("Data Source =Base.db");
        else 
        optionsBuilder.UseSqlite($"Data Source ={_path}");
        
    }  
    public IEnumerable<IEntry> GetEntries()
    {
        return Entries.ToList();
    }
    public async void AddClient(Client newClient){
        await Clients.AddAsync(newClient);
    }
    public async void AddEntry(Entry newEntry){
        await Entries.AddAsync(newEntry);
    }
}
