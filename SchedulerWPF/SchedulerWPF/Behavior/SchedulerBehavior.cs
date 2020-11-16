using System.Windows;
using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;

namespace WpfScheduler
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        SfScheduler scheduler;
        protected override void OnAttached()
        {
            base.OnAttached();
            scheduler = this.AssociatedObject;
            this.AssociatedObject.SizeChanged += AssociatedObject_SizeChanged;
        }
        private void AssociatedObject_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.AssociatedObject.MonthViewSettings.AgendaViewHeight = scheduler.Height * 0.6;
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.SizeChanged -= AssociatedObject_SizeChanged;
            this.scheduler = null;
        }
    }
}
        
    

    

