using System.Collections.Generic;

using MimeTypes.Enums;

namespace MimeTypes.Resources
{
	internal static class TypesSet
	{
		public static List<TypesData> DataSet
		{
			get
			{
				return new List<TypesData>
				{
					new TypesData
					{
						Extension = "aac",
						MimeType = "audio/aac",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "abw",
						MimeType = "application/x-abiword",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document },
					},
					new TypesData
					{
						Extension = "arc",
						MimeType = "application/x-freearc",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
					new TypesData
					{
						Extension = "avi",
						MimeType = "video/x-msvideo",
						Type = Types.Video,
					},
					new TypesData
					{
						Extension = "azw",
						MimeType = "application/vnd.amazon.ebook",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.EBook },
					},
					new TypesData
					{
						Extension = "bin",
						MimeType = "application/octet-stream",
						Type = Types.Application | Types.Audio | Types.Font | Types.Image | Types.Model | Types.Text | Types.Video,
					},
					new TypesData
					{
						Extension = "bmp",
						MimeType = "image/bmp",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "bz",
						MimeType = "application/x-bzip",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
					new TypesData
					{
						Extension = "bz2",
						MimeType = "application/x-bzip2",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
					new TypesData
					{
						Extension = "csh",
						MimeType = "application/x-csh",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Script },
					},
					new TypesData
					{
						Extension = "css",
						MimeType = "text/css",
						Type = Types.Text,
					},
					new TypesData
					{
						Extension = "csv",
						MimeType = "text/csv",
						Type = Types.Text,
					},
					new TypesData
					{
						Extension = "doc",
						MimeType = "application/msword",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice, ExtendedTypes.MicrosoftOfficeWord },
					},
					new TypesData
					{
						Extension = "docx",
						MimeType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice, ExtendedTypes.MicrosoftOfficeWordX },
					},
					new TypesData
					{
						Extension = "eot",
						MimeType = "application/vnd.ms-fontobject",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Font },
					},
					new TypesData
					{
						Extension = "epub",
						MimeType = "application/epub+zip",
						Type = Types.Application,
					},
					new TypesData
					{
						Extension = "gz",
						MimeType = "application/gzip",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
					new TypesData
					{
						Extension = "gif",
						MimeType = "image/gif",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "htm",
						MimeType = "text/html",
						Type = Types.Text,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Html },
					},
					new TypesData
					{
						Extension = "html",
						MimeType = "text/html",
						Type = Types.Text,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Html },
					},
					new TypesData
					{
						Extension = "ico",
						MimeType = "image/vnd.microsoft.icon",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "ics",
						MimeType = "text/calendar",
						Type = Types.Text,
					},
					new TypesData
					{
						Extension = "jar",
						MimeType = "application/java-archive",
						Type = Types.Application,
					},
					new TypesData
					{
						Extension = "jpeg",
						MimeType = "image/jpeg",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "jpg",
						MimeType = "image/jpeg",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "js",
						MimeType = "text/javascript",
						Type = Types.Text,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Script },
					},
					new TypesData
					{
						Extension = "json",
						MimeType = "application/json",
						Type = Types.Application,
					},
					new TypesData
					{
						Extension = "jsonld",
						MimeType = "application/ld+json",
						Type = Types.Application,
					},
					new TypesData
					{
						Extension = "mid",
						MimeType = "audio/midi",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "midi",
						MimeType = "audio/midi",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "mjs",
						MimeType = "text/javascript",
						Type = Types.Text,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Script },
					},
					new TypesData
					{
						Extension = "mp3",
						MimeType = "audio/mpeg",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "mpeg",
						MimeType = "video/mpeg",
						Type = Types.Video,
					},
					new TypesData
					{
						Extension = "mpkg",
						MimeType = "application/vnd.apple.installer+xml",
						Type = Types.Application,
					},
					new TypesData
					{
						Extension = "odp",
						MimeType = "application/vnd.oasis.opendocument.presentation",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentPresentation },
					},
					new TypesData
					{
						Extension = "ods",
						MimeType = "application/vnd.oasis.opendocument.spreadsheet",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentSpreadsheet },
					},
					new TypesData
					{
						Extension = "odt",
						MimeType = "application/vnd.oasis.opendocument.text",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.OpenDocument, ExtendedTypes.OpenDocumentText },
					},
					new TypesData
					{
						Extension = "oga",
						MimeType = "audio/ogg",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "ogx",
						MimeType = "application/ogg",
						Type = Types.Application,
					},
					new TypesData
					{
						Extension = "opus",
						MimeType = "audio/opus",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "otf",
						MimeType = "font/otf",
						Type = Types.Font,
					},
					new TypesData
					{
						Extension = "png",
						MimeType = "image/png",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "pdf",
						MimeType = "application/pdf",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.Pdf },
					},
					new TypesData
					{
						Extension = "php",
						MimeType = "application/php",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Script },
					},
					new TypesData
					{
						Extension = "ppt",
						MimeType = "application/vnd.ms-powerpoint",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice, ExtendedTypes.MicrosoftOfficePowerPoint },
					},
					new TypesData
					{
						Extension = "pptx",
						MimeType = "application/vnd.openxmlformats-officedocument.presentationml.presentation",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice, ExtendedTypes.MicrosoftOfficePowerPointX },
					},
					new TypesData
					{
						Extension = "rar",
						MimeType = "application/vnd.rar",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
					new TypesData
					{
						Extension = "rtf",
						MimeType = "application/rtf",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document },
					},
					new TypesData
					{
						Extension = "sh",
						MimeType = "application/x-sh",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Script },
					},
					new TypesData
					{
						Extension = "svg",
						MimeType = "image/svg+xml",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "swf",
						MimeType = "application/x-shockwave-flash",
						Type = Types.Application,
					},
					new TypesData
					{
						Extension = "tar",
						MimeType = "application/x-tar",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
					new TypesData
					{
						Extension = "tif",
						MimeType = "image/tiff",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "tiff",
						MimeType = "image/tiff",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "ttf",
						MimeType = "font/ttf",
						Type = Types.Font,
					},
					new TypesData
					{
						Extension = "txt",
						MimeType = "text/plain",
						Type = Types.Text,
					},
					new TypesData
					{
						Extension = "vsd",
						MimeType = "application/vnd.visio",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.MicrosoftOfficeVisio },
					},
					new TypesData
					{
						Extension = "wav",
						MimeType = "audio/wav",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "weba",
						MimeType = "audio/webm",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "webm",
						MimeType = "video/webm",
						Type = Types.Video,
					},
					new TypesData
					{
						Extension = "webp",
						MimeType = "image/webp",
						Type = Types.Image,
					},
					new TypesData
					{
						Extension = "woff",
						MimeType = "font/woff",
						Type = Types.Font,
					},
					new TypesData
					{
						Extension = "woff2",
						MimeType = "font/woff2",
						Type = Types.Font,
					},
					new TypesData
					{
						Extension = "xhtml",
						MimeType = "application/xhtml+xml",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Html, ExtendedTypes.Xml },
					},
					new TypesData
					{
						Extension = "xls",
						MimeType = "application/vnd.ms-excel",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice, ExtendedTypes.MicrosoftOfficeExcel },
					},
					new TypesData
					{
						Extension = "xlsx",
						MimeType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Document, ExtendedTypes.MicrosoftOffice, ExtendedTypes.MicrosoftOfficeExcelX },
					},
					new TypesData
					{
						Extension = "xml",
						MimeType = "application/xml",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Xml },
					},
					new TypesData
					{
						Extension = "xul",
						MimeType = "application/vnd.mozilla.xul+xml",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Xml },
					},
					new TypesData
					{
						Extension = "zip",
						MimeType = "application/zip",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
					new TypesData
					{
						Extension = "3gp",
						MimeType = "video/3gpp",
						Type = Types.Video,
					},
					new TypesData
					{
						Extension = "3gp",
						MimeType = "audio/3gpp",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "3g2",
						MimeType = "video/3gpp2",
						Type = Types.Video,
					},
					new TypesData
					{
						Extension = "3gp2",
						MimeType = "audio/3gpp2",
						Type = Types.Audio,
					},
					new TypesData
					{
						Extension = "7z",
						MimeType = "application/x-7z-compressed",
						Type = Types.Application,
						ExtendedTypes = new List<ExtendedTypes>{ ExtendedTypes.Archive },
					},
				};
			}
		}
	}
}
