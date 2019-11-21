using Android.App;
using Android.Content;
using Android.Support.V7.App;

namespace Droid_Alarme.BroadCast
{
    [BroadcastReceiver(Enabled = true)]
    class AlarmeNotificacaoReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            NotificationCompat.Builder builder = new NotificationCompat.Builder(context);

            builder.SetAutoCancel(true)
                .SetDefaults((int)NotificationDefaults.All)
                .SetSmallIcon(Resource.Drawable.Icon)
                .SetContentTitle("Alarme Ativado")
                .SetContentText("Esta é minha notificação")
                .SetContentInfo("Info");

            NotificationManager manager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            manager.Notify(1, builder.Build());
        }
    }
}