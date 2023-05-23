﻿using Tp_02_02.model.Clients.SpecialClients;
using Tp_02_02.model.Clients.TransportClients;

namespace Tp_02_02.model.Clients
{
    public class ClientFactory
    {
        private static ClientFactory instance;

        private ClientFactory()
        {
        }

        public static ClientFactory Instance
        {
            get
            {
                instance ??= new ClientFactory();
                return instance;
            }
        }

        public Client CreateClient(string clientType)
        {
            switch (clientType)
            {
                case "Rescue":
                    return new RescueClient();
                case "Fire":
                    return new FireClient();
                case "Observer":
                    return new ObserverClient();
                case "Cargo":
                    return new CargoClient();
                case "Passenger":
                    return new PassengerClient();
                default:
                    throw new ArgumentException($"Invalid client type: {clientType}");
            }
        }

        public TransportClient CreateTransportClient(string clientType)
        {
            switch (clientType)
            {
                case "Cargo":
                    return new CargoClient();
                case "Passenger":
                    return new PassengerClient();
                default:
                    throw new ArgumentException($"Invalid client type: {clientType}");
            }
        }
    }
}
