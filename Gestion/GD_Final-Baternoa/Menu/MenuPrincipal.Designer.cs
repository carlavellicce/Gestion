﻿namespace GD_Final_Baternoa.Menu
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnLiquidacion = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(141, 41);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(141, 35);
            this.btnProveedores.TabIndex = 0;
            this.btnProveedores.Text = "Gestión Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(288, 41);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(143, 35);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Gestión Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(437, 41);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(141, 35);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.Text = "Gestión Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            // 
            // btnCompra
            // 
            this.btnCompra.Location = new System.Drawing.Point(100, 150);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(102, 63);
            this.btnCompra.TabIndex = 4;
            this.btnCompra.Text = "COMPRA";
            this.btnCompra.UseVisualStyleBackColor = true;
            // 
            // btnVenta
            // 
            this.btnVenta.Location = new System.Drawing.Point(242, 150);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(97, 64);
            this.btnVenta.TabIndex = 5;
            this.btnVenta.Text = "VENTA";
            this.btnVenta.UseVisualStyleBackColor = true;
            // 
            // btnLiquidacion
            // 
            this.btnLiquidacion.Location = new System.Drawing.Point(378, 148);
            this.btnLiquidacion.Name = "btnLiquidacion";
            this.btnLiquidacion.Size = new System.Drawing.Size(95, 65);
            this.btnLiquidacion.TabIndex = 6;
            this.btnLiquidacion.Text = "LIQUIDACIÓN";
            this.btnLiquidacion.UseVisualStyleBackColor = true;
            this.btnLiquidacion.Click += new System.EventHandler(this.btnLiquidacion_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(526, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(12, 41);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(123, 35);
            this.btnProductos.TabIndex = 8;
            this.btnProductos.Text = "Gestión Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 321);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLiquidacion);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProveedores);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnLiquidacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProductos;
    }
}