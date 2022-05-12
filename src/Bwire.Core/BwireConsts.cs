using Bwire.Debugging;

namespace Bwire
{
    public class BwireConsts
    {
        public const string LocalizationSourceName = "Bwire";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "1f530bffa2994615b1174535199b09b7";
    }
}
