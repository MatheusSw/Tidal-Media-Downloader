using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tidal
{
    public enum eSoundQuality
    {
        LOW = 0,
        HIGH,
        LOSSLESS,
        HI_RES,
        //NORMAL,
        //HIGH,
        //HiFi,
        //MASTER
    }

    public enum eObjectType
    {
        ALBUM,
        ARTIST,
        PLAYLIST,
        TRACK,
        VIDEO,
        SEARCH,
        None,
    }

    public enum eResolution
    {
        e240P = 240,
        e360P = 360,
        e480P = 480,
        e720P = 720,
        e1080P = 1080
    }

    public enum eContributorRole
    {
        PRODUCER,
        COMPOSER,
        LYRICIST,
        ASSOCIATED_PERFORMER,
        BACKGROUND_VOCAL,
        BASS,
        DRUMS,
        GUITAR,
        MASTERING_ENGINEER,
        MIX_ENGINEER,
        PERCUSSION,
        SYNTHESIZER,
        VOCAL,
        PERFORMER,
        REMIXER,
        ENSEMBLE_ORCHESTRA,
        CHOIR,
        CONDUCTOR,
        ELSE,
    }
}
