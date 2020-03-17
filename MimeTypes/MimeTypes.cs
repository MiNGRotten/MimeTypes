using System;
using System.Collections.Generic;
using System.Linq;

using MimeTypes.Enums;
using MimeTypes.Resources;

namespace MimeTypes
{
    public static class MimeTypes
    {
        public static bool CheckIsType(string extension, Types types)
        {
            if (extension.Contains("."))
            {
                throw new ArgumentException("Check extension");
            }

            if (types == Types.OctetStream)
            {
                return TypesSet.DataSet.Exists(s => s.Extension == extension);
            }

            return TypesSet.DataSet.Exists(s => s.Extension == extension && s.Type == types);
        }

        public static bool CheckIsAnyExtendedType(string extension, ExtendedTypes[] extendedTypes)
        {
            if (extension.Contains("."))
            {
                throw new ArgumentException("Check extension");
            }

            if (extendedTypes is null || extendedTypes.Length == 0)
            {
                throw new ArgumentException("Check extendedTypes");
            }

            return TypesSet.DataSet.Exists(s => s.Extension == extension && s.ExtendedTypes.Any(set => extendedTypes.Contains(set)));
        }

        public static bool CheckIsAllExtendedType(string extension, ExtendedTypes[] extendedTypes)
        {
            if (extension.Contains("."))
            {
                throw new ArgumentException("Check extension");
            }

            if (extendedTypes is null || extendedTypes.Length == 0)
            {
                throw new ArgumentException("Check extendedTypes");
            }

            return TypesSet.DataSet.Exists(s => s.Extension == extension && s.ExtendedTypes.All(set => extendedTypes.Contains(set)));
        }

        public static List<string> GetMimeType(string extension)
        {
            if (extension.Contains("."))
            {
                throw new ArgumentException("Check extension");
            }

            return TypesSet.DataSet.Where(s => s.Extension == extension).Select(s => s.MimeType)?.ToList();
        }

        public static List<Types> GetTypes(string extension)
        {
            if (extension.Contains("."))
            {
                throw new ArgumentException("Check extension");
            }

            return TypesSet.DataSet.Where(s => s.Extension == extension).Select(s => s.Type)?.ToList();
        }

        public static List<ExtendedTypes> GetExtendedTypes(string extension)
        {
            if (extension.Contains("."))
            {
                throw new ArgumentException("Check extension");
            }

            return TypesSet.DataSet.Where(s => s.Extension == extension).SelectMany(s => s.ExtendedTypes)?.ToList();
        }

        public static List<string> GetExtensions(Types types)
        {
            return TypesSet.DataSet.Where(s => s.Type == types).Select(s => s.Extension)?.ToList();
        }

        public static List<string> GetExtensions(ExtendedTypes[] extendedTypes)
        {
            return TypesSet.DataSet.Where(s => s.ExtendedTypes.Any(set => extendedTypes.Contains(set))).Select(s => s.Extension)?.ToList();
        }
    }
}