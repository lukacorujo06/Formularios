﻿/*
 * Created by SharpDevelop.
 * User: LAB-09
 * Date: 18/10/2021
 * Time: 10:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Formularios
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_mostrar = new System.Windows.Forms.Button();
			this.btn_ocultar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_mostrar
			// 
			this.btn_mostrar.Location = new System.Drawing.Point(114, 64);
			this.btn_mostrar.Name = "btn_mostrar";
			this.btn_mostrar.Size = new System.Drawing.Size(170, 52);
			this.btn_mostrar.TabIndex = 0;
			this.btn_mostrar.Text = "Mostrar";
			this.btn_mostrar.UseVisualStyleBackColor = true;
			this.btn_mostrar.Click += new System.EventHandler(this.Btn_mostrarClick);
			// 
			// btn_ocultar
			// 
			this.btn_ocultar.Location = new System.Drawing.Point(114, 165);
			this.btn_ocultar.Name = "btn_ocultar";
			this.btn_ocultar.Size = new System.Drawing.Size(170, 52);
			this.btn_ocultar.TabIndex = 1;
			this.btn_ocultar.Text = "Ocultar";
			this.btn_ocultar.UseVisualStyleBackColor = true;
			this.btn_ocultar.Click += new System.EventHandler(this.Btn_ocultarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(426, 320);
			this.Controls.Add(this.btn_ocultar);
			this.Controls.Add(this.btn_mostrar);
			this.Name = "MainForm";
			this.Text = "Formularios";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btn_ocultar;
		private System.Windows.Forms.Button btn_mostrar;
	}
}
