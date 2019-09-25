using System.Collections.Generic;
using System.Text;
using Conciliador.Standard.Utilities;
namespace Conciliador.Standard
{
    public partial class Configuration
    {


        public enum Environments
        {
            //Ambiente de Produção para o cliente
            PRODU_O,
            //Ambiente de Homologação para o cliente
            HOMOLOGA_O,
        }
        public enum Servers
        {
            ENUM_DEFAULT,
        }

        //The current environment being used
        public static Environments Environment = Environments.HOMOLOGA_O;

        //Token de Acesso
        //TODO: Replace the AccessToken with an appropriate value
        public static string AccessToken = "";

        //A map of environments and their corresponding servers/baseurls
        public static Dictionary<Environments, Dictionary<Servers, string>> EnvironmentsMap =
            new Dictionary<Environments, Dictionary<Servers, string>>
            {
                { 
                    Environments.PRODU_O,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://homolog.vooo.ws/" },
                    }
                },
                { 
                    Environments.HOMOLOGA_O,new Dictionary<Servers, string>
                    {
                        { Servers.ENUM_DEFAULT,"https://homolog.vooo.ws/" },
                    }
                },
            };

        /// <summary>
        /// Makes a list of the BaseURL parameters 
        /// </summary>
        /// <return>Returns the parameters list</return>
        internal static List<KeyValuePair<string, object>> GetBaseURIParameters()
        {
            List<KeyValuePair<string, object>> kvpList = new List<KeyValuePair<string, object>>()
            {
            };
            return kvpList; 
        }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends it with template parameters
        /// </summary>
        /// <param name="alias">Default value:DEFAULT</param>
        /// <return>Returns the baseurl</return>
        internal static string GetBaseURI(Servers alias = Servers.ENUM_DEFAULT)
        {
            StringBuilder Url =  new StringBuilder(EnvironmentsMap[Environment][alias]);
            APIHelper.AppendUrlWithTemplateParameters(Url, GetBaseURIParameters());
            return Url.ToString();        
        }
    }
}