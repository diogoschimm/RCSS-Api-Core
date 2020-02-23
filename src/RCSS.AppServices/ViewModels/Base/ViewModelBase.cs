using RCSS.AppServices.ViewModels.Notifications;
using System.Collections.Generic;

namespace RCSS.AppServices.ViewModels.Base
{
    public class ViewModelBase
    {
        public ICollection<Notification> Notifications { get; set; }
        public bool Invalid { get; set; }
        public bool Valid { get; set; }
    }
}
