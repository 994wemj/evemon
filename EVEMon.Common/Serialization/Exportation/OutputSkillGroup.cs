﻿using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace EVEMon.Common.Serialization.Exportation
{
    /// <summary>
    /// A serialization class designed for HTML exportation.
    /// </summary>
    public sealed class OutputSkillGroup
    {
        private readonly Collection<OutputSkill> m_skills;

        public OutputSkillGroup()
        {
            m_skills = new Collection<OutputSkill>();
        }

        [XmlAttribute("groupName")]
        public string Name { get; set; }

        [XmlAttribute("skillsCount")]
        public int SkillsCount { get; set; }

        [XmlAttribute("totalSP")]
        public string TotalSP { get; set; }

        [XmlElement("skill")]
        public Collection<OutputSkill> Skills
        {
            get { return m_skills; }
        }
    }
}