using RehearsalLib.Enums;
namespace RehearsalLib.Entities;

public record EntryProperties (DateTime StartTime,int RehearsalHours,
                                string AdditionMessage,bool IsCymbalsRequired
                                ,EntryType Type,EntryStatus Status,Client Owner);
public record ClientProperties (string Name,string Phone,string Email);