namespace TestProgreeeBar
{
    public partial class Form1 : Form
    {
        IWork work;
        public Form1()
        {
            InitializeComponent();
            work = new Work();
            work.ProgressChanged += Update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                work.Handle();
            }
            );
        }

        public void Update(int e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    progressBar1.Value = e;
                }));
            }
            else
            {
                progressBar1.Value = e;
            }
        }
    }
}