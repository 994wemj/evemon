﻿using System.Drawing;
using System.Xml.Serialization;

namespace EVEMon.Common.SettingsObjects
{
    /// <summary>
    /// Represents a serializable version of a rectangle
    /// </summary>
    public sealed class SerializableRectangle
    {
        [XmlAttribute("left")]
        public int Left { get; set; }

        [XmlAttribute("top")]
        public int Top { get; set; }

        [XmlAttribute("width")]
        public int Width { get; set; }

        [XmlAttribute("height")]
        public int Height { get; set; }

        /// <summary>
        /// Performs an explicit conversion from <see cref="EVEMon.Common.SettingsObjects.SerializableRectangle"/> to <see cref="System.Drawing.Rectangle"/>.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>The result of the conversion.</returns>
        /// <remarks>Do not make the conversion operators implicit, there is a bug with XML serialization</remarks>
        public static explicit operator Rectangle(SerializableRectangle rect)
        {
            return new Rectangle(rect.Left, rect.Top, rect.Width, rect.Height);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="System.Drawing.Rectangle"/> to <see cref="EVEMon.Common.SettingsObjects.SerializableRectangle"/>.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <returns>The result of the conversion.</returns>
        /// <remarks>Do not make the conversion operators implicit, there is a bug with XML serialization</remarks>
        public static explicit operator SerializableRectangle(Rectangle rect)
        {
            return new SerializableRectangle { Left = rect.Left, Top = rect.Top, Width = rect.Width, Height = rect.Height };
        }
    }
}