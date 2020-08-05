using System.IO;

namespace COMP123.Lab18
{
    /// <summary>
    /// Interface for objects that can be written into a string
    /// </summary>
    public interface IWriteable
    {
        /// <summary>
        /// Write the object into a string using the given output stream
        /// </summary>
        /// <param name="writer">Output stream to use</param>
        void Write(TextWriter writer);
    }
}
