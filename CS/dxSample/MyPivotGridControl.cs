using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace DXSample {
    public class MyPivotGridControl :PivotGridControl {
        public MyPivotGridControl() : base() { }
        protected override PivotGridViewInfoData CreateData() {
            return new MyPivotGridViewInfoData(this);
        }
    }
}