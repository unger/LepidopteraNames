using UIKit;

namespace LepidopteraNames.iOS.Helpers
{
    public class CellAccessoryHelper
    {
        public static UITableViewCellAccessory GetCellAccessory(string styleId)
        {
            switch (styleId)
            {
                case "none":
                    return UIKit.UITableViewCellAccessory.None;
                case "checkmark":
                    return UIKit.UITableViewCellAccessory.Checkmark;
                case "detail-button":
                    return UIKit.UITableViewCellAccessory.DetailButton;
                case "detail-disclosure-button":
                    return UIKit.UITableViewCellAccessory.DetailDisclosureButton;
                case "disclosure":
                    return UIKit.UITableViewCellAccessory.DisclosureIndicator;
                default:
                    return UIKit.UITableViewCellAccessory.None;
            }
        }
    }
}
