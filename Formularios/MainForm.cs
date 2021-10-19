using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Formularios
{
	public partial class MainForm : Form
	{
		public Form formulario;
		
		public MainForm()
		{
			formulario = new Form1();
			
			InitializeComponent();
		}
		
		void Btn_mostrarClick(object sender, EventArgs e)
		{
			formulario.Show();
		}
		
		void Btn_ocultarClick(object sender, EventArgs e)
		{
			formulario.Hide();
		}
	}
}
