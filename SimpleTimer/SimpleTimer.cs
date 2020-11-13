using System;
namespace SimpleTimer{
    public partial class SimpleTimer : System.Windows.Forms.Form{
        int x;

        void StopClick(object sender, EventArgs e)
        {
            tm.Stop();
        }

        public SimpleTimer()
        {
            InitializeComponent();
            tm.Interval = 1000;
            tm.Tick += (object s, EventArgs ev) => this.T();
        }

        void StartClick(object sender, EventArgs e)
        {
            tm.Start();
        }

        void T()
        {
            display.Text = TimeSpan.FromSeconds(x++).ToString();
        }

        void ResetClick(object sender, EventArgs e)
        {
            display.Text = "00:00:00";
            x = 0;
        }
    }
}
