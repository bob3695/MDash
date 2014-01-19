using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDash.Plex.Models
{
    public class NowPlayingInfo
    {
        public List<Video> Videos { get; set; }
    }

    public class Video
    {
        #region Attributes

        public string AddedAt { get; set; }
        public string Art { get; set; }
        public string ContentRating { get; set; }
        public string Duration { get; set; }
        public string Guid { get; set; }
        public string Key { get; set; }
        public string LibrarySectionID { get; set; }
        public string OriginallyAvailableAt { get; set; }
        public string Rating { get; set; }
        public string RatingKey { get; set; }
        public string SessionKey { get; set; }
        public string Studio { get; set; }
        public string Summary { get; set; }
        public string Tagline { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
        public string TitleSort { get; set; }
        public string Type { get; set; }
        public string UpdatedAt { get; set; }
        public string ViewOffset { get; set; }
        public string Year { get; set; }
        public PlexPlayer Player { get; set; }
        public PlexUser User { get; set; }
        public PlexTranscodeSession TranscodeSession { get; set; }

        #endregion

        #region Children

        public List<PlexMedia> Medias { get; set; }
        public List<PlexGenre> Genres { get; set; }
        public List<PlexWriter> Writers { get; set; }
        public List<PlexDirector> Directors { get; set; }
        public List<PlexProducer> Producers { get; set; }
        public List<PlexCountry> Countries { get; set; }
        public List<PlexRole> Roles { get; set; }

        #endregion
    }

    public class PlexDirector
    {
        public string Id { get; set; }
        public string Tag { get; set; }
    }

    public class PlexProducer
    {
        public string Id { get; set; }
        public string Tag { get; set; }
    }

    public class PlexCountry
    {
        public string Id { get; set; }
        public string Tag { get; set; }
    }

    public class PlexWriter
    {
        public string Id { get; set; }
        public string Tag { get; set; }
    }

    public class PlexGenre
    {
        public string Id { get; set; }
        public string Tag { get; set; }
    }

    public class PlexRole
    {
        public string Id { get; set; }
        public string Tag { get; set; }
        public string Role { get; set; }
    }

    public class PlexUser
    {
        public string Id { get; set; }
        public string Thumb { get; set; }
        public string Title { get; set; }
    }

    public class PlexPlayer
    {
        public string MachineIdentifier { get; set; }
        public string Platform { get; set; }
        public string state { get; set; }
        public string Title { get; set; }
    }

    public class PlexTranscodeSession
    {
        public string Key { get; set; }
        public string Throttled { get; set; }
        public string Progress { get; set; }
        public string Speed { get; set; }
        public string Duration { get; set; }
        public string VideoDecision { get; set; }
        public string AudioDecision { get; set; }
        public string Protocol { get; set; }
        public string Container { get; set; }
        public string VideoCodec { get; set; }
        public string AudioCodec { get; set; }
        public string AudioChannels { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }

    public class PlexStream
    {
        public string _elementType { get; set; }
        public string bitDepth { get; set; }
        public string bitrate { get; set; }
        public string cabac { get; set; }
        public string chromaSubsampling { get; set; }
        public string codec { get; set; }
        public string codecID { get; set; }
        public string colorSpace { get; set; }
        public string duration { get; set; }
        public string frameRate { get; set; }
        public string frameRateMode { get; set; }
        public string hasScalingMatrix { get; set; }
        public string height { get; set; }
        public string id { get; set; }
        public string index { get; set; }
        public string language { get; set; }
        public string languageCode { get; set; }
        public string level { get; set; }
        public string profile { get; set; }
        public string refFrames { get; set; }
        public string scanType { get; set; }
        public string streamType { get; set; }
        public string title { get; set; }
        public string width { get; set; }
        public string bitrateMode { get; set; }
        public string channels { get; set; }
        public string dialogNorm { get; set; }
        public string samplingRate { get; set; }
        public string selected { get; set; }
        public string format { get; set; }
    }

    public class PlexPart
    {
        public string _elementType { get; set; }
        public string container { get; set; }
        public string duration { get; set; }
        public string file { get; set; }
        public string id { get; set; }
        public string key { get; set; }
        public string size { get; set; }
        public List<PlexStream> Streams { get; set; }
    }

    public class PlexMedia
    {
        public string _elementType { get; set; }
        public string aspectRatio { get; set; }
        public object audioChannels { get; set; }
        public string audioCodec { get; set; }
        public string bitrate { get; set; }
        public string container { get; set; }
        public object duration { get; set; }
        public object height { get; set; }
        public string id { get; set; }
        public string videoCodec { get; set; }
        public string videoFrameRate { get; set; }
        public string videoResolution { get; set; }
        public object width { get; set; }
        public List<PlexPart> Parts { get; set; }
        public string tag { get; set; }
        public string role { get; set; }
        public string thumb { get; set; }
        public string title { get; set; }
        public string machineIdentifier { get; set; }
        public string platform { get; set; }
        public string state { get; set; }
        public string key { get; set; }
        public bool? throttled { get; set; }
        public double? progress { get; set; }
        public int? speed { get; set; }
        public string videoDecision { get; set; }
        public string audioDecision { get; set; }
        public string protocol { get; set; }
    }
}
