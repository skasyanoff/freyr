﻿using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class IntakeDto : FoodDto
    {
        private XmlDateTimeOffset _forDateField;

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset ForDate
        {
            get => _forDateField;
            set => _forDateField = value;
        }
    }
}