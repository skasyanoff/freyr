﻿using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class AllergenListRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public AllergenListRequest AllergenListRequest;

        public AllergenListRequest1()
        {
        }

        public AllergenListRequest1(AllergenListRequest allergenListRequest) => AllergenListRequest = allergenListRequest;
    }
}