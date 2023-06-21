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
    [System.ComponentModel.DisplayName("Bảng điểm HP"), NavigationItem(false)]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class BangdiemHP : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public BangdiemHP(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private LopHP _Lophocphan;
        [Association("lophp-bd")]
        [XafDisplayName("Lớp học phần")]
        public LopHP Lophocphan
        {
            get { return _Lophocphan; }
            set { SetPropertyValue<LopHP>(nameof(Lophocphan), ref _Lophocphan, value); }
        }


        private Sinhvien _SV;
        [Association("sv-lophp")]
        [XafDisplayName("Sinh viên")]
        public Sinhvien SV
        {
            get { return _SV; }
            set { SetPropertyValue<Sinhvien>(nameof(SV), ref _SV, value); }
        }

        private Nullable<double> _Chuyencan;
        [XafDisplayName("Chuyên cần")]
        public Nullable<double> Chuyencan
        {
            get { return _Chuyencan; }
            set { 
                bool isModified= SetPropertyValue< Nullable<double >> (nameof(Chuyencan), ref _Chuyencan, value);
                if (isModified && !IsLoading && !IsSaving && !IsDeleted) Tinhdiem();
            }
        }

        private Nullable<double> _Giuaky;
        [XafDisplayName("Giữa kỳ")]
        public Nullable<double> Giuaky
        {
            get { return _Giuaky; }
            set {
                bool isModified = SetPropertyValue<Nullable<double>>(nameof(Giuaky), ref _Giuaky, value);
                if (isModified && !IsLoading && !IsSaving && !IsDeleted) Tinhdiem();
            }
        }

        private Nullable<double> _Cuoiky;
        [XafDisplayName("Cuối kỳ")]
        public Nullable<double> Cuoiky
        {
            get { return _Cuoiky; }
            set {
                bool isModified = SetPropertyValue<Nullable<double>>(nameof(Cuoiky), ref _Cuoiky, value);
                if (isModified && !IsLoading && !IsSaving && !IsDeleted) Tinhdiem();
            }
        }


        private Nullable<double> _DiemHP;
        [XafDisplayName("Điểm học phần"), ModelDefault("AllowEdit","false")]
        public Nullable<double> DiemHP
        {
            get { return _DiemHP; }
            set { SetPropertyValue<Nullable<double>>(nameof(DiemHP), ref _DiemHP, value); }
        }
        private void Tinhdiem()
        {
            if(Chuyencan!=null && Giuaky!=null && Cuoiky!=null)
                DiemHP= Giuaky*0.3+Giuaky*0.3+Cuoiky*0.4;
        }
        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}