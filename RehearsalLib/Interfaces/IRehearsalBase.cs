
using RehearsalLib.Entities;

namespace RehearsalLib.Interfaces;

    public interface IRehearsalBase
    {
        IEnumerable<IEntry> GetEntries();
        void AddEntry(Entry newEntry);
        void AddClient(Client newClient);
    }
