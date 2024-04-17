using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal interface IDatabaseAdapter
    {
        // Opret forbindelse.
        bool EstablishConnection(string connectionString);

        // Hent data.
        T GetData<T>(string query);

        // Opdater felt.
        bool Update(string toUpdate);

    }
}
