namespace MusicServices.ViewModels
{
    public class MenuItemViewModel
    {
        #region Public Properties

        public int Id { get; set; }
        public string MenuName { get; set; }
        public string MenuLink { get; set; }
        public bool MenuPermissions { get; set; }

        #endregion
    }
}
