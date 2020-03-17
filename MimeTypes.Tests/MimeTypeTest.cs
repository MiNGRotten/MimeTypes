using System.Linq;
using MimeTypes.Enums;

using Xunit;

namespace MimeTypes.Tests
{
    public class MimeTypeTest
    {
        [Theory]
        [InlineData("png", Types.Image)]
        [InlineData("doc", Types.Application)]
        [InlineData("webm", Types.Video)]
        [InlineData("bin", Types.OctetStream)]
        [InlineData("mp3", Types.Audio)]
        [InlineData("txt", Types.Text)]
        [InlineData("docx", Types.OctetStream)]
        public void CheckIsTypeTestSuccessful(string ext, Types type)
        {
            Assert.True(MimeTypes.CheckIsType(ext, type));
        }

        [Theory]
        [InlineData("png", Types.Video)]
        [InlineData("doc", Types.Text)]
        [InlineData("webm", Types.Audio)]
        [InlineData("bin", Types.Model)]
        [InlineData("txt", Types.Application)]
        public void CheckIsTypeTestFailed(string ext, Types type)
        {
            Assert.False(MimeTypes.CheckIsType(ext, type));
        }

        [Theory]
        [InlineData("docx", new[] { ExtendedTypes.Document, ExtendedTypes.Archive, ExtendedTypes.MicrosoftOffice })]
        [InlineData("odp", new[] { ExtendedTypes.Document, ExtendedTypes.Archive, ExtendedTypes.MicrosoftOffice })]
        [InlineData("rar", new[] { ExtendedTypes.Document, ExtendedTypes.Archive, ExtendedTypes.MicrosoftOffice })]
        public void CheckIsAnyExtendedTypeSuccessful(string ext, ExtendedTypes[] extendedTypes)
        {
            Assert.True(MimeTypes.CheckIsAnyExtendedType(ext, extendedTypes));
        }

        [Theory]
        [InlineData("docx", new[] { ExtendedTypes.Font, ExtendedTypes.Archive })]
        [InlineData("odp", new[] { ExtendedTypes.Archive, ExtendedTypes.MicrosoftOffice })]
        [InlineData("rar", new[] { ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice })]
        public void CheckIsAnyExtendedTypeFailed(string ext, ExtendedTypes[] extendedTypes)
        {
            Assert.False(MimeTypes.CheckIsAnyExtendedType(ext, extendedTypes));
        }

        [Theory]
        [InlineData("docx", new[] { ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice, ExtendedTypes.MicrosoftOfficeWordX })]
        [InlineData("odp", new[] { ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentPresentation })]
        [InlineData("rar", new[] { ExtendedTypes.Archive })]
        public void CheckIsAllExtendedTypeSuccessful(string ext, ExtendedTypes[] extendedTypes)
        {
            Assert.True(MimeTypes.CheckIsAllExtendedType(ext, extendedTypes));
        }

        [Theory]
        [InlineData("docx", new[] { ExtendedTypes.Font, ExtendedTypes.Archive })]
        [InlineData("odp", new[] { ExtendedTypes.Archive, ExtendedTypes.MicrosoftOffice })]
        [InlineData("rar", new[] { ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice })]
        public void CheckIsAllExtendedTypeFailed(string ext, ExtendedTypes[] extendedTypes)
        {
            Assert.False(MimeTypes.CheckIsAllExtendedType(ext, extendedTypes));
        }

        [Theory]
        [InlineData("docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document")]
        [InlineData("mp3", "audio/mpeg")]
        public void CheckMimeTypeSuccessful(string ext, string type)
        {
            Assert.Equal(MimeTypes.GetMimeType(ext).First(), type);
        }

        [Theory]
        [InlineData("docx", "wrong")]
        [InlineData("mp3", "fail")]
        public void CheckMimeTypeFailed(string ext, string type)
        {
            Assert.NotEqual(MimeTypes.GetMimeType(ext).First(), type);
        }

        [Theory]
        [InlineData("docx", Types.Application)]
        [InlineData("mp3", Types.Audio)]
        public void CheckTypesSuccessful(string ext, Types type)
        {
            Assert.Equal(MimeTypes.GetTypes(ext).First(), type);
        }

        [Theory]
        [InlineData("docx", Types.Audio)]
        [InlineData("mp3", Types.Application)]
        public void CheckTypesFailed(string ext, Types type)
        {
            Assert.NotEqual(MimeTypes.GetTypes(ext).First(), type);
        }

        [Theory]
        [InlineData("odt", new[] { ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentText })]
        [InlineData("ods", new[] { ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentSpreadsheet })]
        [InlineData("pdf", new[] { ExtendedTypes.Document, ExtendedTypes.Pdf })]
        public void CheckExtendedTypesSuccessful(string ext, ExtendedTypes[] extendedTypes)
        {
            Assert.Equal(MimeTypes.GetExtendedTypes(ext), extendedTypes);
        }

        [Theory]
        [InlineData("mp3", new[] { ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentText })]
        [InlineData("pdf", new[] { ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentSpreadsheet })]
        public void CheckExtendedTypesFailed(string ext, ExtendedTypes[] extendedTypes)
        {
            Assert.NotEqual(MimeTypes.GetExtendedTypes(ext), extendedTypes);
        }

        [Theory]
        [InlineData(Types.Audio, new[] { "mp3", "oga"})]
        [InlineData(Types.Application, new[] { "docx", "pdf"})]
        public void CheckExtensionsSuccessful(Types type, string[] ext)
        {
            Assert.Contains(MimeTypes.GetExtensions(type), t => ext.Any(e => t == e));
        }

        [Theory]
        [InlineData(Types.Video, new[] { "mp3", "oga" })]
        [InlineData(Types.Font, new[] { "docx", "pdf" })]
        public void CheckExtensionsFailed(Types type, string[] ext)
        {
            Assert.DoesNotContain(MimeTypes.GetExtensions(type), t => ext.All(e => t == e));
        }

        [Theory]
        [InlineData(new[] { ExtendedTypes.Archive, ExtendedTypes.Document }, new[] { "rar", "docx", "pdf" })]
        [InlineData(new[] { ExtendedTypes.Html, ExtendedTypes.Xml }, new[] { "htm", "html", "xml" })]
        public void CheckExtendedExtensionsSuccessful(ExtendedTypes[] types, string[] ext)
        {
            Assert.Contains(MimeTypes.GetExtensions(types), t => ext.Any(e => t == e));
        }

        [Theory]
        [InlineData(new[] { ExtendedTypes.Script, ExtendedTypes.Xml }, new[] { "rar", "docx", "pdf" })]
        [InlineData(new[] { ExtendedTypes.MicrosoftOfficeExcel, ExtendedTypes.OpenDocument }, new[] { "htm", "html", "xml" })]
        public void CheckExtendedExtensionsFailed(ExtendedTypes[] types, string[] ext)
        {
            Assert.DoesNotContain(MimeTypes.GetExtensions(types), t => ext.All(e => t == e));
        }
    }
}
