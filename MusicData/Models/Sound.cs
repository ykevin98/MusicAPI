#region Usings

using System;

#endregion

namespace MusicData.Models
{
    public class Sound
    {
        #region Public Properties

        public string Id { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        #endregion
    }
}
