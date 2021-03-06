﻿using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum RecommendationType
    {
        /// <remarks />
        Range,

        /// <remarks />
        ShouldExceed,

        /// <remarks />
        ShouldNotExceed,

        /// <remarks />
        Percentage
    }
}