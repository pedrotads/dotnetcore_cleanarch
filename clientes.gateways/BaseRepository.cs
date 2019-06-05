using System;

namespace clientes.gateways
{
    
    public class BaseRepository
    {
        private static string  EnvironmentVariable = "ASPNETCORE_ENVIRONMENT";
        protected string Env {get;}        
        public BaseRepository()
        {
            Env = Environment.GetEnvironmentVariable(EnvironmentVariable);
        } 
    }

}