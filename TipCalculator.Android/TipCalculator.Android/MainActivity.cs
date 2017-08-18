using Android.App;
using Android.Widget;
using Android.OS;

namespace TipCalculator.Android
{
    [Activity(Label = "TipCalculator.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        private Button calculateButton;
        private EditText inputBill;
        private TextView outputTip;
        private TextView outputTotal;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            calculateButton = FindViewById<Button>(Resource.Id.calculateButon);
            inputBill = FindViewById<EditText>(Resource.Id.inputBill);
            outputTip = FindViewById<TextView>(Resource.Id.outputTip);
            outputTotal = FindViewById<TextView>(Resource.Id.outputTotal);

            calculateButton.Click += (sender, e) => {
                var bill = double.Parse(inputBill.Text);
                var percent = bill * 0.15;
                var total = bill + percent;
                outputTip.Text = percent.ToString();
                outputTotal.Text = total.ToString(); 
            };

        }
    }
}

