using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Demo.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    [System.ComponentModel.DisplayName("Học phần")]
    [DefaultProperty("TenHP")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Monhoc : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Monhoc(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _TenHP;
        [XafDisplayName("Tên học phần")]
        public string TenHP
        {
            get { return _TenHP; }
            set { SetPropertyValue<string>(nameof(TenHP), ref _TenHP, value); }
        }

        private double _SoTC;
        [XafDisplayName("Số TC")]
        public double SoTC
        {
            get { return _SoTC; }
            set { SetPropertyValue<double>(nameof(SoTC), ref _SoTC, value); }
        }

        [Association("mon-khung")]
        public XPCollection<KhungCT> KhungCTs
        {
            get { return GetCollection<KhungCT>(nameof(KhungCTs)); }
        }

        [Association("mon-diem")]
        [XafDisplayName("Bảng điểm")]
        public XPCollection<Bangdiem> Bangdiems
        {
            get { return GetCollection<Bangdiem>(nameof(Bangdiems)); }
        }

        [Association("mon-lophp")]
        [XafDisplayName("Lớp học phần")]
        public XPCollection<LopHP> LopHPs
        {
            get { return GetCollection<LopHP>(nameof(LopHPs)); }
        }

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}