#region Usings

using System;

#endregion

namespace MusicServices.ViewModels
{
    public class SoundViewModel
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