using System;
using System.Collections.Generic;
using System.IO;

namespace Classes
{
    public class Client
    {
        public string Name;
        public string Phone;
        public string CPF;

        public static List<Client> getClients()
        {
            var clients = new List<Client>();
            if (File.Exists(@"../db/clients.txt"))
            {
                using(StreamReader file = File.OpenText(@"../db/clients.txt"))
                {
                    string row;

                    int i = 0;
                    while ((row = file.ReadLine()) != null)
                    {   
                        i++;
                        if (i == 1) continue;
                        var clientInfo = row.Split(';');
                        var client = new Client();
                        client.Name = clientInfo[0];
                        client.Phone = clientInfo[1];
                        client.CPF = clientInfo[2];

                        clients.Add(client);
                    }
                }
            }
            return clients;
        }

        
    }
}