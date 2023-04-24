
using RehearsalLib.Enums;
using RehearsalLib.Interfaces;

namespace RehearsalLib.Entities;

public class Entry : IEntry
{
    public int Id {get;set;}
    public string AdditionMessage { get; set; }
    public bool IsCymbalsRequired { get; set; }
    public int RehearsalHours { get; set; }
    public EntryType Type {get;set;}
    private DateTime startTime;
    public DateTime StartTime 
    {
        get => startTime;
        set => EndTime = startTime.AddHours(RehearsalHours);
    }
    
    public DateTime EndTime {get;set;}
    public EntryStatus Status {get;set;}
    public Client ClientOwner { get; set; }
    public Entry(){}
    public Entry(EntryProperties properties,Client ClientOwner)
    {
        AdditionMessage = properties.AdditionMessage;
        IsCymbalsRequired = properties.IsCymbalsRequired;
        RehearsalHours =  properties.RehearsalHours;
        StartTime = properties.StartTime;
        Status = properties.Status;
        Type = properties.Type;
        this.ClientOwner = ClientOwner;
    }
}