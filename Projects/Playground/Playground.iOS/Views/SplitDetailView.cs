using System;
using MvvmCross.Platform.Ios.Views;
using MvvmCross.Platform.Ios.Views.Presenters.Attributes;
using Playground.Core.ViewModels;

namespace Playground.iOS.Views
{
    [MvxFromStoryboard("Main")]
    [MvxDetailSplitViewPresentation]
    public partial class SplitDetailView : MvxViewController<SplitDetailViewModel>
    {
        public SplitDetailView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            btnClose.TouchUpInside += (sender, e) =>
            {
                DismissViewController(true, null);
            };
        }
    }
}