using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkjatextaVerkefniHopur42.Models
{
    // This class is for storing information about each video that there are subtitle files for.
    public class VideoTitle : SubtitleFile
    {
        List<SubtitleFile> subtitleFileList = new List<SubtitleFile>();
        string title;
        int ID;
    }
}