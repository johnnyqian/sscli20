//------------------------------------------------------------------------------
// <copyright file="PerformanceCountersElement.cs" company="Microsoft Corporation">
//     
//      Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//     
//      The use and distribution terms for this software are contained in the file
//      named license.txt, which can be found in the root of this distribution.
//      By using this software in any fashion, you are agreeing to be bound by the
//      terms of this license.
//     
//      You must not remove this notice, or any other, from this software.
//     
// </copyright>
//------------------------------------------------------------------------------

namespace System.Net.Configuration
{
    using System;
    using System.Configuration;
    using System.Reflection;
    using System.Security.Permissions;

    public sealed class PerformanceCountersElement : ConfigurationElement
    {
        public PerformanceCountersElement()
        {
            this.properties.Add(this.enabled);
        }
        
        [ConfigurationProperty(ConfigurationStrings.Enabled, DefaultValue=false)]
        public bool Enabled
        {
            get { return (bool) this[this.enabled]; }
            set { this[this.enabled] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get 
            {
                return this.properties;
            }
        }

        ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();

        readonly ConfigurationProperty enabled =
            new ConfigurationProperty(ConfigurationStrings.Enabled, typeof(bool), false,
                    ConfigurationPropertyOptions.None);
    }
}
