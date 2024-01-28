namespace CryptoPack.Library
{
    /// <summary>
    /// Defines the structure of a cpkg file.
    /// </summary>
    public class FileStructure
    {
        /// <summary>
        /// This byte sequence identifies the file type.
        /// </summary>
        static readonly byte[] MagicNumber = [0x6e, 0x06, 0x3a, 0x1d, 0x48, 0x61, 0x4d, 0x90, 0x83, 0x43, 0xc4, 0xf1, 0x23, 0x52, 0xee, 0x05];

        /// <summary>
        /// This byte identifies the version number of the specification.
        /// </summary>
        static readonly byte Version = 1;

        /// <summary>
        /// Size of the header of the file.
        /// </summary>
        ulong HeaderSize {  get; set; }
        /// <summary>
        /// Size of encrypted binary data.
        /// </summary>
        ulong DataSize { get; set; }
        /// <summary>
        /// Reserved for future use.
        /// </summary>
        ulong ReservedSize { get; set; }
        /// <summary>
        /// The file ends with a SHA3-256.
        /// </summary>
        byte[] Hash { get; } = new byte[256];
    }
}
