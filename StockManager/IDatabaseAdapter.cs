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
        bool EstablishConnection();

        // Opdater felt.
        bool Update(string query);

    }

    class MongoDB : IDatabaseAdapter
    {
        public bool EstablishConnection()
        {
            throw new NotImplementedException();
        }

        public bool Update(string query)
        {
            throw new NotImplementedException();
        }
    }
}
