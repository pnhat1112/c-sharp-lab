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
    [System.ComponentModel.DisplayName("Sinh viên")]
    [DefaultProperty("Hoten")]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Sinhvien : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Sinhvien(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private Lophoc _Lop;
        [Association("lop-sv")]
        public Lophoc Lop
        {
            get { return _Lop; }
            set { SetPropertyValue<Lophoc>(nameof(Lop), ref _Lop, value); }
        }

        private string _Sothe;
        [XafDisplayName("Số thẻ"), RuleUniqueValue]
        [RuleRequiredField("sothe", DefaultContexts.Save,"Phải có số thẻ")]
        public string Sothe
        {
            get { return _Sothe; }
            set { SetPropertyValue<string>(nameof(Sothe), ref _Sothe, value); }
        }

        private string _Hoten;
        [XafDisplayName("Họ Tên")]
        [RuleRequiredField("hotensv", DefaultContexts.Save, "Phải có họ và tên")]
        public string Hoten
        {
            get { return _Hoten; }
            set { SetPropertyValue<string>(nameof(Hoten), ref _Hoten, value); }
        }

        private DateTime _Ngaysinh;
        [XafDisplayName("Ngày sinh")]
        public DateTime Ngaysinh
        {
            get { return _Ngaysinh; }
            set { SetPropertyValue<DateTime>(nameof(Ngaysinh), ref _Ngaysinh, value); }
        }

        private bool _IsNam;
        [XafDisplayName("Nam")]
        public bool IsNam
        {
            get { return _IsNam; }
            set { SetPropertyValue<bool>(nameof(IsNam), ref _IsNam, value); }
        }


        [Association("sv-lophp")]
        [XafDisplayName("Lớp học phần")]
        public XPCollection<BangdiemHP> BangdiemHPs
        {
            get { return GetCollection<BangdiemHP>(nameof(BangdiemHPs)); }
        }

        [Association("sv-diem")]
        [XafDisplayName("Bảng điểm")]
        public XPCollection<Bangdiem> Bangdiems
        {
            get { return GetCollection<Bangdiem>(nameof(Bangdiems)); }
        }

        [Action(Caption = "Cập nhật điểm", ConfirmationMessage = "Chắc chắn chưa?", ImageName = "Attention", AutoCommit = true)]
        public void ActionMethod()
        {
            if (Lop != null)
            {
                if (Lop.ChuongtrinhDT != null)
                {
                    Chuongtrinh ct = Session.GetObjectByKey<Chuongtrinh>(Lop.ChuongtrinhDT.Oid);
                    XPCollection<KhungCT> khung = new XPCollection<KhungCT>(Session,
                        CriteriaOperator.Parse("ChuongtrinhDT=?", ct));
                    foreach(KhungCT dong in khung)
                    {
                        Bangdiem dongdiem = Session.FindObject<Bangdiem>(CriteriaOperator.Parse("SV=? && Mon=?", this, dong.Mon));
                        if (dongdiem == null)
                        {
                            dongdiem = new(Session);
                            dongdiem.Mon = dong.Mon;
                            dongdiem.SV = this;
                        }
                        foreach(BangdiemHP bang in BangdiemHPs)
                        {
                            if(bang.Lophocphan.Mon==dong.Mon && bang.DiemHP != null)
                            {
                                dongdiem.Diem=bang.DiemHP; 
                            }
                        }
                        dongdiem.Save();
                    }
                }
            }
        }
    }
}