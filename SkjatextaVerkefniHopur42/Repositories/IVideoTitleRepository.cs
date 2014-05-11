using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkjatextaVerkefniHopur42.Models;

namespace SkjatextaVerkefniHopur42.Repositories
{
    public interface IVideoTitleRepository
    {
        VideoTitle getSingleVideoTitle();
        IQueryable<VideoTitle> getAllVideoTitles();
        VideoTitle createVideoTitle();
    }
}