using ExploracionPaquetes.Src.Design.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploracionPaquetes.Src.Design.Templates
{
    public class TemplateViews : DataTemplateSelector
    {
        public DataTemplate view1 { get; set; }
        public DataTemplate view2 { get; set; }
        public DataTemplate view3 { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            int vmBotttomAppBar = (int)container.BindingContext.GetType().GetProperty("IdMenu").GetValue(container.BindingContext);
            if (vmBotttomAppBar == 0)
                return view1;
            if (vmBotttomAppBar == 1)
                return view2;
            if (vmBotttomAppBar == 2)
                return view3;
            return view1;
        }
    }
}
