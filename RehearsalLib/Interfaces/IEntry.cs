using RehearsalLib.Enums;

namespace RehearsalLib.Interfaces;

    public interface IEntry
    {
        EntryType Type {get;set;}
        DateTime StartTime {get;set;}
        DateTime EndTime {get;set;}
        EntryStatus Status {get;set;}
    }
