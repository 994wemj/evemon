﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.Datafiles
{
    /// <summary>
    /// Represents a skill group in our datafile
    /// </summary>
    /// <remarks>
    /// This is the optimized way to implement the object as serializable and satisfy all FxCop rules.
    /// Don't use auto-property with private setter for the collections as it does not work with XmlSerializer.
    /// </remarks>
    public sealed class SerializableSkillGroup
    {
        private readonly Collection<SerializableSkill> m_skills;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableSkillGroup"/> class.
        /// </summary>
        public SerializableSkillGroup()
        {
            m_skills = new Collection<SerializableSkill>();
        }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>The ID.</value>
        [XmlAttribute("id")]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the skills.
        /// </summary>
        /// <value>The skills.</value>
        [XmlElement("skill")]
        public Collection<SerializableSkill> Skills
        {
            get { return m_skills; }
        }
    }
}