using System;
using System.Collections.ObjectModel;

namespace Hyper.DotNet.Commands.Common.Models
{
    public class ViewTemplateList
    {
        public ObservableCollection<ViewTemplateItem> ViewTemplates { get; set; }

        public ObservableCollection<ViewTemplateItem> PartialViewTemplates { get; set; }
    }
}

