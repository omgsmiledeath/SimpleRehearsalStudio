
using RehearsalLib.Enums;
using RehearsalLib.Interfaces;

namespace RehearsalLib.Entities;

public abstract class Entry : IEntry
{
    public int Id {get;set;}
    public EntryType Type {get;set;}
    public DateTime StartTime {get;set;}
    public DateTime EndTime {get;set;}
    public EntryStatus Status {get;set;}
    public Client ClientOwner { get; set; }
}