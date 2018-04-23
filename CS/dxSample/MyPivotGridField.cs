using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraPivotGrid.ViewInfo;

namespace DXSample {
    public class MyPivotGridField :PivotGridField {
        public MyPivotGridField(string fieldName, PivotArea area) : base(fieldName, area) { }
        public MyPivotGridField() : this(string.Empty, PivotArea.FilterArea) { }
        public MyPivotGridField(PivotGridData data) : base(data) { }
        public override bool CanFilter {
            get {
                if (Data == null || !Visible) return false;
                if (Area == PivotArea.DataArea) return true;
                return base.CanFilter;
            }
        }
    }

    public class MyPivotGridFieldCollection :PivotGridFieldCollection {
        public MyPivotGridFieldCollection(PivotGridData data) : base(data) { }
        protected override PivotGridField CreateFieldCore(string fieldName, PivotArea area) {
            return new MyPivotGridField(fieldName, area);
        }
    }

    public class MyPivotGridViewInfoData :PivotGridViewInfoData {
        public MyPivotGridViewInfoData(IViewInfoControl control) : base(control) { }
        public MyPivotGridViewInfoData() : this(null) { }
        protected override PivotGridFieldCollectionBase CreateFieldCollection() {
            return new MyPivotGridFieldCollection(this);
        }
    }
}