namespace PruebaWinForms
{
    public partial class Form1 : Form
    {
        public int Count { get; set; }
        public Form1()
        {
            InitializeComponent();
            Count = 0;
            InicializarBoton();
        }
        private void InicializarBoton()
        {
            Button btnMostrarEtiqueta = new Button();
            btnMostrarEtiqueta.Text = "Mostrar";
            btnMostrarEtiqueta.Size = new Size(500, 250);
            btnMostrarEtiqueta.Location = new Point(50, 150);
            btnMostrarEtiqueta.Click += Mostrar_Etiqueta;
            btnMostrarEtiqueta.Click += btnContar_Click;
            this.Controls.Add(btnMostrarEtiqueta);
        }
        private void Mostrar_Etiqueta(object sender, EventArgs e)
        {
            Label lblEtiqueta = new Label();
            lblEtiqueta.ForeColor = Color.Red;
            lblEtiqueta.Text = "Soy una etiqueta";
            lblEtiqueta.Size = new Size(150, 50);
            lblEtiqueta.Location = new Point(250, 50);
            this.Controls.Add(lblEtiqueta);
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            Count++;
            btnContar.Text = Count.ToString();
        }
    }
}
