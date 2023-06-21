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
    [System.ComponentModel.DisplayName("Lớp học phần")]
    [DefaultProperty("TenlopHP")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class LopHP : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public LopHP(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private Monhoc _Mon;
        [Association("mon-lophp")]
        [XafDisplayName("Môn học")]
        public Monhoc Mon
        {
            get { return _Mon; }
            set { SetPropertyValue<Monhoc>(nameof(Mon), ref _Mon, value); }
        }


        private string _TenlopHP;
        [XafDisplayName("Tên lớp HP")]
        public string TenlopHP
        {
            get { return _TenlopHP; }
            set { SetPropertyValue<string>(nameof(TenlopHP), ref _TenlopHP, value); }
        }

        private string _TKB;
        [XafDisplayName("Thời khóa biểu")]
        public string TKB
        {
            get { return _TKB; }
            set { SetPropertyValue<string>(nameof(TKB), ref _TKB, value); }
        }

        [Association("lophp-bd")]
        [XafDisplayName("Danh sách lớp")]
        public XPCollection<BangdiemHP> BangdiemHPs
        {
            get { return GetCollection<BangdiemHP>(nameof(BangdiemHPs)); }
        }




        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}