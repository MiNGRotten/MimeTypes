using System;

namespace MimeTypes.Enums
{
    [Flags]
    public enum Types : int
    {
        Application = 0,
        Audio = 1,
        Font = 2,
        Image = 4,
        Model = 8,
        Text = 16,
        Video = 32,
        OctetStream = Application | Audio | Font | Image | Model | Text | Video,
    }
}
