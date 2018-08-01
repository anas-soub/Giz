using GizDb;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizWPF.ViewModel
{
    public class PartnerViewModel
    {
        public PartnerViewModel()
        {
            LoadPartners();
        }
        public ObservableCollection<vwPartner> Partners
        {
            get;
            set;
        }
        public void LoadPartners()
        {
            ObservableCollection<vwPartner> partners;
            using (GizEntities context = new GizEntities())
            {
                var p = context.vwPartners;
                partners = new ObservableCollection<vwPartner>(p);
            }
           
            Partners = partners;
        }
    

}
}
