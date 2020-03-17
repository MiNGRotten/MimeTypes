using System.Collections.Generic;
using MimeTypes.Enums;

namespace MimeTypes.Resources
{
    internal class TypesData
    {
        public TypesData()
        {
            ExtendedTypes = new List<ExtendedTypes>();
        }

        public string Extension { get; set; }
        public string MimeType { get; set; }
        public Types Type { get; set; }
        public List<ExtendedTypes> ExtendedTypes { get; set; }
    }
}
