﻿using CSXToolPlus.Types;
using CSXToolPlus.Utils;

namespace CSXToolPlus.Sections
{
    public class SectionNativeFunc
    {
        public WideStringArray Names { get; set; }
        public DwordArray Addresses { get; set; }

        public SectionNativeFunc()
        {
            Names = new WideStringArray();
            Addresses = new DwordArray();
        }

        public void Read(SimpleBinaryReader reader)
        {
            Names.Read(reader);
            Addresses.Read(reader);
        }

        public void Write(SimpleBinaryWriter writer)
        {
            Names.Write(writer);
            Addresses.Write(writer);
        }
    }
}
