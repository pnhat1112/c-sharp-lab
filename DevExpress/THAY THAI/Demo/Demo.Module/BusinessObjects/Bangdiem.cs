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
    [System.ComponentModel.DisplayName("Bảng điểm"), NavigationItem(false)]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Bangdiem : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Bangdiem(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private Sinhvien _SV;
        [Association("sv-diem")]
        [XafDisplayName("Sinh viên")]
        public Sinhvien SV
        {
            get { return _SV; }
            set { SetPropertyValue<Sinhvien>(nameof(SV), ref _SV, value); }
        }

        private Monhoc _Mon;
        [Association("mon-diem")]
        [XafDisplayName("Học phần")]
        public Monhoc Mon
        {
            get { return _Mon; }
            set { SetPropertyValue<Monhoc>(nameof(Mon), ref _Mon, value); }
        }

        private Nullable<double> _Diem;
        [XafDisplayName("Điểm học phần"), ModelDefault("AllowEdit", "false")]
        public Nullable<double> Diem
        {
            get { return _Diem; }
            set { SetPropertyValue<Nullable<double>>(nameof(Diem), ref _Diem, value); }
        }



        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}