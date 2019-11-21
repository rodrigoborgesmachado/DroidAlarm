using Android.Content;
using Android.Widget;

namespace Droid_Alarme.BroadCast
{
    [BroadcastReceiver(Enabled = true)]
    public class AlarmeMensagemReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Toast.MakeText(context, "Alarme do Macoratti", ToastLength.Long).Show();
        }
    }
}