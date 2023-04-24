
using RehearsalLib.Entities;

namespace RehearsalLib.Factories;

    public static class ClientFactory
    {
        public static Client NewClientCreate(ClientProperties properties)
        {
            return new Client (properties);
        }    
    }
