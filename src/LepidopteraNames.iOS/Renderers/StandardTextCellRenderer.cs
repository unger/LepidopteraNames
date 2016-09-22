using LepidopteraNames.iOS.Helpers;
using LepidopteraNames.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TextCell), typeof(StandardTextCellRenderer))] 
namespace LepidopteraNames.iOS.Renderers
{
    public class StandardTextCellRenderer : TextCellRenderer
    {
        public override UIKit.UITableViewCell GetCell(Cell item, UIKit.UITableViewCell reusableCell,
            UIKit.UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);
            cell.Accessory = CellAccessoryHelper.GetCellAccessory(item.StyleId);
            return cell;
        }
    }
}
