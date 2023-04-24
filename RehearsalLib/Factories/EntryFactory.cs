using RehearsalLib.Entities;

namespace RehearsalLib.Factories;

    public static class EntryFactory
    {
        public static Entry NewEntryCreate (EntryProperties prop,Client ClientOwner){
            return new Entry(prop,ClientOwner);
        }
    }
