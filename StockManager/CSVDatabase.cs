using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    internal class CSVDatabase : IDatabaseAdapter
    {
        private Hashtable content = new Hashtable();
        private string dbFileContent;

        public bool EstablishConnection(string connectionString)
        {
            try
            {
                dbFileContent = File.ReadAllText(connectionString);
            } catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            
                   
            String[] pairs = dbFileContent.Split(';');

            foreach (string pair in pairs)
            {
                String[] sides = pair.Split('=');
                content.Add(sides[0], sides[1]);
            }

            return true;
        }

        public T GetData<T>(string query) => (T) content[query];

        public bool Update(string toUpdate)
        {
            
        }
    }
}
