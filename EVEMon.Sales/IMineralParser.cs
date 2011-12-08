using System;
using System.Text.RegularExpressions;

namespace EVEMon.Sales
{
    /// <summary>
    /// Defines an interface to a Mineral Parser.
    /// </summary>
    public interface IMineralParser
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        string Name { get; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>The title.</value>
        string Title { get; }

        /// <summary>
        /// Gets the courtesy URL.
        /// </summary>
        /// <value>The courtesy URL.</value>
        Uri CourtesyUrl { get; }

        /// <summary>
        /// Gets the courtesy text.
        /// </summary>
        /// <value>The courtesy text.</value>
        string CourtesyText { get; }

        /// <summary>
        /// Gets the tokenizer.
        /// </summary>
        /// <value>The tokenizer.</value>
        Regex Tokenizer { get; }

        /// <summary>
        /// Gets the URL.
        /// </summary>
        /// <value>The URL.</value>
        Uri URL { get; }
    }
}