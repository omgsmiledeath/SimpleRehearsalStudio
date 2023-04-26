
using RehearsalLib.Entities;

namespace RehearsalLib.Interfaces;

    public interface IRehearsalBase
    {
        IEnumerable<IEntry> GetEntries();
        IEnumerable<Client> GetClients();
        void AddEntry(Entry newEntry);
        void AddClient(Client newClient);
    }
