namespace WinFormsApp2
{
    public partial class Lesson : Form
    {
       
        public Lesson()
        {
            
            InitializeComponent1();
            this.Load += LoadEvent;
        }

        private void Lesson_Load(object sender, EventArgs e)
        {

        }
        private void LoadEvent(object sender, EventArgs e) 
        {
            this.BackColor=Color.Yellow;
        }
    }
}