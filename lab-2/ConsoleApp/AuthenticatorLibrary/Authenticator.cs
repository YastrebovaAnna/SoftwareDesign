using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticatorLibrary
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> instance = new Lazy<Authenticator>(() => new Authenticator());

        private Authenticator()
        {
        }

        public static Authenticator Instance
        {
            get { return instance.Value; }
        }

        public void Authenticate(string user)
        {
            Console.WriteLine($"{user} authenticated successfully!");
        }
    }
}
