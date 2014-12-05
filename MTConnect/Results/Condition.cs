﻿//************************************************************************************
//
// Author: Jacob Ebey
//
// Copyright © 2013-2014 OMAX Corporation
//
//************************************************************************************

using System.Xml.Linq;

namespace MTConnect
{
    public class Condition : Event
    {

        public string NativeCode { get; private set; }

        public string NativeSeverity { get; private set; }

        public string Type { get; private set; }

        public string Qualifier { get; private set; }


        public Condition(XElement element, Device device)
            : base(element, device)
        {
            if (element.Attribute("nativeCode") != null)
                NativeCode = element.Attribute("nativeCode").Value;
            if (element.Attribute("nativeSeverity") != null)
                NativeSeverity = element.Attribute("nativeSeverity").Value;
            if (element.Attribute("qualifier") != null)
                Qualifier = element.Attribute("qualifier").Value;
            Type = element.Attribute("type").Value;
            Value = Type + ":" + element.Name.LocalName + ":" + Value;
        }
    }
}
