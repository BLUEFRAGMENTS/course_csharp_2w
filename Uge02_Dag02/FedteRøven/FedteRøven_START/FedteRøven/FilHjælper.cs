using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedteRøven
{
    public class FilHjælper
    {
        const string fileSti = "AlleUdlån.txt";

        public async Task<string> LæsFilHvisDenEksistereAsync()
        {
            if (File.Exists(fileSti))
            {
                var tekstIFilen = await File.ReadAllTextAsync(fileSti);
                return tekstIFilen;
            }

            return string.Empty;
        }

        public async Task SkrivTilFilAsync(string tekst)
        {
            await File.WriteAllTextAsync(fileSti, tekst);
        }
    }
}
