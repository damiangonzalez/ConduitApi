using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phabricator.Conduit.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://github.com/hach-que/Phabricator.Conduit
            // https://secure.phabricator.com/book/phabricator/article/troubleshooting_https/#certificate-authority-pr
            var client = new ConduitClient("https://phabricator.dev.us.corp/api");
            client.User = "DamianGo";
            client.Certificate = "dlivt6ucjopz3mau4oeauda3szlg7i2dpynvix6ryndpharncbtlsgbtuvl4wfqtzw2lhkmfnstntnqw2ivjipawlaoqkuynzznz2ummrqpuzuinflr6nb46626yb3na3we3inpukfp2oecadpvujeoonev3uvm2a5o6v3cxoj7nhz4lytebkoa5b4sa43natvejzm64f7yiy2kraatv4gjx3m53slraewkbzlqxjemyec66vrkwazjbtblcahy";
            var  result = client.Do("user.query", "[\"kathysu\"]");
        }
    }
}
