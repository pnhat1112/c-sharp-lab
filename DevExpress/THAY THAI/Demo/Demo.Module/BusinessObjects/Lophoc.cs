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
    [System.ComponentModel.DisplayName("Lớp")]
    [DefaultProperty("Tenlop")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Lophoc : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Lophoc(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private string _Tenlop;
        [XafDisplayName("Tên lớp")]
        public string Tenlop
        {
            get { return _Tenlop; }
            set { SetPropertyValue<string>(nameof(Tenlop), ref _Tenlop, value); }
        }

        private Chuongtrinh _ChuongtrinhDT;
        [Association("ct-lop")]
        public Chuongtrinh ChuongtrinhDT
        {
            get { return _ChuongtrinhDT; }
            set { SetPropertyValue<Chuongtrinh>(nameof(ChuongtrinhDT), ref _ChuongtrinhDT, value); }
        }

        [Association("lop-sv")]
        [XafDisplayName("Danh sách lớp")]
        public XPCollection<Sinhvien> Sinhviens
        {
            get { return GetCollection<Sinhvien>(nameof(Sinhviens)); }
        }

    }
}