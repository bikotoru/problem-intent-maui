using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;

namespace Demo.Platforms.Android
{

    [IntentFilter(new[] { Intent.ActionView },
            Categories = new[]
            {
                Intent.ActionView,
                Intent.CategoryDefault,
                Intent.CategoryBrowsable,

            },
            DataHost = "result",
            DataScheme = "demoapp"
            //DataPath = "result", 
            //DataPathPrefix = "/result"
        )
    ]
    [Activity(Exported = true, Theme = "@style/Maui.SplashTheme")]
    internal class CallbackActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);



            OnNewIntent(Intent);


        }
        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

            var action = intent.Action;
            var data = intent.DataString;

     

        }
    }

}
