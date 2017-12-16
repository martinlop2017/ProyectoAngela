﻿using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionUsusarios : Form
    {
        private ISeguridadProvider seguridadProvider;
        private IFormOpener formOpener;
        private GestionUsuarioViewModel viewModel;

        public GestionUsusarios(IFormOpener formOpener, ISeguridadProvider seguridadProvider)
        {
            this.formOpener = formOpener;
            this.seguridadProvider = seguridadProvider;
            InitializeComponent();
        }

        private void GestionUsusarios_Load(object sender, EventArgs e)
        {
            FillControls();
        }

        private void FillControls()
        {
            viewModel = seguridadProvider.GetGestionUsuario();
            this.dataGridViewUsuarios.DataSource = viewModel.Usuarios;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewUsuarios.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para modificarlo");
            }
            else if (selectedRows.Count > 1)
            {
                MessageBox.Show("Solo se puede modificar un usuario al mismo tiempo");
            }
            else
            {
                var selectedUser = (UsuarioViewModel)selectedRows[0].DataBoundItem;

                this.OpenFormToModify(selectedUser);
            }
        }

        private void OpenFormToModify(UsuarioViewModel selectedUser)
        {
            using (var formAltaUsuario = this.formOpener.GetForm<AltaUsuario>() as AltaUsuario)
            {
                formAltaUsuario.IsUpdate(selectedUser.Usuario);
                formAltaUsuario.ShowDialog();
            }

            this.FillControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<AltaUsuario>();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void buttonModify_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void buttonModify_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
    }
}
